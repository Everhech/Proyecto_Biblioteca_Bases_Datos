
namespace LibraryUI
{
    partial class FormLibCat
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
            this.dataGridCount = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCatLib = new System.Windows.Forms.Label();
            this.panelConsBiblio = new System.Windows.Forms.Panel();
            this.dataGridBiblio = new System.Windows.Forms.DataGridView();
            this.panelLibCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelConsBiblio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLibCat
            // 
            this.panelLibCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.panelLibCat.Controls.Add(this.dataGridCount);
            this.panelLibCat.Controls.Add(this.panel3);
            this.panelLibCat.Controls.Add(this.iconButton1);
            this.panelLibCat.Controls.Add(this.panel2);
            this.panelLibCat.Controls.Add(this.panel1);
            this.panelLibCat.Controls.Add(this.labelCatLib);
            this.panelLibCat.Controls.Add(this.panelConsBiblio);
            this.panelLibCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLibCat.Location = new System.Drawing.Point(0, 0);
            this.panelLibCat.Name = "panelLibCat";
            this.panelLibCat.Size = new System.Drawing.Size(668, 437);
            this.panelLibCat.TabIndex = 0;
            // 
            // dataGridCount
            // 
            this.dataGridCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCount.Location = new System.Drawing.Point(531, 235);
            this.dataGridCount.Name = "dataGridCount";
            this.dataGridCount.Size = new System.Drawing.Size(108, 89);
            this.dataGridCount.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(400, 212);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(83, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(268, 58);
            this.panel3.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(101, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 58);
            this.panel6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Resultados encontrados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(83, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 58);
            this.panel5.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(400, 134);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(20);
            this.iconButton1.Size = new System.Drawing.Size(268, 78);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "Consultar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(400, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 61);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(400, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 28);
            this.panel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aventura",
            "Drama",
            "Suspenso"});
            this.comboBox1.Location = new System.Drawing.Point(73, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // labelCatLib
            // 
            this.labelCatLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCatLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatLib.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCatLib.Location = new System.Drawing.Point(400, 0);
            this.labelCatLib.Name = "labelCatLib";
            this.labelCatLib.Size = new System.Drawing.Size(268, 45);
            this.labelCatLib.TabIndex = 15;
            this.labelCatLib.Text = "Categoria del Libro :";
            this.labelCatLib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConsBiblio
            // 
            this.panelConsBiblio.Controls.Add(this.dataGridBiblio);
            this.panelConsBiblio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConsBiblio.Location = new System.Drawing.Point(0, 0);
            this.panelConsBiblio.Name = "panelConsBiblio";
            this.panelConsBiblio.Size = new System.Drawing.Size(400, 437);
            this.panelConsBiblio.TabIndex = 8;
            // 
            // dataGridBiblio
            // 
            this.dataGridBiblio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBiblio.Location = new System.Drawing.Point(0, 0);
            this.dataGridBiblio.Name = "dataGridBiblio";
            this.dataGridBiblio.ReadOnly = true;
            this.dataGridBiblio.Size = new System.Drawing.Size(400, 437);
            this.dataGridBiblio.TabIndex = 1;
            // 
            // FormLibCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 437);
            this.Controls.Add(this.panelLibCat);
            this.Name = "FormLibCat";
            this.Text = "Libros por categoria";
            this.Load += new System.EventHandler(this.FormLibCat_Load);
            this.panelLibCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelConsBiblio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLibCat;
        private System.Windows.Forms.Panel panelConsBiblio;
        private System.Windows.Forms.DataGridView dataGridBiblio;
        private System.Windows.Forms.Label labelCatLib;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridCount;
    }
}