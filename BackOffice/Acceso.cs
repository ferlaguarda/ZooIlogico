using AuthenicationLogic;
using CommonEntities.Interfaces;
using System;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            IAuthentication auth = new FileAccess();
            try
            {
                if(auth.Login(usuario, password))
                {
                    Principal mainForm = new Principal();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Las credenciales de acceso no son validas.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
        }
    }
}
