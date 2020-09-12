namespace StooqParser
{
    partial class FormMain
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
            this.tbTicker = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtStop = new System.Windows.Forms.DateTimePicker();
            this.btnParse = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTicker
            // 
            this.tbTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTicker.Location = new System.Drawing.Point(24, 24);
            this.tbTicker.Name = "tbTicker";
            this.tbTicker.Size = new System.Drawing.Size(100, 20);
            this.tbTicker.TabIndex = 0;
            this.tbTicker.Text = "PKN";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(153, 24);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(150, 20);
            this.dtStart.TabIndex = 1;
            // 
            // dtStop
            // 
            this.dtStop.Location = new System.Drawing.Point(320, 24);
            this.dtStop.Name = "dtStop";
            this.dtStop.Size = new System.Drawing.Size(150, 20);
            this.dtStop.TabIndex = 2;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(493, 12);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(109, 42);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "Pobierz";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(24, 68);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(764, 370);
            this.dgvData.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.dtStop);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbTicker);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTicker;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtStop;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

