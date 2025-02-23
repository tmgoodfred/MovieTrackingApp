namespace MovieTrackingApp
{
    partial class CreateAccountScreen
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
            emailTxt = new TextBox();
            usernameTxt = new TextBox();
            passwordTxt = new MaskedTextBox();
            confirmPasswordTxt = new MaskedTextBox();
            createAccountBtn = new Button();
            backBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(246, 74);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(243, 23);
            emailTxt.TabIndex = 0;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(246, 114);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(243, 23);
            usernameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(246, 158);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(243, 23);
            passwordTxt.TabIndex = 2;
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.Location = new Point(246, 201);
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.PasswordChar = '*';
            confirmPasswordTxt.Size = new Size(243, 23);
            confirmPasswordTxt.TabIndex = 3;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Location = new Point(346, 271);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(101, 23);
            createAccountBtn.TabIndex = 4;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(220, 271);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 5;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 77);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 117);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 204);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 9;
            label4.Text = "Confirm Password";
            // 
            // CreateAccountScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 396);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backBtn);
            Controls.Add(createAccountBtn);
            Controls.Add(confirmPasswordTxt);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(emailTxt);
            Name = "CreateAccountScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTxt;
        private TextBox usernameTxt;
        private MaskedTextBox passwordTxt;
        private MaskedTextBox confirmPasswordTxt;
        private Button createAccountBtn;
        private Button backBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}