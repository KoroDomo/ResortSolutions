using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Resort
{
    public partial class Resumen : Form
    {
        public Resumen()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            FormRS obj = new FormRS();
           

            label8.Text = "Punta Cana";
            label9.Text = FormRS.resort;
            label10.Text = Reservacion.fLlegada + " - " + Reservacion.fSalida;
            label11.Text = Reservacion.adultos;
            label12.Text = Reservacion.niños;
            label13.Text = Reservacion.habitaciones;
        }
    }
}
