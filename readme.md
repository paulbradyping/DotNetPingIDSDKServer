This .net forms application uses the PingID API and the PIngID SDK
It uses a PingID or SDK properties file from a PingOne Tenant that is being tested. 

Pre- Requisites 
-PingOne Tenant with PingID. 
-Registered Device or Multiple Devices
-Test User other than the 1st Administrator

Install
- Extract the file to a local folder. 

Start the application. 
-To Start the application use the windows explorer and browse to the folder that has PingIDAPI-sdk.exe in it.
Run the PingIDAPI-sdk.exe 

To Test PingID API
You need the pingID properties file from the PingOne Tenant you are testing with
Browse to select that file

Enter the username of a someone that is Registered in PingOne with a device(s)

Click Start Authenticate

PingOne if all is correct PingOne will return the user and all the info about them and all the Device they have Registered

Then You can Online Authenticate by clicking the button

To build this app open the project or SLN with Visual Studio.net 2015

To Test the PingID SDK

Select SDK

Import the SDK properties file

Create a Test user. 

Register a device for test user with Test Android App. 


