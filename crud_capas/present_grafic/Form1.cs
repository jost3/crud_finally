using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace present_grafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void getData()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "Nombre") textNombre.Text = "";
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "") textNombre.Text = "Nombre";
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "Apellido") textApellido.Text = "";
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "") textApellido.Text = "Apellido";
        }

        private void textID_Enter(object sender, EventArgs e)
        {
            if (textID.Text == "ID") textID.Text = "";
        }

        private void textID_Leave(object sender, EventArgs e)
        {
            if (textID.Text == "") textID.Text = "ID";
        }
        private void ClearTexboxs()
        {
            textNombre.Text = "Nombre";
            textApellido.Text = "Apellido";
            textID.Text = "ID";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
