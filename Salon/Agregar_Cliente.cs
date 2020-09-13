using System;
using System.Windows.Forms;

namespace Salon
{
    public partial class Agregar_Cliente : Form
    {
        public Cliente nuevo_cliente;

        public Agregar_Cliente(string Nom, string Ape1, string Ape2, string Tel)
        {
            InitializeComponent();
            NombreBox.Text = Nom;
            Apellido1Box.Text = Ape1;
            Apellido2Box.Text = Ape2;
            TelefonoBox.Text = Tel;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (NombreBox.Text == "" || Apellido1Box.Text == "" || Apellido2Box.Text == "" || TelefonoBox.Text == "")
            {
                MessageBox.Show("Favor de ingresar todos los datos");
            }
            else
            {
                nuevo_cliente = new Cliente
                {
                    Nombre = NombreBox.Text,
                    Primer_A = Apellido1Box.Text,
                    Segundo_A = Apellido2Box.Text,
                    Telefono = TelefonoBox.Text
                };
                DialogResult = DialogResult.OK;
            }
        }
    }
}
