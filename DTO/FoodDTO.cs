﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberManagementProject.DTO
{
        public class DoAnDTO
        {
            // ID của đồ ăn
            public int IDDoAn { get; set; }

            // Tên đồ ăn
            public string TenDoAn { get; set; }

            // Giá của đồ ăn
            public decimal Gia { get; set; }

            // ID loại đồ ăn
            public int IDLoai { get; set; }

            // Hình ảnh của đồ ăn
            public string HinhAnh { get; set; }

            // Constructor không tham số
            public DoAnDTO() { }

            // Constructor đầy đủ tham số
            public DoAnDTO(int idDoAn, string tenDoAn, decimal gia, int idLoai, string hinhAnh)
            {
                IDDoAn = idDoAn;
                TenDoAn = tenDoAn;
                Gia = gia;
                IDLoai = idLoai;
                HinhAnh = hinhAnh;
            }

            // Override phương thức ToString() để dễ hiển thị thông tin
            public override string ToString()
            {
                return $"ID: {IDDoAn}, Tên: {TenDoAn}, Giá: {Gia}, ID Loại: {IDLoai}, Hình ảnh: {HinhAnh}";
            }
        }

}
