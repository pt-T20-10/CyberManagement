using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

class CyberManager
{
    public delegate void MoneyAddedHandler(int idPhien);
    public event MoneyAddedHandler OnMoneyAdded;

    private static readonly ConcurrentDictionary<int, double> tienNapDict = new ConcurrentDictionary<int, double>();

    // ✅ Cập nhật tiền nạp vào phiên
    public static void NapTien(int idPhien, double soTien, string userName)
    {
        tienNapDict.AddOrUpdate(idPhien, soTien, (key, oldValue) => oldValue + soTien);

        // Cập nhật vào database ngay lập tức
        TKKhachHangDAO.Instance.NapTien((float)soTien, userName);

        //MessageBox.Show($"Nạp {soTien} VNĐ vào phiên {idPhien}. Tổng: {tienNapDict[idPhien]}");
    }

    // ✅ Kết thúc phiên, lưu vào database
    public static void KetThucPhien(int idPhien, DateTime timeKetThuc, double tongTienNap, double tongTienDoAn)
    {
        try
        {
            if (tienNapDict.TryRemove(idPhien, out double tienNap))
            {
                //MessageBox.Show($"Phiên {idPhien} kết thúc. Tổng tiền nạp: {tienNap}, Tổng tiền đồ ăn: {tongTienDoAn}");

                // Lưu thông tin kết thúc phiên vào database
                MayTinhDAO.Instance.AddThoiGianKetThucPhien(idPhien, timeKetThuc, (float)tienNap, (float)tongTienDoAn);
                //MessageBox.Show("Lưu thành công vào database");
            }
            else
            {
                //MessageBox.Show($"Không tìm thấy idPhien {idPhien} trong tienNapDict.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi lưu vào database: {ex.Message}");
        }
    }

    // ✅ Lấy tổng tiền nạp của một phiên
    public static decimal GetTongTienNap(int idPhien)
    {
        return (decimal)(tienNapDict.TryGetValue(idPhien, out double tongTienNap) ? tongTienNap : 0);
    }

    // ✅ Thêm phương thức cập nhật tiền nạp vào database
    public static void CapNhatTienNap(int idPhien, double soTien)
    {
        try
        {
            // Cập nhật trong dictionary
            tienNapDict.AddOrUpdate(idPhien, soTien, (key, oldValue) => oldValue + soTien);

            // Gọi DAO để cập nhật vào database
            PhienSuDungDAO.Instance.CapNhatTienNap(idPhien, (float)soTien);

            //MessageBox.Show($"Cập nhật {soTien} VNĐ vào phiên {idPhien}. Tổng: {tienNapDict[idPhien]}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi cập nhật tiền nạp: {ex.Message}");
        }
    }

    // ✅ Thêm phương thức lấy danh sách các phiên đang chạy
    public static List<PhienSuDung> LayPhienDangChay()
    {
        try
        {
            List<PhienSuDung> danhSach = PhienSuDungDAO.Instance.LayPhienDangChay();

            // Cập nhật dictionary với các phiên đang chạy
            foreach (var phien in danhSach)
            {
                tienNapDict[phien.IDPhien] = (double)phien.TongTienNap;
            }

            return danhSach;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi lấy danh sách phiên đang chạy: {ex.Message}");
            return new List<PhienSuDung>();
        }
    }
    public static void KhoiPhucPhienDangChay()
    {
        var danhSachPhien = PhienSuDungDAO.Instance.LayPhienDangChay();
        foreach (var phien in danhSachPhien)
        {
            tienNapDict.TryAdd(phien.IDPhien, (double)phien.TongTienNap);
        }
        //MessageBox.Show($"Khôi phục {danhSachPhien.Count} phiên đang chạy.");
    }

}
