
namespace Quanlysinhvien
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_lop = new System.Windows.Forms.CheckBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_mshs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.dt_timngaysinh = new System.Windows.Forms.DateTimePicker();
            this.chk_timngaysinh = new System.Windows.Forms.CheckBox();
            this.cb_timlop = new System.Windows.Forms.ComboBox();
            this.tb_timsdt = new System.Windows.Forms.TextBox();
            this.tb_timdiachi = new System.Windows.Forms.TextBox();
            this.chk_timdiachi = new System.Windows.Forms.CheckBox();
            this.chk_timsdt = new System.Windows.Forms.CheckBox();
            this.cb_timgioitinh = new System.Windows.Forms.ComboBox();
            this.chk_timmshs = new System.Windows.Forms.CheckBox();
            this.chk_timlop = new System.Windows.Forms.CheckBox();
            this.tb_timten = new System.Windows.Forms.TextBox();
            this.chk_timgiotinh = new System.Windows.Forms.CheckBox();
            this.tb_timmshs = new System.Windows.Forms.TextBox();
            this.chk_timten = new System.Windows.Forms.CheckBox();
            this.chk_timkiem = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_lop);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.cb_gioitinh);
            this.groupBox1.Controls.Add(this.tb_ten);
            this.groupBox1.Controls.Add(this.tb_mshs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(522, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // chk_lop
            // 
            this.chk_lop.AutoSize = true;
            this.chk_lop.Location = new System.Drawing.Point(262, 86);
            this.chk_lop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_lop.Name = "chk_lop";
            this.chk_lop.Size = new System.Drawing.Size(44, 17);
            this.chk_lop.TabIndex = 15;
            this.chk_lop.Text = "Lop";
            this.chk_lop.UseVisualStyleBackColor = true;
            this.chk_lop.CheckedChanged += new System.EventHandler(this.chk_lop_CheckedChanged);
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(64, 105);
            this.dt_ngaysinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(92, 20);
            this.dt_ngaysinh.TabIndex = 14;
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(341, 84);
            this.cb_lop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(91, 21);
            this.cb_lop.TabIndex = 13;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(341, 58);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(116, 20);
            this.tb_sdt.TabIndex = 12;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(341, 30);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(116, 20);
            this.tb_diachi.TabIndex = 11;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(64, 80);
            this.cb_gioitinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(92, 21);
            this.cb_gioitinh.TabIndex = 9;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(64, 57);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(151, 20);
            this.tb_ten.TabIndex = 8;
            // 
            // tb_mshs
            // 
            this.tb_mshs.Location = new System.Drawing.Point(64, 28);
            this.tb_mshs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_mshs.Name = "tb_mshs";
            this.tb_mshs.Size = new System.Drawing.Size(113, 20);
            this.tb_mshs.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSHS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(9, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(729, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_tk
            // 
            this.bt_tk.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_tk.Location = new System.Drawing.Point(392, 23);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(68, 34);
            this.bt_tk.TabIndex = 26;
            this.bt_tk.Text = "Tìm Kiếm";
            this.bt_tk.UseVisualStyleBackColor = false;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_timkiem.Location = new System.Drawing.Point(392, 24);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(68, 34);
            this.bt_timkiem.TabIndex = 3;
            this.bt_timkiem.Text = "Tìm Kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Visible = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_xoa.Location = new System.Drawing.Point(310, 24);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(68, 34);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_sua.Location = new System.Drawing.Point(228, 24);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(68, 34);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Yellow;
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_them.Location = new System.Drawing.Point(146, 24);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(68, 34);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_lammoi);
            this.groupBox4.Controls.Add(this.bt_tk);
            this.groupBox4.Controls.Add(this.dt_timngaysinh);
            this.groupBox4.Controls.Add(this.bt_timkiem);
            this.groupBox4.Controls.Add(this.chk_timngaysinh);
            this.groupBox4.Controls.Add(this.bt_sua);
            this.groupBox4.Controls.Add(this.bt_xoa);
            this.groupBox4.Controls.Add(this.cb_timlop);
            this.groupBox4.Controls.Add(this.tb_timsdt);
            this.groupBox4.Controls.Add(this.bt_them);
            this.groupBox4.Controls.Add(this.tb_timdiachi);
            this.groupBox4.Controls.Add(this.chk_timdiachi);
            this.groupBox4.Controls.Add(this.chk_timsdt);
            this.groupBox4.Controls.Add(this.cb_timgioitinh);
            this.groupBox4.Controls.Add(this.chk_timmshs);
            this.groupBox4.Controls.Add(this.chk_timlop);
            this.groupBox4.Controls.Add(this.tb_timten);
            this.groupBox4.Controls.Add(this.chk_timgiotinh);
            this.groupBox4.Controls.Add(this.tb_timmshs);
            this.groupBox4.Controls.Add(this.chk_timten);
            this.groupBox4.Controls.Add(this.chk_timkiem);
            this.groupBox4.Location = new System.Drawing.Point(9, 384);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(640, 185);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bt_lammoi.Location = new System.Drawing.Point(549, 57);
            this.bt_lammoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(68, 34);
            this.bt_lammoi.TabIndex = 27;
            this.bt_lammoi.Text = "Làm Mới";
            this.bt_lammoi.UseVisualStyleBackColor = false;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // dt_timngaysinh
            // 
            this.dt_timngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timngaysinh.Location = new System.Drawing.Point(85, 161);
            this.dt_timngaysinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_timngaysinh.Name = "dt_timngaysinh";
            this.dt_timngaysinh.Size = new System.Drawing.Size(92, 20);
            this.dt_timngaysinh.TabIndex = 15;
            this.dt_timngaysinh.ValueChanged += new System.EventHandler(this.dt_timngaysinh_ValueChanged);
            // 
            // chk_timngaysinh
            // 
            this.chk_timngaysinh.AutoSize = true;
            this.chk_timngaysinh.Location = new System.Drawing.Point(7, 161);
            this.chk_timngaysinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timngaysinh.Name = "chk_timngaysinh";
            this.chk_timngaysinh.Size = new System.Drawing.Size(75, 17);
            this.chk_timngaysinh.TabIndex = 25;
            this.chk_timngaysinh.Text = "Ngày Sinh";
            this.chk_timngaysinh.UseVisualStyleBackColor = true;
            this.chk_timngaysinh.CheckedChanged += new System.EventHandler(this.chk_timngaysinh_CheckedChanged);
            // 
            // cb_timlop
            // 
            this.cb_timlop.FormattingEnabled = true;
            this.cb_timlop.Location = new System.Drawing.Point(384, 137);
            this.cb_timlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_timlop.Name = "cb_timlop";
            this.cb_timlop.Size = new System.Drawing.Size(92, 21);
            this.cb_timlop.TabIndex = 24;
            this.cb_timlop.SelectedIndexChanged += new System.EventHandler(this.cb_timlop_SelectedIndexChanged);
            // 
            // tb_timsdt
            // 
            this.tb_timsdt.Location = new System.Drawing.Point(384, 92);
            this.tb_timsdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_timsdt.Name = "tb_timsdt";
            this.tb_timsdt.Size = new System.Drawing.Size(113, 20);
            this.tb_timsdt.TabIndex = 23;
            this.tb_timsdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timsdt_KeyDown);
            // 
            // tb_timdiachi
            // 
            this.tb_timdiachi.Location = new System.Drawing.Point(384, 115);
            this.tb_timdiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_timdiachi.Name = "tb_timdiachi";
            this.tb_timdiachi.Size = new System.Drawing.Size(113, 20);
            this.tb_timdiachi.TabIndex = 22;
            this.tb_timdiachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timdiachi_KeyDown);
            // 
            // chk_timdiachi
            // 
            this.chk_timdiachi.AutoSize = true;
            this.chk_timdiachi.Location = new System.Drawing.Point(310, 117);
            this.chk_timdiachi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timdiachi.Name = "chk_timdiachi";
            this.chk_timdiachi.Size = new System.Drawing.Size(60, 17);
            this.chk_timdiachi.TabIndex = 21;
            this.chk_timdiachi.Text = "Địa Chỉ";
            this.chk_timdiachi.UseVisualStyleBackColor = true;
            this.chk_timdiachi.CheckedChanged += new System.EventHandler(this.chk_timdiachi_CheckedChanged);
            // 
            // chk_timsdt
            // 
            this.chk_timsdt.AutoSize = true;
            this.chk_timsdt.Location = new System.Drawing.Point(310, 95);
            this.chk_timsdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timsdt.Name = "chk_timsdt";
            this.chk_timsdt.Size = new System.Drawing.Size(48, 17);
            this.chk_timsdt.TabIndex = 20;
            this.chk_timsdt.Text = "SDT";
            this.chk_timsdt.UseVisualStyleBackColor = true;
            this.chk_timsdt.CheckedChanged += new System.EventHandler(this.chk_timsdt_CheckedChanged);
            // 
            // cb_timgioitinh
            // 
            this.cb_timgioitinh.FormattingEnabled = true;
            this.cb_timgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_timgioitinh.Location = new System.Drawing.Point(85, 137);
            this.cb_timgioitinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_timgioitinh.Name = "cb_timgioitinh";
            this.cb_timgioitinh.Size = new System.Drawing.Size(92, 21);
            this.cb_timgioitinh.TabIndex = 19;
            this.cb_timgioitinh.SelectedIndexChanged += new System.EventHandler(this.cb_timgioitinh_SelectedIndexChanged);
            // 
            // chk_timmshs
            // 
            this.chk_timmshs.AutoSize = true;
            this.chk_timmshs.Location = new System.Drawing.Point(7, 95);
            this.chk_timmshs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timmshs.Name = "chk_timmshs";
            this.chk_timmshs.Size = new System.Drawing.Size(57, 17);
            this.chk_timmshs.TabIndex = 17;
            this.chk_timmshs.Text = "MSHS";
            this.chk_timmshs.UseVisualStyleBackColor = true;
            this.chk_timmshs.CheckedChanged += new System.EventHandler(this.chk_timmshs_CheckedChanged);
            // 
            // chk_timlop
            // 
            this.chk_timlop.AutoSize = true;
            this.chk_timlop.Location = new System.Drawing.Point(310, 140);
            this.chk_timlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timlop.Name = "chk_timlop";
            this.chk_timlop.Size = new System.Drawing.Size(44, 17);
            this.chk_timlop.TabIndex = 16;
            this.chk_timlop.Text = "Lớp";
            this.chk_timlop.UseVisualStyleBackColor = true;
            this.chk_timlop.CheckedChanged += new System.EventHandler(this.chk_timlop_CheckedChanged);
            // 
            // tb_timten
            // 
            this.tb_timten.Location = new System.Drawing.Point(85, 115);
            this.tb_timten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_timten.Name = "tb_timten";
            this.tb_timten.Size = new System.Drawing.Size(151, 20);
            this.tb_timten.TabIndex = 15;
            this.tb_timten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timten_KeyDown);
            // 
            // chk_timgiotinh
            // 
            this.chk_timgiotinh.AutoSize = true;
            this.chk_timgiotinh.Location = new System.Drawing.Point(7, 139);
            this.chk_timgiotinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timgiotinh.Name = "chk_timgiotinh";
            this.chk_timgiotinh.Size = new System.Drawing.Size(70, 17);
            this.chk_timgiotinh.TabIndex = 9;
            this.chk_timgiotinh.Text = "Giới Tính";
            this.chk_timgiotinh.UseVisualStyleBackColor = true;
            this.chk_timgiotinh.CheckedChanged += new System.EventHandler(this.chk_timgiotinh_CheckedChanged);
            // 
            // tb_timmshs
            // 
            this.tb_timmshs.Location = new System.Drawing.Point(85, 93);
            this.tb_timmshs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_timmshs.Name = "tb_timmshs";
            this.tb_timmshs.Size = new System.Drawing.Size(113, 20);
            this.tb_timmshs.TabIndex = 8;
            this.tb_timmshs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_timmshs_KeyDown);
            // 
            // chk_timten
            // 
            this.chk_timten.AutoSize = true;
            this.chk_timten.Location = new System.Drawing.Point(7, 117);
            this.chk_timten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timten.Name = "chk_timten";
            this.chk_timten.Size = new System.Drawing.Size(45, 17);
            this.chk_timten.TabIndex = 1;
            this.chk_timten.Text = "Tên";
            this.chk_timten.UseVisualStyleBackColor = true;
            this.chk_timten.CheckedChanged += new System.EventHandler(this.chk_timten_CheckedChanged);
            // 
            // chk_timkiem
            // 
            this.chk_timkiem.AutoSize = true;
            this.chk_timkiem.Location = new System.Drawing.Point(484, 24);
            this.chk_timkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_timkiem.Name = "chk_timkiem";
            this.chk_timkiem.Size = new System.Drawing.Size(137, 17);
            this.chk_timkiem.TabIndex = 0;
            this.chk_timkiem.Text = "Tìm kiếm nhiều Dữ Liệu";
            this.chk_timkiem.UseVisualStyleBackColor = true;
            this.chk_timkiem.CheckedChanged += new System.EventHandler(this.chk_timkiem_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(234, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "QUẢN LÝ THÔNG TIN HỌC SINH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 604);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_mshs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_timkiem;
        private System.Windows.Forms.CheckBox chk_timmshs;
        private System.Windows.Forms.CheckBox chk_timlop;
        private System.Windows.Forms.TextBox tb_timten;
        private System.Windows.Forms.CheckBox chk_timgiotinh;
        private System.Windows.Forms.TextBox tb_timmshs;
        private System.Windows.Forms.CheckBox chk_timten;
        private System.Windows.Forms.ComboBox cb_timlop;
        private System.Windows.Forms.TextBox tb_timsdt;
        private System.Windows.Forms.TextBox tb_timdiachi;
        private System.Windows.Forms.CheckBox chk_timdiachi;
        private System.Windows.Forms.CheckBox chk_timsdt;
        private System.Windows.Forms.ComboBox cb_timgioitinh;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.DateTimePicker dt_timngaysinh;
        private System.Windows.Forms.CheckBox chk_timngaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.CheckBox chk_lop;
        private System.Windows.Forms.Button bt_lammoi;
    }
}

