using Animales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class Form1 : Form
    {
        private List<Animal> animales;

        public Form1()
        {
            InitializeComponent();
            CargarValorPorDefectoEnCombos();
            animales = new List<Animal>();
        }

        private void cboTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sen = sender as ComboBox;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                animales.Add(LeerDatosDeControles());
                MessageBox.Show("Animal agregado con éxito !!");
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: NO se pudo agregar el animal. -- {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtRaza.Clear();
            txtSonido.Clear();
            txtAlimento.Clear();
            txtEspecie.Clear();
            nudEdad.Value = 0;
            CargarValorPorDefectoEnCombos();
        }

        private void CargarValorPorDefectoEnCombos()
        {
            cboTipoAnimal.SelectedIndex = 0;
            cboTipoAlimentacion.SelectedIndex = 0;
        }
    
        private Animal LeerDatosDeControles()
        {
            var nombre = txtNombre.Text;
            var raza = txtRaza.Text;
            var sonido = txtSonido.Text;
            var alimento = txtAlimento.Text;
            var especie = txtEspecie.Text;
            var edad = (int)nudEdad.Value;
            var tipoAnimal = (Animales.TipoAnimal)cboTipoAnimal.SelectedIndex;
            var tipoAlimentacion = (Animales.TipoAlimentacion)cboTipoAlimentacion.SelectedIndex;
            switch(tipoAnimal)
            {
                case TipoAnimal.Mamifero:
                    return new Mamifero(nombre,edad, especie, raza, tipoAlimentacion,alimento, sonido, 9, true);
                case TipoAnimal.Ave:
                    return new Aves(nombre, edad, especie, raza, tipoAlimentacion, alimento, sonido, true, true, "primavera");
                case TipoAnimal.Pez:
                case TipoAnimal.Reptil:
                case TipoAnimal.Insecto:
                    return new Animal(nombre, tipoAnimal, edad, especie, raza, tipoAlimentacion, alimento, sonido);
                case TipoAnimal.Indefinido:
                    throw new Exception("Debe seleccionar un tipo de animal válido.");
                default:
                    break;
            }
            return null;
        }

        private void BtnVerDatos_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder("Mis animales son: ");
            foreach (var animal in animales)
            {
                builder.AppendLine();
                builder.Append($"{animal.Nombre} de especie: {animal.Especie}");
            }
            MessageBox.Show(builder.ToString());
        }
    }
}
