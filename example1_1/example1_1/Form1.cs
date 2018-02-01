using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw,true);
            this.BackColor = Color.White;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Following codes shift the origin to the center of the client area,and then draw a line from (0,0) to (1,1)
            g.PageUnit = GraphicsUnit.Inch;//指定英寸为度量单位（单位长度）
            g.TranslateTransform((ClientRectangle.Width / g.DpiX / 2), (ClientRectangle.Height / g.DpiY) / 2);
            //把坐标原点转换到窗口中心，把世界坐标系转换为页面坐标。每个传入的XY值均加上这个函数中的XY值。
            Pen greenPen = new Pen(Color.Green, 1 / g.DpiX);//单个像素宽？
            g.DrawLine(greenPen, 0, 0, 1, 1);
        }
        /*       public Pen UnitScaling(Graphics g)
               {
                   switch (g.PageUnit)
                   { 
                       case GraphicsUnit.Pixel:
                           return new Pen(Color.Black,, 1f);
                       case GraphicsUnit.Inch:
                           return new Pen(Color.Black, 1f/g.DpiX);
                       case GraphicsUnit.Millimeter:
                           return new Pen(Color.Black, 25.4f/ g.DpiX);
                       case GraphicsUnit.Point:
                           return new Pen(Color.Black, 72f / g.DpiX);
                       case GraphicsUnit.Display:
                           return new Pen(Color.Black, 75f / g.DpiX);
                       case GraphicsUnit.Document:
                           return new Pen(Color.Black, 300f / g.DpiX);
                   }

               }*/
    }
   
}
