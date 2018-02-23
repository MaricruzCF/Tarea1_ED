using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_1ED.Properties;

namespace tarea_1ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(textBox1.Text);
            num >>= 1;
            int direccion = (num & 7),
                nivel = ((num >>= 3) & 3),
                sensor1 = ((num >>= 2) & 1),
                sensor2 =((num >>= 1) & 1),
                dia = ((num >>= 1) & 31),
                mes = ((num >>= 5) & 15),
                anio = ((num >>= 4) & 127);

            switch (direccion)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.N;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.NE;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.E;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.SE;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.S;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.SO;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.O;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.NO;
                    break;
            }

            txtNivelM.Text = "";
            switch (nivel)
            {
                case 0:
                    txtNivelM.Visible = false;
                    txtNivelA.BackColor = Color.Gray;
                    break;
                case 1:
                    txtNivelM.Visible = true;
                    txtNivelA.BackColor = Color.Gray;
                    txtNivelM.BackColor = Color.FromArgb(0, 0, 123);
                    break;
                case 2:
                    txtNivelM.Visible = false;
                    txtNivelA.BackColor = Color.FromArgb(0, 0, 123);
                    break;
                default:
                    txtNivelM.Visible = true;
                    txtNivelM.Text = "///////////////////////////////////////////////////";
                    txtNivelM.ForeColor = Color.FromArgb(0, 0, 123);
                    txtNivelA.BackColor = Color.Gray;
                    txtNivelM.BackColor = Color.Gray;
                    break;
            }

            if (sensor1 == 1)
                pictureBox2.Image = Properties.Resources.ok_simbolo_dentro_de_un_esquema_circulo_318_41760;
            else
                pictureBox2.Image = Properties.Resources.Prohibido;

            if (sensor2 == 1)
                pictureBox3.Image = Properties.Resources.ok_simbolo_dentro_de_un_esquema_circulo_318_41760;
            else
                pictureBox3.Image = Properties.Resources.Prohibido;

            txtFecha.Text = dia + "/" + mes + "/" + (anio + 1900);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            txtFecha2.Text = (fecha.Day | (fecha.Month << 5) | ((fecha.Year - 1900) << 9)).ToString();
        }
    }
}
//lblSenP.BackColor = Color.FromArgb(0,128,0);
//lblSenN.BackColor = Color.FromArgb(252,0,0);
//if (g >= 2)
//{
//    txtNivelM.Visible = false;
//    txtNivelA.BackColor = Color.FromArgb(0, 0, 123);
//}
//else
//{
//    txtNivelM.Visible = true;
//    txtNivelA.BackColor = Color.FromArgb(255,255,255);
//    txtNivelM.BackColor = Color.FromArgb(0, 0, 123);
//}
