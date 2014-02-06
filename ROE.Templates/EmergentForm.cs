using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ROE.Templates
{
    public partial class EmergentForm : Form
    {

        private double idleOpacity = 0.7; //how opaque it is when the mouse is not on it
        private double fadeRate = 0.001; //how fast the form fades in/out

        Thread fadeIn;
        Thread fadeOut;

        public EmergentForm()
        {
            InitializeComponent();
        }

        private void EmergentForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.TransparencyKey = Color.FromArgb(100, 126, 51); //Prevent flicker from opacity change by forcing
            //The form to be layered now

            this.Opacity = idleOpacity;

            //Prepare the fade in/out threads that will be called later
            ThreadStart fadeInStart = new ThreadStart(FadeIn);
            fadeIn = new Thread(fadeInStart);

            ThreadStart fadeOutStart = new ThreadStart(FadeOut);
            fadeOut = new Thread(fadeOutStart);
        }

        private void EmergentForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics draw = e.Graphics;
            draw.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle area = this.ClientRectangle;
            area.Width -= 1;
            area.Height -= 1;

            Pen outline = new Pen(Color.DarkGreen, 2);

            draw.FillRectangle(Brushes.Green, this.ClientRectangle); //Background
            draw.DrawRectangle(outline, area); //Border

            outline.Dispose();
        }
        private delegate void ChangeOpacityDelegate(double value);
        private void ChangeOpacity(double value)
        {
            if (this.InvokeRequired)
            {
                ChangeOpacityDelegate del = new ChangeOpacityDelegate(ChangeOpacity);
                object[] parameters = { value };

                this.Invoke(del, value);
            }
            else
            {
                this.Opacity = value;
            }
        }

        private void FadeIn()
        {
            for (double i = this.Opacity; i <= 1; i += fadeRate)
            {
                ChangeOpacity(i);
            }

            if (this.Opacity != 1.00)
                ChangeOpacity(1.00);
        }

        private void FadeOut()
        {
            for (double i = this.Opacity; i >= idleOpacity; i -= fadeRate)
            {
                ChangeOpacity(i);
            }

            if (this.Opacity != idleOpacity)
                ChangeOpacity(idleOpacity);
        }
        Point lastPoint;

        private void EmergentForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EmergentForm_MouseEnter(object sender, EventArgs e)
        {
            //Cancel running fading threads to avoid overflowing the stack
            if (fadeIn.ThreadState == ThreadState.Running)
                fadeIn.Abort();

            if (fadeOut.ThreadState == ThreadState.Running)
                fadeOut.Abort();

            //Begin fading in
            ThreadStart fadeInStart = new ThreadStart(FadeIn);
            fadeIn = new Thread(fadeInStart);

            fadeIn.Start();
        }

        private void EmergentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void EmergentForm_MouseLeave(object sender, EventArgs e)
        {
            if (this.Bounds.Contains(Cursor.Position)) return;

            //Cancel running fading threads to avoid overflowing the stack
            if (fadeIn.ThreadState == ThreadState.Running)
                fadeIn.Abort();

            if (fadeOut.ThreadState == ThreadState.Running)
                fadeOut.Abort();

            //Begin fading out
            ThreadStart fadeOutStart = new ThreadStart(FadeOut);
            fadeOut = new Thread(fadeOutStart);

            fadeOut.Start();
        }


    }
}
