﻿using System;
using System.Windows.Forms;

namespace Heiwa
{
    public partial class Usuarios : Form
    {
        // Referencias a los demás formularios
        private Main mainForm;
        private Form ordenesForm;
        private Form productosForm;
        private Form ingredientesForm;

        public Usuarios()
        {
            InitializeComponent();
        }

        // Método para configurar las referencias de los formularios
        public void ConfigurarFormularios(Main main, Form ordenes, Form productos, Form ingredientes)
        {
            mainForm = main;
            ordenesForm = ordenes;
            productosForm = productos;
            ingredientesForm = ingredientes;
        }

        // Manejo de botones
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ordenesForm);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(productosForm);
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ingredientesForm);
        }

        // Método para ocultar el actual y mostrar el siguiente formulario
        private void CambiarFormulario(Form formularioDestino)
        {
            this.Hide(); // Ocultar el formulario actual
            formularioDestino.Show(); // Mostrar el formulario destino
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

    }
}
