namespace ExchangeRate
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.ErrorLabel);
            this.LoginPanel.Controls.Add(this.CancelButton);
            this.LoginPanel.Controls.Add(this.EnterButton);
            this.LoginPanel.Controls.Add(this.PasswordTB);
            this.LoginPanel.Controls.Add(this.LoginTB);
            this.LoginPanel.Controls.Add(this.MainLabel);
            this.LoginPanel.Location = new System.Drawing.Point(34, 21);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(499, 381);
            this.LoginPanel.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(71, 257);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(357, 23);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Неверное имя пользователя или пароль!";
            this.ErrorLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(257, 310);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(166, 43);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterButton.Enabled = false;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.Location = new System.Drawing.Point(75, 310);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(166, 43);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTB.Location = new System.Drawing.Point(75, 196);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.PlaceholderText = "Пароль";
            this.PasswordTB.Size = new System.Drawing.Size(348, 34);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextChanged += new System.EventHandler(this.LoginTB_TextChanged);
            // 
            // LoginTB
            // 
            this.LoginTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTB.Location = new System.Drawing.Point(75, 120);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.PlaceholderText = "Логин";
            this.LoginTB.Size = new System.Drawing.Size(348, 34);
            this.LoginTB.TabIndex = 1;
            this.LoginTB.TextChanged += new System.EventHandler(this.LoginTB_TextChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(198, 42);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(99, 45);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Вход";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 430);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label ErrorLabel;
        public System.Windows.Forms.Panel LoginPanel;
    }
}