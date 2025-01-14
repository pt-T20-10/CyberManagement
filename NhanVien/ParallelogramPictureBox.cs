using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ParallelogramPictureBox : PictureBox
{
    public int ShearFactor { get; set; } = 30; // Độ nghiêng của hình bình hành

    // Override phương thức OnPaint để vẽ hình bình hành
    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);

        Graphics g = pe.Graphics;

        // Tạo các điểm cho hình bình hành
        Point[] parallelogramPoints = new Point[]
        {
            new Point(0, 0),
            new Point(Width, 0),
            new Point(Width - ShearFactor, Height),
            new Point(-ShearFactor, Height)
        };

        // Vẽ hình bình hành
        g.FillPolygon(new SolidBrush(this.BackColor), parallelogramPoints); // Màu nền
        g.DrawPolygon(new Pen(this.ForeColor), parallelogramPoints); // Viền của hình bình hành

        // Vẽ hình ảnh bên trong hình bình hành
        if (this.Image != null)
        {
            // Cắt ảnh sao cho phù hợp với hình bình hành
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddPolygon(parallelogramPoints);
                g.SetClip(path);
                g.DrawImage(this.Image, 0, 0, this.Width, this.Height); // Vẽ ảnh vào khu vực đã cắt
            }
        }
    }
}
