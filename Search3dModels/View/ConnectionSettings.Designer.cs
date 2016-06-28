namespace Search3dModels
{
    partial class ConnectionSettings
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
            saveLoginAndPasswordButton = new System.Windows.Forms.Button();
            loginInput = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            passwordInput = new System.Windows.Forms.TextBox();
            linkLabel = new System.Windows.Forms.LinkLabel();
            selectFolderToSaveModels = new System.Windows.Forms.Button();
            selectedFolderForModels = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // saveLoginAndPasswordButton
            // 
            saveLoginAndPasswordButton.Location = new System.Drawing.Point(25, 136);
            saveLoginAndPasswordButton.Name = "saveLoginAndPasswordButton";
            saveLoginAndPasswordButton.Size = new System.Drawing.Size(215, 23);
            saveLoginAndPasswordButton.TabIndex = 0;
            saveLoginAndPasswordButton.Text = "Save";
            saveLoginAndPasswordButton.UseVisualStyleBackColor = true;
            saveLoginAndPasswordButton.Click += new System.EventHandler(button1_Click);
            // 
            // loginInput
            // 
            loginInput.Location = new System.Drawing.Point(94, 28);
            loginInput.Name = "loginInput";
            loginInput.Size = new System.Drawing.Size(146, 20);
            loginInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 3;
            label1.Text = "Login(email):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Location = new System.Drawing.Point(94, 68);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new System.Drawing.Size(145, 20);
            passwordInput.TabIndex = 5;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(80, 108);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(111, 13);
            linkLabel.TabIndex = 6;
            linkLabel.TabStop = true;
            linkLabel.Text = "Register new account";
            // 
            // selectFolderToSaveModels
            // 
            selectFolderToSaveModels.Location = new System.Drawing.Point(25, 267);
            selectFolderToSaveModels.Name = "selectFolderToSaveModels";
            selectFolderToSaveModels.Size = new System.Drawing.Size(215, 23);
            selectFolderToSaveModels.TabIndex = 7;
            selectFolderToSaveModels.Text = "Select Folder";
            selectFolderToSaveModels.UseVisualStyleBackColor = true;
            selectFolderToSaveModels.Click += new System.EventHandler(selectFolderToSaveModels_Click);
            // 
            // selectedFolderForModels
            // 
            selectedFolderForModels.Location = new System.Drawing.Point(25, 230);
            selectedFolderForModels.Name = "selectedFolderForModels";
            selectedFolderForModels.Size = new System.Drawing.Size(215, 20);
            selectedFolderForModels.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(70, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 13);
            label3.TabIndex = 9;
            label3.Text = "Select foder for models :";
            // 
            // ConnectionSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(272, 316);
            Controls.Add(label3);
            Controls.Add(selectedFolderForModels);
            Controls.Add(selectFolderToSaveModels);
            Controls.Add(linkLabel);
            Controls.Add(passwordInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginInput);
            Controls.Add(saveLoginAndPasswordButton);
            Name = "ConnectionSettings";
            Text = "Settings";
            Load += new System.EventHandler(ConnectionSettings_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Button saveLoginAndPasswordButton;
        public static System.Windows.Forms.TextBox loginInput;
        public static System.Windows.Forms.Label label1;
        public static System.Windows.Forms.Label label2;
        public static System.Windows.Forms.TextBox passwordInput;
        public static System.Windows.Forms.LinkLabel linkLabel;
        public static System.Windows.Forms.Button selectFolderToSaveModels;
        public static System.Windows.Forms.TextBox selectedFolderForModels;
        public static System.Windows.Forms.Label label3;



    }
}