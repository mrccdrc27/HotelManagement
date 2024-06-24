using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Form3 embeddedForm = new Form3();
            embeddedForm.TopLevel = false;
            Controls.Add(embeddedForm);
            embeddedForm.Show();
        }
    }
}
