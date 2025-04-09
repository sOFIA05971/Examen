using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Inicio : Form
    {
        Acciones acc = new Acciones();

        public Inicio()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DGdatos.DataSource = null;
            DGdatos.DataSource = acc.MostrarN();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarN(Convert.ToInt32(tbxID.Text)))

            {
                MessageBox.Show("Eliminado con exito");
            }
            else
            {
                MessageBox.Show("Fallo al eliminar");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                if (acc.AgregarN(Convert.ToInt32(tbxID.Text),tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text), tbxColor.Text))
                    MessageBox.Show("Agregado con exito");

                else
                    MessageBox.Show("Fallo al agregado");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarN(Convert.ToInt32(tbxID.Text), tbxNombre.Text, Convert.ToDateTime(tbxFecha.Text), Convert.ToBoolean(tbxActivo.Text),tbxColor.Text))
            {
                MessageBox.Show("Actualizado con éxito");
                DGdatos.DataSource = null;
                DGdatos.DataSource = acc.MostrarN();
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }
        }
    }
}
