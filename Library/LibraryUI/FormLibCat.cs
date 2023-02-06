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
    public partial class FormLibCat : Form
    {
        clsControllerBook book = new clsControllerBook();
        public FormLibCat()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string categoria = comboBox1.Text;
            dataGridCount.DataSource = book.ControllerResearchCountBook(categoria);            
            dataGridBiblio.DataSource = book.ControllerShowBookByCategory(categoria);            
        }

        private void FormLibCat_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
            
    }
}
