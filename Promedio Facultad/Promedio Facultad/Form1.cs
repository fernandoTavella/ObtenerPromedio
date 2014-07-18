using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Promedio : Form
    {
        string nombre;
        int nota;
        Notas unaNota = new Notas();
        public Promedio()
        {
             InitializeComponent();
        }

        private void txtIngMateria_TextChanged(object sender, EventArgs e)
        {
            txtIngMateria.Focus();
            nombre = this.txtIngMateria.Text.ToString();
        }

        private void txtIngNota_TextChanged(object sender, EventArgs e)
        {
            txtIngNota.Focus();
            int.TryParse(txtIngNota.Text, out nota);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string validacion = unaNota.agregarMateria(nombre, nota);
            lblConfirmacionDeAgregado.Text = validacion;
            LimpiadoraDeContenidos(this);
        }

        private void btnObtProm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio es: " + unaNota.calcularPromedio().ToString());
        }

        private void textPromedio_TextChanged(object sender, EventArgs e)
        {}


        private static void LimpiadoraDeContenidos(Form aForm) {
            foreach (Control unControl in aForm.Controls) {
                if (unControl is TextBox)
                {
                    unControl.Text = "";
                }
           }
       }

        private void lblConfirmacionDeAgregado_Click(object sender, EventArgs e)
        {}
        private void btnGuardado_Click(object sender, EventArgs e)
        {
            unaNota.guardar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblConfirmacionDeAgregado.Text = "";
        }

        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            unaNota.abrir();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(unaNota.listarContenido());
            
        }
    }
}
