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
    public partial class ucBaiHat : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private String sortItem = "";
        private static ucBaiHat _instance;
        public static ucBaiHat Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBaiHat();
                return _instance;
            }
        }
        public ucBaiHat()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            var result = from c in db.BaiHat
                         select new
                         {
                             MaBH = c.MaBaiHat,
                             TenBH = c.TenBaiHat,
                             MaNS = c.MaNhacSi,
                             GhiChu = c.GhiChu,
                             GiaiDieu = c.GiaiDieu
                         };
            dtGV_BaiHat.DataSource = result.ToList();
        }
        public void init()
        {
            var result = from c in db.NhacSi
                         select new
                         {
                             MaNS = c.MaNhacSi,
                             TenNS = c.TenNhacSi,
                             GhiChu = c.GhiChu,
                             SDT = c.SDT
                         };
            lk_MaNS.Properties.DataSource = result.ToList();
            lk_MaNS.Properties.ValueMember = "MaNS";
            lk_MaNS.Properties.DisplayMember = "TenNS";
        }

        private void ucBaiHat_Load(object sender, EventArgs e)
        {
            loadData();
            init();
            btn_Delete.Enabled = false;
        }

        private void dtGV_BaiHat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_BaiHat.Rows[e.RowIndex];

                txb_MaBH.Text = r.Cells[0].Value.ToString();
                txb_TenBH.Text = r.Cells[1].Value.ToString();
                lk_MaNS.EditValue = r.Cells[2].Value.ToString();
                txb_GiaiDieu.Text = r.Cells[3].Value.ToString();
                txb_GhiChu.Text = r.Cells[4].Value.ToString();

                txb_MaBH.ReadOnly = true;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.BaiHat where t.MaBaiHat == txb_MaBH.Text select t).SingleOrDefault();
                s.TenBaiHat = txb_TenBH.Text;
                s.MaNhacSi = lk_MaNS.EditValue.ToString();
                s.GiaiDieu = txb_GiaiDieu.Text;
                s.GhiChu = txb_GhiChu.Text;
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(txb_MaBH.Text)
                                || String.IsNullOrWhiteSpace(txb_TenBH.Text)
                                || String.IsNullOrWhiteSpace(lk_MaNS.EditValue.ToString())
                                || String.IsNullOrWhiteSpace(txb_GhiChu.Text)
                                || String.IsNullOrWhiteSpace(txb_GiaiDieu.Text)
                                || (db.BaiHat.Any(p => p.MaBaiHat == txb_MaBH.Text.Trim())))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    BaiHat k = new BaiHat()
                    {
                        MaBaiHat = txb_MaBH.Text.Trim(),
                        TenBaiHat = txb_TenBH.Text.Trim(),
                        MaNhacSi = lk_MaNS.EditValue.ToString(),
                        GhiChu = txb_GhiChu.Text.Trim(),
                        GiaiDieu = txb_GiaiDieu.Text.Trim(),
                    };
                    db.BaiHat.Add(k);
                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.BaiHat where t.MaBaiHat == txb_MaBH.Text select t).SingleOrDefault();
                if (db.ChiTietAlbum.Any(p => p.MaBaiHat == s.MaBaiHat))
                {
                    MessageBox.Show("This record can't be deleted! Please try again");
                }
                else
                {
                    db.BaiHat.Remove(s);
                }
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txb_MaBH.ReadOnly = false;
            btn_Delete.Enabled = false;
            isUpdate = false;

            txb_MaBH.Text = "";
            txb_TenBH.Text = "";
            txb_GhiChu.Text = "";
            txb_GiaiDieu.Text = "";
            lk_MaNS.EditValue = null;
        }

        private void btn_sortAsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sortItem.Equals("MaBH"))
            {
                //this.dtGV_CaSi.Sort(this.dtGV_CaSi.Columns[0], ListSortDirection.Ascending);
                var result = from c in db.BaiHat
                             select new
                             {
                                 MaBH = c.MaBaiHat,
                                 TenBH = c.TenBaiHat,
                                 MaNS = c.MaNhacSi,
                                 GhiChu = c.GhiChu,
                                 GiaiDieu = c.GiaiDieu
                             };
                dtGV_BaiHat.DataSource = result.OrderBy(o => o.MaBH).ToList();
            }
            else
            {
                //this.dtGV_CaSi.Sort(this.dtGV_CaSi.Columns[1], ListSortDirection.Ascending);
                var result = from c in db.BaiHat
                             select new
                             {
                                 MaBH = c.MaBaiHat,
                                 TenBH = c.TenBaiHat,
                                 MaNS = c.MaNhacSi,
                                 GhiChu = c.GhiChu,
                                 GiaiDieu = c.GiaiDieu
                             };
                dtGV_BaiHat.DataSource = result.OrderBy(o => o.TenBH).ToList();
            }
        }

        private void btn_sortDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sortItem.Equals("MaBH"))
            {
                //this.dtGV_CaSi.Sort(this.dtGV_CaSi.Columns[0], ListSortDirection.Ascending);
                var result = from c in db.BaiHat
                             select new
                             {
                                 MaBH = c.MaBaiHat,
                                 TenBH = c.TenBaiHat,
                                 MaNS = c.MaNhacSi,
                                 GhiChu = c.GhiChu,
                                 GiaiDieu = c.GiaiDieu
                             };
                dtGV_BaiHat.DataSource = result.OrderByDescending(o => o.MaBH).ToList();
            }
            else
            {
                //this.dtGV_CaSi.Sort(this.dtGV_CaSi.Columns[1], ListSortDirection.Ascending);
                var result = from c in db.BaiHat
                             select new
                             {
                                 MaBH = c.MaBaiHat,
                                 TenBH = c.TenBaiHat,
                                 MaNS = c.MaNhacSi,
                                 GhiChu = c.GhiChu,
                                 GiaiDieu = c.GiaiDieu
                             };
                dtGV_BaiHat.DataSource = result.OrderByDescending(o => o.TenBH).ToList();
            }
        }

        private void check_MaBH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaBH.Checked = true;
            check_TenBH.Checked = false;
            sortItem = "MaBH";
        }
        private void check_TenBH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaBH.Checked = false;
            check_TenBH.Checked = true;
            sortItem = "TenBH";
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
                toExcel(dtGV_BaiHat, saveFileDialog.FileName);
            }
        }
    }
}
