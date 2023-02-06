
namespace LibraryUI
{
    partial class FormRegBiblio
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
            this.components = new System.ComponentModel.Container();
            this.panelRegBiblio = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.registrarBibliotecaclick = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textNomBiblio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNit = new System.Windows.Forms.Panel();
            this.textNit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTableBiblio = new System.Windows.Forms.Panel();
            this.dataGridBiblio = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelRegBiblio.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelNit.SuspendLayout();
            this.panelTableBiblio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegBiblio
            // 
            this.panelRegBiblio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.panelRegBiblio.Controls.Add(this.panel3);
            this.panelRegBiblio.Controls.Add(this.panelTableBiblio);
            this.panelRegBiblio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegBiblio.Location = new System.Drawing.Point(0, 0);
            this.panelRegBiblio.Name = "panelRegBiblio";
            this.panelRegBiblio.Size = new System.Drawing.Size(668, 437);
            this.panelRegBiblio.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panelNit);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 437);
            this.panel3.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.registrarBibliotecaclick);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 78);
            this.panel6.TabIndex = 6;
            // 
            // registrarBibliotecaclick
            // 
            this.registrarBibliotecaclick.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrarBibliotecaclick.FlatAppearance.BorderSize = 0;
            this.registrarBibliotecaclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarBibliotecaclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBibliotecaclick.ForeColor = System.Drawing.Color.Gainsboro;
            this.registrarBibliotecaclick.IconChar = FontAwesome.Sharp.IconChar.SchoolCircleCheck;
            this.registrarBibliotecaclick.IconColor = System.Drawing.Color.Gainsboro;
            this.registrarBibliotecaclick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrarBibliotecaclick.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrarBibliotecaclick.Location = new System.Drawing.Point(0, 0);
            this.registrarBibliotecaclick.Name = "registrarBibliotecaclick";
            this.registrarBibliotecaclick.Padding = new System.Windows.Forms.Padding(20);
            this.registrarBibliotecaclick.Size = new System.Drawing.Size(268, 78);
            this.registrarBibliotecaclick.TabIndex = 6;
            this.registrarBibliotecaclick.Text = "Registrar";
            this.registrarBibliotecaclick.UseVisualStyleBackColor = true;
            this.registrarBibliotecaclick.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textNomBiblio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 216);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 28);
            this.panel5.TabIndex = 5;
            // 
            // textNomBiblio
            // 
            this.textNomBiblio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNomBiblio.Location = new System.Drawing.Point(54, 5);
            this.textNomBiblio.Name = "textNomBiblio";
            this.textNomBiblio.Size = new System.Drawing.Size(160, 20);
            this.textNomBiblio.TabIndex = 3;
            this.textNomBiblio.TextChanged += new System.EventHandler(this.textNomBiblio_TextChanged);
            //this.textNomBiblio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNomBiblio_KeyPress);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 94);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la biblioteca :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panelTableBiblio
            // 
            this.panelTableBiblio.Controls.Add(this.dataGridBiblio);
            this.panelTableBiblio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTableBiblio.Location = new System.Drawing.Point(0, 0);
            this.panelTableBiblio.Name = "panelTableBiblio";
            this.panelTableBiblio.Size = new System.Drawing.Size(400, 437);
            this.panelTableBiblio.TabIndex = 6;
            // 
            // dataGridBiblio
            // 
            this.dataGridBiblio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBiblio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBiblio.Location = new System.Drawing.Point(0, 0);
            this.dataGridBiblio.Name = "dataGridBiblio";
            this.dataGridBiblio.ReadOnly = true;
            this.dataGridBiblio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBiblio.Size = new System.Drawing.Size(400, 437);
            this.dataGridBiblio.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormRegBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 437);
            this.Controls.Add(this.panelRegBiblio);
            this.Name = "FormRegBiblio";
            this.Text = "Registrar biblioteca";
            this.Load += new System.EventHandler(this.FormRegBiblio_Load);
            this.panelRegBiblio.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelNit.ResumeLayout(false);
            this.panelNit.PerformLayout();
            this.panelTableBiblio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegBiblio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelNit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTableBiblio;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton registrarBibliotecaclick;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textNomBiblio;
        private System.Windows.Forms.DataGridView dataGridBiblio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textNit;
    }
}