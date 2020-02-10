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
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lblDigitalInput = new System.Windows.Forms.Label();
            this.nuDigitalInput = new System.Windows.Forms.NumericUpDown();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.lblPorts = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbOutput.SuspendLayout();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDigitalInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLabviewFile
            // 
            this.txtLabviewFile.Location = new System.Drawing.Point(10, 21);
            this.txtLabviewFile.Name = "txtLabviewFile";
            this.txtLabviewFile.Size = new System.Drawing.Size(296, 20);
            this.txtLabviewFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(312, 19);
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
            this.btnSwitch.Location = new System.Drawing.Point(6, 69);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(392, 59);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "OFF";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblLoopRate
            // 
            this.lblLoopRate.AutoSize = true;
            this.lblLoopRate.Location = new System.Drawing.Point(219, 24);
            this.lblLoopRate.Name = "lblLoopRate";
            this.lblLoopRate.Size = new System.Drawing.Size(79, 13);
            this.lblLoopRate.TabIndex = 3;
            this.lblLoopRate.Text = "Loop Rate (Hz)";
            // 
            // txtLoopRate
            // 
            this.txtLoopRate.Location = new System.Drawing.Point(312, 24);
            this.txtLoopRate.Name = "txtLoopRate";
            this.txtLoopRate.ReadOnly = true;
            this.txtLoopRate.Size = new System.Drawing.Size(83, 20);
            this.txtLoopRate.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(6, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 36);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnStart);
            this.gbOutput.Controls.Add(this.btnSwitch);
            this.gbOutput.Controls.Add(this.txtLoopRate);
            this.gbOutput.Controls.Add(this.lblLoopRate);
            this.gbOutput.Controls.Add(this.btnStop);
            this.gbOutput.Location = new System.Drawing.Point(12, 165);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(404, 134);
            this.gbOutput.TabIndex = 6;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lblPorts);
            this.gbInput.Controls.Add(this.cbPorts);
            this.gbInput.Controls.Add(this.lblDigitalInput);
            this.gbInput.Controls.Add(this.nuDigitalInput);
            this.gbInput.Controls.Add(this.btnBrowse);
            this.gbInput.Controls.Add(this.txtLabviewFile);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(402, 130);
            this.gbInput.TabIndex = 7;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // lblDigitalInput
            // 
            this.lblDigitalInput.AutoSize = true;
            this.lblDigitalInput.Location = new System.Drawing.Point(181, 69);
            this.lblDigitalInput.Name = "lblDigitalInput";
            this.lblDigitalInput.Size = new System.Drawing.Size(66, 13);
            this.lblDigitalInput.TabIndex = 4;
            this.lblDigitalInput.Text = "Digital Input:";
            // 
            // nuDigitalInput
            // 
            this.nuDigitalInput.Location = new System.Drawing.Point(253, 67);
            this.nuDigitalInput.Name = "nuDigitalInput";
            this.nuDigitalInput.Size = new System.Drawing.Size(53, 20);
            this.nuDigitalInput.TabIndex = 2;
            this.nuDigitalInput.ValueChanged += new System.EventHandler(this.nuDigitalInput_ValueChanged);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(48, 66);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(117, 21);
            this.cbPorts.TabIndex = 5;
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(8, 69);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(34, 13);
            this.lblPorts.TabIndex = 6;
            this.lblPorts.Text = "Ports:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(101, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 311);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMainView";
            this.Text = "Tresa Visual POC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainView_FormClosed);
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDigitalInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLabviewFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblLoopRate;
        private System.Windows.Forms.TextBox txtLoopRate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Label lblDigitalInput;
        private System.Windows.Forms.NumericUpDown nuDigitalInput;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnStart;
    }
}

