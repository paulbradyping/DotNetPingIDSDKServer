using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Diagnostics;



namespace PingIDAPI
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }
        
        public static string token = "";
        public static string api_version = "v4";
        public static string deviceID = "";
        public static string sessionID = "";
        public static string AuthsessionId = "";
        public static string devicefound = "";
        public static string OTPValue = "";
        public static string NewDeviceID = "";
        public static string NewDeviceType = "";
        public static string AddnewDevice = "0";

        public static string APIKey = "";
        public static string AccountID = "";

        public static string APIVersion = "";
        

        public static string Base64UrlEncodeString(string rawString)
        {
            return Base64UrlEncodeString(Encoding.UTF8.GetBytes(rawString));
        }

        public static string Base64UrlEncodeString(byte[] rawBytes)
        {
            var encodedString = Convert.ToBase64String(rawBytes);

            encodedString = encodedString.Replace('+', '-');
            encodedString = encodedString.Replace('/', '_');
            encodedString = encodedString.TrimEnd(new char[] { '=' });

            return encodedString;
        }

        public static byte[] Base64UrlDecodeString(string encodedString)
        {
            encodedString = encodedString.Replace('-', '+');
            encodedString = encodedString.Replace('_', '/');
            encodedString = encodedString.PadRight(encodedString.Length + (4 - encodedString.Length % 4) % 4, '=');

            return Convert.FromBase64String(encodedString);
        }

        public static string DictionaryToJsonString(Dictionary<string, object> dictionary)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Serialize(dictionary);
        }

        public static string sendToken(Dictionary<string, object> requestBody, string apiEndpoint)
        {
            
            Dictionary<string, object> jwtHeader = new Dictionary<string, object>();
            jwtHeader.Add("alg", "HS256");
            jwtHeader.Add("typ", "JWT");
            jwtHeader.Add("account_id", AccountID);
            jwtHeader.Add("token", token);
            jwtHeader.Add("jwt_version", api_version);
            
            var headerSerialized = DictionaryToJsonString(jwtHeader);
            var headerEncoded = Base64UrlEncodeString(headerSerialized);

            Dictionary<string, object> reqHeaderClaims = new Dictionary<string, object>();
          //  reqHeaderClaims.Add("locale", "en");
            reqHeaderClaims.Add("account_id", AccountID);
            reqHeaderClaims.Add("token", token);
            reqHeaderClaims.Add("timestamp", DateTime.UtcNow);
            reqHeaderClaims.Add("version", api_version);

            Dictionary<string, object> jwtPayload = new Dictionary<string, object>();
            jwtPayload.Add("reqHeader", reqHeaderClaims);
            jwtPayload.Add("reqBody", requestBody);

            var payloadSerialized = DictionaryToJsonString(jwtPayload);

            var payloadEncoded = Base64UrlEncodeString(payloadSerialized);

            var signedComponents = String.Join(".", headerEncoded, payloadEncoded);

            var HMAC = new HMACSHA256(Base64UrlDecodeString(APIKey));

            var signatureBytes = HMAC.ComputeHash(Encoding.UTF8.GetBytes(signedComponents));

            var signatureEncoded = Base64UrlEncodeString(signatureBytes);

            var apiToken = String.Join(".", signedComponents, signatureEncoded);

            // Send the JWS

            var response = HttpPost(apiEndpoint, apiToken);

            return response;

        }

        public static string HttpPost(string URI, string jwt)
        {
            WebRequest webRequest = WebRequest.Create(URI);

            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            byte[] payload = Encoding.UTF8.GetBytes(jwt);
            webRequest.ContentLength = payload.Length;

            Stream outputStream = webRequest.GetRequestStream();
            outputStream.Write(payload, 0, payload.Length);
            outputStream.Close();
            try
            {
                WebResponse webResponse = webRequest.GetResponse();


                if (webResponse == null) return null;

                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                return sr.ReadToEnd().Trim();

            }
            catch (WebException e)
            {

                StreamReader sr = new StreamReader(e.Response.GetResponseStream());


                MessageBox.Show(sr.ReadToEnd(), "Error Message Returned Click In Message Box and hit CTRL C Use JWT.io to read the errror ", MessageBoxButtons.OK);

            }
            return "hi";


        }




        private void GetPropertiesFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string infile = openFileDialog1.FileName.ToString();
            string inline = "";
            

            StreamReader readinfile = new StreamReader(infile);

            while ((inline = readinfile.ReadLine()) != null)
                
            {
                
                if (inline.Contains("api_key"))
                {
                    APIKey = inline.Substring(inline.IndexOf("=")+1);
                    
                }

                if (inline.Contains("account_id"))
                {
                    AccountID = inline.Substring(inline.IndexOf("=") + 1);

                }

                if (inline.Contains("token"))
                {

                    token = inline.Substring(inline.IndexOf("=") + 1);

                }

            }

            txbAPIKey.Text = APIKey;
            txbAccountID.Text = AccountID ;
            txbToken.Text = token;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {


                if (txbUserName.Text == "") throw new ApplicationException();
                richTextBox1.Clear();
                
                //APIVersion = textBox5.Text;

                Dictionary<string, object> reqBody = new Dictionary<string, object>();
                reqBody.Add("userName", txbUserName.Text );
                reqBody.Add("firstname", txbFirstName.Text);
                reqBody.Add("lastname", txbFirstName.Text);
                
                //https://sdk.pingid.com/pingid/v1/accounts/6fc88ec5-04e7-4a07-9686-d987ce1dc04d/users

                var apiEndpoint = "https://sdk.pingid.com/pingid/v1/accounts/6fc88ec5-04e7-4a07-9686-d987ce1dc04d/users";

                string apiResponse = sendToken(reqBody, apiEndpoint);

                string[] responseComponents = apiResponse.Split(new char[] { '.' });

                string responsePayload = responseComponents[1];
                string responsePayloadDecoded = Encoding.UTF8.GetString(Base64UrlDecodeString(responsePayload));
                
                richTextBox1.AppendText("PayLoad: " + "\n" + responsePayloadDecoded);
                

            }
            catch
            {
                if (txbUserName.Text == "") MessageBox.Show("You Must Enter the Name of a User registered in PingOne ");
                
            }

        }
    }
}
