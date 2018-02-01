﻿using System;
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
            g.PageUnit = GraphicsUnit.Inch;
            g.TranslateTransform((ClientRectangle.Width / g.DpiX / 2), (ClientRectangle.Height / g.DpiY) / 2);
            Pen greenPen = new Pen(Color.Green, 20 / g.DpiX);
            g.DrawLine(greenPen, 0, 0, 2, 2);
        }
    }
   
}
