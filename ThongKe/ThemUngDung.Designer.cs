namespace QLQuanNET
{
    partial class frmQLyUngDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnKhungQLyUngDung = new Panel();
            gbxQLyUngDung = new GroupBox();
            pnThongTinUngDung = new Panel();
            gbxCapNhatUD = new GroupBox();
            cbxLoaiUngDung = new ComboBox();
            txtCapNhatDuongDanUD = new TextBox();
            txtCapNhatMoTaUngDung = new TextBox();
            lb10 = new Label();
            lb9 = new Label();
            lb8 = new Label();
            lb7 = new Label();
            lb6 = new Label();
            txtCapNhatTenUngDung = new TextBox();
            txtCapNhatIDUngDung = new TextBox();
            btnResetUngDung = new Button();
            btnXoaUngDung = new Button();
            btnCapNhatUngDung = new Button();
            btnThemUngDung = new Button();
            pnViewUngDung = new Panel();
            dgvViewUngDung = new DataGridView();
            pnKhungQLyUngDung.SuspendLayout();
            gbxQLyUngDung.SuspendLayout();
            pnThongTinUngDung.SuspendLayout();
            gbxCapNhatUD.SuspendLayout();
            pnViewUngDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewUngDung).BeginInit();
            SuspendLayout();
            // 
            // pnKhungQLyUngDung
            // 
            pnKhungQLyUngDung.Controls.Add(gbxQLyUngDung);
            pnKhungQLyUngDung.Dock = DockStyle.Fill;
            pnKhungQLyUngDung.Location = new Point(0, 0);
            pnKhungQLyUngDung.Margin = new Padding(2, 2, 2, 2);
            pnKhungQLyUngDung.Name = "pnKhungQLyUngDung";
            pnKhungQLyUngDung.Size = new Size(833, 397);
            pnKhungQLyUngDung.TabIndex = 0;
            // 
            // gbxQLyUngDung
            // 
            gbxQLyUngDung.Controls.Add(pnThongTinUngDung);
            gbxQLyUngDung.Controls.Add(btnResetUngDung);
            gbxQLyUngDung.Controls.Add(btnXoaUngDung);
            gbxQLyUngDung.Controls.Add(btnCapNhatUngDung);
            gbxQLyUngDung.Controls.Add(btnThemUngDung);
            gbxQLyUngDung.Controls.Add(pnViewUngDung);
            gbxQLyUngDung.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxQLyUngDung.Location = new Point(8, 7);
            gbxQLyUngDung.Margin = new Padding(2, 2, 2, 2);
            gbxQLyUngDung.Name = "gbxQLyUngDung";
            gbxQLyUngDung.Padding = new Padding(2, 2, 2, 2);
            gbxQLyUngDung.Size = new Size(816, 383);
            gbxQLyUngDung.TabIndex = 0;
            gbxQLyUngDung.TabStop = false;
            gbxQLyUngDung.Text = "Quản Lý Ứng Dụng";
            // 
            // pnThongTinUngDung
            // 
            pnThongTinUngDung.BorderStyle = BorderStyle.FixedSingle;
            pnThongTinUngDung.Controls.Add(gbxCapNhatUD);
            pnThongTinUngDung.Location = new Point(540, 64);
            pnThongTinUngDung.Margin = new Padding(2, 2, 2, 2);
            pnThongTinUngDung.Name = "pnThongTinUngDung";
            pnThongTinUngDung.Size = new Size(273, 319);
            pnThongTinUngDung.TabIndex = 5;
            // 
            // gbxCapNhatUD
            // 
            gbxCapNhatUD.Controls.Add(cbxLoaiUngDung);
            gbxCapNhatUD.Controls.Add(txtCapNhatDuongDanUD);
            gbxCapNhatUD.Controls.Add(txtCapNhatMoTaUngDung);
            gbxCapNhatUD.Controls.Add(lb10);
            gbxCapNhatUD.Controls.Add(lb9);
            gbxCapNhatUD.Controls.Add(lb8);
            gbxCapNhatUD.Controls.Add(lb7);
            gbxCapNhatUD.Controls.Add(lb6);
            gbxCapNhatUD.Controls.Add(txtCapNhatTenUngDung);
            gbxCapNhatUD.Controls.Add(txtCapNhatIDUngDung);
            gbxCapNhatUD.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxCapNhatUD.Location = new Point(2, 2);
            gbxCapNhatUD.Margin = new Padding(2, 2, 2, 2);
            gbxCapNhatUD.Name = "gbxCapNhatUD";
            gbxCapNhatUD.Padding = new Padding(2, 2, 2, 2);
            gbxCapNhatUD.Size = new Size(267, 313);
            gbxCapNhatUD.TabIndex = 1;
            gbxCapNhatUD.TabStop = false;
            gbxCapNhatUD.Text = "Thông Tin Ứng Dụng";
            // 
            // cbxLoaiUngDung
            // 
            cbxLoaiUngDung.Font = new Font("Segoe UI", 9F);
            cbxLoaiUngDung.FormattingEnabled = true;
            cbxLoaiUngDung.Location = new Point(121, 131);
            cbxLoaiUngDung.Margin = new Padding(2, 2, 2, 2);
            cbxLoaiUngDung.Name = "cbxLoaiUngDung";
            cbxLoaiUngDung.Size = new Size(129, 23);
            cbxLoaiUngDung.TabIndex = 5;
            // 
            // txtCapNhatDuongDanUD
            // 
            txtCapNhatDuongDanUD.Font = new Font("Segoe UI", 9F);
            txtCapNhatDuongDanUD.Location = new Point(121, 214);
            txtCapNhatDuongDanUD.Multiline = true;
            txtCapNhatDuongDanUD.Name = "txtCapNhatDuongDanUD";
            txtCapNhatDuongDanUD.Size = new Size(129, 24);
            txtCapNhatDuongDanUD.TabIndex = 4;
            // 
            // txtCapNhatMoTaUngDung
            // 
            txtCapNhatMoTaUngDung.Font = new Font("Segoe UI", 9F);
            txtCapNhatMoTaUngDung.Location = new Point(121, 172);
            txtCapNhatMoTaUngDung.Multiline = true;
            txtCapNhatMoTaUngDung.Name = "txtCapNhatMoTaUngDung";
            txtCapNhatMoTaUngDung.Size = new Size(129, 24);
            txtCapNhatMoTaUngDung.TabIndex = 3;
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb10.Location = new Point(4, 214);
            lb10.Margin = new Padding(2, 0, 2, 0);
            lb10.Name = "lb10";
            lb10.Size = new Size(72, 15);
            lb10.TabIndex = 2;
            lb10.Text = "Đường dẫn:";
            // 
            // lb9
            // 
            lb9.AutoSize = true;
            lb9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb9.Location = new Point(4, 172);
            lb9.Margin = new Padding(2, 0, 2, 0);
            lb9.Name = "lb9";
            lb9.Size = new Size(42, 15);
            lb9.TabIndex = 2;
            lb9.Text = "Mô tả:";
            // 
            // lb8
            // 
            lb8.AutoSize = true;
            lb8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb8.Location = new Point(4, 131);
            lb8.Margin = new Padding(2, 0, 2, 0);
            lb8.Name = "lb8";
            lb8.Size = new Size(32, 15);
            lb8.TabIndex = 2;
            lb8.Text = "Loại:";
            // 
            // lb7
            // 
            lb7.AutoSize = true;
            lb7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb7.Location = new Point(0, 89);
            lb7.Margin = new Padding(2, 0, 2, 0);
            lb7.Name = "lb7";
            lb7.Size = new Size(86, 15);
            lb7.TabIndex = 2;
            lb7.Text = "Tên ứng dụng:";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb6.Location = new Point(4, 49);
            lb6.Margin = new Padding(2, 0, 2, 0);
            lb6.Name = "lb6";
            lb6.Size = new Size(23, 15);
            lb6.TabIndex = 2;
            lb6.Text = "ID:";
            // 
            // txtCapNhatTenUngDung
            // 
            txtCapNhatTenUngDung.Font = new Font("Segoe UI", 9F);
            txtCapNhatTenUngDung.Location = new Point(121, 89);
            txtCapNhatTenUngDung.Multiline = true;
            txtCapNhatTenUngDung.Name = "txtCapNhatTenUngDung";
            txtCapNhatTenUngDung.Size = new Size(129, 24);
            txtCapNhatTenUngDung.TabIndex = 1;
            // 
            // txtCapNhatIDUngDung
            // 
            txtCapNhatIDUngDung.Font = new Font("Segoe UI", 9F);
            txtCapNhatIDUngDung.Location = new Point(121, 49);
            txtCapNhatIDUngDung.Multiline = true;
            txtCapNhatIDUngDung.Name = "txtCapNhatIDUngDung";
            txtCapNhatIDUngDung.ReadOnly = true;
            txtCapNhatIDUngDung.Size = new Size(129, 24);
            txtCapNhatIDUngDung.TabIndex = 1;
            // 
            // btnResetUngDung
            // 
            btnResetUngDung.BackColor = Color.White;
            btnResetUngDung.FlatStyle = FlatStyle.Flat;
            btnResetUngDung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetUngDung.Location = new Point(450, 31);
            btnResetUngDung.Name = "btnResetUngDung";
            btnResetUngDung.Size = new Size(87, 30);
            btnResetUngDung.TabIndex = 4;
            btnResetUngDung.Text = "Reset";
            btnResetUngDung.UseVisualStyleBackColor = false;
            btnResetUngDung.Click += btnResetUngDung_Click;
            // 
            // btnXoaUngDung
            // 
            btnXoaUngDung.BackColor = Color.White;
            btnXoaUngDung.FlatStyle = FlatStyle.Flat;
            btnXoaUngDung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaUngDung.Location = new Point(303, 32);
            btnXoaUngDung.Name = "btnXoaUngDung";
            btnXoaUngDung.Size = new Size(87, 29);
            btnXoaUngDung.TabIndex = 4;
            btnXoaUngDung.Text = "Xóa";
            btnXoaUngDung.UseVisualStyleBackColor = false;
            btnXoaUngDung.Click += btnXoaUngDung_Click;
            // 
            // btnCapNhatUngDung
            // 
            btnCapNhatUngDung.BackColor = Color.White;
            btnCapNhatUngDung.FlatStyle = FlatStyle.Flat;
            btnCapNhatUngDung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhatUngDung.Location = new Point(152, 32);
            btnCapNhatUngDung.Name = "btnCapNhatUngDung";
            btnCapNhatUngDung.Size = new Size(101, 29);
            btnCapNhatUngDung.TabIndex = 4;
            btnCapNhatUngDung.Text = "Cập nhật";
            btnCapNhatUngDung.UseVisualStyleBackColor = false;
            btnCapNhatUngDung.Click += btnCapNhatUngDung_Click;
            // 
            // btnThemUngDung
            // 
            btnThemUngDung.BackColor = Color.White;
            btnThemUngDung.FlatStyle = FlatStyle.Flat;
            btnThemUngDung.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemUngDung.Location = new Point(7, 31);
            btnThemUngDung.Name = "btnThemUngDung";
            btnThemUngDung.Size = new Size(87, 30);
            btnThemUngDung.TabIndex = 4;
            btnThemUngDung.Text = "Thêm";
            btnThemUngDung.UseVisualStyleBackColor = false;
            btnThemUngDung.Click += btnThemUngDung_Click;
            // 
            // pnViewUngDung
            // 
            pnViewUngDung.BorderStyle = BorderStyle.FixedSingle;
            pnViewUngDung.Controls.Add(dgvViewUngDung);
            pnViewUngDung.Location = new Point(4, 64);
            pnViewUngDung.Margin = new Padding(2, 2, 2, 2);
            pnViewUngDung.Name = "pnViewUngDung";
            pnViewUngDung.Size = new Size(532, 320);
            pnViewUngDung.TabIndex = 0;
            // 
            // dgvViewUngDung
            // 
            dgvViewUngDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewUngDung.Dock = DockStyle.Fill;
            dgvViewUngDung.Location = new Point(0, 0);
            dgvViewUngDung.Margin = new Padding(2, 2, 2, 2);
            dgvViewUngDung.MultiSelect = false;
            dgvViewUngDung.Name = "dgvViewUngDung";
            dgvViewUngDung.RowHeadersWidth = 62;
            dgvViewUngDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViewUngDung.Size = new Size(530, 318);
            dgvViewUngDung.TabIndex = 0;
            dgvViewUngDung.CellClick += dgvViewUngDung_CellClick;
            dgvViewUngDung.CellContentClick += dgvViewUngDung_CellContentClick;
            // 
            // frmQLyUngDung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 397);
            Controls.Add(pnKhungQLyUngDung);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmQLyUngDung";
            Text = "Quản Lý Ứng Dụng";
            Load += frmQLyUngDung_Load;
            pnKhungQLyUngDung.ResumeLayout(false);
            gbxQLyUngDung.ResumeLayout(false);
            pnThongTinUngDung.ResumeLayout(false);
            gbxCapNhatUD.ResumeLayout(false);
            gbxCapNhatUD.PerformLayout();
            pnViewUngDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvViewUngDung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnKhungQLyUngDung;
        private GroupBox gbxQLyUngDung;
        private Panel pnViewUngDung;
        private DataGridView dgvViewUngDung;
        private Button btnResetUngDung;
        private Button btnXoaUngDung;
        private Button btnCapNhatUngDung;
        private Button btnThemUngDung;
        private Panel pnThongTinUngDung;
        private GroupBox gbxCapNhatUD;
        private Label lb8;
        private Label lb7;
        private Label lb6;
        private TextBox txtCapNhatTenUngDung;
        private TextBox txtCapNhatIDUngDung;
        private TextBox txtCapNhatDuongDanUD;
        private TextBox txtCapNhatMoTaUngDung;
        private Label lb10;
        private Label lb9;
        private ComboBox cbxLoaiUngDung;
    }
}