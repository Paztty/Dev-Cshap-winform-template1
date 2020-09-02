using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_project1
{
    public partial class FormRunTest : Form
    {
        public FormRunTest()
        {
            InitializeComponent();
            DrawChart(1000, 6);
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {

        }

        private void labelTest_Click(object sender, EventArgs e)
        {

        }



        private void DrawChart(int okNumber, int ngNumber)
        {
            int Total = okNumber + ngNumber;

            labelNgNum.Text = ngNumber.ToString();
            labelOkNum.Text = okNumber.ToString();
            labelTotalNum.Text = Total.ToString();

            float persentOk = (float)okNumber / (float)Total * 100;


            if (Total == 0) Total = 10000000;
            float okRadian = (float)360.0 / Total * okNumber;
            float ngRadian = (float)360.0 - okRadian;
            try
            {
                int startRectY = pBChar.Size.Height / 2 - pBChar.Size.Width / 2;
                int startRectX = pBChar.Size.Width / 2 - pBChar.Size.Height / 2;
                int rectDimemtions = pBChar.Size.Width;

                if (startRectY < 0)
                {
                    startRectY = 0;
                    rectDimemtions = pBChar.Size.Height;
                }
                if (startRectX < 0)
                {
                    startRectX = 0;
                    rectDimemtions = pBChar.Size.Width;
                }

                Rectangle rect = new Rectangle(startRectX, startRectY, rectDimemtions, rectDimemtions);
                Rectangle rectInside = new Rectangle(startRectX + rectDimemtions / 3, startRectY + rectDimemtions / 3, rectDimemtions / 3, rectDimemtions / 3);
                Bitmap custormChart = new Bitmap(pBChar.Size.Width, pBChar.Size.Height);
                Graphics g = Graphics.FromImage(custormChart);

                Color okColor = Color.FromArgb(27, 183, 234);
                Color bacgroudColor = Color.FromArgb(62, 62, 62);
                SolidBrush brush = new SolidBrush(okColor);
                SolidBrush brushInside = new SolidBrush(bacgroudColor);

                g.FillPie(brush, rect, 0, okRadian);
                g.FillPie(Brushes.Black, rect, okRadian, ngRadian);
                g.FillPie(brushInside, rectInside, 0, 360);

                String persenOkString = persentOk.ToString("F1") + " %";
                System.Drawing.Font persentOkFont = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
                g.DrawString(persenOkString, persentOkFont, brush, startRectX + rectDimemtions / 2 - (persenOkString.Length) * 5, startRectY + rectDimemtions / 2 - 10);

                pBChar.Image = custormChart;
            }
            catch (Exception)
            { }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawChart(1, 20); // test
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (this.tlpRunTest.ColumnStyles[1].Width == 0)
                ActivateSlot("SlotA");
            else
                ActivateSlot("SlotB");

        }


        private void ActivateSlot(String name)
        {
            if (name == "SlotA")
                SlotB_Deactivate();
            if (name == "SlotB")
                SlotA_Deactivate();
        }

        private void SlotA_Deactivate()
        {
            if (this.tlpRunTest.ColumnStyles[1].Width != 0)
            {
                labelSlotA.Hide();
                labelSlotAGet.Hide();
                labelSlotASet.Hide();
                labelSlotAResult.Hide();

                this.tlpRunTest.ColumnStyles[2].SizeType = SizeType.Percent;
                this.tlpRunTest.ColumnStyles[2].Width = 40;
                this.tlpRunTest.ColumnStyles[1].SizeType = SizeType.Percent;
                this.tlpRunTest.ColumnStyles[1].Width = 0;

                labelSlotB.Show();
                labelSlotBGet.Show();
                labelSlotBSet.Show();
                labelSlotBResult.Show();
            }

        }
        private void SlotB_Deactivate()
        {
            if (this.tlpRunTest.ColumnStyles[2].Width != 0)
            {
                labelSlotB.Hide();
                labelSlotBGet.Hide();
                labelSlotBSet.Hide();
                labelSlotBResult.Hide();
                
                this.tlpRunTest.ColumnStyles[1].SizeType = SizeType.Percent;
                this.tlpRunTest.ColumnStyles[1].Width = 40;
                this.tlpRunTest.ColumnStyles[2].SizeType = SizeType.Percent;
                this.tlpRunTest.ColumnStyles[2].Width = 0;

                labelSlotA.Show();
                labelSlotAGet.Show();
                labelSlotASet.Show();
                labelSlotAResult.Show();
            }
        }

        private void labelSlotBResult_Click(object sender, EventArgs e)
        {

        }
    }



    public class Chart
    {
        public uint okNumber = 0;
        public uint ngNumber = 0;

        public Chart(System.Windows.Forms.PictureBox pictureBox, uint okNumber, uint ngNumber)
        {
            uint Total = okNumber + ngNumber;

            if (Total == 0) Total = 10000000;
            float okRadian = (float)360.0 / Total * okNumber;
            float ngRadian = (float)360.0 - okRadian;

            int startRectY = pictureBox.Size.Height / 2 - pictureBox.Size.Width / 2;
            int startRectX = pictureBox.Size.Width / 2 - pictureBox.Size.Height / 2;
            int rectDimemtions = pictureBox.Size.Width;
            if (startRectY < 0)
            {
                startRectY = 0;
                rectDimemtions = pictureBox.Size.Height;
            }
            if (startRectX < 0)
            {
                startRectX = 0;
                rectDimemtions = pictureBox.Size.Width;
            }

            Rectangle rect = new Rectangle(startRectX, startRectY, rectDimemtions, rectDimemtions);
            Bitmap custormChart = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            Graphics g = Graphics.FromImage(custormChart);

            g.FillPie(Brushes.Lime, rect, 0, okRadian);
            g.FillPie(Brushes.Red, rect, okRadian, ngRadian);
            pictureBox.Image = custormChart;
        }



    }

}
