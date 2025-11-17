using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using FileAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.Usuarios
{
    public partial class UsersGrid : Form
    {
        private BindingList<UsuarioBO> bindingList;
        public UsersGrid()
        {
            InitializeComponent();
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersGrid_Load(object sender, EventArgs e)
        {
            IGenericFileManager<UsuarioBO> jsonManager = new GenericJasonManager<UsuarioBO>();
            List<UsuarioBO> users = jsonManager.Leer("C:\\Temporal\\Progg2\\usuariosBO.json");
            bindingList  = new BindingList<UsuarioBO>(users);

            if (users !=null && users.Any()){
                DgvUsers.DataSource = bindingList;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IGenericFileManager<UsuarioBO> jsonManager = new GenericJasonManager<UsuarioBO>();
            jsonManager.Guardar("C:\\Temporal\\Progg2\\usuariosBO.json", bindingList.ToList());
            
        }
    }
}
