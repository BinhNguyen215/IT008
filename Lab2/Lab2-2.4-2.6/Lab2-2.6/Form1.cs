using System.Windows.Forms;

namespace Lab2_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                SinhVien sinhVienSua = dataGridView.SelectedRows[0].DataBoundItem as SinhVien;

                sinhVienSua.MaSinhVien = textBox1.Text;
                sinhVienSua.TenSinhVien = textBox2.Text;
                sinhVienSua.Lop = textBox3.Text;

                dataGridView.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSinhVien = textBox1.Text;
            string tenSinhVien = textBox2.Text;
            string lop = textBox3.Text;

            SinhVien sinhVienMoi = new SinhVien(maSinhVien, tenSinhVien, lop);

            danhSachSinhVien.Add(sinhVienMoi);

            dataGridView.DataSource = null;
            dataGridView.DataSource = danhSachSinhVien;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                SinhVien sinhVienXoa = dataGridView.SelectedRows[0].DataBoundItem as SinhVien;
                danhSachSinhVien.Remove(sinhVienXoa);
                dataGridView.DataSource = null;
                dataGridView.DataSource = danhSachSinhVien;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                SinhVien sinhVienChon = dataGridView.SelectedRows[0].DataBoundItem as SinhVien;

                textBox1.Text = sinhVienChon.MaSinhVien;
                textBox2.Text = sinhVienChon.TenSinhVien;
                textBox3.Text = sinhVienChon.Lop;
            }
        }
    }
}