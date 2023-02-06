using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LibraryUI
{
	public partial class FormPrincipal : Form
	{
		private Panel leftBorderBtn;
		private IconButton currenBtn;
		private Form currentChildForm;
		public FormPrincipal()
		{
			InitializeComponent();
			
			this.leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(8,60);
			panelSideMenu.Controls.Add(leftBorderBtn);
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MinimumSize = new Size(1280,720);
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}
		private void validarCampo()
        {

        }
		private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
				this.DisableButton();
				//boton
				currenBtn = (IconButton)senderBtn;
				currenBtn.BackColor = Color.FromArgb(37,36,81);
				currenBtn.ForeColor = color;
				currenBtn.TextAlign = ContentAlignment.MiddleCenter;
				currenBtn.IconColor = color;
				currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currenBtn.ImageAlign = ContentAlignment.MiddleRight;
				//boton izquierdo
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0,currenBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				//iconCurrentChildForm
				iconCurrentChildForm.IconChar = currenBtn.IconChar;
				iconCurrentChildForm.IconColor = color;
            }
        }
		private struct RGBColors
        {
			public static Color color1 = Color.FromArgb(172,126,241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 114);
			public static Color color4 = Color.FromArgb(95, 77, 221);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
			public static Color color7 = Color.FromArgb(143, 188, 143);
		}
		private void DisableButton()
        {
            if (currenBtn != null)
            {
				currenBtn.BackColor = Color.FromArgb(11, 7, 17);
				currenBtn.ForeColor = Color.Gainsboro;
				currenBtn.TextAlign = ContentAlignment.MiddleLeft;
				currenBtn.IconColor = Color.Gainsboro;
				currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
        }

		private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
				currentChildForm.Close();
            }
			labelTime.Visible = false;
			labelData.Visible = false;
			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			labelTitleChildForm.Text = childForm.Text;
        }
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelLogo_Paint(object sender, PaintEventArgs e)
		{

		}





        private void iconButton7_Click(object sender, EventArgs e)
        {
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormRegBiblio());
		}

        private void iconButton8_Click(object sender, EventArgs e)
        {
			ActivateButton(sender, RGBColors.color2);
			OpenChildForm(new FormRegLib());
		}

		private void iconButton5_Click_1(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormContBiblio());
		}
		private void iconButton11_Click(object sender, EventArgs e)
        {
			ActivateButton(sender, RGBColors.color6);
			OpenChildForm(new FormLibCat());
		}

        private void panelRegistro_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			currentChildForm.Close();
			Reset();
		}
		private void Reset()
        {
			DisableButton();
			leftBorderBtn.Visible = false;
			iconCurrentChildForm.IconChar = currenBtn.IconChar;
			iconCurrentChildForm.IconColor = Color.MediumPurple;
			labelTitleChildForm.Text = "Inicio";
			labelTime.Visible = true;
			labelData.Visible = true;
		}

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleChildForm_Click(object sender, EventArgs e)
        {

        }
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
			Application.Exit();
			
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
				WindowState = FormWindowState.Maximized;

			}
            else
            {
				WindowState = FormWindowState.Normal;
            }
			//this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			//this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
			WindowState = FormWindowState.Minimized;
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
			labelTime.Text = DateTime.Now.ToLongTimeString();
			labelData.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
			ActivateButton(sender, RGBColors.color7);
			OpenChildForm(new FormRegLibToBiblio());
		}
    }
	//Metodo abrir formulario
	
}
