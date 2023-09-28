using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto5_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuaradar_Click(object sender, EventArgs e)
        {
            //Obtener los datos de los TexBox
            string nombres = textBox1.Text;
            string apellidos = textBox2.Text;
            string edad = textBox3.Text;
            string estatura = textBox4.Text;
            string telelfono = textBox5.Text;


            //Obtener el genero seleccinado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }

            //Crear una cadena con los datos 
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telelfono} kg\r\nEstatura: {estatura}cm\r\nEdad: {edad} años\n\nGenero: {genero}";

            //Guardar los datos en un archivo de texto
            string rutaArchivo = "C:/Users/MARIO/OneDrive/Documentos/prueba.txt";
            File.WriteAllText(rutaArchivo, datos);
            //Verificar si el el archcivo ya existe 
            bool archivoExiste = File.Exists(rutaArchivo);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        // Si el archivo existe, añadir un separador antes del nuevo regristro 
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);


                }

                //Mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}