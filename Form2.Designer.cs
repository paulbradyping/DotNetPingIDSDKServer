namespace PingIDAPI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PingIDSDKgroupBox = new System.Windows.Forms.GroupBox();
            this.GetSDKPropertiesFile = new System.Windows.Forms.Button();
            this.txbAccountID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbToken = new System.Windows.Forms.TextBox();
            this.txbAPIKey = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PingIDSDKgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PingIDSDKgroupBox
            // 
            this.PingIDSDKgroupBox.Controls.Add(this.GetSDKPropertiesFile);
            this.PingIDSDKgroupBox.Controls.Add(this.txbAccountID);
            this.PingIDSDKgroupBox.Controls.Add(this.label6);
            this.PingIDSDKgroupBox.Controls.Add(this.textBox5);
            this.PingIDSDKgroupBox.Controls.Add(this.label3);
            this.PingIDSDKgroupBox.Controls.Add(this.label4);
            this.PingIDSDKgroupBox.Controls.Add(this.label5);
            this.PingIDSDKgroupBox.Controls.Add(this.txbToken);
            this.PingIDSDKgroupBox.Controls.Add(this.txbAPIKey);
            this.PingIDSDKgroupBox.Location = new System.Drawing.Point(25, 82);
            this.PingIDSDKgroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.PingIDSDKgroupBox.Name = "PingIDSDKgroupBox";
            this.PingIDSDKgroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.PingIDSDKgroupBox.Size = new System.Drawing.Size(998, 269);
            this.PingIDSDKgroupBox.TabIndex = 18;
            this.PingIDSDKgroupBox.TabStop = false;
            this.PingIDSDKgroupBox.Text = "PingID SDK Properties File Info";
            // 
            // GetSDKPropertiesFile
            // 
            this.GetSDKPropertiesFile.Location = new System.Drawing.Point(32, 64);
            this.GetSDKPropertiesFile.Margin = new System.Windows.Forms.Padding(6);
            this.GetSDKPropertiesFile.Name = "GetSDKPropertiesFile";
            this.GetSDKPropertiesFile.Size = new System.Drawing.Size(354, 44);
            this.GetSDKPropertiesFile.TabIndex = 14;
            this.GetSDKPropertiesFile.Text = "Get PingId SDK Properties File";
            this.GetSDKPropertiesFile.UseVisualStyleBackColor = true;
            this.GetSDKPropertiesFile.Click += new System.EventHandler(this.GetPropertiesFile_Click);
            // 
            // txbAccountID
            // 
            this.txbAccountID.Location = new System.Drawing.Point(628, 123);
            this.txbAccountID.Margin = new System.Windows.Forms.Padding(6);
            this.txbAccountID.Name = "txbAccountID";
            this.txbAccountID.Size = new System.Drawing.Size(196, 31);
            this.txbAccountID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "api_version";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(890, 219);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(92, 31);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "v1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "AccountID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "token";
            // 
            // txbToken
            // 
            this.txbToken.Location = new System.Drawing.Point(626, 177);
            this.txbToken.Margin = new System.Windows.Forms.Padding(6);
            this.txbToken.Name = "txbToken";
            this.txbToken.Size = new System.Drawing.Size(196, 31);
            this.txbToken.TabIndex = 11;
            // 
            // txbAPIKey
            // 
            this.txbAPIKey.Location = new System.Drawing.Point(628, 69);
            this.txbAPIKey.Margin = new System.Windows.Forms.Padding(6);
            this.txbAPIKey.Name = "txbAPIKey";
            this.txbAPIKey.Size = new System.Drawing.Size(196, 31);
            this.txbAPIKey.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbLastName);
            this.groupBox1.Controls.Add(this.txbFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbUserName);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(35, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 250);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create PingID SDK user";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "FirstName";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(171, 196);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(180, 31);
            this.txbLastName.TabIndex = 19;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(171, 134);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(180, 31);
            this.txbFirstName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "UserName";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(171, 70);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(180, 31);
            this.txbUserName.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(761, 380);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 420);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 853);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PingIDSDKgroupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.PingIDSDKgroupBox.ResumeLayout(false);
            this.PingIDSDKgroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PingIDSDKgroupBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GetSDKPropertiesFile;
        private System.Windows.Forms.TextBox txbAccountID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbToken;
        private System.Windows.Forms.TextBox txbAPIKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}