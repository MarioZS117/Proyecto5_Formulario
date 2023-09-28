﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Proyecto5_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbEdad.TextChanged += validarEdad;
            tbEstatura.TextChanged += validarEstatura;
            tbTelefono.TextChanged += validarTelefono;
            tbNombre.TextChanged += validarNombre;
            tbApellidos.TextChanged += validarApellidos;
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
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telelfono) && EstextoValido(nombres)
                && EstextoValido(apellidos)){


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
                else
                {
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
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }
        private bool EstextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
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
        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("Por favor ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese apellidos válidos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
    }
}