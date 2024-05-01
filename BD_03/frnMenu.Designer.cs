namespace BD_03
{
    partial class frnMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnMenu));
            this.imgalunos = new System.Windows.Forms.PictureBox();
            this.imgdisciplinas = new System.Windows.Forms.PictureBox();
            this.lblalunos = new System.Windows.Forms.Label();
            this.lbldisciplinas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgalunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // imgalunos
            // 
            this.imgalunos.Image = ((System.Drawing.Image)(resources.GetObject("imgalunos.Image")));
            this.imgalunos.Location = new System.Drawing.Point(53, 117);
            this.imgalunos.Name = "imgalunos";
            this.imgalunos.Size = new System.Drawing.Size(442, 286);
            this.imgalunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgalunos.TabIndex = 0;
            this.imgalunos.TabStop = false;
            this.imgalunos.Click += new System.EventHandler(this.imgalunos_Click);
            // 
            // imgdisciplinas
            // 
            this.imgdisciplinas.Image = ((System.Drawing.Image)(resources.GetObject("imgdisciplinas.Image")));
            this.imgdisciplinas.Location = new System.Drawing.Point(558, 117);
            this.imgdisciplinas.Name = "imgdisciplinas";
            this.imgdisciplinas.Size = new System.Drawing.Size(442, 286);
            this.imgdisciplinas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdisciplinas.TabIndex = 1;
            this.imgdisciplinas.TabStop = false;
            this.imgdisciplinas.Click += new System.EventHandler(this.imgdisciplinas_Click);
            // 
            // lblalunos
            // 
            this.lblalunos.AutoSize = true;
            this.lblalunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalunos.Location = new System.Drawing.Point(186, 47);
            this.lblalunos.Name = "lblalunos";
            this.lblalunos.Size = new System.Drawing.Size(177, 55);
            this.lblalunos.TabIndex = 2;
            this.lblalunos.Text = "Alunos";
            this.lblalunos.Click += new System.EventHandler(this.lblalunos_Click);
            // 
            // lbldisciplinas
            // 
            this.lbldisciplinas.AutoSize = true;
            this.lbldisciplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisciplinas.Location = new System.Drawing.Point(648, 47);
            this.lbldisciplinas.Name = "lbldisciplinas";
            this.lbldisciplinas.Size = new System.Drawing.Size(263, 55);
            this.lbldisciplinas.TabIndex = 3;
            this.lbldisciplinas.Text = "Disciplinas";
            this.lbldisciplinas.Click += new System.EventHandler(this.lbldisciplinas_Click);
            // 
            // frnMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.lbldisciplinas);
            this.Controls.Add(this.lblalunos);
            this.Controls.Add(this.imgdisciplinas);
            this.Controls.Add(this.imgalunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frnMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.imgalunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgalunos;
        private System.Windows.Forms.PictureBox imgdisciplinas;
        private System.Windows.Forms.Label lblalunos;
        private System.Windows.Forms.Label lbldisciplinas;
    }
}