namespace Tugas_Week_2
{
    partial class FormWarna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblInput = new System.Windows.Forms.Label();
            this.TBoxIsi = new System.Windows.Forms.TextBox();
            this.BtnProses = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(25, 45);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(86, 20);
            this.LblInput.TabIndex = 0;
            this.LblInput.Text = "Input Data :";
            // 
            // TBoxIsi
            // 
            this.TBoxIsi.Location = new System.Drawing.Point(25, 81);
            this.TBoxIsi.Name = "TBoxIsi";
            this.TBoxIsi.Size = new System.Drawing.Size(431, 27);
            this.TBoxIsi.TabIndex = 1;
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(25, 133);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(94, 29);
            this.BtnProses.TabIndex = 2;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(12, 165);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(185, 54);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "[EMPTY]";
            // 
            // FormWarna
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 271);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.TBoxIsi);
            this.Controls.Add(this.LblInput);
            this.Name = "FormWarna";
            this.Text = "Form Pengaturan Warna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.TextBox TBoxIsi;
        private System.Windows.Forms.Button BtnProses;
        private System.Windows.Forms.Label LblOutput;
    }
}
