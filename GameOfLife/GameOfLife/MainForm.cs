using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public class MainForm : Form
    {
        public MainForm()
        {
            ClientSize = new Size(800, 600);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics formGraphics;
            formGraphics = CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Red);

            Pen Pen = new Pen(Color.Black);

            for (int y = 0; y < 60; ++y)
            {
                formGraphics.DrawLine(Pen, 0, y * 10, 100 * 10, y * 10);
            }

            for (int x = 0; x < 80; ++x)
            {
                formGraphics.DrawLine(Pen, x * 10, 0, x * 10, 100 * 10);
            }

            // formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}