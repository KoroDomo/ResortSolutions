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
    public partial class Reservacion : Form
    {
        public static string fLlegada;
        public static string fSalida;
        public static string adultos;
        public static string niños;
        public static string habitaciones;
        public Reservacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {
            
            lblResort.Text = FormRS.resort;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fLlegada = txbLlegada.Text;
            fSalida = txbSalida.Text;
            adultos =  txbAdultos.Text;
            niños = txbNinos.Text;
            habitaciones = txbHabitaciones.Text;
            this.Visible = false;
            Resumen obj = new Resumen();
                       

            obj.Show();

        }
    }
}
