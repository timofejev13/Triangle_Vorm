using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Vorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true){
                listView1.Items.Clear();
                double a, b, c;
                a = Convert.ToDouble(txt1.Text);
                b = Convert.ToDouble(txt2.Text);
                c = Convert.ToDouble(txt3.Text);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона A");
                listView1.Items.Add("Сторона B");
                listView1.Items.Add("Сторона C");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
                else listView1.Items[5].SubItems.Add("Не существует");
                if (a == b && a == c)
                {
                    listView1.Items[6].SubItems.Add("Равносторонний");
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "rave.png");
                }
                else if (a == b || a == c || b == c)
                {
                    listView1.Items[6].SubItems.Add("Равнобедренный");
                    pictureBox1.Image = Image.FromFile(AppContext.BaseDirectory + "raven.png");
                }
            }
            else if (radioButton2.Checked == true)
            {
                listView1.Items.Clear();
                double a, ah;
                a = Convert.ToDouble(txt1.Text);
                ah = Convert.ToDouble(txt4.Text);
                Triangle triangle = new Triangle(a, ah);
                listView1.Items.Add("Сторона A");
                listView1.Items.Add("Высота H");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputAH());
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.Surface2()));
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Visible = true;
            txt2.Visible = true;
            txt3.Visible = true;
            txt4.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Visible = true;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
