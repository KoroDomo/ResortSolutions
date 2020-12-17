
namespace Programa_Resort
{
    partial class Reservacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLlegada = new System.Windows.Forms.TextBox();
            this.txbSalida = new System.Windows.Forms.TextBox();
            this.txbHabitaciones = new System.Windows.Forms.TextBox();
            this.txbAdultos = new System.Windows.Forms.TextBox();
            this.txbNinos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResort
            // 
            this.lblResort.AutoSize = true;
            this.lblResort.Location = new System.Drawing.Point(84, 71);
            this.lblResort.Name = "lblResort";
            this.lblResort.Size = new System.Drawing.Size(0, 13);
            this.lblResort.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Llegada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adultos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Niños:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Habitaciones:";
            // 
            // txbLlegada
            // 
            this.txbLlegada.Location = new System.Drawing.Point(229, 171);
            this.txbLlegada.Name = "txbLlegada";
            this.txbLlegada.Size = new System.Drawing.Size(149, 20);
            this.txbLlegada.TabIndex = 6;
            // 
            // txbSalida
            // 
            this.txbSalida.Location = new System.Drawing.Point(529, 167);
            this.txbSalida.Name = "txbSalida";
            this.txbSalida.Size = new System.Drawing.Size(149, 20);
            this.txbSalida.TabIndex = 7;
            // 
            // txbHabitaciones
            // 
            this.txbHabitaciones.Location = new System.Drawing.Point(229, 282);
            this.txbHabitaciones.Name = "txbHabitaciones";
            this.txbHabitaciones.Size = new System.Drawing.Size(34, 20);
            this.txbHabitaciones.TabIndex = 8;
            this.txbHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbAdultos
            // 
            this.txbAdultos.Location = new System.Drawing.Point(229, 225);
            this.txbAdultos.Name = "txbAdultos";
            this.txbAdultos.Size = new System.Drawing.Size(34, 20);
            this.txbAdultos.TabIndex = 9;
            this.txbAdultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNinos
            // 
            this.txbNinos.Location = new System.Drawing.Point(529, 223);
            this.txbNinos.Name = "txbNinos";
            this.txbNinos.Size = new System.Drawing.Size(33, 20);
            this.txbNinos.TabIndex = 10;
            this.txbNinos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reservar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNinos);
            this.Controls.Add(this.txbAdultos);
            this.Controls.Add(this.txbHabitaciones);
            this.Controls.Add(this.txbSalida);
            this.Controls.Add(this.txbLlegada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResort);
            this.Name = "Reservacion";
            this.Text = "Reservacion";
            this.Load += new System.EventHandler(this.Reservacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLlegada;
        private System.Windows.Forms.TextBox txbSalida;
        private System.Windows.Forms.TextBox txbHabitaciones;
        private System.Windows.Forms.TextBox txbAdultos;
        private System.Windows.Forms.TextBox txbNinos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}