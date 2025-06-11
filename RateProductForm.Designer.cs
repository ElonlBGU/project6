namespace Project6
{
    partial class RateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button buttonSubmitRating;
        private System.Windows.Forms.Label labelMessage;

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
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelProductList = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.buttonSubmitRating = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(60, 40);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(134, 28);
            this.labelCustomerId.TabIndex = 0;
            this.labelCustomerId.Text = "Customer ID:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCustomerId.Location = new System.Drawing.Point(200, 37);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(120, 34);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(340, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 36);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.labelCustomerName.Location = new System.Drawing.Point(60, 90);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(149, 25);
            this.labelCustomerName.TabIndex = 3;
            this.labelCustomerName.Text = "Customer Name:";
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelProductList.Location = new System.Drawing.Point(60, 140);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(124, 25);
            this.labelProductList.TabIndex = 4;
            this.labelProductList.Text = "Product List:";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(200, 137);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(240, 33);
            this.comboBoxProducts.TabIndex = 5;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelRating.Location = new System.Drawing.Point(60, 190);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(75, 25);
            this.labelRating.TabIndex = 6;
            this.labelRating.Text = "Rating:";
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(200, 187);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(80, 33);
            this.comboBoxRating.TabIndex = 7;
            // 
            // buttonSubmitRating
            // 
            this.buttonSubmitRating.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonSubmitRating.Location = new System.Drawing.Point(60, 240);
            this.buttonSubmitRating.Name = "buttonSubmitRating";
            this.buttonSubmitRating.Size = new System.Drawing.Size(180, 40);
            this.buttonSubmitRating.TabIndex = 8;
            this.buttonSubmitRating.Text = "Submit Rating";
            this.buttonSubmitRating.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessage.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelMessage.Location = new System.Drawing.Point(60, 300);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 23);
            this.labelMessage.TabIndex = 9;
            // 
            // RateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 370);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.buttonSubmitRating);
            this.Controls.Add(this.labelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Purchased Product";
            this.Load += new System.EventHandler(this.RateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}