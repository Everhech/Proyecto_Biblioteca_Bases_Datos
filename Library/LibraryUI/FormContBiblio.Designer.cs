
namespace LibraryUI
{
    partial class FormContBiblio
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
            this.panelCons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.panelNit = new System.Windows.Forms.Panel();
            this.textNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsBiblio = new System.Windows.Forms.Panel();
            this.dataGridBiblio = new System.Windows.Forms.DataGridView();
            this.panelCons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelNit.SuspendLayout();
            this.panelConsBiblio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCons
            // 
            this.panelCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.panelCons.Controls.Add(this.panel3);
            this.panelCons.Controls.Add(this.panelConsBiblio);
            this.panelCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCons.Location = new System.Drawing.Point(0, 0);
            this.panelCons.Name = "panelCons";
            this.panelCons.Size = new System.Drawing.Size(668, 437);
            this.panelCons.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panelSpace);
            this.panel3.Controls.Add(this.panelNit);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 437);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iconButton1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 78);
            this.panel6.TabIndex = 25;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(20);
            this.iconButton1.Size = new System.Drawing.Size(268, 78);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Consultar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 168);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(268, 45);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha inicio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSpace
            // 
            this.panelSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpace.Location = new System.Drawing.Point(0, 122);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(268, 46);
            this.panelSpace.TabIndex = 4;
            // 
            // panelNit
            // 
            this.panelNit.Controls.Add(this.textNit);
            this.panelNit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNit.Location = new System.Drawing.Point(0, 94);
            this.panelNit.Name = "panelNit";
            this.panelNit.Size = new System.Drawing.Size(268, 28);
            this.panelNit.TabIndex = 3;
            // 
            // textNit
            // 
            this.textNit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNit.Location = new System.Drawing.Point(54, 4);
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(160, 20);
            this.textNit.TabIndex = 4;
            this.textNit.TextChanged += new System.EventHandler(this.textNit_TextChanged);
            this.textNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNit_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIT :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConsBiblio
            // 
            this.panelConsBiblio.Controls.Add(this.dataGridBiblio);
            this.panelConsBiblio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConsBiblio.Location = new System.Drawing.Point(0, 0);
            this.panelConsBiblio.Name = "panelConsBiblio";
            this.panelConsBiblio.Size = new System.Drawing.Size(400, 437);
            this.panelConsBiblio.TabIndex = 7;
            // 
            // dataGridBiblio
            // 
            this.dataGridBiblio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBiblio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBiblio.Location = new System.Drawing.Point(0, 0);
            this.dataGridBiblio.Name = "dataGridBiblio";
            this.dataGridBiblio.Size = new System.Drawing.Size(400, 437);
            this.dataGridBiblio.TabIndex = 1;
            // 
            // FormContBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 437);
            this.Controls.Add(this.panelCons);
            this.Name = "FormContBiblio";
            this.Text = "Contenido de la biblioteca";
            this.Load += new System.EventHandler(this.FormContBiblio_Load);
            this.panelCons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelNit.ResumeLayout(false);
            this.panelNit.PerformLayout();
            this.panelConsBiblio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCons;
        private System.Windows.Forms.Panel panelConsBiblio;
        private System.Windows.Forms.DataGridView dataGridBiblio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNit;
        private System.Windows.Forms.TextBox textNit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}