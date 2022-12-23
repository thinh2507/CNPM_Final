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
    public partial class ucNSX : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private String sortItem = "";
        private static ucNSX _instance;
        public static ucNSX Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNSX();
                return _instance;
            }
        }
        public ucNSX()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            var result = from c in db.NhaSanXuat
                         select new
                         {
                             MaNSX = c.MaNSX,
                             TenCty = c.TenCty,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            dtGV_NSX.DataSource = result.ToList();
        }

        private void ucNSX_Load(object sender, EventArgs e)
        {
            loadData();
            btn_Delete.Enabled = false;
        }

        private void dtGV_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_NSX.Rows[e.RowIndex];
                txb_MaNSX.Text = r.Cells[0].Value.ToString();
                txb_TenCty.Text = r.Cells[1].Value.ToString();
                txb_DiaChi.Text = r.Cells[2].Value.ToString();
                txb_SDT.Text = r.Cells[3].Value.ToString();

                txb_MaNSX.ReadOnly = true;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.NhaSanXuat where t.MaNSX == txb_MaNSX.Text select t).SingleOrDefault();
                s.TenCty = txb_TenCty.Text;
                s.DiaChi = txb_DiaChi.Text;
                s.SDT = txb_SDT.Text;
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(txb_MaNSX.Text)
                                || String.IsNullOrWhiteSpace(txb_TenCty.Text)
                                || String.IsNullOrWhiteSpace(txb_DiaChi.Text)
                                || String.IsNullOrWhiteSpace(txb_SDT.Text)
                                || (db.NhaSanXuat.Any(p => p.MaNSX == txb_MaNSX.Text.Trim())))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    NhaSanXuat nsx = new NhaSanXuat()
                    {
                        MaNSX = txb_MaNSX.Text.Trim(),
                        TenCty = txb_TenCty.Text.Trim(),
                        DiaChi = txb_DiaChi.Text.Trim(),
                        SDT = txb_SDT.Text.Trim()
                    };
                    db.NhaSanXuat.Add(nsx);

                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.NhaSanXuat where t.MaNSX == txb_MaNSX.Text select t).SingleOrDefault();
                if (db.Album.Any(p => p.MaNSX == s.MaNSX))
                {
                    MessageBox.Show("This record can't be deleted! Please try again");
                }
                else
                {
                    db.NhaSanXuat.Remove(s);
                }
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txb_MaNSX.ReadOnly = false;
            btn_Delete.Enabled = false;
            isUpdate = false;
            txb_MaNSX.Text = "";
            txb_TenCty.Text = "";
            txb_DiaChi.Text = "";
            txb_SDT.Text = "";
        }

        private void check_MaNSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaNSX.Checked = true;
            check_TenCty.Checked = false;
            sortItem = "MaNSX";
        }

        private void check_TenCty_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check_MaNSX.Checked = false;
            check_TenCty.Checked = true;
            sortItem = "TenCty";
        }

        private void btn_sortAsc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.NhaSanXuat
                         select new
                         {
                             MaNSX = c.MaNSX,
                             TenCty = c.TenCty,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaNSX"))
            {
                dtGV_NSX.DataSource = result.OrderBy(o => o.MaNSX).ToList();
            }
            else
            {
                dtGV_NSX.DataSource = result.OrderBy(o => o.TenCty).ToList();
            }
        }

        private void btn_sortDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = from c in db.NhaSanXuat
                         select new
                         {
                             MaNSX = c.MaNSX,
                             TenCty = c.TenCty,
                             DiaChi = c.DiaChi,
                             SDT = c.SDT
                         };
            if (sortItem.Equals("MaNSX"))
            {
                dtGV_NSX.DataSource = result.OrderByDescending(o => o.MaNSX).ToList();
            }
            else
            {
                dtGV_NSX.DataSource = result.OrderByDescending(o => o.TenCty).ToList();
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
                toExcel(dtGV_NSX, saveFileDialog.FileName);
            }
        }
    }
}
