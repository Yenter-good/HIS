namespace App_Sys.Drug
{
    partial class FormPriceChangedReceipt
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
            this.ucPriceChangedReceipt = new App_Sys.Drug.UCPriceChangedReceipt();
            this.SuspendLayout();
            // 
            // ucPriceChangedReceipt
            // 
            this.ucPriceChangedReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPriceChangedReceipt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPriceChangedReceipt.Location = new System.Drawing.Point(0, 0);
            this.ucPriceChangedReceipt.Name = "ucPriceChangedReceipt";
            this.ucPriceChangedReceipt.Size = new System.Drawing.Size(1113, 612);
            this.ucPriceChangedReceipt.TabIndex = 0;
            this.ucPriceChangedReceipt.ViewData = null;
            // 
            // FormPriceChangedReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 612);
            this.Controls.Add(this.ucPriceChangedReceipt);
            this.Name = "FormPriceChangedReceipt";
            this.Text = "药品调价";
            this.Shown += new System.EventHandler(this.FormPriceChangedReceipt_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private UCPriceChangedReceipt ucPriceChangedReceipt;
    }
}