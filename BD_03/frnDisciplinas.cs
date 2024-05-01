using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_03
{
    public partial class frnDisciplinas : Form
    {
        public frnDisciplinas()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void Listar()
        {
            sql = string.Format("select * from disciplinas");
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        public void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcarga.Clear();
            cbxano.SelectedIndex = -1;
            txtprofessor.Clear();
            txtdesc.Clear();
        }

        private void frnDisciplinas_Load(object sender, EventArgs e)
        {
            Listar();
            Limpar();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into disciplinas values(null, '{0}', '{1}', '{2}', '{3}', '{4}')", 
                                txtnome.Text, txtcarga.Text, cbxano.Text, txtprofessor.Text, txtdesc.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Disciplina cadastrada com sucesso!", "Cadastro de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from disciplinas where codigo = '{0}' or nome = '{1}'", txtcodigo.Text, txtnome.Text);
            buscar = bd.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txtcodigo.Text = buscar.Rows[0]["codigo"].ToString();
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                txtcarga.Text = buscar.Rows[0]["carga_horaria"].ToString();
                cbxano.Text = buscar.Rows[0]["ano"].ToString();
                txtprofessor.Text = buscar.Rows[0]["professor"].ToString();
                txtdesc.Text = buscar.Rows[0]["descricao"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro de disciplinas não encontrado!", "Buscar Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update disciplinas set nome = '{0}', carga_horaria = '{1}', ano = '{2}', professor = '{3}', descricao = '{4}' where codigo = '{5}'",
                                txtnome.Text, txtcarga.Text, cbxano.Text, txtprofessor.Text, txtdesc.Text, txtcodigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Disciplina alterada com sucesso!", "Alterar Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from disciplinas where codigo = '{0}'", txtcodigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Disciplina excluida com sucesso!", "Excluir Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
            Listar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcarga.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxano.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtprofessor.Text = dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdesc.Text = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
