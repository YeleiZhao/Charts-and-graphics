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
            g.PageUnit = GraphicsUnit.Inch;
            Pen blackPen = new Pen(Color.Black, 1 / g.DpiX);
            g.DrawLine(blackPen, 0, 0, 1, 1);
        }
    }
   
}
