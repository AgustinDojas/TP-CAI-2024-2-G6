﻿using Negocio;
using Negocio.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateTPIntegrador.utils;

namespace TemplateTPIntegrador
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            ValidacionesTemplateUtils validacionesTemplateUtils = new ValidacionesTemplateUtils();

            // Llama al método ValidarVacios para chequear los inputs
            string mensaje_validacion_vacios = validacionesTemplateUtils.ValidarVacios(txt_usuario.Text, txt_contraseña.Text);

            if (mensaje_validacion_vacios != null)
            {
                // Muestra mensaje de error para el primer campo vacío
                MessageBox.Show(mensaje_validacion_vacios, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Pone el cursor en el primer campo vacío
                if (mensaje_validacion_vacios.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (mensaje_validacion_vacios.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
            }

            ValidacionesNegocioUtils validacionesNegocioUtils = new ValidacionesNegocioUtils();

            // Llama al metodo ValidarCaracteres para chequear que los campos contengan la cantidad de caracteres requeridos
            string mensaje_validacion_caracteres = validacionesNegocioUtils.ValidarCaracteres(txt_usuario.Text, txt_contraseña.Text);

            if (mensaje_validacion_caracteres != null)
            {
                // Muestra mensaje de error para el primer campo incorrecto
                MessageBox.Show(mensaje_validacion_caracteres, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Pone el cursor en el primer campo incorrecto
                if (mensaje_validacion_caracteres.Contains("Usuario"))
                {
                    txt_usuario.Focus();
                }
                else if (mensaje_validacion_caracteres.Contains("Contraseña"))
                {
                    txt_contraseña.Focus();
                }
            }
            else
            {
                // Inicio de sesión si pasa las validaciones
                MessageBox.Show("Inicio de Sesión exitoso!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}