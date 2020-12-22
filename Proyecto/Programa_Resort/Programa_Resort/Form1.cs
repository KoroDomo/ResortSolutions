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
    
    public partial class FormRS : Form
    {
        

        public static string resort = "";
        public FormRS()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "La Altagracia, Punta Cana")
            {
                btnSiguiente.Enabled = true;
                comboBox2.Enabled = false; comboBox3.Enabled = false;
            }
                
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
                      
            
            int i = comboBox1.SelectedIndex;
            resort = comboBox1.Items[i].ToString();

            if(resort == "Hard Rock - Hotel y Casino"){
                formHardRock Nueva_Ventana = new formHardRock();
                this.Visible = false;
                Nueva_Ventana.Show();
                
            } 
            else if (resort == "Tortuga Bay Hotel Puntacana Resort & Club")
            {
                formTortugaBay Nueva_Ventana = new formTortugaBay();
                this.Visible = false;
                Nueva_Ventana.Show();
            }
            else if (resort == "The Westin Puntacana Resort & Club")
            {
                formWestin Nueva_Ventana = new formWestin();
                this.Visible = false;
                Nueva_Ventana.Show();
            }


             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Puerto Plata")
            {
                btnSiguiente.Enabled = true;
                comboBox2.Enabled = false; comboBox3.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "La Romana")
            {
                btnSiguiente.Enabled = true;
                comboBox2.Enabled = false; comboBox3.Enabled = false;
            }
        }

        private void FormRS_Load(object sender, EventArgs e)
        {
            
        }
    }
}
