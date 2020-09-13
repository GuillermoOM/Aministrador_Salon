//TODO: Agregar Servicios y Eliminarlos

using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Salon
{
    public partial class Editar_Cita : Form
    {
        List<Cliente> clientes_disp;
        public Cita Cita_nueva = new Cita();
        public Cliente nuevo_cliente;
        public bool generar = false;

        public Editar_Cita(List<Cliente> clientes)
        {
            InitializeComponent();
            clientes_disp = clientes;
            if (clientes_disp.Count == 0)
            {
                Es_cliente.Enabled = false;
            }
            Hora_Cita.CustomFormat = "hh':'mm tt";
            Fecha_cita.Value = DateTime.Now;
            Hora_Cita.Value = DateTime.Now;
        }

        private void agregar_serv_Click(object sender, EventArgs e)
        {
            Form servicio = new Nueva_Venta();
            servicio.ShowDialog();
        }

        public void Generar_Click(object sender, EventArgs e)
        {
            Cita_nueva.Fecha = Fecha_cita.Text;
            Cita_nueva.Hora = Hora_Cita.Text;
            if (Servicios.Items.Count != 0)
            {
                for (int i = 0; i < Servicios.Items.Count; i++)
                {
                    Cita_nueva.Servicios[i] = Servicios.Items[i].ToString();
                }
            }
            
            if (Es_cliente.Checked)
            {
                Cita_nueva.Cliente = Elegir_cliente.SelectedItem.ToString();
                Cita_nueva.EsCliente = "SI";
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (Nombre.Text == "" || Apellido_1.Text == "" || Apellido_2.Text == "" || telefono.Text == "")
                {
                    MessageBox.Show("Favor de ingresar todos los datos del cliente");
                }
                else
                {
                    nuevo_cliente = new Cliente
                    {
                        Nombre = Nombre.Text,
                        Primer_A = Apellido_1.Text,
                        Segundo_A = Apellido_2.Text,
                        Telefono = telefono.Text
                    };
                    Cita_nueva.Cliente = (nuevo_cliente.Nombre + " " + nuevo_cliente.Primer_A + " " + nuevo_cliente.Segundo_A);
                    Cita_nueva.EsCliente = "NO";
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void Es_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (Elegir_cliente.Enabled)
            {
                Elegir_cliente.Enabled = false;
                Nombre.Enabled = true;
                Apellido_1.Enabled = true;
                Apellido_2.Enabled = true;
                telefono.Enabled = true;
            }
            else
            {
                Elegir_cliente.Enabled = true;
                Nombre.Enabled = false;
                Apellido_1.Enabled = false;
                Apellido_2.Enabled = false;
                telefono.Enabled = false;
                Elegir_cliente.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cita_Load(object sender, EventArgs e)
        {
            if (clientes_disp != null)
            {
                foreach (Cliente n in clientes_disp)
                {
                    Elegir_cliente.Items.Add(n.Nombre + " " + n.Primer_A + " " + n.Segundo_A);
                }
            }
        }
    }
}
