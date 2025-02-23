namespace MovieTrackingApp
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTxt = new TextBox();
            passwordTxt = new MaskedTextBox();
            loginBtn = new Button();
            createAccountLinkLabel = new LinkLabel();
            forgotPasswordLinkLabel = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(195, 76);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(192, 23);
            usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(195, 117);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(192, 23);
            passwordTxt.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(239, 225);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // createAccountLinkLabel
            // 
            createAccountLinkLabel.AutoSize = true;
            createAccountLinkLabel.Location = new Point(298, 171);
            createAccountLinkLabel.Name = "createAccountLinkLabel";
            createAccountLinkLabel.Size = new Size(89, 15);
            createAccountLinkLabel.TabIndex = 3;
            createAccountLinkLabel.TabStop = true;
            createAccountLinkLabel.Text = "Create Account";
            createAccountLinkLabel.LinkClicked += createAccountLinkLabel_LinkClicked;
            // 
            // forgotPasswordLinkLabel
            // 
            forgotPasswordLinkLabel.AutoSize = true;
            forgotPasswordLinkLabel.Location = new Point(195, 171);
            forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            forgotPasswordLinkLabel.Size = new Size(100, 15);
            forgotPasswordLinkLabel.TabIndex = 4;
            forgotPasswordLinkLabel.TabStop = true;
            forgotPasswordLinkLabel.Text = "Forgot Password?";
            forgotPasswordLinkLabel.LinkClicked += forgotPasswordLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 79);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 120);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 298);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(forgotPasswordLinkLabel);
            Controls.Add(createAccountLinkLabel);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private MaskedTextBox passwordTxt;
        private Button loginBtn;
        private LinkLabel createAccountLinkLabel;
        private LinkLabel forgotPasswordLinkLabel;
        private Label label1;
        private Label label2;
    }
}
