namespace BudgetTracker.Forms
{
    partial class RegisterForm
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
            txtUsernameRegister = new TextBox();
            txtPasswordRegister = new TextBox();
            txtPasswordRegisterConfirm = new TextBox();
            btnRegister = new Button();
            btnGoToLogin = new Button();
            SuspendLayout();
            // 
            // txtUsernameRegister
            // 
            txtUsernameRegister.Location = new Point(350, 114);
            txtUsernameRegister.Name = "txtUsernameRegister";
            txtUsernameRegister.PlaceholderText = "Kullanıcı Adı";
            txtUsernameRegister.Size = new Size(100, 23);
            txtUsernameRegister.TabIndex = 0;
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Location = new Point(350, 156);
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.PlaceholderText = "Şifre";
            txtPasswordRegister.Size = new Size(100, 23);
            txtPasswordRegister.TabIndex = 1;
            // 
            // txtPasswordRegisterConfirm
            // 
            txtPasswordRegisterConfirm.Location = new Point(350, 199);
            txtPasswordRegisterConfirm.Name = "txtPasswordRegisterConfirm";
            txtPasswordRegisterConfirm.PlaceholderText = "Şifre (Tekrar)";
            txtPasswordRegisterConfirm.Size = new Size(100, 23);
            txtPasswordRegisterConfirm.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(313, 246);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnGoToLogin
            // 
            btnGoToLogin.Location = new Point(418, 249);
            btnGoToLogin.Name = "btnGoToLogin";
            btnGoToLogin.Size = new Size(75, 23);
            btnGoToLogin.TabIndex = 4;
            btnGoToLogin.Text = "Geri Dön";
            btnGoToLogin.UseVisualStyleBackColor = true;
            btnGoToLogin.Click += btnGoToLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoToLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPasswordRegisterConfirm);
            Controls.Add(txtPasswordRegister);
            Controls.Add(txtUsernameRegister);
            Name = "RegisterForm";
            Text = "Kayıt Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsernameRegister;
        private TextBox txtPasswordRegister;
        private TextBox txtPasswordRegisterConfirm;
        private Button btnRegister;
        private Button btnGoToLogin;
    }
}