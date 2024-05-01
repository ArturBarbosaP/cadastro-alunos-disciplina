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
    public partial class frnAlunos : Form
    {
        public frnAlunos()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql, foto;
        DateTime data;

        public void Listar()
        {
            sql = string.Format("select * from alunos");
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        public void Limpar()
        {
            txtmatricula.Clear();
            txtnome.Clear();
            txtnota.Clear();
            dtpdata.Text = DateTime.Now.ToString();
            cbxsexo.SelectedIndex = -1;
            imgfoto.Load("D:/Meus Documentos/Documentos/Escola/2021/TEP/Visual Studio/BD_03/semfoto.jpg");
        }

        private void frnAlunos_Load(object sender, EventArgs e)
        {
            Listar();
            Limpar();
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            foto = "";
            if (ofdfoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgfoto.Load(ofdfoto.FileName);
                foto = ofdfoto.FileName;
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtpdata.Text);
            foto = foto.Replace(@"\", @"\\");
            sql = string.Format("insert into alunos values(null, '{0}', '{1}', '{2}', '{3}', '{4}')",
                         txtnome.Text, data.ToString("yyyy-MM-dd"), cbxsexo.Text, txtnota.Text, foto);

            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno cadastrado com sucesso!", "Cadastro de Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
            Limpar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from alunos where matricula = '{0}' or nome = '{1}'", txtmatricula.Text, txtnome.Text);
            buscar = bd.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txtmatricula.Text = buscar.Rows[0]["matricula"].ToString();
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                txtnota.Text = buscar.Rows[0]["nota"].ToString();
                dtpdata.Text = buscar.Rows[0]["dt_nasc"].ToString();
                cbxsexo.Text = buscar.Rows[0]["sexo"].ToString();
                imgfoto.Load(buscar.Rows[0]["foto"].ToString());
                foto = buscar.Rows[0]["foto"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro de aluno(a) não encontrado!", "Buscar Aluno(a).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            foto = foto.Replace(@"\", @"\\");
            data = DateTime.Parse(dtpdata.Text);
            sql = string.Format("update alunos set nome = '{0}', dt_nasc = '{1}', nota = '{2}', sexo = '{3}', foto = '{4}' where matricula = '{5}'",
                                txtnome.Text, data.ToString("yyyy-MM-dd"), txtnota.Text, cbxsexo.Text, foto, txtmatricula.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno(a) alterado com sucesso!", "Alterar Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            Listar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from alunos where matricula = '{0}'", txtmatricula.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno(a) excluido com sucesso!", "Excluir Alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            Listar();
            Limpar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatricula.Text = dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpdata.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxsexo.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnota.Text = dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString();
            imgfoto.Load(dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString());
            foto = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
