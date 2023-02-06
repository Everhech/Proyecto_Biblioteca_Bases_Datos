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
    public partial class FormRegBiblio : Form
    {
        clsControllerLibrary library = new clsControllerLibrary();
        public FormRegBiblio()
        {
            InitializeComponent();
            registrarBibliotecaclick.Enabled = false;
        }

        private void textNit_TextChanged(object sender, EventArgs e)
        {
            this.validarCampo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            registrarBibliotecaclick.Enabled = false;
            int nit = int.Parse(textNit.Text);
            string nameLibrary = textNomBiblio.Text;
            if (library.ControllerValidateCodeLibrary(nit) == false && library.ControllerValidateNameLibrary(nameLibrary) == false)
            {
                library.ControllerRegisterLibrary(nit,nameLibrary);
                dataGridBiblio.DataSource = library.ControllerShowAllLibrary();
                textNit.Clear(); textNomBiblio.Clear();
            }
            else
            {
                MessageBox.Show("Ya existe esta biblioteca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNit.Clear(); textNomBiblio.Clear();
            }
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textNomBiblio.Text) &&
                !string.IsNullOrEmpty(textNit.Text);
            registrarBibliotecaclick.Enabled = vr;
        }

        private void textNomBiblio_TextChanged(object sender, EventArgs e)
        {
            this.validarCampo();
        }

        private void textNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar <=47)|| (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FormRegBiblio_Load(object sender, EventArgs e)
        {
            dataGridBiblio.DataSource = library.ControllerShowAllLibrary();
        }
    }
}
