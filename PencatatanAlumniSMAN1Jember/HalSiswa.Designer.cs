namespace PencatatanAlumniSMAN1Jember
{
    partial class HalSiswa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari2 = new System.Windows.Forms.TextBox();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.dgvAlumni2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumni2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = global::PencatatanAlumniSMAN1Jember.Properties.Resources.LOGO_SMASA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCari2);
            this.groupBox1.Controls.Add(this.btnCari2);
            this.groupBox1.Controls.Add(this.dgvAlumni2);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Data Alumni";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // txtCari2
            // 
            this.txtCari2.Location = new System.Drawing.Point(815, 41);
            this.txtCari2.Multiline = true;
            this.txtCari2.Name = "txtCari2";
            this.txtCari2.Size = new System.Drawing.Size(93, 29);
            this.txtCari2.TabIndex = 2;
            // 
            // btnCari2
            // 
            this.btnCari2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCari2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari2.ForeColor = System.Drawing.Color.Black;
            this.btnCari2.Location = new System.Drawing.Point(914, 31);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(122, 45);
            this.btnCari2.TabIndex = 1;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = false;
            this.btnCari2.Click += new System.EventHandler(this.btnCari2_Click);
            // 
            // dgvAlumni2
            // 
            this.dgvAlumni2.AllowUserToAddRows = false;
            this.dgvAlumni2.AllowUserToDeleteRows = false;
            this.dgvAlumni2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAlumni2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumni2.Location = new System.Drawing.Point(34, 92);
            this.dgvAlumni2.Name = "dgvAlumni2";
            this.dgvAlumni2.ReadOnly = true;
            this.dgvAlumni2.RowHeadersWidth = 51;
            this.dgvAlumni2.RowTemplate.Height = 24;
            this.dgvAlumni2.Size = new System.Drawing.Size(1014, 318);
            this.dgvAlumni2.TabIndex = 0;
            // 
            // HalSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HalSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Alumni [Siswa]";
            this.Load += new System.EventHandler(this.HalSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumni2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAlumni2;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.TextBox txtCari2;
        private System.Windows.Forms.Label label1;
    }
}