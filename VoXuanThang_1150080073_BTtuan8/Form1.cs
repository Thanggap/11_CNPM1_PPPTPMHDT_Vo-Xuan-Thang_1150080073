namespace Lab6;

using System.Data;
using System.Data.SqlClient;

public partial class Form1 : Form
{
    // Chuỗi kết nối - hãy cập nhật đường dẫn đến file .mdf của bạn
    string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;";
    
    // Đối tượng kết nối
    SqlConnection sqlCon = null;

    public Form1()
    {
        InitializeComponent();
    }

    // Mở kết nối
    private void MoKetNoi()
    {
        if (sqlCon == null)
        {
            sqlCon = new SqlConnection(strCon);
        }
        if (sqlCon.State == ConnectionState.Closed)
        {
            sqlCon.Open();
        }
    }

    // Đóng kết nối
    private void DongKetNoi()
    {
        if (sqlCon != null && sqlCon.State == ConnectionState.Open)
        {
            sqlCon.Close();
        }
    }

    // Hiển thị danh sách nhà xuất bản
    private void HienThiDanhSachXB()
    {
        try
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiXB";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();

            while (reader.Read())
            {
                string maXB = reader.GetString(0);
                string tenXB = reader.GetString(1);
                string diaChi = reader.GetString(2);

                ListViewItem lvi = new ListViewItem(maXB);
                lvi.SubItems.Add(tenXB);
                lvi.SubItems.Add(diaChi);
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Hiển thị thông tin chi tiết nhà xuất bản theo mã
    private void HienThiThongTinXBTheoMa(string maXB)
    {
        try
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiChiTietXB";
            sqlCmd.Connection = sqlCon;

            SqlParameter parMaXB = new SqlParameter("@maXB", SqlDbType.Char);
            parMaXB.Value = maXB;
            sqlCmd.Parameters.Add(parMaXB);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            txtMaXB_View.Text = txtTenXB_View.Text = txtDiaChi_View.Text = "";

            if (reader.Read())
            {
                string _maXB = reader.GetString(0);
                string tenXB = reader.GetString(1);
                string diaChi = reader.GetString(2);

                txtMaXB_View.Text = _maXB;
                txtTenXB_View.Text = tenXB;
                txtDiaChi_View.Text = diaChi;
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Sự kiện khi chọn item trong ListView
    private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lsvDanhSach.SelectedItems.Count == 0) return;

        ListViewItem lvi = lsvDanhSach.SelectedItems[0];
        string maXB = lvi.SubItems[0].Text;
        HienThiThongTinXBTheoMa(maXB);
    }

    // Sự kiện Load form
    private void Form1_Load(object sender, EventArgs e)
    {
        HienThiDanhSachXB();
        txtMaXB_Add.Focus();
    }

    // Thêm dữ liệu
    private void btnThemDL_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaXB_Add.Text) ||
            string.IsNullOrWhiteSpace(txtTenXB_Add.Text) ||
            string.IsNullOrWhiteSpace(txtDiaChi_Add.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "ThemDuLieu";

            SqlParameter parMaXB = new SqlParameter("@maXB", SqlDbType.Char);
            SqlParameter parTenXB = new SqlParameter("@tenXB", SqlDbType.NVarChar);
            SqlParameter parDiaChi = new SqlParameter("@diaChi", SqlDbType.NVarChar);

            parMaXB.Value = txtMaXB_Add.Text.Trim();
            parTenXB.Value = txtTenXB_Add.Text.Trim();
            parDiaChi.Value = txtDiaChi_Add.Text.Trim();

            sqlCmd.Parameters.Add(parMaXB);
            sqlCmd.Parameters.Add(parTenXB);
            sqlCmd.Parameters.Add(parDiaChi);
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachXB();
                txtMaXB_Add.Text = txtTenXB_Add.Text = txtDiaChi_Add.Text = "";
                txtMaXB_Add.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Sửa dữ liệu
    private void btnSuaDL_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaXB_Edit.Text) ||
            string.IsNullOrWhiteSpace(txtTenXB_Edit.Text) ||
            string.IsNullOrWhiteSpace(txtDiaChi_Edit.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "SuaDuLieu";

            SqlParameter parMaXB = new SqlParameter("@maXB", SqlDbType.Char);
            SqlParameter parTenXB = new SqlParameter("@tenXB", SqlDbType.NVarChar);
            SqlParameter parDiaChi = new SqlParameter("@diaChi", SqlDbType.NVarChar);

            parMaXB.Value = txtMaXB_Edit.Text.Trim();
            parTenXB.Value = txtTenXB_Edit.Text.Trim();
            parDiaChi.Value = txtDiaChi_Edit.Text.Trim();

            sqlCmd.Parameters.Add(parMaXB);
            sqlCmd.Parameters.Add(parTenXB);
            sqlCmd.Parameters.Add(parDiaChi);
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachXB();
                txtMaXB_Edit.Text = txtTenXB_Edit.Text = txtDiaChi_Edit.Text = "";
                txtMaXB_Edit.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Xóa dữ liệu
    private void btnXoaDL_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaXB_Del.Text))
        {
            MessageBox.Show("Vui lòng nhập mã nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes) return;

        try
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "XoaDuLieu";

            SqlParameter parMaXB = new SqlParameter("@maXB", SqlDbType.Char);
            parMaXB.Value = txtMaXB_Del.Text.Trim();
            sqlCmd.Parameters.Add(parMaXB);
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachXB();
                txtMaXB_Del.Text = "";
                txtMaXB_Del.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà xuất bản với mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
