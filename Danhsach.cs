using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhânSự
{
    public partial class frmDanhsach : Form
    {
        #region Variables
        public static string ConnectionString = @"Data Source=21AK22-COM;Initial Catalog=QLNS;Integrated Security=True";
        public static string LoaiTK = "-1";
        public static string State = "-1";
        #endregion
        public frmDanhsach()
        {
            InitializeComponent();
            SetControl("First");
            GetData();
        }

        public void SetControl(string state)
        {
            switch(state)
            {
                case "First":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThoat.Enabled = false;
                break;
                    default:
                    break;
            }
        }

        public void GetData()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "SELECT * FROM Giangvien ORDER BY HoTen";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgMain.DataSource = ds.Tables[0]; 
            }
            else
            {
                dtgMain.DataSource = null;
               // lblTrangthai.Text = "Tài khoản hoặc mật khẩu không chính xác.";
            }
        }

        private void dtgMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgMain.Rows[index];

            txtMagv.Text = selectedRow.Cells["MaGV"].Value.ToString();
            txtHoten.Text = selectedRow.Cells["HoTen"].Value.ToString();
            txtMangach.Text = selectedRow.Cells["MaNgach"].Value.ToString();
            txtSdt.Text = selectedRow.Cells["Sdt"].Value.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            txtQue.Text = selectedRow.Cells["QueQuan"].Value.ToString();
            txtHamhoc.Text = selectedRow.Cells["HamHoc"].Value.ToString();
            txtNgachvc.Text = selectedRow.Cells["NgachVC"].Value.ToString();
            txtChucvucq.Text = selectedRow.Cells["ChucVuCCQ"].Value.ToString();
            txtChuyennganh.Text = selectedRow.Cells["ChuyenNganh"].Value.ToString();
            txtChucvukn.Text = selectedRow.Cells["ChucVuKN"].Value.ToString();
            txtChucvudang.Text = selectedRow.Cells["ChucVuDang"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;

            txtMagv.Text = "";
            txtHoten.Text = "";
            txtMangach.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtQue.Text = "";
            txtHamhoc.Text = "";
            txtNgachvc.Text = "";
            txtChucvucq.Text = "";
            txtChuyennganh.Text = "";
            txtChucvukn.Text = "";
            txtChucvudang.Text = "";

           // txtMagv.Enabled=false;
            txtHoten.Focus();
            State = "Insert";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;

            State = "Update";
            txtHoten.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "") { MessageBox.Show("Chưa nhập thông tin họ tên", "Thông báo"); txtHoten.Focus(); return; }
            
            if(State == "Insert")
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "INSERT INTO Giangvien (MaGV, HoTen, MaNgach, Sdt, Email, QueQuan, HamHoc, NgachVC, ChucVuCCQ, ChuyenNganh, ChucVuKN, ChucVuDang) VALUES (N'"+ txtMagv.Text.Trim() + "',N'"+ txtHoten.Text.Trim() + "',N'"+ txtMangach.Text.Trim() + "','"+ txtSdt.Text.Trim() + "','"+ txtEmail.Text.Trim() + "',N'"+ txtQue.Text.Trim() + "',N'"+ txtHamhoc.Text.Trim() + "',N'"+ txtNgachvc.Text.Trim() + "',N'"+ txtChucvucq.Text.Trim() + "',N'"+ txtChuyennganh.Text.Trim() + "',N'"+ txtChucvukn.Text.Trim() + "',N'"+ txtChucvudang.Text.Trim() +"')"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if(result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Lỗi lưu dữ liệu", "Thông báo");
                }
            }
            else if (State == "Update")
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "UPDATE Giangvien SET HoTen =N'" + txtHoten.Text.Trim() + "' , MaNgach=N'" + txtMangach.Text.Trim() + "', Sdt='" + txtSdt.Text.Trim() + "', Email='" + txtEmail.Text.Trim() + "', QueQuan=N'" + txtQue.Text.Trim() + "', HamHoc=N'" + txtHamhoc.Text.Trim() + "', NgachVC=N'" + txtNgachvc.Text.Trim() + "', ChucVuCCQ=N'" + txtChucvucq.Text.Trim() + "', ChuyenNganh=N'" + txtChuyennganh.Text.Trim() + "', ChucVuKN=N'" + txtChucvukn.Text.Trim() + "', ChucVuDang=N'" + txtChucvudang.Text.Trim() + "' WHERE MaGV = '"+ txtMagv.Text.Trim() +"'";

                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cap nhat dữ liệu thành công", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Lỗi lưu dữ liệu", "Thông báo");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            SetControl("First");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "DELETE FROM Giangvien WHERE MaGV = '"+ txtMagv.Text.Trim() +"'";

            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                GetData();
            }
            else
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
