namespace Assignment_2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginLabel.Location = new System.Drawing.Point(113, 36);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(78, 32);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(23, 83);
            this.LoginTextBox.MinimumSize = new System.Drawing.Size(250, 25);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Username";
            this.LoginTextBox.Size = new System.Drawing.Size(250, 25);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.TabStop = false;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // NewUserButton
            // 
            this.NewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NewUserButton.Location = new System.Drawing.Point(113, 170);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewUserButton.Size = new System.Drawing.Size(78, 35);
            this.NewUserButton.TabIndex = 3;
            this.NewUserButton.Text = "New User";
            this.NewUserButton.UseVisualStyleBackColor = false;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Lime;
            this.LoginButton.Location = new System.Drawing.Point(23, 170);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(77, 35);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gold;
            this.ExitButton.Location = new System.Drawing.Point(198, 170);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 35);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 124);
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(250, 25);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 25);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowButton.Image")));
            this.ShowButton.Location = new System.Drawing.Point(239, 126);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(29, 23);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Image = ((System.Drawing.Image)(resources.GetObject("HideButton.Image")));
            this.HideButton.Location = new System.Drawing.Point(239, 126);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(34, 23);
            this.HideButton.TabIndex = 8;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 426);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.PasswordTextBox);
            this.MinimumSize = new System.Drawing.Size(314, 465);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LoginLabel;
        private TextBox LoginTextBox;
        private Button NewUserButton;
        private Button LoginButton;
        private Button ExitButton;
        private TextBox PasswordTextBox;
        private Button ShowButton;
        private Button HideButton;
    }
}