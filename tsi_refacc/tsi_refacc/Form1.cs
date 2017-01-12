using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsi_refacc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Size desktopsize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 alto = (desktopsize.Height - 296)/2;
            Int32 ancho = (desktopsize.Width - 488)/2;
            panel1.Location = new Point(ancho, alto);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text!="admin") 
            {
                lbMensaje.Text = "Usuario Incorrecto";
                
            }
            else
                if (txtPass.Text != "admin")
                {
                    lbMensaje.Text = "Password Incorrecto";

                }
                else
                {
                    MessageBox.Show("Usuario Correcto");
                }


        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
        }
      
    }
}
