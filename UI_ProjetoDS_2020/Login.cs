using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoDS_2020;
using BLL_ProjetoDS_2020;

namespace UI_ProjetoDS_2020
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Login obj = new DTO_Login();

                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;

                MessageBox.Show(BLL_Login.ValidarLogin(obj));

                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
