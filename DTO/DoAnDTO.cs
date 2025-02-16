using System;

namespace CyberManagementProject.DTO
{
    public class DoAnDTO
    {
        // ID của đồ ăn
        public int IDDoAn { get; set; }
        public string TenDoAn { get; set; }
        public decimal Gia { get; set; }
        public int IDLoai { get; set; }
        public string HinhAnh { get; set; }
        public int Quantity { get; set; } = 0;  // Mặc định số lượng là 0

        // Tính tổng tiền dựa trên số lượng
        public decimal ThanhTien => Gia * Quantity;

        // Constructor không tham số
        public DoAnDTO() { }

        // Constructor đầy đủ tham số
        public DoAnDTO(int idDoAn, string tenDoAn, decimal gia, int idLoai, string hinhAnh, int quantity = 0)
        {
            IDDoAn = idDoAn;
            TenDoAn = tenDoAn;
            Gia = gia;
            IDLoai = idLoai;
            HinhAnh = hinhAnh;
            Quantity = quantity;
        }

        // Override phương thức ToString() để hiển thị thông tin
        public override string ToString()
        {
            return $"ID: {IDDoAn}, Tên: {TenDoAn}, Giá: {Gia:N0} VNĐ, Loại: {IDLoai}, Hình ảnh: {HinhAnh}, Số lượng: {Quantity}, Thành tiền: {ThanhTien:N0} VNĐ";
        }
    }
}
