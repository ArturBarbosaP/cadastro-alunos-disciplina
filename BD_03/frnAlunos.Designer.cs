namespace BD_03
{
    partial class frnAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnAlunos));
            this.lblmatricula = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnfoto = new System.Windows.Forms.Button();
            this.imgfoto = new System.Windows.Forms.PictureBox();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatricula
            // 
            this.lblmatricula.AutoSize = true;
            this.lblmatricula.Location = new System.Drawing.Point(12, 9);
            this.lblmatricula.Name = "lblmatricula";
            this.lblmatricula.Size = new System.Drawing.Size(49, 13);
            this.lblmatricula.TabIndex = 0;
            this.lblmatricula.Text = "Marícula";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(168, 9);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(12, 72);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(30, 13);
            this.lbldata.TabIndex = 2;
            this.lbldata.Text = "Data";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(349, 72);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Location = new System.Drawing.Point(556, 72);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(30, 13);
            this.lblnota.TabIndex = 4;
            this.lblnota.Text = "Nota";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(15, 34);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(115, 20);
            this.txtmatricula.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(171, 34);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(490, 20);
            this.txtnome.TabIndex = 6;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(559, 103);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(102, 20);
            this.txtnota.TabIndex = 7;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(15, 103);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(224, 20);
            this.dtpdata.TabIndex = 8;
            // 
            // cbxsexo
            // 
            this.cbxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbxsexo.Location = new System.Drawing.Point(352, 102);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(74, 21);
            this.cbxsexo.TabIndex = 9;
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(15, 150);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(646, 206);
            this.dtglistar.TabIndex = 10;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // btnnovo
            // 
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.Location = new System.Drawing.Point(15, 379);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(101, 50);
            this.btnnovo.TabIndex = 11;
            this.btnnovo.Text = "Novo";
            this.btnnovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(151, 379);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 50);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Image = ((System.Drawing.Image)(resources.GetObject("btnalterar.Image")));
            this.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalterar.Location = new System.Drawing.Point(287, 379);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(101, 50);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(423, 379);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(101, 50);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(559, 379);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(101, 50);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnfoto.Image")));
            this.btnfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfoto.Location = new System.Drawing.Point(731, 379);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(295, 50);
            this.btnfoto.TabIndex = 16;
            this.btnfoto.Text = "Escolher foto...";
            this.btnfoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // imgfoto
            // 
            this.imgfoto.Location = new System.Drawing.Point(731, 9);
            this.imgfoto.Name = "imgfoto";
            this.imgfoto.Size = new System.Drawing.Size(295, 347);
            this.imgfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgfoto.TabIndex = 17;
            this.imgfoto.TabStop = false;
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            // 
            // frnAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.imgfoto);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblmatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frnAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frnAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatricula;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.PictureBox imgfoto;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
    }
}

