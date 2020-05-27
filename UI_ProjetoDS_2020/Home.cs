using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI_ProjetoDS_2020
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}
