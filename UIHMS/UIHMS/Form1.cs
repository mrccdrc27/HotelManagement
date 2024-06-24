using Avalonia;
using Avalonia.Media.TextFormatting.Unicode;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHMS
{
    public partial class Form1 : Form
    {
        bool panel_7 = false;
        bool panel_8 = false;
        bool panel_9 = false;

        public Connection? Connection;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //creates database

            Connection = new Connection();
            this.Connection.Database.EnsureCreated();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }


        protected override void OnPaint(PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }





        private void panel7_Paint(object sender, EventArgs e)
        {


            if (sender == panel7 || sender == pictureBox1 || sender == label3)
            {
                panel_7 = false;
                panel7.BackColor = Color.FromArgb(227, 227, 227);
                panel_8 = false;
                panel8.BackColor = Color.FromArgb(227, 227, 227);
                panel_9 = false;
                panel9.BackColor = Color.FromArgb(227, 227, 227);
                reservationForm1.Hide();
                menu11.Hide();
                room1.Hide();


                if (panel_7 == false)
                {
                    reservationForm1.Show();
                    panel7.BackColor = Color.FromArgb(242, 242, 242);
                    panel_7 = true;
                }



            }
            if (sender == panel8 || sender == pictureBox2 || sender == label1)
            {
                panel_7 = false;
                panel7.BackColor = Color.FromArgb(227, 227, 227);
                panel_8 = false;
                panel8.BackColor = Color.FromArgb(227, 227, 227);
                panel_9 = false;
                panel9.BackColor = Color.FromArgb(227, 227, 227);
                reservationForm1.Hide();
                menu11.Hide();
                room1.Hide();

                if (panel_8 == false)
                {
                    menu11.Show();
                    panel8.BackColor = Color.FromArgb(242, 242, 242);
                    panel_8 = true;
                }

            }
            if (sender == panel9 || sender == pictureBox3 || sender == label2)
            {
                panel_7 = false;
                panel7.BackColor = Color.FromArgb(227, 227, 227);
                panel_8 = false;
                panel8.BackColor = Color.FromArgb(227, 227, 227);
                panel_9 = false;
                panel9.BackColor = Color.FromArgb(227, 227, 227);
                reservationForm1.Hide();
                menu11.Hide();
                room1.Hide();

                if (panel_9 == false)
                {
                    room1.Show();
                    panel9.BackColor = Color.FromArgb(242, 242, 242);
                    panel_9 = true;
                }
            }

        }



        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservationForm1_Load(object sender, EventArgs e)
        {

        }


        private void Menu1_Load(object sender, EventArgs e)
        {

        }

        private void guestForm1_Load(object sender, EventArgs e)
        {

        }

        private void room1_Load(object sender, EventArgs e)
        {

        }

        private void guestForm1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
