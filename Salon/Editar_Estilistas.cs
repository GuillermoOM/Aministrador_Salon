using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class Editar_Estilistas : Form
    {
        public Editar_Estilistas()
        {
            InitializeComponent();
        }

        private void Agregar_es_Click(object sender, EventArgs e)
        {
            Form Add_est = new Agregar_estilista();
            Add_est.ShowDialog();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
