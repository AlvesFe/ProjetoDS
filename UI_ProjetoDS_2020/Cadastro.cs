using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ProjetoDS_2020;
using DTO_ProjetoDS_2020;

namespace UI_ProjetoDS_2020
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Cadastro obj = new DTO_Cadastro();
                obj.nome = txtNome.Text;
                obj.userName = txtUsuario.Text;
                obj.email = txtEmail.Text;
                obj.CPF = txtCpf.Text;
                obj.senha = txtSenha.Text;
                obj.confSenha = txtConfSenha.Text;

                MessageBox.Show(BLL_Cadastro.ValidarCadastro(obj));

                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
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
