
namespace LibraryUI
{
    partial class FormRegLibToBiblio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLibCat = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textNitBiblio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCodigoLib = new System.Windows.Forms.TextBox();
            this.labelCatLib = new System.Windows.Forms.Label();
            this.panelConsBiblio = new System.Windows.Forms.Panel();
            this.dataGridBiblio = new System.Windows.Forms.DataGridView();
            this.panelLibCat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelConsBiblio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLibCat
            // 
            this.panelLibCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.panelLibCat.Controls.Add(this.iconButton1);
            this.panelLibCat.Controls.Add(this.dateTimePicker2);
            this.panelLibCat.Controls.Add(this.dateTimePicker1);
            this.panelLibCat.Controls.Add(this.label2);
            this.panelLibCat.Controls.Add(this.label1);
            this.panelLibCat.Controls.Add(this.panel2);
            this.panelLibCat.Controls.Add(this.panel1);
            this.panelLibCat.Controls.Add(this.labelCatLib);
            this.panelLibCat.Controls.Add(this.panelConsBiblio);
            this.panelLibCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibCat.Location = new System.Drawing.Point(0, 0);
            this.panelLibCat.Name = "panelLibCat";
            this.panelLibCat.Size = new System.Drawing.Size(786, 450);
            this.panelLibCat.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(400, 227);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(20);
            this.iconButton1.Size = new System.Drawing.Size(386, 223);
            this.iconButton1.TabIndex = 35;
            this.iconButton1.Text = "Registrar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(533, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(400, 182);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(386, 45);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha Fin:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(400, 137);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(386, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha inicio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textNitBiblio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(400, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 61);
            this.panel2.TabIndex = 17;
            // 
            // textNitBiblio
            // 
            this.textNitBiblio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNitBiblio.Location = new System.Drawing.Point(120, 35);
            this.textNitBiblio.Name = "textNitBiblio";
            this.textNitBiblio.Size = new System.Drawing.Size(146, 20);
            this.textNitBiblio.TabIndex = 13;
            this.textNitBiblio.TextChanged += new System.EventHandler(this.textNitBiblio_TextChanged);
            this.textNitBiblio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNitBiblio_KeyPress);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Registrar en biblioteca (NIT):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textCodigoLib);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(400, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 31);
            this.panel1.TabIndex = 16;
            // 
            // textCodigoLib
            // 
            this.textCodigoLib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCodigoLib.Location = new System.Drawing.Point(120, 5);
            this.textCodigoLib.Name = "textCodigoLib";
            this.textCodigoLib.Size = new System.Drawing.Size(146, 20);
            this.textCodigoLib.TabIndex = 5;
            this.textCodigoLib.TextChanged += new System.EventHandler(this.textCodigoLib_TextChanged);
            this.textCodigoLib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigoLib_KeyPress);
            // 
            // labelCatLib
            // 
            this.labelCatLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCatLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatLib.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCatLib.Location = new System.Drawing.Point(400, 0);
            this.labelCatLib.Name = "labelCatLib";
            this.labelCatLib.Size = new System.Drawing.Size(386, 45);
            this.labelCatLib.TabIndex = 15;
            this.labelCatLib.Text = "Código del libro:";
            this.labelCatLib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConsBiblio
            // 
            this.panelConsBiblio.Controls.Add(this.dataGridBiblio);
            this.panelConsBiblio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConsBiblio.Location = new System.Drawing.Point(0, 0);
            this.panelConsBiblio.Name = "panelConsBiblio";
            this.panelConsBiblio.Size = new System.Drawing.Size(400, 450);
            this.panelConsBiblio.TabIndex = 8;
            // 
            // dataGridBiblio
            // 
            this.dataGridBiblio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBiblio.Location = new System.Drawing.Point(0, 0);
            this.dataGridBiblio.Name = "dataGridBiblio";
            this.dataGridBiblio.ReadOnly = true;
            this.dataGridBiblio.Size = new System.Drawing.Size(400, 450);
            this.dataGridBiblio.TabIndex = 1;
            // 
            // FormRegLibToBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.panelLibCat);
            this.Name = "FormRegLibToBiblio";
            this.Text = "Registro de libro en biblioteca";
            this.Load += new System.EventHandler(this.FormRegLibToBiblio_Load);
            this.panelLibCat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConsBiblio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLibCat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCatLib;
        private System.Windows.Forms.Panel panelConsBiblio;
        private System.Windows.Forms.DataGridView dataGridBiblio;
        private System.Windows.Forms.TextBox textCodigoLib;
        private System.Windows.Forms.TextBox textNitBiblio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}