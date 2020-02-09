namespace TresaVisualPOC
{
    partial class frmMainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLabviewFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblLoopRate = new System.Windows.Forms.Label();
            this.txtLoopRate = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLabviewFile
            // 
            this.txtLabviewFile.Location = new System.Drawing.Point(12, 12);
            this.txtLabviewFile.Name = "txtLabviewFile";
            this.txtLabviewFile.Size = new System.Drawing.Size(296, 20);
            this.txtLabviewFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(314, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Gray;
            this.btnSwitch.Enabled = false;
            this.btnSwitch.Location = new System.Drawing.Point(12, 82);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(377, 59);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblLoopRate
            // 
            this.lblLoopRate.AutoSize = true;
            this.lblLoopRate.Location = new System.Drawing.Point(214, 55);
            this.lblLoopRate.Name = "lblLoopRate";
            this.lblLoopRate.Size = new System.Drawing.Size(79, 13);
            this.lblLoopRate.TabIndex = 3;
            this.lblLoopRate.Text = "Loop Rate (Hz)";
            // 
            // txtLoopRate
            // 
            this.txtLoopRate.Location = new System.Drawing.Point(306, 52);
            this.txtLoopRate.Name = "txtLoopRate";
            this.txtLoopRate.ReadOnly = true;
            this.txtLoopRate.Size = new System.Drawing.Size(83, 20);
            this.txtLoopRate.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(12, 52);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 161);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtLoopRate);
            this.Controls.Add(this.lblLoopRate);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLabviewFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMainView";
            this.Text = "Tresa Visual POC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainView_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLabviewFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblLoopRate;
        private System.Windows.Forms.TextBox txtLoopRate;
        private System.Windows.Forms.Button btnStop;
    }
}

