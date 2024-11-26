namespace Variant3Demo
{
    partial class ProductViewForm
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
            this.BackToMainButton = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.ProductShowButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.Location = new System.Drawing.Point(33, 13);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(96, 23);
            this.BackToMainButton.TabIndex = 0;
            this.BackToMainButton.Text = "Вернуться на главную";
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 16;
            this.ProductList.Location = new System.Drawing.Point(33, 64);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(733, 340);
            this.ProductList.TabIndex = 1;
            // 
            // ProductShowButton
            // 
            this.ProductShowButton.Location = new System.Drawing.Point(188, 13);
            this.ProductShowButton.Name = "ProductShowButton";
            this.ProductShowButton.Size = new System.Drawing.Size(141, 24);
            this.ProductShowButton.TabIndex = 2;
            this.ProductShowButton.Text = "Показать товары";
            this.ProductShowButton.UseVisualStyleBackColor = true;
            this.ProductShowButton.Click += new System.EventHandler(this.ProductShowButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(584, 12);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(182, 36);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Использовать фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Имя TEXT",
            "Имя NETEXT",
            "Без фильтра"});
            this.FilterComboBox.Location = new System.Drawing.Point(448, 13);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.FilterComboBox.TabIndex = 4;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // ProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ProductShowButton);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.BackToMainButton);
            this.Name = "ProductViewForm";
            this.Text = "ProductViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMainButton;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button ProductShowButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox FilterComboBox;
    }
}