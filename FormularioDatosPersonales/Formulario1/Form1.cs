using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();

            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(nudEdad.Value);
            string direccion = txtDireccion.Text;

            if(apellido.Length == 0)
            {
                txtApellido.BackColor = Color.Red;
                return;
            }

            items.Add("APELLIDO Y NOMBRE: " + txtApellido.Text + ", " + txtNombre.Text);
            items.Add("EDAD: " + Convert.ToInt32(nudEdad.Value));
            items.Add("DIRECCION: " + txtDireccion.Text);

            foreach (var item in items)
            {
                listView1.Items.Add(item);
            }
        }
    }
}
