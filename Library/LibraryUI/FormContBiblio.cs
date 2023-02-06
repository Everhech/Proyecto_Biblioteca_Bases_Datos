using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryUI.controller;

namespace LibraryUI
{
    public partial class FormContBiblio : Form
    {
        clsControllerLibrary library = new clsControllerLibrary();
        public FormContBiblio()
        {
            InitializeComponent();
            iconButton1.Enabled = false;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            int nit = int.Parse(textNit.Text);
            string fechaIni = dateTimePicker1.Text;
            if (library.ControllerValidateCodeLibrary(nit) == true)
            {
                dataGridBiblio.DataSource = library.ControllerResearchLibrary(nit, fechaIni);
                textNit.Clear();
            }
            else
            {
                MessageBox.Show("No existe la biblioteca buscada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNit.Clear();
            }
            
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textNit.Text);
            iconButton1.Enabled = vr;
        }

        private void textNit_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FormContBiblio_Load(object sender, EventArgs e)
        {

        }
    }
}
