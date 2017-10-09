namespace GetVendorID
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHwId = new System.Windows.Forms.TextBox();
            this.tbSystemSerialNo = new System.Windows.Forms.TextBox();
            this.tbLicenseIdentifier = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "HW ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "系统序列号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Identifier";
            // 
            // tbHwId
            // 
            this.tbHwId.Location = new System.Drawing.Point(166, 51);
            this.tbHwId.Name = "tbHwId";
            this.tbHwId.Size = new System.Drawing.Size(275, 21);
            this.tbHwId.TabIndex = 3;
            // 
            // tbSystemSerialNo
            // 
            this.tbSystemSerialNo.Location = new System.Drawing.Point(166, 102);
            this.tbSystemSerialNo.Name = "tbSystemSerialNo";
            this.tbSystemSerialNo.Size = new System.Drawing.Size(275, 21);
            this.tbSystemSerialNo.TabIndex = 4;
            // 
            // tbLicenseIdentifier
            // 
            this.tbLicenseIdentifier.Location = new System.Drawing.Point(166, 157);
            this.tbLicenseIdentifier.Name = "tbLicenseIdentifier";
            this.tbLicenseIdentifier.Size = new System.Drawing.Size(275, 21);
            this.tbLicenseIdentifier.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "来！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLicenseIdentifier);
            this.Controls.Add(this.tbSystemSerialNo);
            this.Controls.Add(this.tbHwId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "玩得哎第";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHwId;
        private System.Windows.Forms.TextBox tbSystemSerialNo;
        private System.Windows.Forms.TextBox tbLicenseIdentifier;
        private System.Windows.Forms.Button button1;
    }
}

