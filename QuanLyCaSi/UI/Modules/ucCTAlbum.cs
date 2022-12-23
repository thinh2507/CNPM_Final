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
    public partial class ucCTAlbum : DevExpress.XtraEditors.XtraUserControl
    {
        private QuanLyCaSyEntities db = new QuanLyCaSyEntities();
        private bool isUpdate = false;
        private static ucCTAlbum _instance;
        public static ucCTAlbum Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCTAlbum();
                return _instance;
            }
        }
        public ucCTAlbum()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            var result = from c in db.ChiTietAlbum
                         select new
                         {
                             MaAlbum = c.MaAlbum,
                             MaBH = c.MaBaiHat,
                             MaCS = c.MaCaSi
                         };
            dtGV_CT_Album.DataSource = result.ToList();
        }
        public void init()
        {
            lk_Album.Properties.DataSource = db.Album.ToList();
            lk_Album.Properties.DisplayMember = "TenAlbum";
            lk_Album.Properties.ValueMember = "MaAlbum";

            lk_BaiHat.Properties.DataSource = db.BaiHat.ToList();
            lk_BaiHat.Properties.DisplayMember = "TenBaiHat";
            lk_BaiHat.Properties.ValueMember = "MaBaiHat";

            lk_CaSi.Properties.DataSource = db.CaSi.ToList();
            lk_CaSi.Properties.DisplayMember = "TenCaSi";
            lk_CaSi.Properties.ValueMember = "MaCaSi";
        }

        private void ucCTAlbum_Load(object sender, EventArgs e)
        {
            loadData();
            init();
            btn_Delete.Enabled = false;
        }

        private void dtGV_CT_Album_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtGV_CT_Album.Rows[e.RowIndex];

                lk_CaSi.EditValue = r.Cells[2].Value.ToString();
                lk_BaiHat.EditValue = r.Cells[1].Value.ToString();
                lk_Album.EditValue = r.Cells[0].Value.ToString();

                //lk_CaSi.Enabled = false;
                //lk_Album.Enabled = false;
                //lk_BaiHat.Enabled = false;
                btn_Delete.Enabled = true;
                isUpdate = true;
            }
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Update
            if (isUpdate == true)
            {
                var s = (from t in db.ChiTietAlbum where t.MaAlbum == lk_Album.EditValue.ToString() select t).SingleOrDefault();
                s.MaAlbum = lk_Album.EditValue.ToString();
                s.MaBaiHat = lk_BaiHat.EditValue.ToString();
                s.MaCaSi = lk_CaSi.EditValue.ToString();
            }
            // Insert
            else
            {
                if (String.IsNullOrWhiteSpace(lk_Album.EditValue.ToString())
                                || String.IsNullOrWhiteSpace(lk_BaiHat.EditValue.ToString())
                                || String.IsNullOrWhiteSpace(lk_CaSi.EditValue.ToString()))
                {
                    MessageBox.Show("Insert failed. Please try again!");
                }
                else
                {
                    ChiTietAlbum t = new ChiTietAlbum()
                    {
                        MaAlbum = lk_Album.EditValue.ToString(),
                        MaBaiHat = lk_BaiHat.EditValue.ToString(),
                        MaCaSi = lk_CaSi.EditValue.ToString()

                    };
                    db.ChiTietAlbum.Add(t);
                    db.SaveChanges();
                    loadData();
                }
            }
            db.SaveChanges();
            loadData();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in db.ChiTietAlbum where t.MaAlbum == lk_Album.EditValue.ToString() 
                    & t.MaBaiHat == lk_BaiHat.EditValue.ToString() 
                    & t.MaCaSi == lk_CaSi.EditValue.ToString() select t).SingleOrDefault();
                db.ChiTietAlbum.Remove(s);
                db.SaveChanges();
                loadData();
            }
        }

        private void btn_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lk_Album.Enabled = true;
            //lk_BaiHat.Enabled = true;
            //lk_CaSi.Enabled = true;
            btn_Delete.Enabled = false;
            isUpdate = false;

            lk_Album.EditValue = null;
            lk_BaiHat.EditValue = null;
            lk_CaSi.EditValue = null;
        }
    }
}
