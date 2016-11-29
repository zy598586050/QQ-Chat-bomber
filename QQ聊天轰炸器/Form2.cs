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
    public partial class Form2 : LayeredForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void layeredPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LayeredSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void layeredPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            LayeredSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void layeredButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("tencent://message/?Menu=yes&uin=" + layeredTextBox1.Text + "&Site=itbulu&Service=300&sigT=45a1e5847943b64c6ff3990f8a9e644d2b31356cb0b4ac6b24663a3c8dd0f8aa12a595b1714f9d45");
            //tencent://message/?Menu=yes&uin=" + textBox1.Text + "&Site=itbulu&Service=300&sigT=45a1e5847943b64c6ff3990f8a9e644d2b31356cb0b4ac6b24663a3c8dd0f8aa12a595b1714f9d45
            //tencent://message/?Menu=yes&uin="+textBox1.Text+"&Site=&Service=201&sigT=c66448f8ca24db68219eca617eff6c4ff5a26353acc48e29df2b4789998940d1000867caed78b0dc3e8c35acbbf6fa8d&sigU=809fc02497521090077da44b01aa5d1e001ab95480135263bb507a3b81c48cdaa204aa4abf65e7c2
        }

        private void layeredButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("tencent://AddContact/?fromId=50&fromSubId=1&subcmd=all&uin=" + layeredTextBox1.Text);
        }

        private void layeredButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
