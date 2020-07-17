using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAlumnoSinBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {     
            SR_WSAlumnoSinBD.WebService1SoapClient ws_net = new SR_WSAlumnoSinBD.WebService1SoapClient();
            SR_GetWSAlumnoSinBD.WSAlumnoSinBDClient ws_java = new SR_GetWSAlumnoSinBD.WSAlumnoSinBDClient();
            

            String datos = ws_net.WSAlumnoSinBD();
            textBox1.Text = datos;

            datos = ws_java.GetWSAlumnoSinBD();
            textBox2.Text = datos;
        }
    }
}
