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
            this.btnNumber = new System.Windows.Forms.Button();
            this.httpReqTxt = new System.Windows.Forms.TextBox();
            this.httpreqLbl = new System.Windows.Forms.Label();
            this.lblReqStatus = new System.Windows.Forms.Label();
            this.actualResultLbl = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtReqBody = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTrivia = new System.Windows.Forms.Label();
            this.rbtnTrivia = new System.Windows.Forms.RadioButton();
            this.rbtnMath = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(509, 9);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(112, 23);
            this.btnNumber.TabIndex = 0;
            this.btnNumber.Text = "Get Number Fact";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // httpReqTxt
            // 
            this.httpReqTxt.Location = new System.Drawing.Point(197, 9);
            this.httpReqTxt.Name = "httpReqTxt";
            this.httpReqTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.httpReqTxt.Size = new System.Drawing.Size(279, 20);
            this.httpReqTxt.TabIndex = 1;
            // 
            // httpreqLbl
            // 
            this.httpreqLbl.AutoSize = true;
            this.httpreqLbl.Location = new System.Drawing.Point(62, 9);
            this.httpreqLbl.Name = "httpreqLbl";
            this.httpreqLbl.Size = new System.Drawing.Size(72, 13);
            this.httpreqLbl.TabIndex = 2;
            this.httpreqLbl.Text = "Enter Number";
            // 
            // lblReqStatus
            // 
            this.lblReqStatus.AutoSize = true;
            this.lblReqStatus.Location = new System.Drawing.Point(62, 98);
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
            this.lblBody.Size = new System.Drawing.Size(82, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Response Body";
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
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.Location = new System.Drawing.Point(62, 38);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(86, 13);
            this.lblTrivia.TabIndex = 10;
            this.lblTrivia.Text = "Choose Random";
            // 
            // rbtnTrivia
            // 
            this.rbtnTrivia.AutoSize = true;
            this.rbtnTrivia.Location = new System.Drawing.Point(197, 38);
            this.rbtnTrivia.Name = "rbtnTrivia";
            this.rbtnTrivia.Size = new System.Drawing.Size(51, 17);
            this.rbtnTrivia.TabIndex = 11;
            this.rbtnTrivia.TabStop = true;
            this.rbtnTrivia.Text = "Trivia";
            this.rbtnTrivia.UseVisualStyleBackColor = true;
            // 
            // rbtnMath
            // 
            this.rbtnMath.AutoSize = true;
            this.rbtnMath.Location = new System.Drawing.Point(197, 62);
            this.rbtnMath.Name = "rbtnMath";
            this.rbtnMath.Size = new System.Drawing.Size(49, 17);
            this.rbtnMath.TabIndex = 12;
            this.rbtnMath.TabStop = true;
            this.rbtnMath.Text = "Math";
            this.rbtnMath.UseVisualStyleBackColor = true;
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(298, 38);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(48, 17);
            this.rbtnDate.TabIndex = 13;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Location = new System.Drawing.Point(298, 62);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(47, 17);
            this.rbtnYear.TabIndex = 14;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(509, 56);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(112, 23);
            this.btnRandom.TabIndex = 15;
            this.btnRandom.Text = "Get Random Fact";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormApiApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 335);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.rbtnMath);
            this.Controls.Add(this.rbtnTrivia);
            this.Controls.Add(this.lblTrivia);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReqBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.actualResultLbl);
            this.Controls.Add(this.lblReqStatus);
            this.Controls.Add(this.httpreqLbl);
            this.Controls.Add(this.httpReqTxt);
            this.Controls.Add(this.btnNumber);
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

        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.TextBox httpReqTxt;
        private System.Windows.Forms.Label httpreqLbl;
        private System.Windows.Forms.Label lblReqStatus;
        private System.Windows.Forms.Label actualResultLbl;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtReqBody;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.RadioButton rbtnTrivia;
        private System.Windows.Forms.RadioButton rbtnMath;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.Button btnRandom;
    }
}

