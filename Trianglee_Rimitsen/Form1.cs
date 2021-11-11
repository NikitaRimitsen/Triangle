﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Rimitsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор"); 
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Vesota()));
            if (triangle.ExistTriange) { listView1.Items[6].SubItems.Add("Существует"); }
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TriangleType);
            if(triangle.TriangleType=="Это равносторонний")
            {
                pictureBox1.Image = Properties.Resources.ravnosto;
            }
            else if(triangle.TriangleType == "Это равнобедренный")
            {
                pictureBox1.Image = Properties.Resources.ravno;
            }
            else if (triangle.TriangleType == "Это разносторонний")
            {
                pictureBox1.Image = Properties.Resources.raznosto;
            }
            else if (triangle.TriangleType == "Это ломаная")
            {
                pictureBox1.Image = Properties.Resources.lomanaya;
            }




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*My_form frm = new frm My_form();
            frm.Show();*/
        }

        private void Run_button_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
