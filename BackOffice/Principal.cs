using BackOffice.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void miMantenimientoAnimales_Click(object sender, EventArgs e)
        {
            Form1 mantenimientoAnimalesForm = new Form1();
            mantenimientoAnimalesForm.MdiParent = this;
            mantenimientoAnimalesForm.Show();

        }

        private void miMantenimientoUsuarios_Click(object sender, EventArgs e)
        {
            UsersGrid usersGridForm = new UsersGrid();
            usersGridForm.MdiParent = this;
            usersGridForm.Show();
        }
    }
}
