using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaSi.UI.Modules
{
    public partial class ucCaSi : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCaSi _instance;
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private String sortItem = "";
        public static ucCaSi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCaSi();
                return _instance;
            }
        }
        public ucCaSi()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            var result = from c in db.CaSi
                         select new
                         {
                             MaCS = c.MaCaSi,
                             TenCS = c.TenCaSi,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            dtGV_CaSi.DataSource = result.ToList();
        }

        private void ucCaSi_Load(object sender, EventArgs e)
        {
            loadData();
            btn_Delete.Enabled = false;
        }

        private void dtGV_CaSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_CaSi.Rows[e.RowIndex];
                txb_MaCS.Text = r.Cells[0].Value.ToString();
                txb_TenCS.Text = r.Cells[1].Value.ToString();
                txb_DiaChi.Text = r.Cells[2].Value.ToString();
                txb_SDT.Text = r.Cells[3].Value.ToString();

                txb_MaCS.ReadOnly = true;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.CaSi where t.MaCaSi == txb_MaCS.Text select t).SingleOrDefault();
                s.TenCaSi = txb_TenCS.Text;
                s.DiaChi = txb_DiaChi.Text;
                s.SDT = txb_SDT.Text;
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(txb_MaCS.Text)
                                || String.IsNullOrWhiteSpace(txb_TenCS.Text)
                                || String.IsNullOrWhiteSpace(txb_DiaChi.Text)
                                || String.IsNullOrWhiteSpace(txb_SDT.Text)
                                || (db.CaSi.Any(p => p.MaCaSi == txb_MaCS.Text.Trim())))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    CaSi cs = new CaSi()
                    {
                        MaCaSi = txb_MaCS.Text.Trim(),
                        TenCaSi = txb_TenCS.Text.Trim(),
                        DiaChi = txb_DiaChi.Text.Trim(),
                        SDT = txb_SDT.Text.Trim()
                    };
                    db.CaSi.Add(cs);

                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.CaSi where t.MaCaSi == txb_MaCS.Text select t).SingleOrDefault();
                if (db.ChiTietAlbum.Any(p => p.MaCaSi == s.MaCaSi))
                {
                    MessageBox.Show("This record can't be deleted! Please try again");
                }
                else
                {
                    db.CaSi.Remove(s);
                }
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txb_MaCS.ReadOnly = false;
            btn_Delete.Enabled = false;
            isUpdate = false;
            txb_MaCS.Text = "";
            txb_TenCS.Text = "";
            txb_DiaChi.Text = "";
            txb_SDT.Text = "";
        }

        private void check_MaCS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaCS.Checked = true;
            check_TenCS.Checked = false;
            sortItem = "MaCS";
        }

        private void check_TenCS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaCS.Checked = false;
            check_TenCS.Checked = true;
            sortItem = "TenCS";
        }

        private void btn_sortAsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.CaSi
                         select new
                         {
                             MaCS = c.MaCaSi,
                             TenCS = c.TenCaSi,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaCS"))
            {
                dtGV_CaSi.DataSource = result.OrderBy(o => o.MaCS).ToList();
            }
            else
            {
                dtGV_CaSi.DataSource = result.OrderBy(o => o.TenCS).ToList();
            }
        }

        private void btn_sortDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.CaSi
                         select new
                         {
                             MaCS = c.MaCaSi,
                             TenCS = c.TenCaSi,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaCS"))
            {
                dtGV_CaSi.DataSource = result.OrderByDescending(o => o.MaCS).ToList();
            }
            else
            {
                dtGV_CaSi.DataSource = result.OrderByDescending(o => o.TenCS).ToList();
            }
        }
        private void toExcel(DataGridView dtGV, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "QuanLyDanhMucCaSi";
                // export header trong DataGridView
                for (int i = 0; i < dtGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtGV.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dtGV.RowCount; i++)
                {
                    for (int j = 0; j < dtGV.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtGV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }

        }

        private void btn_toExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                toExcel(dtGV_CaSi, saveFileDialog.FileName);
            }
        }
    }
}
