namespace Week7Program2
{
    partial class Form1
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
            this.StudentRestaurantLabel = new System.Windows.Forms.Label();
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FoodListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReceiptGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.MenuGroupBox.SuspendLayout();
            this.ReceiptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentRestaurantLabel
            // 
            this.StudentRestaurantLabel.AutoSize = true;
            this.StudentRestaurantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRestaurantLabel.Location = new System.Drawing.Point(218, 9);
            this.StudentRestaurantLabel.Name = "StudentRestaurantLabel";
            this.StudentRestaurantLabel.Size = new System.Drawing.Size(234, 29);
            this.StudentRestaurantLabel.TabIndex = 0;
            this.StudentRestaurantLabel.Text = "Student Restaurant";
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.PriceListBox);
            this.MenuGroupBox.Controls.Add(this.PriceLabel);
            this.MenuGroupBox.Controls.Add(this.FoodListBox);
            this.MenuGroupBox.Controls.Add(this.ItemsLabel);
            this.MenuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGroupBox.Location = new System.Drawing.Point(28, 70);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(299, 246);
            this.MenuGroupBox.TabIndex = 1;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "Menu";
            // 
            // PriceListBox
            // 
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 20;
            this.PriceListBox.Items.AddRange(new object[] {
            "4.80",
            "3.50",
            "2.50",
            "5.50",
            "3.00",
            "9.00",
            "3.50"});
            this.PriceListBox.Location = new System.Drawing.Point(180, 58);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PriceListBox.Size = new System.Drawing.Size(75, 144);
            this.PriceListBox.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(191, 26);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 20);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price $";
            // 
            // FoodListBox
            // 
            this.FoodListBox.FormattingEnabled = true;
            this.FoodListBox.ItemHeight = 20;
            this.FoodListBox.Items.AddRange(new object[] {
            "Tea/Coffee",
            "Juice",
            "Banana Bread",
            "Cereal",
            "Sushi",
            "Pizza",
            "Drinks"});
            this.FoodListBox.Location = new System.Drawing.Point(20, 58);
            this.FoodListBox.Name = "FoodListBox";
            this.FoodListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FoodListBox.Size = new System.Drawing.Size(132, 144);
            this.FoodListBox.TabIndex = 1;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(43, 26);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(54, 20);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(38, 339);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(118, 35);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(190, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReceiptGroupBox
            // 
            this.ReceiptGroupBox.Controls.Add(this.ReceiptLabel);
            this.ReceiptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptGroupBox.Location = new System.Drawing.Point(384, 70);
            this.ReceiptGroupBox.Name = "ReceiptGroupBox";
            this.ReceiptGroupBox.Size = new System.Drawing.Size(245, 246);
            this.ReceiptGroupBox.TabIndex = 4;
            this.ReceiptGroupBox.TabStop = false;
            this.ReceiptGroupBox.Text = "Receipt";
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.AutoSize = true;
            this.ReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptLabel.Location = new System.Drawing.Point(24, 48);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(0, 18);
            this.ReceiptLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 401);
            this.Controls.Add(this.ReceiptGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.StudentRestaurantLabel);
            this.Name = "Form1";
            this.Text = "Student Restaurant Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuGroupBox.ResumeLayout(false);
            this.MenuGroupBox.PerformLayout();
            this.ReceiptGroupBox.ResumeLayout(false);
            this.ReceiptGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentRestaurantLabel;
        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.ListBox PriceListBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ListBox FoodListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox ReceiptGroupBox;
        private System.Windows.Forms.Label ReceiptLabel;
    }
}

