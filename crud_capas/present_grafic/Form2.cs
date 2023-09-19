using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace present_grafic
{
    public partial class Form2 : Form
    {

        private bool isDragging = false;
        private Point lastCursorPosition;
        public Form2()
        {
            InitializeComponent();

            this.MouseDown += Form2_MouseDown;
            this.MouseMove += Form2_MouseMove;
            this.MouseUp += Form2_MouseUp;

            label1.BackColor = Color.FromArgb(10, 255, 255, 255);
            label2.BackColor = Color.FromArgb(10, 255, 255, 255);

            this.AcceptButton = btnRegistrar;
        }

        private void btnSaliendo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = textUser.Text;
            password = textContraseña.Text;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRUD_N_CAPAS;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "select user_log,pass_log from inicio_sesion where user_log = '" + usuario + "' AND pass_log = '" + password + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + usuario);
                this.Hide();
                Form1 a1 = new Form1();
                a1.Show();
            }
            else
            {
                MessageBox.Show("No existe este usuario " + usuario);
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "") textUser.Text = "Ingrese Su usuario";
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Ingrese Su usuario") textUser.Text = "";
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textContraseña.Text))
            {
                textContraseña.Text = "Ingrese Su Contraseña";
                // Restaura el texto de contraseña en el caso de que no se haya ingresado nada
                textContraseña.PasswordChar = '\0'; // Restaura el carácter de contraseña
            }
        }

        private void textContraseña_FontChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Ingrese Su Contraseña")
            {
                textContraseña.Text = "";
                // Configura el caracter de contraseña (puntos negros)
                textContraseña.PasswordChar = '*'; // Cambia '*' a otro carácter si lo prefieres
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
