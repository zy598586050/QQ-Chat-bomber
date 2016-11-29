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
    public partial class Form1 : LayeredForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Show(string s) 
        {
            this.layeredTextBox1.Text += s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32((Convert.ToDouble(layeredTrackBar2.Value))*1000);
            if (layeredCheckButton2.Checked == false)
            {
                Clipboard.SetDataObject(layeredTextBox1.Text);
                SendKeys.SendWait("^v");
                SendKeys.SendWait("{ENTER}");
            }
            else 
            {
                string[] s1 = 
                { 
                    "想必一定是人渣中的极品，禽兽中的禽兽.看看啊，你这小脸瘦得，都没个猪样啦！", 
                    "天生就是属黄瓜的，欠拍！后天属核桃的，欠捶！终生属破摩托的，欠踹！找个媳妇属螺丝钉的，欠拧！", 
                    "长得跟前列线似的,尿尿都分叉了,赶快去治治吧!! 人贱一辈子 猪贱一刀子 活着浪费空气 死了浪费土地 在家浪费RMB", 
                    "你打我，我不怕，我去北京找我爸，我爸拿着机关枪，照你屁股打三枪!", 
                    "你妈的头，像皮球，一脚踢到百货大楼，百货大楼卖皮球，卖的就是你妈的头!", 
                    "你丑到连长颈鹿看到你都可以在三秒内呕出来。", 
                    "你的愚蠢总是那么富有创造力。", 
                    "我不想知道你有病，别表现的这么明显好吗？",
                    "你丫的早上会不会洗脸了，顶着个一年半载没洗过的脸出来晃荡！",
                    "脑子转不过弯没关系，别进水就行。",
                    "实在我有多爱瞅你你知道吗，一天看不见你风流的母狗样姐就蛋疼。",
                    "我觉得你挺适合做人妖的，不然真的是浪费人才啊！",
                    "我要生孩子一定让你教他，还要教他历史，看一眼你的脸，中华五千年全记住了。",
                    "你头上的头发数的清，你脸上的麻子就不用数了，数都数不清。",
                    "你那头圆的，真是绝了，苹果都描述不了，你那简直就是篮球，让人看到就想打。",
                    "美眉出门要带武器，而你就不用了，因为你的长相是最好的武器。",
                    "贵重稀有金属你卖什么不好你卖银！"
                };
                Random rand = new Random();
                Clipboard.SetDataObject(s1[rand.Next(0,s1.Length)]);
                SendKeys.SendWait("^v");
                SendKeys.SendWait("{ENTER}");
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer2.Interval = 100;
            this.timer2.Enabled = true;
        }

        private void layeredButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void layeredButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void layeredPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            LayeredSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void layeredPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            LayeredSkin.NativeMethods.MouseToMoveControl(this.Handle);
        }

        private void layeredCheckButton1_Click(object sender, EventArgs e)
        {
            if (layeredCheckButton1.Checked)
            {
                this.timer1.Enabled = true;
            }
            else 
            {
                this.timer1.Enabled = false;
            }
        }

        private void layeredButton3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.F = this;
            frm.Show(); 
        }

        private void layeredTrackBar2_Click(object sender, EventArgs e)
        {
            layeredLabel6.Text = layeredTrackBar2.Value.ToString("0.0") + "秒/条";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            layeredPictureBox3.Left = layeredPictureBox3.Left+1;
            if (layeredPictureBox3.Right > this.Width)
            {
                layeredPictureBox3.Left = 0; 
            }
        }

        private void layeredButton5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }

}
