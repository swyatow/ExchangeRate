namespace ExchangeRate
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateTimeString = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.logInButton = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyListButton = new System.Windows.Forms.ToolStripMenuItem();
            this.favCurrencyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateTimeString
            // 
            this.dateTimeString.BackColor = System.Drawing.SystemColors.Control;
            this.dateTimeString.Name = "dateTimeString";
            this.dateTimeString.Size = new System.Drawing.Size(0, 18);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown,
            this.accountDropDown,
            this.currencyDropDown,
            this.aboutDropDown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileDropDown
            // 
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCloseButton});
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(59, 24);
            this.fileDropDown.Text = "Файл";
            // 
            // fileCloseButton
            // 
            this.fileCloseButton.Name = "fileCloseButton";
            this.fileCloseButton.Size = new System.Drawing.Size(149, 26);
            this.fileCloseButton.Text = "Закрыть";
            this.fileCloseButton.Click += new System.EventHandler(this.fileCloseButton_Click);
            // 
            // accountDropDown
            // 
            this.accountDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInButton,
            this.logOutButton});
            this.accountDropDown.Name = "accountDropDown";
            this.accountDropDown.Size = new System.Drawing.Size(77, 24);
            this.accountDropDown.Text = "Аккаунт";
            // 
            // logInButton
            // 
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(220, 26);
            this.logInButton.Text = "Войти в аккаунт";
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Enabled = false;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(220, 26);
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // currencyDropDown
            // 
            this.currencyDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyListButton,
            this.favCurrencyButton});
            this.currencyDropDown.Enabled = false;
            this.currencyDropDown.Name = "currencyDropDown";
            this.currencyDropDown.Size = new System.Drawing.Size(101, 24);
            this.currencyDropDown.Text = "Курс валют";
            // 
            // currencyListButton
            // 
            this.currencyListButton.Name = "currencyListButton";
            this.currencyListButton.Size = new System.Drawing.Size(230, 26);
            this.currencyListButton.Text = "Список валют";
            this.currencyListButton.Click += new System.EventHandler(this.currencyListButton_Click);
            // 
            // favCurrencyButton
            // 
            this.favCurrencyButton.Name = "favCurrencyButton";
            this.favCurrencyButton.Size = new System.Drawing.Size(230, 26);
            this.favCurrencyButton.Text = "Избранные валюты";
            this.favCurrencyButton.Click += new System.EventHandler(this.favCurrencyButton_Click);
            // 
            // aboutDropDown
            // 
            this.aboutDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.aboutDropDown.Name = "aboutDropDown";
            this.aboutDropDown.Size = new System.Drawing.Size(81, 24);
            this.aboutDropDown.Text = "Справка";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(187, 26);
            this.aboutButton.Text = "О программе";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem fileCloseButton;
        private System.Windows.Forms.ToolStripMenuItem accountDropDown;
        private System.Windows.Forms.ToolStripMenuItem logInButton;
        private System.Windows.Forms.ToolStripMenuItem logOutButton;
        private System.Windows.Forms.ToolStripMenuItem currencyDropDown;
        private System.Windows.Forms.ToolStripMenuItem currencyListButton;
        private System.Windows.Forms.ToolStripMenuItem favCurrencyButton;
        private System.Windows.Forms.ToolStripMenuItem aboutDropDown;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeString;
    }
}
