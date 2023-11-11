using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Quanlysinhvien
{
    public partial class Form1 : Form
    {
        string chuoiketnoi = "Server = DESKTOP-DC3P0U3\\SQLEXPRESS; Database = Quanlythongtinhocsinh; Integrated Security = True";
        SqlConnection con = new SqlConnection();
        private void ketnoicsdl()
        {
            try
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
                //MessageBox.Show("ket noi thanh cong");
            }
            catch
            {
                MessageBox.Show("ket noi that bai");
            }
        }
        
        //Load Dữ liệu vào DataGridView
        private void loaddulieulenluoi()
        {
            string sql = "SELECT * FROM Hocsinh";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //Load Dữ liệu vào Combobox Mã Khoa
        private void loadcombobox(ComboBox cb)
        {
            string sql = "SELECT * FROM Lop";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns["Lop"].ToString();
        }

        // định dạng cột
        private void dinhdangluoi()
        {
            dataGridView1.Columns[0].HeaderText = "MSHS";   //bat dau cua dgv  = 0
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Giới Tính";
            dataGridView1.Columns[2].Width =40;
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "SDT";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].HeaderText = "Lop";
            dataGridView1.Columns[6].Width = 80;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            loaddulieulenluoi();
            loadcombobox(cb_lop);
            chk_timkiem_CheckedChanged(sender, e);
            cb_lop.Text = "";
            chk_lop_CheckedChanged(sender, e);
            cb_lop.Visible = true;
        }

        private bool Kiemtra()
        {
            if (tb_mshs.Text == "")
            {
                MessageBox.Show("Chưa nhập MSHS.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_mshs.Focus();
                return false;
            }
            if (tb_ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên Học Sinh.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ten.Focus();
                return false;
            }
            if (cb_gioitinh.Text == "")
            {
                MessageBox.Show("Chưa nhập Giới Tính.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_gioitinh.Focus();
                return false;
            }
            if (dt_ngaysinh.Text == "")
            {
                MessageBox.Show("Chưa nhập Ngày Sinh.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_ngaysinh.Focus();
                return false;
            }
            if (tb_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập Địa Chỉ.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_diachi.Focus();
                return false;
            }
            if (tb_sdt.Text == "")
            {
                MessageBox.Show("Chưa nhập Số điện thoại.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_sdt.Focus();
                return false;
            }
            if (cb_lop.Text == "")
            {
                MessageBox.Show("Chưa nhập Lớp.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_lop.Focus();
                return false;
            }
            return true;
        }
        // load dữ liệu trên combobox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mshs.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_ten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_gioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dt_ngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_diachi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_sdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cb_lop.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        //nút thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                try
                {
                    DialogResult them;
                    them = MessageBox.Show("Thêm thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sqlthem = " insert into Hocsinh values ('" + tb_mshs.Text + "', N'" + tb_ten.Text +
                    "', N'" + cb_gioitinh.Text + "','" + dt_ngaysinh.Text + "', N'" + tb_diachi.Text + "', '" + tb_sdt.Text + "', '" + cb_lop.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand(sqlthem, con);
                    sqlCommand.ExecuteNonQuery();
                    loaddulieulenluoi();

                }
                catch
                {
                    MessageBox.Show("Thêm không thành công.");
                }
            }
        }

        //nút sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                try
                {
                    DialogResult sua;
                    sua = MessageBox.Show("Sửa thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sqlsua = "update Hocsinh set Ten = N'" + tb_ten.Text + "', GioiTinh =  N'" + cb_gioitinh.Text + "', " +
                        "NgaySinh = '" + dt_ngaysinh.Text + "', DiaChi = N'" + tb_diachi.Text + "', SDT = '" + tb_sdt.Text + "'," +
                        " Lop = '" + cb_lop.Text + "' where MSHS = '" + tb_mshs.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlsua, con);
                    sqlCommand.ExecuteNonQuery();
                    loaddulieulenluoi();
                }
                catch
                {
                    MessageBox.Show("Sua khong thanh cong");
                }
            }
        }

        //nút xóa - xóa theo mshs
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult question;
            question = MessageBox.Show("Bạn có muốn Xóa thông tin học sinh này không ?", "Thông báo! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(question == DialogResult.Yes)
            {
                try
                {
                    string sqlxoa = "delete Hocsinh " + "where MSHS = '" + tb_mshs.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlxoa, con);
                    sqlCommand.ExecuteNonQuery();
                    loaddulieulenluoi();
                    MessageBox.Show("Xoá thành công.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công.");
                }
            }
        }


        //Checkbox Tìm kiếm Dữ Liệu
        private void chk_timkiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timkiem.Checked == true)
            {
                chk_timmshs.Visible = true;
                tb_timmshs.Visible = true;
                chk_timten.Visible = true;
                tb_timten.Visible = true;
                chk_timgiotinh.Visible = true;
                cb_timgioitinh.Visible = true;
                chk_timngaysinh.Visible = true;
                dt_timngaysinh.Visible = true;
                chk_timdiachi.Visible = true;
                tb_timdiachi.Visible = true;
                chk_timsdt.Visible = true;
                tb_timsdt.Visible = true;
                chk_timlop.Visible = true;
                cb_timlop.Visible = true;
                bt_timkiem.Visible = true;
                bt_tk.Visible = false;
                //---//
                chk_timmshs.Checked = true;
                chk_timten.Checked = true;
                chk_timgiotinh.Checked = true;
                chk_timngaysinh.Checked = true;
                chk_timdiachi.Checked = true;
                chk_timsdt.Checked = true;
                chk_timlop.Checked = true;
            }
            else
            {
                chk_timmshs.Visible = false;
                tb_timmshs.Visible = false;
                chk_timten.Visible = false;
                tb_timten.Visible = false;
                chk_timgiotinh.Visible = false;
                cb_timgioitinh.Visible = false;
                chk_timngaysinh.Visible = false;
                dt_timngaysinh.Visible = false;
                chk_timdiachi.Visible = false;
                tb_timdiachi.Visible = false;
                chk_timsdt.Visible = false;
                tb_timsdt.Visible = false;
                chk_timlop.Visible = false;
                cb_timlop.Visible = false;
                bt_timkiem.Visible = false;
                bt_tk.Visible = true;
                loaddulieulenluoi();    //load lại dữ liệu
            }
        }


        //Checkbox tìm MSHS
        private void chk_timmshs_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timmshs.Checked == true)
            {
                tb_timmshs.Visible = true;  //Hiện 
                tb_timmshs.Text = "";   //Mặc định điền trống
                tb_timmshs.Focus(); //Đặt con trỏ
                if (chk_timten.Checked == true && chk_timgiotinh.Checked == true 
                    && chk_timngaysinh.Checked == true && chk_timdiachi.Checked == true 
                    && chk_timsdt.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                tb_timmshs.Visible = false;
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //Textbox Tìm MSHS
        private void tb_timmshs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT * FROM Hocsinh where MSHS like '%" + tb_timmshs.Text + "'  ";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dinhdangluoi();
            }
        }

        //Checkbox Tìm Tên SV
        private void chk_timten_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timten.Checked == true)
            {
                tb_timten.Visible = true;
                tb_timten.Text = "";
                tb_timten.Focus();
                if(chk_timmshs.Checked == true && chk_timgiotinh.Checked == true && 
                    chk_timngaysinh.Checked == true && chk_timdiachi.Checked == true 
                    && chk_timsdt.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                tb_timten.Visible = false;
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //Textbox Tìm Tên SV
        private void tb_timten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT * FROM Hocsinh where Ten like N'%" + tb_timten.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dinhdangluoi();
            }
        }

        //Checkbox Tìm Giới Tính
        private void chk_timgiotinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timgiotinh.Checked == true)
            {
                loaddulieulenluoi();
                if(chk_timmshs.Checked == true && chk_timten.Checked == true 
                    && chk_timngaysinh.Checked == true && chk_timdiachi.Checked == true 
                    && chk_timsdt.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                bt_timkiem.Visible = false;
            }
        }

        //Combobox Tìm Giới Tính
        private void cb_timgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where GioiTinh like N'%" + cb_timgioitinh.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //Checkbox Tìm Ngày Sinh
        private void chk_timngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timngaysinh.Checked == true)
            {
                loaddulieulenluoi();
                if (chk_timmshs.Checked == true && chk_timten.Checked == true && 
                    chk_timgiotinh.Checked == true && chk_timdiachi.Checked == true
                    && chk_timsdt.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //DateTimePicker Tìm Ngày Sinh
        private void dt_timngaysinh_ValueChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where NgaySinh = '" + dt_timngaysinh.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //Checkbox Tìm Địa Chỉ
        private void chk_timdiachi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timdiachi.Checked == true)
            {
                tb_timdiachi.Visible = true;
                tb_timdiachi.Text = "";
                tb_timdiachi.Focus();
                if (chk_timmshs.Checked == true && chk_timten.Checked == true &&
                    chk_timgiotinh.Checked == true && chk_timngaysinh.Checked == true 
                    && chk_timsdt.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                tb_timdiachi.Visible = false;
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //Textbox Tìm Địa Chỉ
        private void tb_timdiachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT * FROM Hosinh where DiaChi like N'%" + tb_timdiachi.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dinhdangluoi();
            }
        }

        //Checkbox Tìm SDT
        private void chk_timsdt_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timsdt.Checked == true)
            {
                tb_timsdt.Visible = true;
                tb_timsdt.Text = "";
                tb_timsdt.Focus();
                if (chk_timmshs.Checked == true && chk_timten.Checked == true 
                    && chk_timgiotinh.Checked == true && chk_timngaysinh.Checked == true 
                    && chk_timdiachi.Checked == true && chk_timlop.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                tb_timsdt.Visible = false;
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //Textbox Tìm SDT
        private void tb_timsdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT * FROM Hocsinh where SDT like N'%" + tb_timsdt.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dinhdangluoi();
            }
        }

        //Checkbox tìm Lớp
        private void chk_timlop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_timlop.Checked == true)
            {
                cb_timlop.Visible = true;
                loadcombobox(cb_timlop); //Load dữ liệu vào cb_timmakhoa
                if (chk_timmshs.Checked == true && chk_timten.Checked == true 
                    && chk_timgiotinh.Checked == true && chk_timngaysinh.Checked == true 
                    && chk_timdiachi.Checked == true && chk_timsdt.Checked == true)
                {
                    bt_timkiem.Visible = true;
                }
                else
                {
                    bt_timkiem.Visible = false;
                }
            }
            else
            {
                cb_timlop.Visible = false;
                bt_timkiem.Visible = false;
                loaddulieulenluoi();
            }
        }

        //Combobox tìm Lớp
        private void cb_timlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where Lop = '" + cb_timlop.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        // nút tìm kiếm
        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where MSHS like '%" + tb_timmshs.Text + "' " +
                "and  Ten like N'%" + tb_timten.Text + "%'" +
            "and GioiTinh like N'%" + cb_timgioitinh.Text + "%' and " +
            "DiaChi like N'%" + tb_timdiachi.Text + "%' and SDT like N'%" + tb_timsdt.Text + "%'" +
            "and Lop = '" + cb_timlop.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //nút Tìm kiếm 
        private void bt_tk_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where MSHS like '%" + tb_mshs.Text + "' " +
                "and  Ten like N'%" + tb_ten.Text + "%'" +
            "and GioiTinh like N'%" + cb_gioitinh.Text + "%' and" +
            " DiaChi like N'%" + tb_diachi.Text + "%' and SDT like N'%" + tb_sdt.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //Checkbox lop
        private void chk_lop_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lop.Checked == true)
            {
                loadcombobox(cb_lop);
                cb_lop.Visible = true;
            }
            else
            {
                loaddulieulenluoi();
                cb_lop.Visible = false;
            }
        }

        //Combobox lop
        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hocsinh where Lop = '" + cb_lop.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dinhdangluoi();
        }

        //nút Làm mới
        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            tb_mshs.Text = "";
            tb_ten.Text = "";
            cb_gioitinh.Text = "";
            dt_ngaysinh.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            cb_lop.Text = "";
            //---//
            tb_timmshs.Text = "";
            tb_timten.Text = "";
            cb_timgioitinh.Text = "";
            dt_timngaysinh.Text = "";
            tb_timdiachi.Text = "";
            tb_timsdt.Text = "";
            cb_timlop.Text = "";
            loaddulieulenluoi();
        }
    }
}
