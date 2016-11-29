using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LayeredSkin.Forms;

namespace QQ聊天轰炸器
{
    public partial class Form3 : LayeredForm
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 f;
        public Form1 F 
        {
            get { return f; }
            set { f = value; }
        }
        private void shutdown(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.LostFocus += new EventHandler(shutdown);
            //this.Location = new System.Drawing.Point(500,500);
            //this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show("/wx");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show("/se");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.Show("/fn");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f.Show("/cy");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f.Show("/shuai");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f.Show("/zhd");
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f.Show("/zhm");
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f.Show("/kuk");
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f.Show("/bs");
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            f.Show("/mg");
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f.Show("/cd");
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            f.Show("/qiang");
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f.Show("/bb");
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            f.Show("/gy");
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            f.Show("/tuu");
            this.Close();
        }
    }
}
