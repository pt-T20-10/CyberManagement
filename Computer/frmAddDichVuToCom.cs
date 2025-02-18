using CyberManagementProject.DAO;
using CyberManagementProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberManagementProject.Computer
{
    public partial class frmAddDichVuToCom : Form
    {
        private MayTinhView mayTinh;
        public MayTinhView MayTinh { get => mayTinh; set => mayTinh = value; }
        public frmAddDichVuToCom(MayTinhView Com)
        {
            InitializeComponent();
            this.MayTinh = Com;
            LoadCategory();
        }
        void LoadCategory()
        {
            List<LoaiDoAn> listCategory = LoaiDoAnDAO.Instance.GetListCategory();
            cbxAddToComLoaiMon.DataSource = listCategory;
            cbxAddToComLoaiMon.DisplayMember = "TenLoai";
        }
        void LoadFoodListByCategoryId(int id)
        {
            List<DoAnDTO> listFood = FoodDAO.Instance.GetListFoodByCategoryId(id);
            cbxAddToComMon.DataSource = listFood;
            cbxAddToComMon.DisplayMember = "TenDoAn";
        }
        private void cbxAddToComLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cbxCategory = sender as ComboBox;

            if (cbxCategory.SelectedItem == null) return;

            LoaiDoAn selected = cbxCategory.SelectedItem as LoaiDoAn;
            id = selected.IdLoai;

            LoadFoodListByCategoryId(id);
        }

        private void btnAcceptAddDVtoCom_Click(object sender, EventArgs e)
        {
            int? idPhien = MayTinh.IDPhien;
            int idFood = (cbxAddToComMon.SelectedItem as DoAnDTO).IDDoAn;
            int count = (int)nrudAddToComCount.Value;
            MayTinhDAO.Instance.InsertServiceToComputer(idPhien, idFood, count);
            if (MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }


        }
    }
}
