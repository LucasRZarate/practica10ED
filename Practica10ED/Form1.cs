using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
         private void button1_Click(object sender, EventArgs e)
            {         
            if(tNombre.Text == "" || tTelefono.Text == "" || tApellidos.Text == "")
            {
                MessageBox.Show("Inserta todos los datos");
                return;
            }    
            string nombre = tNombre.Text;
            string apellido = tApellidos.Text;
            string telefono = tTelefono.Text;
            tListaSocios.Text += nombre + apellido + telefono +" \r\n";
        }
    }
}
