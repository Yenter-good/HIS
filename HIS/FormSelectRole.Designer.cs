namespace HIS
{
    partial class FormSelectRole
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
            this.pnlRoleList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRoleList
            // 
            this.pnlRoleList.AutoSize = true;
            this.pnlRoleList.Location = new System.Drawing.Point(22, 43);
            this.pnlRoleList.Name = "pnlRoleList";
            this.pnlRoleList.Size = new System.Drawing.Size(10, 10);
            this.pnlRoleList.TabIndex = 0;
            // 
            // FormSelectRole
            // 
            this.AbortBtn.AutoSize = false;
            this.AbortBtn.Enable = true;
            this.AbortBtn.Text = "中止";
            this.AbortBtn.Width = 64;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.Enable = true;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.Width = 64;
            this.ClientSize = new System.Drawing.Size(557, 228);
            this.Controls.Add(this.pnlRoleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IgnoreBtn.AutoSize = false;
            this.IgnoreBtn.Enable = true;
            this.IgnoreBtn.Text = "忽略";
            this.IgnoreBtn.Width = 64;
            this.Name = "FormSelectRole";
            this.NoBtn.AutoSize = false;
            this.NoBtn.Enable = true;
            this.NoBtn.Text = "否";
            this.NoBtn.Width = 64;
            this.OKBtn.AutoSize = false;
            this.OKBtn.Enable = true;
            this.OKBtn.Text = "确定";
            this.OKBtn.Width = 64;
            this.RetryBtn.AutoSize = false;
            this.RetryBtn.Enable = true;
            this.RetryBtn.Text = "重试";
            this.RetryBtn.Width = 64;
            this.Text = "选择角色";
            this.YesBtn.AutoSize = false;
            this.YesBtn.Enable = true;
            this.YesBtn.Text = "是";
            this.YesBtn.Width = 64;
            this.Load += new System.EventHandler(this.FormSelectRole_Load);
            this.Shown += new System.EventHandler(this.FormSelectRole_Shown);
            this.Controls.SetChildIndex(this.pnlRoleList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoleList;
    }
}