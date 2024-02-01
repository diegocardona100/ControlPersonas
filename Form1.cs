using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();



        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            dateTimePicker1.Value = DateTime.Today; // Establece la fecha actual
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
        }




        private void btnIngreso_Click(object sender, EventArgs e)
        {  
            persona.Dpi = txtbxDpi.Text;
            persona.Nombre = txtbxNombre.Text;
            persona.Apellido = txtbxApellido.Text;
            persona.FechaNacimiento1 = dateTimePicker1.Value;

            txtbxDpi.Text = string.Empty;
            txtbxNombre.Text = string.Empty;
            txtbxApellido.Text = string.Empty;

            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = persona.Dpi;
            label6.Text = persona.Nombre;
            label7.Text = persona.Apellido;
            label8.Text = persona.FechaNacimiento1.ToShortDateString();

            
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            



        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //persona.Nombre= Regex.Replace()
            persona.PrimeraMayuscula();
            label6.Text = persona.Nombre;
            label6.Visible = true;
            
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            persona.FechaNacimiento1 = dateTimePicker1.Value;

            int edad = persona.Edad();
            labeledadactual.Text = $"Edad: {edad} años";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            persona.Nombre = label6.Text.Replace(" ", "");

            label6.Text = persona.Nombre;
            label6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            persona.FechaNacimiento1 = dateTimePicker1.Value;

            int edad = persona.Edad();
            labeledadactual.Text = $"Edad: {edad} años";
            labeledadactual.Visible = true;
        }
    }
}
