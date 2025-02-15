using CyberManagementProject.DAO;
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class CyberManager
{
    public delegate void MoneyAddedHandler(int idPhien);
    public event MoneyAddedHandler OnMoneyAdded;

    private static readonly ConcurrentDictionary<int, decimal> tienNapDict = new ConcurrentDictionary<int, decimal>();

    public static void NapTien(int idPhien, decimal soTien, string userName)
    {
        Task.Run(() =>
        {
            tienNapDict.AddOrUpdate(idPhien, soTien, (key, oldValue) => oldValue + soTien);

            // Cập nhật vào database ngay lập tức
            TKKhachHangDAO.Instance.NapTien((float)soTien, userName);

            Console.WriteLine($"Nạp {soTien} VNĐ vào phiên {idPhien}. Tổng: {tienNapDict[idPhien]}");
        });
    }

    public static void KetThucPhien(int idPhien, DateTime timeKetThuc, decimal tongTienDoAn)
    {
        Task.Run(() =>
        {
            if (tienNapDict.TryRemove(idPhien, out decimal tongTienNap))
            {
                Console.WriteLine($"Phiên {idPhien} kết thúc. Tổng tiền nạp: {tongTienNap}, Tổng tiền đồ ăn: {tongTienDoAn}");

                // Lưu thông tin kết thúc phiên vào database
                MayTinhDAO.Instance.AddThoiGianKetThucPhien(idPhien, timeKetThuc, (float)tongTienNap, (float)tongTienDoAn);
            }
        });
    }

    public static decimal GetTongTienNap(int idPhien)
    {
        return tienNapDict.TryGetValue(idPhien, out decimal tongTien) ? tongTien : 0;
    }
}
