namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    partial class saleSuccessful
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_TextDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 222);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(306, 52);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm Sale";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(324, 222);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(306, 52);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel Sale";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_TextDisplay
            // 
            this.lbl_TextDisplay.AutoSize = true;
            this.lbl_TextDisplay.Location = new System.Drawing.Point(8, 20);
            this.lbl_TextDisplay.Name = "lbl_TextDisplay";
            this.lbl_TextDisplay.Size = new System.Drawing.Size(561, 20);
            this.lbl_TextDisplay.TabIndex = 2;
            this.lbl_TextDisplay.Text = "Some text will appear here. If that text is not here, something is very very wron" +
    "g";
            // 
            // saleSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 286);
            this.Controls.Add(this.lbl_TextDisplay);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "saleSuccessful";
            this.Text = "Complete Sale?";
            this.Load += new System.EventHandler(this.saleSuccessful_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_TextDisplay;
    }
}