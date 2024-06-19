using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_system
{
    public partial class Form1 : Form
    {

        private Form2 formInstance;
        private Form3 formInstance2;
        private Form4 formInstance3;
        private Form5 formInstance4;

        bool shown = false;
        bool shown2 = false;
        bool shown3 = false;
        bool shown4 = false;
        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            formInstance = new Form2();

            shown = true;
            formInstance.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }
    
        private void panel3_click(object sender, EventArgs e)
        {
            if(shown2 == true)
            {
                formInstance2.Close();
                shown2 = false;
            }
            if (shown3 == true)
            {
                shown3 = false;
                formInstance3.Close();
            }
            if (shown4 == true)
            {
                shown4 = false;
                formInstance4.Close();
            }

            if (shown == false)
            {
                formInstance = new Form2();
                shown = true;
            }
            
                formInstance.Show();





            Menu1_Panel.BackColor = ColorManager.PanelColor2;
            Menu2_Panel.BackColor = ColorManager.PanelColor;
            Menu3_Panel.BackColor = ColorManager.PanelColor;
            Menu4_Panel.BackColor = ColorManager.PanelColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (shown == true)
            {
                formInstance.Close();
                shown = false;
            }
            if (shown3 == true)
            {
                shown3 = false;
                formInstance3.Close();
            }
            if (shown2 == true)
            {
                shown2 = false;
                formInstance2.Close();
            }

            if (shown4 == false)
            {
                formInstance4 = new Form5();
                shown4 = true;
            }

            formInstance4.Show();

            Menu1_Panel.BackColor = ColorManager.PanelColor;
            Menu2_Panel.BackColor = ColorManager.PanelColor;
            Menu3_Panel.BackColor = ColorManager.PanelColor;
            Menu4_Panel.BackColor = ColorManager.PanelColor2;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (shown == true)
            {
                formInstance.Close();
                shown = false;
            }
            if (shown2 == true)
            {
                shown2 = false;
                formInstance2.Close();
            }
            if (shown4 == true)
            {
                shown4 = false;
                formInstance4.Close();
            }

            if (shown3 == false)
            {
                formInstance3 = new Form4();
                shown3 = true;
            }

            formInstance3.Show();
            Menu1_Panel.BackColor = ColorManager.PanelColor;
            Menu2_Panel.BackColor = ColorManager.PanelColor;
            Menu3_Panel.BackColor = ColorManager.PanelColor2;
            Menu4_Panel.BackColor = ColorManager.PanelColor;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (shown == true)
            {
                formInstance.Close();
                shown = false;
            }
            if (shown3 == true)
            {
                shown3 = false;
                formInstance3.Close();
            }
            if (shown4 == true)
            {
                shown4 = false;
                formInstance4.Close();
            }

            if (shown2 == false)
            {
                formInstance2 = new Form3();
                shown2 = true;
            }

            formInstance2.Show();
            Menu1_Panel.BackColor = ColorManager.PanelColor;
            Menu2_Panel.BackColor = ColorManager.PanelColor2;
            Menu3_Panel.BackColor = ColorManager.PanelColor;
            Menu4_Panel.BackColor = ColorManager.PanelColor;
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
