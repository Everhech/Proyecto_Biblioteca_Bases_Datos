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
    public partial class FormRegLib : Form
    {
        clsControllerBook book = new clsControllerBook();
        clsControllerLibrary library = new clsControllerLibrary();
        public FormRegLib()
        {
            InitializeComponent();
            iconButton1.Enabled = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            int libcodigo = int.Parse(textCodigoLib.Text);
            string libtitulo = textTitulo.Text;
            int numPag = int.Parse(textNroPags.Text);
            string categoria = comboBox1.Text;
            string fechaIni = fecha.ToString();
            string fechaFin = fecha2.ToString();
            int nitBiblioteca = int.Parse(textNitBiblio.Text);
            if (book.ControllerValidateCodeBook(libcodigo) == false && book.ControllerValidateTitleBook(libtitulo) == false )
            {
                if (library.ControllerValidateCodeLibrary(nitBiblioteca) == true)
                {
                    book.ControllerRegisterBook(libcodigo, libtitulo, numPag, categoria, fechaIni, fechaFin, nitBiblioteca);
                    library.ControllerRegisterBookOnLibrary(libcodigo,nitBiblioteca,fechaIni,fechaFin);
                    dataGridBiblio.DataSource = book.ControllerShowAllBooks();
                    textCodigoLib.Clear(); textTitulo.Clear(); textNroPags.Clear(); textNitBiblio.Clear();
                }
                else
                {
                    MessageBox.Show("No existe la biblioteca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridBiblio.DataSource = book.ControllerShowAllBooks();
                    textNitBiblio.Clear();
                }                
            }
            else
            {
                MessageBox.Show("Ya existe este libro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridBiblio.DataSource = book.ControllerShowAllBooks();
                textCodigoLib.Clear(); textTitulo.Clear(); textNroPags.Clear(); textNitBiblio.Clear();
            }
        }

        private void FormRegLib_Load(object sender, EventArgs e)
        {
            dataGridBiblio.DataSource = book.ControllerShowAllBooks();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textCodigoLib.Text) &&
                !string.IsNullOrEmpty(textNitBiblio.Text) && !string.IsNullOrEmpty(textNroPags.Text) &&
               !string.IsNullOrEmpty(textTitulo.Text) && !string.IsNullOrEmpty(comboBox1.Text);
            iconButton1.Enabled = vr;
        }

        private void textCodigoLib_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textTitulo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textNroPags_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textNitBiblio_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void textNroPags_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textCodigoLib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, ingrese solo números.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
