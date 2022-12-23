using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class ucAlbum : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private String sortItem = "";
        private static ucAlbum _instance;
        public static ucAlbum Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAlbum();
                return _instance;
            }
        }
        public ucAlbum()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            var result = from c in db.Album
                         select new
                         {
                             MaAlbum = c.MaAlbum,
                             TenAlbum = c.TenAlbum,
                             MaNSX = c.MaNSX,
                             GiaTien = c.GiaTien
                         };
            dtGV_Album.DataSource = result.ToList();
        }

        public void init()
        {
            var result = from c in db.NhaSanXuat
                         select new
                         {
                             MaNSX = c.MaNSX,
                             TenCty = c.TenCty,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            lk_MaNSX.Properties.DataSource = result.ToList();
            lk_MaNSX.Properties.ValueMember = "MaNSX";
            lk_MaNSX.Properties.DisplayMember = "TenCty";
        }

        private void ucAlbum_Load(object sender, EventArgs e)
        {
            loadData();
            init();
            btn_Delete.Enabled = false;
        }

        private void dtGV_Album_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_Album.Rows[e.RowIndex];

                txb_MaAlbum.Text = r.Cells[0].Value.ToString();
                txb_TenAlbum.Text = r.Cells[1].Value.ToString();
                lk_MaNSX.EditValue = r.Cells[2].Value.ToString();
                // cbb_MaNSX.SelectedValue = r.Cells[2].Value.ToString();
                txb_GiaTien.Text = r.Cells[3].Value.ToString();
                txb_MaAlbum.ReadOnly = true;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.Album where t.MaAlbum == txb_MaAlbum.Text select t).SingleOrDefault();
                s.TenAlbum = txb_TenAlbum.Text;
                s.MaNSX = lk_MaNSX.EditValue.ToString();
                s.GiaTien = Int32.Parse(txb_GiaTien.Text.Trim()); ;
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(txb_MaAlbum.Text)
                                || String.IsNullOrWhiteSpace(txb_TenAlbum.Text)
                                || String.IsNullOrWhiteSpace(lk_MaNSX.EditValue.ToString())
                                || String.IsNullOrWhiteSpace(txb_GiaTien.Text)
                                || (db.Album.Any(p => p.MaAlbum == txb_MaAlbum.Text.Trim())))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    Album k = new Album()
                    {
                        MaAlbum = txb_MaAlbum.Text.Trim(),
                        TenAlbum = txb_TenAlbum.Text.Trim(),
                        MaNSX = lk_MaNSX.EditValue.ToString(),
                        GiaTien = Int32.Parse(txb_GiaTien.Text.Trim())
                    };
                    db.Album.Add(k);
                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.Album where t.MaAlbum == txb_MaAlbum.Text select t).SingleOrDefault();
                if (db.ChiTietAlbum.Any(p => p.MaAlbum == s.MaAlbum))
                {
                    MessageBox.Show("This record can't be deleted! Please try again");
                }
                else
                {
                    db.Album.Remove(s);
                }
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txb_MaAlbum.ReadOnly = false;
            btn_Delete.Enabled = false;
            isUpdate = false;

            txb_MaAlbum.Text = "";
            txb_TenAlbum.Text = "";
            txb_GiaTien.Text = "";
            lk_MaNSX.EditValue = null;
        }

        private void check_MaAlb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaAlb.Checked = true;
            check_TenAlb.Checked = false;
            check_Price.Checked = false;
            sortItem = "MaAlb";
        }

        private void check_TenAlb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaAlb.Checked = false;
            check_TenAlb.Checked = true;
            check_Price.Checked = false;
            sortItem = "TenAlb";
        }

        private void check_Price_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaAlb.Checked = false;
            check_TenAlb.Checked = false;
            check_Price.Checked = true;
            sortItem = "Price";
        }

        private void btn_sortAsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.Album
                         select new
                         {
                             MaAlbum = c.MaAlbum,
                             TenAlbum = c.TenAlbum,
                             MaNSX = c.MaNSX,
                             GiaTien = c.GiaTien
                         };
            if (sortItem.Equals("MaAlb"))
            {
                dtGV_Album.DataSource = result.OrderBy(o => o.MaAlbum).ToList();
            }
            else if (sortItem.Equals("TenAlb"))
            {
                dtGV_Album.DataSource = result.OrderBy(o => o.TenAlbum).ToList();
            }
            else
            {
                dtGV_Album.DataSource = result.OrderBy(o => o.GiaTien).ToList();
            }
        }

        private void btn_sortDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.Album
                         select new
                         {
                             MaAlbum = c.MaAlbum,
                             TenAlbum = c.TenAlbum,
                             MaNSX = c.MaNSX,
                             GiaTien = c.GiaTien
                         };
            if (sortItem.Equals("MaAlb"))
            {
                dtGV_Album.DataSource = result.OrderByDescending(o => o.MaAlbum).ToList();
            }
            else if (sortItem.Equals("TenAlb"))
            {
                dtGV_Album.DataSource = result.OrderByDescending(o => o.TenAlbum).ToList();
            }
            else
            {
                dtGV_Album.DataSource = result.OrderByDescending(o => o.GiaTien).ToList();
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
                toExcel(dtGV_Album, saveFileDialog.FileName);
            }
        }
    }
}
