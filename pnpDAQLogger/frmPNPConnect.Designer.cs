namespace pnpDAQLogger
{
    partial class frmPNPConnect
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
            this.cboProtocol = new System.Windows.Forms.ComboBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboProtocol
            // 
            this.cboProtocol.FormattingEnabled = true;
            this.cboProtocol.Location = new System.Drawing.Point(74, 9);
            this.cboProtocol.Name = "cboProtocol";
            this.cboProtocol.Size = new System.Drawing.Size(151, 21);
            this.cboProtocol.TabIndex = 0;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Location = new System.Drawing.Point(12, 9);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(46, 13);
            this.lblProtocol.TabIndex = 1;
            this.lblProtocol.Text = "Protocol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(64, 172);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // frmPNPConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 229);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProtocol);
            this.Controls.Add(this.cboProtocol);
            this.Name = "frmPNPConnect";
            this.Text = "PnP DAQ Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProtocol;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnect;
    }
}

