using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 10;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        int radius = CornerRadius * 2;
        path.AddArc(ClientRectangle.X, ClientRectangle.Y, radius, radius, 180, 90);
        path.AddArc(ClientRectangle.Width - radius, ClientRectangle.Y, radius, radius, 270, 90);
        path.AddArc(ClientRectangle.Width - radius, ClientRectangle.Height - radius, radius, radius, 0, 90);
        path.AddArc(ClientRectangle.X, ClientRectangle.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        // Apply the rounded rectangle path to the panel
        this.Region = new Region(path);

        // Optionally, you can also draw a border
        using (Pen borderPen = new Pen(Color.Black, 1.5f))
        {
            e.Graphics.DrawPath(borderPen, path);
        }
    }
}
