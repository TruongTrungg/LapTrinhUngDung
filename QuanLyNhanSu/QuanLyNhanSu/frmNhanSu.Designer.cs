namespace QuanLyNhanSu
{
    partial class frmNhanSu
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.botHuy = new System.Windows.Forms.Button();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.pnTNNS = new System.Windows.Forms.Panel();
            this.btoThemTDHV = new System.Windows.Forms.Button();
            this.btothemCV = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTDHV = new System.Windows.Forms.ComboBox();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.cboGT = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtgNhanSu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnTNNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(20, 14);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 27);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btoUpdate);
            this.panel1.Controls.Add(this.botHuy);
            this.panel1.Controls.Add(this.btoTimKiem);
            this.panel1.Controls.Add(this.btoSua);
            this.panel1.Controls.Add(this.btoXoa);
            this.panel1.Controls.Add(this.btoThem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 46);
            this.panel1.TabIndex = 0;
            // 
            // btoUpdate
            // 
            this.btoUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoUpdate.Location = new System.Drawing.Point(1001, 6);
            this.btoUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoUpdate.Name = "btoUpdate";
            this.btoUpdate.Size = new System.Drawing.Size(73, 34);
            this.btoUpdate.TabIndex = 8;
            this.btoUpdate.Text = "Update";
            this.btoUpdate.UseVisualStyleBackColor = true;
            this.btoUpdate.Click += new System.EventHandler(this.btoUpdate_Click);
            // 
            // botHuy
            // 
            this.botHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botHuy.Location = new System.Drawing.Point(825, 10);
            this.botHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botHuy.Name = "botHuy";
            this.botHuy.Size = new System.Drawing.Size(81, 27);
            this.botHuy.TabIndex = 7;
            this.botHuy.Text = "Clear";
            this.botHuy.UseVisualStyleBackColor = true;
            this.botHuy.Click += new System.EventHandler(this.botHuy_Click);
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoTimKiem.Location = new System.Drawing.Point(282, 12);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(109, 27);
            this.btoTimKiem.TabIndex = 6;
            this.btoTimKiem.Text = "Tìm kiếm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // btoSua
            // 
            this.btoSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoSua.Location = new System.Drawing.Point(719, 10);
            this.btoSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(81, 27);
            this.btoSua.TabIndex = 5;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // btoXoa
            // 
            this.btoXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoXoa.Location = new System.Drawing.Point(613, 10);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(81, 27);
            this.btoXoa.TabIndex = 4;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoThem
            // 
            this.btoThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoThem.Location = new System.Drawing.Point(503, 10);
            this.btoThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(81, 27);
            this.btoThem.TabIndex = 3;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // pnTNNS
            // 
            this.pnTNNS.AutoScroll = true;
            this.pnTNNS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnTNNS.Controls.Add(this.btoThemTDHV);
            this.pnTNNS.Controls.Add(this.btothemCV);
            this.pnTNNS.Controls.Add(this.dtpNgaySinh);
            this.pnTNNS.Controls.Add(this.cboChucVu);
            this.pnTNNS.Controls.Add(this.label10);
            this.pnTNNS.Controls.Add(this.label9);
            this.pnTNNS.Controls.Add(this.label8);
            this.pnTNNS.Controls.Add(this.cboTDHV);
            this.pnTNNS.Controls.Add(this.cboPB);
            this.pnTNNS.Controls.Add(this.cboGT);
            this.pnTNNS.Controls.Add(this.txtEmail);
            this.pnTNNS.Controls.Add(this.txtSDT);
            this.pnTNNS.Controls.Add(this.label14);
            this.pnTNNS.Controls.Add(this.label13);
            this.pnTNNS.Controls.Add(this.label12);
            this.pnTNNS.Controls.Add(this.label5);
            this.pnTNNS.Controls.Add(this.label4);
            this.pnTNNS.Controls.Add(this.label3);
            this.pnTNNS.Controls.Add(this.label2);
            this.pnTNNS.Controls.Add(this.label1);
            this.pnTNNS.Controls.Add(this.txtDiaChi);
            this.pnTNNS.Controls.Add(this.txtCCCD);
            this.pnTNNS.Controls.Add(this.txtHoTen);
            this.pnTNNS.Controls.Add(this.txtMaNV);
            this.pnTNNS.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTNNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnTNNS.Location = new System.Drawing.Point(5, 62);
            this.pnTNNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTNNS.Name = "pnTNNS";
            this.pnTNNS.Size = new System.Drawing.Size(1092, 281);
            this.pnTNNS.TabIndex = 1;
            // 
            // btoThemTDHV
            // 
            this.btoThemTDHV.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoThemTDHV.Location = new System.Drawing.Point(1011, 235);
            this.btoThemTDHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btoThemTDHV.Name = "btoThemTDHV";
            this.btoThemTDHV.Size = new System.Drawing.Size(64, 25);
            this.btoThemTDHV.TabIndex = 9;
            this.btoThemTDHV.Text = "Thêm";
            this.btoThemTDHV.UseVisualStyleBackColor = true;
            this.btoThemTDHV.Click += new System.EventHandler(this.btoThemTDHV_Click);
            // 
            // btothemCV
            // 
            this.btothemCV.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btothemCV.Location = new System.Drawing.Point(645, 235);
            this.btothemCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btothemCV.Name = "btothemCV";
            this.btothemCV.Size = new System.Drawing.Size(65, 25);
            this.btothemCV.TabIndex = 8;
            this.btothemCV.Text = "Thêm";
            this.btothemCV.UseVisualStyleBackColor = true;
            this.btothemCV.Click += new System.EventHandler(this.btothemCV_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(456, 26);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(181, 25);
            this.dtpNgaySinh.TabIndex = 35;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(457, 235);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(180, 25);
            this.cboChucVu.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(761, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "TDHV: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Phòng Ban:";
            // 
            // cboTDHV
            // 
            this.cboTDHV.FormattingEnabled = true;
            this.cboTDHV.Location = new System.Drawing.Point(825, 235);
            this.cboTDHV.Margin = new System.Windows.Forms.Padding(4);
            this.cboTDHV.Name = "cboTDHV";
            this.cboTDHV.Size = new System.Drawing.Size(180, 25);
            this.cboTDHV.TabIndex = 29;
            // 
            // cboPB
            // 
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(147, 235);
            this.cboPB.Margin = new System.Windows.Forms.Padding(4);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(180, 25);
            this.cboPB.TabIndex = 28;
            // 
            // cboGT
            // 
            this.cboGT.FormattingEnabled = true;
            this.cboGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGT.Location = new System.Drawing.Point(147, 159);
            this.cboGT.Margin = new System.Windows.Forms.Padding(4);
            this.cboGT.Name = "cboGT";
            this.cboGT.Size = new System.Drawing.Size(180, 25);
            this.cboGT.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(825, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 27);
            this.txtEmail.TabIndex = 25;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(825, 50);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 27);
            this.txtSDT.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(773, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(715, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Số Điện Thoại:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(396, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "CCCD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(457, 165);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 27);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(456, 90);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(180, 27);
            this.txtCCCD.TabIndex = 22;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(147, 90);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 27);
            this.txtHoTen.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(147, 26);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(180, 27);
            this.txtMaNV.TabIndex = 18;
            // 
            // dtgNhanSu
            // 
            this.dtgNhanSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNhanSu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanSu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgNhanSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgNhanSu.Location = new System.Drawing.Point(0, 347);
            this.dtgNhanSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgNhanSu.Name = "dtgNhanSu";
            this.dtgNhanSu.ReadOnly = true;
            this.dtgNhanSu.RowHeadersWidth = 51;
            this.dtgNhanSu.RowTemplate.Height = 24;
            this.dtgNhanSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNhanSu.Size = new System.Drawing.Size(1097, 278);
            this.dtgNhanSu.TabIndex = 1;
            this.dtgNhanSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanSu_CellClick);
            // 
            // frmNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1097, 625);
            this.Controls.Add(this.dtgNhanSu);
            this.Controls.Add(this.pnTNNS);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanSu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanSu_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnTNNS.ResumeLayout(false);
            this.pnTNNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.Panel pnTNNS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgNhanSu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTDHV;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.ComboBox cboGT;
        private System.Windows.Forms.Button botHuy;
        private System.Windows.Forms.Button btothemCV;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.Button btoThemTDHV;
    }
}