namespace WinTestApp
{
    partial class FrmPrincTestLog
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
            this.butDo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileOrigen = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(216, 62);
            this.butDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(208, 109);
            this.butDo.TabIndex = 0;
            this.butDo.Text = "Process";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.butDo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo Origen:";
            // 
            // txtFileOrigen
            // 
            this.txtFileOrigen.Location = new System.Drawing.Point(151, 28);
            this.txtFileOrigen.Name = "txtFileOrigen";
            this.txtFileOrigen.Size = new System.Drawing.Size(429, 26);
            this.txtFileOrigen.TabIndex = 2;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(-5, 203);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(705, 367);
            this.txtSalida.TabIndex = 3;
            // 
            // FrmPrincTestLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 572);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtFileOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincTestLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileOrigen;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

