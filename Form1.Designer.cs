namespace OOPAssess1_BingoOfficeSupplies_Take2
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
            this.imgBox_Display = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lBox_ProductsDisplay = new System.Windows.Forms.ListBox();
            this.lbl_SalePrice = new System.Windows.Forms.Label();
            this.btn_Sale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox_Display
            // 
            this.imgBox_Display.Location = new System.Drawing.Point(347, 35);
            this.imgBox_Display.Name = "imgBox_Display";
            this.imgBox_Display.Size = new System.Drawing.Size(137, 132);
            this.imgBox_Display.TabIndex = 1;
            this.imgBox_Display.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Price:";
            // 
            // lBox_ProductsDisplay
            // 
            this.lBox_ProductsDisplay.FormattingEnabled = true;
            this.lBox_ProductsDisplay.Location = new System.Drawing.Point(12, 12);
            this.lBox_ProductsDisplay.Name = "lBox_ProductsDisplay";
            this.lBox_ProductsDisplay.Size = new System.Drawing.Size(123, 264);
            this.lBox_ProductsDisplay.TabIndex = 0;
            // 
            // lbl_SalePrice
            // 
            this.lbl_SalePrice.AutoSize = true;
            this.lbl_SalePrice.Location = new System.Drawing.Point(424, 170);
            this.lbl_SalePrice.Name = "lbl_SalePrice";
            this.lbl_SalePrice.Size = new System.Drawing.Size(54, 13);
            this.lbl_SalePrice.TabIndex = 3;
            this.lbl_SalePrice.Text = "<VALUE>";
            // 
            // btn_Sale
            // 
            this.btn_Sale.Location = new System.Drawing.Point(347, 186);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(137, 28);
            this.btn_Sale.TabIndex = 4;
            this.btn_Sale.Text = "Submit Order";
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 288);
            this.Controls.Add(this.btn_Sale);
            this.Controls.Add(this.lbl_SalePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox_Display);
            this.Controls.Add(this.lBox_ProductsDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox_Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBox_ProductsDisplay;
        private System.Windows.Forms.Label lbl_SalePrice;
        private System.Windows.Forms.Button btn_Sale;
    }
}

