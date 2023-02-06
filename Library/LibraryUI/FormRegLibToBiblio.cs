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
    public partial class FormRegLibToBiblio : Form
    {
        clsControllerLibrary library = new clsControllerLibrary();
        clsControllerBook book = new clsControllerBook();
        public FormRegLibToBiblio()
        {
            InitializeComponent();
            iconButton1.Enabled = false;
        }

        private void textNitBiblio_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            int libcodigo = int.Parse(textCodigoLib.Text);
            int nitBiblioteca = int.Parse(textNitBiblio.Text);
            string fechaIni = fecha.ToString();
            string fechaFin = fecha2.ToString();
            if (book.ControllerValidateCodeBook(libcodigo)== true && library.ControllerValidateCodeLibrary(nitBiblioteca) == true)
            {
                if (library.ControllerValidateBookOnLibrary(libcodigo, nitBiblioteca) == false)
                {
                    library.ControllerRegisterBookOnLibrary(libcodigo, nitBiblioteca, fechaIni, fechaFin);
                    dataGridBiblio.DataSource = library.ControllerShowAllBookOnLibrary();
                    textNitBiblio.Clear(); textCodigoLib.Clear();
                }
                else
                {
                    MessageBox.Show("Ya existe registro de este libro en una biblioteca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textNitBiblio.Clear(); textCodigoLib.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("No existe la biblioteca o el libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNitBiblio.Clear(); textCodigoLib.Clear();
            }
}

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textCodigoLib.Text) &&
                !string.IsNullOrEmpty(textNitBiblio.Text);
            iconButton1.Enabled = vr;
        }

        private void textCodigoLib_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textCodigoLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNitBiblio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FormRegLibToBiblio_Load(object sender, EventArgs e)
        {
            dataGridBiblio.DataSource = library.ControllerShowAllBookOnLibrary();
        }
    }
}
