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
        public Form2()
        {
            InitializeComponent();
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
                MessageBox.Show("No existe  este usuario" + usuario);
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
            if (textContraseña.Text == "") textContraseña.Text = "Ingrese Su Contraseña";
        }

        private void textContraseña_FontChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Ingrese Su Contraseña") textContraseña.Text = "";
        }
    }
}
