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
    public partial class ucNhacSi : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private static ucNhacSi _instance;
        private String sortItem = "";
        public static ucNhacSi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNhacSi();
                return _instance;
            }
        }
        public ucNhacSi()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            var result = from c in db.NhacSi
                         select new
                         {
                             MaNS = c.MaNhacSi,
                             TenNS = c.TenNhacSi,
                             GhiChu = c.GhiChu,
                             SDT = c.SDT
                         };
            dtGV_NhacSy.DataSource = result.ToList();
        }

        private void ucNhacSi_Load(object sender, EventArgs e)
        {
            loadData();
            btn_Delete.Enabled = false;
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.NhacSi where t.MaNhacSi == txb_MaNS.Text select t).SingleOrDefault();
                s.TenNhacSi = txb_TenNS.Text;
                s.GhiChu = txb_GhiChu.Text;
                s.SDT = txb_SDT.Text;
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(txb_MaNS.Text)
                                || String.IsNullOrWhiteSpace(txb_TenNS.Text)
                                || String.IsNullOrWhiteSpace(txb_GhiChu.Text)
                                || String.IsNullOrWhiteSpace(txb_SDT.Text)
                                || (db.NhacSi.Any(p => p.MaNhacSi == txb_MaNS.Text.Trim())))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    NhacSi ns = new NhacSi()
                    {
                        MaNhacSi = txb_MaNS.Text.Trim(),
                        TenNhacSi = txb_TenNS.Text.Trim(),
                        GhiChu = txb_GhiChu.Text.Trim(),
                        SDT = txb_SDT.Text.Trim()
                    };
                    db.NhacSi.Add(ns);

                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.NhacSi where t.MaNhacSi == txb_MaNS.Text select t).SingleOrDefault();
                if (db.BaiHat.Any(p => p.MaNhacSi == s.MaNhacSi))
                {
                    MessageBox.Show("This record can't be deleted! Please try again");
                }
                else
                {
                    db.NhacSi.Remove(s);
                }
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txb_MaNS.ReadOnly = false;
            btn_Delete.Enabled = false;
            isUpdate = false;
            txb_MaNS.Text = "";
            txb_TenNS.Text = "";
            txb_GhiChu.Text = "";
            txb_SDT.Text = "";
        }

        private void dtGV_NhacSy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_NhacSy.Rows[e.RowIndex];
                txb_MaNS.Text = r.Cells[0].Value.ToString();
                txb_TenNS.Text = r.Cells[1].Value.ToString();
                txb_GhiChu.Text = r.Cells[2].Value.ToString();
                txb_SDT.Text = r.Cells[3].Value.ToString();

                txb_MaNS.ReadOnly = true;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void check_MaNS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaNS.Checked = true;
            check_TenNS.Checked = false;
            sortItem = "MaNS";
        }

        private void check_TenNS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaNS.Checked = false;
            check_TenNS.Checked = true;
            sortItem = "TenNS";
        }

        private void btn_sortAsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.NhacSi
                         select new
                         {
                             MaNS = c.MaNhacSi,
                             TenNS = c.TenNhacSi,
                             GhiChu = c.GhiChu,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaNS"))
            {
                dtGV_NhacSy.DataSource = result.OrderBy(o => o.MaNS).ToList();
            }
            else
            {
                dtGV_NhacSy.DataSource = result.OrderBy(o => o.TenNS).ToList();
            }
        }

        private void btn_sortDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.NhacSi
                         select new
                         {
                             MaNS = c.MaNhacSi,
                             TenNS = c.TenNhacSi,
                             GhiChu = c.GhiChu,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaNS"))
            {
                dtGV_NhacSy.DataSource = result.OrderByDescending(o => o.MaNS).ToList();
            }
            else
            {
                dtGV_NhacSy.DataSource = result.OrderByDescending(o => o.TenNS).ToList();
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
                toExcel(dtGV_NhacSy, saveFileDialog.FileName);
            }
        }
    }
}
