namespace caesar
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_verschluesseln = new System.Windows.Forms.Button();
            this.bt_endschluesseln = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_verschluesseln
            // 
            this.bt_verschluesseln.Location = new System.Drawing.Point(12, 227);
            this.bt_verschluesseln.Name = "bt_verschluesseln";
            this.bt_verschluesseln.Size = new System.Drawing.Size(88, 23);
            this.bt_verschluesseln.TabIndex = 0;
            this.bt_verschluesseln.Text = "Verschlüsseln";
            this.bt_verschluesseln.UseVisualStyleBackColor = true;
            this.bt_verschluesseln.Click += new System.EventHandler(this.bt_verschluesseln_Click);
            // 
            // bt_endschluesseln
            // 
            this.bt_endschluesseln.Location = new System.Drawing.Point(184, 227);
            this.bt_endschluesseln.Name = "bt_endschluesseln";
            this.bt_endschluesseln.Size = new System.Drawing.Size(88, 23);
            this.bt_endschluesseln.TabIndex = 1;
            this.bt_endschluesseln.Text = "Endschlüsseln";
            this.bt_endschluesseln.UseVisualStyleBackColor = true;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(12, 12);
            this.tb_1.Multiline = true;
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(260, 209);
            this.tb_1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.bt_endschluesseln);
            this.Controls.Add(this.bt_verschluesseln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_verschluesseln;
        private System.Windows.Forms.Button bt_endschluesseln;
        private System.Windows.Forms.TextBox tb_1;
    }
}

