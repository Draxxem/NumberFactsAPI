using System;

namespace ApiApp
{
    partial class FormApiApp
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
            this.btnSend = new System.Windows.Forms.Button();
            this.httpReqTxt = new System.Windows.Forms.TextBox();
            this.httpreqLbl = new System.Windows.Forms.Label();
            this.lblReqStatus = new System.Windows.Forms.Label();
            this.actualResultLbl = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtReqBody = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(65, 289);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Request";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // httpReqTxt
            // 
            this.httpReqTxt.Location = new System.Drawing.Point(197, 50);
            this.httpReqTxt.Name = "httpReqTxt";
            this.httpReqTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.httpReqTxt.Size = new System.Drawing.Size(279, 20);
            this.httpReqTxt.TabIndex = 1;
            // 
            // httpreqLbl
            // 
            this.httpreqLbl.AutoSize = true;
            this.httpreqLbl.Location = new System.Drawing.Point(63, 53);
            this.httpreqLbl.Name = "httpreqLbl";
            this.httpreqLbl.Size = new System.Drawing.Size(74, 13);
            this.httpreqLbl.TabIndex = 2;
            this.httpreqLbl.Text = "HTTP Header";
            // 
            // lblReqStatus
            // 
            this.lblReqStatus.AutoSize = true;
            this.lblReqStatus.Location = new System.Drawing.Point(63, 98);
            this.lblReqStatus.Name = "lblReqStatus";
            this.lblReqStatus.Size = new System.Drawing.Size(37, 13);
            this.lblReqStatus.TabIndex = 4;
            this.lblReqStatus.Text = "Status";
            this.lblReqStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // actualResultLbl
            // 
            this.actualResultLbl.AutoSize = true;
            this.actualResultLbl.Location = new System.Drawing.Point(194, 98);
            this.actualResultLbl.Name = "actualResultLbl";
            this.actualResultLbl.Size = new System.Drawing.Size(0, 13);
            this.actualResultLbl.TabIndex = 5;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(66, 137);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(74, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Request Body";
            // 
            // txtReqBody
            // 
            this.txtReqBody.Location = new System.Drawing.Point(197, 130);
            this.txtReqBody.Multiline = true;
            this.txtReqBody.Name = "txtReqBody";
            this.txtReqBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReqBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReqBody.Size = new System.Drawing.Size(499, 117);
            this.txtReqBody.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(607, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormApiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 335);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReqBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.actualResultLbl);
            this.Controls.Add(this.lblReqStatus);
            this.Controls.Add(this.httpreqLbl);
            this.Controls.Add(this.httpReqTxt);
            this.Controls.Add(this.btnSend);
            this.Name = "FormApiApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Number Facts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void httpReqTxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox httpReqTxt;
        private System.Windows.Forms.Label httpreqLbl;
        private System.Windows.Forms.Label lblReqStatus;
        private System.Windows.Forms.Label actualResultLbl;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtReqBody;
        private System.Windows.Forms.Button btnClear;
    }
}

