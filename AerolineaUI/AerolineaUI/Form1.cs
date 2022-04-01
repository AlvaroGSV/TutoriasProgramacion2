using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaUI
{
    public partial class Form1 : Form
    {
        metodos metodo;
        public Form1(metodos met)
        {
            InitializeComponent();
            metodo = met;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txteMail.Clear();
            txtPrimerApellido.Clear();
            txtPrimerNombre.Clear();
            txtSegundoApellido.Clear();
            txtSegundoNombre.Clear();
            txtTel.Clear();
            cmbNacionaliad.Text = "";
            numudEdad.Value = 18;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int validado = metodo.NuevoPasajero(txtPrimerNombre.Text.ToUpper().ToString(),txtSegundoNombre.Text.ToUpper().ToString(),txtPrimerApellido.Text.ToUpper().ToString(),txtSegundoApellido.Text.ToUpper().ToString(), cmbNacionaliad.Text.ToUpper().ToString(), Convert.ToInt32(numudEdad.Value), txtTel.Text.ToString(),txteMail.Text.ToString());
            lblRes.Text = validado.ToString();
        }
    }
}
