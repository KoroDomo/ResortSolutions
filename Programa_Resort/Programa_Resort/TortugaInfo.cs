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
    public partial class formTortugaBay : Form
    {
        public formTortugaBay()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Reservacion obj = new Reservacion();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRS obj2 = new FormRS();
            obj2.Show();
        }
    }
}
