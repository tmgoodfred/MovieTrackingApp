namespace MovieTrackingApp
{
    partial class ForgotPasswordScreen
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
            label1 = new Label();
            sendEmailBtn = new Button();
            codeTxt = new TextBox();
            codeLbl = new Label();
            SuspendLayout();
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(238, 80);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(204, 23);
            emailTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 83);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter your Email";
            // 
            // sendEmailBtn
            // 
            sendEmailBtn.Location = new Point(255, 157);
            sendEmailBtn.Name = "sendEmailBtn";
            sendEmailBtn.Size = new Size(75, 23);
            sendEmailBtn.TabIndex = 2;
            sendEmailBtn.Text = "Send Email";
            sendEmailBtn.UseVisualStyleBackColor = true;
            sendEmailBtn.Click += sendEmailBtn_Click;
            // 
            // codeTxt
            // 
            codeTxt.Location = new Point(278, 118);
            codeTxt.Name = "codeTxt";
            codeTxt.Size = new Size(100, 23);
            codeTxt.TabIndex = 3;
            codeTxt.Visible = false;
            // 
            // codeLbl
            // 
            codeLbl.AutoSize = true;
            codeLbl.Location = new Point(171, 121);
            codeLbl.Name = "codeLbl";
            codeLbl.Size = new Size(101, 15);
            codeLbl.TabIndex = 4;
            codeLbl.Text = "Enter 6 digit Code";
            codeLbl.Visible = false;
            // 
            // ForgotPasswordScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 255);
            Controls.Add(codeLbl);
            Controls.Add(codeTxt);
            Controls.Add(sendEmailBtn);
            Controls.Add(label1);
            Controls.Add(emailTxt);
            Name = "ForgotPasswordScreen";
            Text = "ForgotPasswordScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTxt;
        private Label label1;
        private Button sendEmailBtn;
        private TextBox codeTxt;
        private Label codeLbl;
    }
}