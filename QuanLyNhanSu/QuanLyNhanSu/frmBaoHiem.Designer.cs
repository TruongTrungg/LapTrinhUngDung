
namespace ontapProjects
{
    partial class frmBaoHiem
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
            this.dtgBaoHiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.txtSbh = new System.Windows.Forms.TextBox();
            this.txtMbh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaBH = new System.Windows.Forms.Button();
            this.btnThembh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBaoHiem
            // 
            this.dtgBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaoHiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgBaoHiem.Location = new System.Drawing.Point(0, 300);
            this.dtgBaoHiem.Name = "dtgBaoHiem";
            this.dtgBaoHiem.RowHeadersWidth = 51;
            this.dtgBaoHiem.RowTemplate.Height = 24;
            this.dtgBaoHiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBaoHiem.Size = new System.Drawing.Size(800, 150);
            this.dtgBaoHiem.TabIndex = 0;
            this.dtgBaoHiem.Click += new System.EventHandler(this.dtgBaoHiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.dtpNgayCap);
            this.groupBox1.Controls.Add(this.txtNoiCap);
            this.groupBox1.Controls.Add(this.txtSbh);
            this.groupBox1.Controls.Add(this.txtMbh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoaBH);
            this.groupBox1.Controls.Add(this.btnThembh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hiểm";
            // 
            // cboMaNV
            // 
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(226, 155);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(186, 27);
            this.cboMaNV.Sorted = true;
            this.cboMaNV.TabIndex = 12;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(423, 52);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(158, 27);
            this.dtpNgayCap.TabIndex = 11;
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(422, 96);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(159, 27);
            this.txtNoiCap.TabIndex = 10;
            // 
            // txtSbh
            // 
            this.txtSbh.Location = new System.Drawing.Point(135, 96);
            this.txtSbh.Name = "txtSbh";
            this.txtSbh.Size = new System.Drawing.Size(159, 27);
            this.txtSbh.TabIndex = 9;
            // 
            // txtMbh
            // 
            this.txtMbh.Location = new System.Drawing.Point(135, 48);
            this.txtMbh.Name = "txtMbh";
            this.txtMbh.Size = new System.Drawing.Size(159, 27);
            this.txtMbh.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nơi cấp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số bảo hiểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã bảo hiểm:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(453, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaBH
            // 
            this.btnXoaBH.Location = new System.Drawing.Point(308, 207);
            this.btnXoaBH.Name = "btnXoaBH";
            this.btnXoaBH.Size = new System.Drawing.Size(89, 27);
            this.btnXoaBH.TabIndex = 1;
            this.btnXoaBH.Text = "Xóa";
            this.btnXoaBH.UseVisualStyleBackColor = true;
            this.btnXoaBH.Click += new System.EventHandler(this.btnXoaBH_Click);
            // 
            // btnThembh
            // 
            this.btnThembh.Location = new System.Drawing.Point(144, 207);
            this.btnThembh.Name = "btnThembh";
            this.btnThembh.Size = new System.Drawing.Size(93, 27);
            this.btnThembh.TabIndex = 0;
            this.btnThembh.Text = "Thêm";
            this.btnThembh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnThembh.UseVisualStyleBackColor = true;
            this.btnThembh.Click += new System.EventHandler(this.btnThembh_Click);
            // 
            // frmBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgBaoHiem);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmBaoHiem";
            this.ShowIcon = false;
            this.Text = "Bảo Hiểm";
            this.Load += new System.EventHandler(this.frmBaoHiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaoHiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBaoHiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.TextBox txtSbh;
        private System.Windows.Forms.TextBox txtMbh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoaBH;
        private System.Windows.Forms.Button btnThembh;
    }
}


