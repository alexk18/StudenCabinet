using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace StudenCabinet
{
    public class ButtonDesign : Button
    {
        public StringFormat GF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;
        public ButtonDesign()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            Size = new Size(100, 100);
            DoubleBuffered = true;
            BackColor = Color.SlateGray; 
            ForeColor = Color.AliceBlue;
            GF.Alignment = StringAlignment.Center;
            GF.LineAlignment = StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);
            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(40,Color.AntiqueWhite)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(40, Color.AntiqueWhite)), rect);
            }
            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, GF);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = true;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = false;
            Invalidate();
        }
    }
}
