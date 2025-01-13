using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet.Event
{
    public class CustomPanel : Panel
    {
        // Thêm thuộc tính để lưu trữ tham chiếu của PictureBox
        public PictureBox PbxBackGround { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            //// Lấy đối tượng Graphics để vẽ
            //Graphics g = e.Graphics;

            //// Xác định màu sắc và bút vẽ
            //Pen pen = new Pen(Color.YellowGreen, 3); // Bút vẽ với màu xanh và độ dày 3
            //SolidBrush brush = new SolidBrush(Color.LightYellow); // Màu nền cho panel

            //// Vẽ hình tứ giác với các góc vuông và đường chéo
            //// Các điểm để tạo hình dạng cần vẽ
            //Point[] points = new Point[]
            //{
            //new Point(0, 0), // Góc trên trái
            //new Point(this.Width -40, 0), // Góc trên phải
            //new Point(this.Width, this.Height), // Góc dưới phải
            //new Point(0, this.Height) // Góc dưới trái
            //};

            //// Vẽ hình thang (tạo ra góc vuông bên trái và góc chéo bên phải)
            //g.FillPolygon(brush, points);
            ////g.DrawPolygon(pen, points); // Vẽ đường viền của hình
            ///
            base.OnPaint(e);

            // Lấy đối tượng Graphics để vẽ
            Graphics g = e.Graphics;

            // Xác định bút vẽ và màu nền
            Pen pen = new Pen(Color.Blue, 3); // Bút vẽ với màu xanh và độ dày 3
            SolidBrush brush = new SolidBrush(Color.LightBlue); // Màu nền cho panel

            // Vẽ hình tứ giác với các góc vuông và đường chéo
            Point[] points = new Point[]
            {
                new Point(0, 0), // Góc trên trái
                new Point(this.Width - 80, 0), // Góc trên phải
                new Point(this.Width, this.Height), // Góc dưới phải
                new Point(0, this.Height) // Góc dưới trái
            };

            // Vẽ hình thang (tạo ra góc vuông bên trái và góc chéo bên phải)
            g.FillPolygon(brush, points);

            // Vẽ ảnh nền từ pbxBackGround vào phần trống của panel
            if (PbxBackGround != null && PbxBackGround.Image != null)
            {
                // Vẽ ảnh vào panel
                g.DrawImage(PbxBackGround.Image, new Rectangle(0, 0, this.Width, this.Height));
            }
            else
            {
                // Nếu pbxBackGround là null hoặc không có ảnh, bạn có thể xử lý theo cách khác
            }

            // Vẽ viền của hình thang nếu cần
            //g.DrawPolygon(pen, points);
        }
    }
}
