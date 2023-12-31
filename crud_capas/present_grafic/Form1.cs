﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_comm1.Atribut;
using dominio_3.Crud;
using System.Drawing.Printing;

namespace present_grafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        //VARIABLES
        Cestudiante estudiante = new Cestudiante();
        atributesEstud atributes = new atributesEstud();
        bool edit = false;

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
            Cestudiante Cestudiante = new Cestudiante();
            dataGridView1.DataSource = Cestudiante.Mostrar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            getData();
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
            textDni.Text = "Dni";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                //INSERTA DATOS
                try
                {
                   
                    atributes.ID = Convert.ToInt32(textID.Text);
                    atributes.Nombre = textNombre.Text;
                    atributes.Apellido = textApellido.Text;
                    atributes.Sexo = comboSexo.Text;
                    atributes.Dni = Convert.ToInt32(textDni.Text);
                    estudiante.insertar(atributes);
                    ClearTexboxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    MessageBox.Show("SE GUARDO UN REGISTRO EXITOSAMENTE", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(edit == true)
            {
                //ACTUALIZA DATOS
                try
                {
                    atributes.ID = Convert.ToInt32(textID.Text);
                    atributes.Nombre = textNombre.Text;
                    atributes.Apellido = textApellido.Text;
                    atributes.Sexo = comboSexo.Text;
                    atributes.Dni = Convert.ToInt32(textDni.Text);
                    estudiante.modificar(atributes);
                    ClearTexboxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    textID.Enabled = true;
                    edit = false;
                    MessageBox.Show("SE ACTUALIZO UN REGISTRO EXITOSAMENTE", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textDni_Enter(object sender, EventArgs e)
        {
            if (textDni.Text == "Dni") textDni.Text = "";
        }
        private void textDni_Leave(object sender, EventArgs e)
        {
            if (textDni.Text == "") textDni.Text = "Dni";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                textID.Enabled = false;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                edit = true;
                // CARGA DE DATOS
                textID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboSexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textDni.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void textBuscar_Enter(object sender, EventArgs e)
        {
            if (textBuscar.Text == "Buscar...") textBuscar.Text = "";
        }

        private void textBuscar_Leave(object sender, EventArgs e)
        {
            if (textBuscar.Text == "")
            {
                textBuscar.Text = "Buscar...";
                getData();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("¿DESEAS ELIMINAR ESTE REGISTRO?","ELIMINAR", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(dialog == DialogResult.Yes)
                {
                    try
                    {
                        atributes.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        estudiante.eliminar(atributes);
                        getData();
                        MessageBox.Show("REGISTRO ELIMINADO EXITOSAMENTE", "ELIMINADO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            Cestudiante Cestudiante = new Cestudiante();
            dataGridView1.DataSource = Cestudiante.buscar(textBuscar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void ImprimirEstudiante(object sender,PrintPageEventArgs e)
        {
            Font font = new Font("Arial",14);
            int ancho = 550;
            int y = 20;

            e.Graphics.DrawString("---INFROMACION DEL ESTUDIANTE---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("ID  :"+textID.Text, font, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
            e.Graphics.DrawString("NOMBRE :  "+textNombre.Text, font, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
            e.Graphics.DrawString("APELLIDO: "+textApellido.Text, font, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
            e.Graphics.DrawString("SEXO :  "+comboSexo.Text, font, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
            e.Graphics.DrawString("DNI  :"+textDni.Text, font, Brushes.Black, new RectangleF(0, y += 50, ancho, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += ImprimirEstudiante;
            printDocument1.Print();
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            //NO ERA ESTE ERROR YA NO SE PUEDE ELIMINAR POR QUE SALE ERROR
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
