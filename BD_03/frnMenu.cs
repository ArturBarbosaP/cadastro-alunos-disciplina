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
    public partial class frnMenu : Form
    {
        public frnMenu()
        {
            InitializeComponent();
        }

        private void imgalunos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frnAlunos cadAlunos = new frnAlunos();
            cadAlunos.ShowDialog();
            this.Visible = true;
        }

        private void lblalunos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frnAlunos cadAlunos = new frnAlunos();
            cadAlunos.ShowDialog();
            this.Visible = true;
        }


        private void imgdisciplinas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frnDisciplinas cadDisciplinas = new frnDisciplinas();
            cadDisciplinas.ShowDialog();
            this.Visible = true;
        }

        private void lbldisciplinas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frnDisciplinas cadDisciplinas = new frnDisciplinas();
            cadDisciplinas.ShowDialog();
            this.Visible = true;
        }
    }
}
