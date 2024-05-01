
namespace BD_03
{
    partial class frnDisciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnDisciplinas));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcarga = new System.Windows.Forms.Label();
            this.txtcarga = new System.Windows.Forms.TextBox();
            this.lblano = new System.Windows.Forms.Label();
            this.cbxano = new System.Windows.Forms.ComboBox();
            this.lblprofessor = new System.Windows.Forms.Label();
            this.txtprofessor = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(12, 9);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(15, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(154, 9);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(157, 35);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(539, 20);
            this.txtnome.TabIndex = 3;
            // 
            // lblcarga
            // 
            this.lblcarga.AutoSize = true;
            this.lblcarga.Location = new System.Drawing.Point(735, 9);
            this.lblcarga.Name = "lblcarga";
            this.lblcarga.Size = new System.Drawing.Size(72, 13);
            this.lblcarga.TabIndex = 4;
            this.lblcarga.Text = "Carga Horária";
            // 
            // txtcarga
            // 
            this.txtcarga.Location = new System.Drawing.Point(738, 35);
            this.txtcarga.Name = "txtcarga";
            this.txtcarga.Size = new System.Drawing.Size(123, 20);
            this.txtcarga.TabIndex = 5;
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(900, 9);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(26, 13);
            this.lblano.TabIndex = 6;
            this.lblano.Text = "Ano";
            // 
            // cbxano
            // 
            this.cbxano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxano.FormattingEnabled = true;
            this.cbxano.Items.AddRange(new object[] {
            "Primeiro",
            "Segundo",
            "Terceiro"});
            this.cbxano.Location = new System.Drawing.Point(903, 35);
            this.cbxano.Name = "cbxano";
            this.cbxano.Size = new System.Drawing.Size(121, 21);
            this.cbxano.TabIndex = 7;
            // 
            // lblprofessor
            // 
            this.lblprofessor.AutoSize = true;
            this.lblprofessor.Location = new System.Drawing.Point(12, 68);
            this.lblprofessor.Name = "lblprofessor";
            this.lblprofessor.Size = new System.Drawing.Size(116, 13);
            this.lblprofessor.TabIndex = 8;
            this.lblprofessor.Text = "Professor Responsável";
            // 
            // txtprofessor
            // 
            this.txtprofessor.Location = new System.Drawing.Point(15, 94);
            this.txtprofessor.Name = "txtprofessor";
            this.txtprofessor.Size = new System.Drawing.Size(398, 20);
            this.txtprofessor.TabIndex = 9;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(443, 68);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(55, 13);
            this.lbldesc.TabIndex = 10;
            this.lbldesc.Text = "Descrição";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(446, 94);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(578, 20);
            this.txtdesc.TabIndex = 11;
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(15, 137);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.RowHeadersWidth = 50;
            this.dtglistar.Size = new System.Drawing.Size(1009, 222);
            this.dtglistar.TabIndex = 12;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // btnvoltar
            // 
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(907, 377);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(116, 50);
            this.btnvoltar.TabIndex = 22;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(684, 377);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(116, 50);
            this.btnexcluir.TabIndex = 21;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Image = ((System.Drawing.Image)(resources.GetObject("btnalterar.Image")));
            this.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalterar.Location = new System.Drawing.Point(461, 377);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(116, 50);
            this.btnalterar.TabIndex = 20;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(238, 377);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(116, 50);
            this.btnbuscar.TabIndex = 19;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.Location = new System.Drawing.Point(15, 377);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(116, 50);
            this.btnnovo.TabIndex = 18;
            this.btnnovo.Text = "Novo";
            this.btnnovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // frnDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.txtprofessor);
            this.Controls.Add(this.lblprofessor);
            this.Controls.Add(this.cbxano);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.txtcarga);
            this.Controls.Add(this.lblcarga);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frnDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplinas";
            this.Load += new System.EventHandler(this.frnDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcarga;
        private System.Windows.Forms.TextBox txtcarga;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.ComboBox cbxano;
        private System.Windows.Forms.Label lblprofessor;
        private System.Windows.Forms.TextBox txtprofessor;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnnovo;
    }
}