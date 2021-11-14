using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triangle_Rimitsen
{
    public partial class My_form : Form
    {
        public My_form()
        {
            InitializeComponent();
        }

        private void My_form_Load(object sender, EventArgs e)
        {

        }

        private void Run_button_Click2(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
