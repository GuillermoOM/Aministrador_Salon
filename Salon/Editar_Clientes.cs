using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Salon
{
    public partial class Editar_Clientes : Form
    {
        public List<Cliente> clientes_disp = new List<Cliente>();
        Agregar_Cliente AddClient;

        public Editar_Clientes(List<Cliente> clientes)
        {
            InitializeComponent();
            clientes_disp = clientes;
            Actualizar();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            using (AddClient = new Agregar_Cliente("", "", "", ""))
            {
                AddClient.ShowDialog();
                if (AddClient.DialogResult == DialogResult.OK)
                {
                    clientes_disp.Add(AddClient.nuevo_cliente);
                    Actualizar();
                }
            }
        }

        private void Actualizar()
        {
            Tabla_Clientes.Items.Clear();
            for (int i = 0; i < clientes_disp.Count; i++)
            {
                Tabla_Clientes.Items.Add((clientes_disp[i].Nombre + " " + clientes_disp[i].Primer_A + " " + clientes_disp[i].Segundo_A));
                Tabla_Clientes.Items[i].SubItems.Add(clientes_disp[i].Telefono);
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void EliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clientes_disp.RemoveAt(Tabla_Clientes.SelectedItems[0].Index);
            Tabla_Clientes.SelectedItems[0].Remove();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddClient = new Agregar_Cliente(
                clientes_disp[Tabla_Clientes.SelectedItems[0].Index].Nombre,
                clientes_disp[Tabla_Clientes.SelectedItems[0].Index].Primer_A,
                clientes_disp[Tabla_Clientes.SelectedItems[0].Index].Segundo_A,
                clientes_disp[Tabla_Clientes.SelectedItems[0].Index].Telefono))
            {
                AddClient.ShowDialog();
                if (AddClient.DialogResult == DialogResult.OK)
                {
                    clientes_disp[Tabla_Clientes.SelectedItems[0].Index] = AddClient.nuevo_cliente;
                    Actualizar();
                }
            }
        }
    }
}
