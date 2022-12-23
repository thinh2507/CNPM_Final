using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevExpress.DXperience.Demos;
using QuanLyCaSi.UI.Modules;

namespace QuanLyCaSi
{
    public partial class formMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private async void formMain_Load(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_CaSi.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucCaSi.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucCaSi.Instance);
                ucCaSi.Instance.Dock = DockStyle.Fill;
                ucCaSi.Instance.BringToFront();
            }
            else
                ucCaSi.Instance.BringToFront();
        }

        private void controlElement_CaSi_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_CaSi.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucCaSi.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucCaSi.Instance);
                ucCaSi.Instance.Dock = DockStyle.Fill;
                ucCaSi.Instance.BringToFront();
            }
            else
                ucCaSi.Instance.BringToFront();
        }

        private void controlElement_Album_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_Album.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucAlbum.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucAlbum.Instance);
                ucAlbum.Instance.Dock = DockStyle.Fill;
                ucAlbum.Instance.BringToFront();
            }
            else
                ucAlbum.Instance.BringToFront();
        }

        private void controlElement_NSX_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_NSX.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucNSX.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucNSX.Instance);
                ucNSX.Instance.Dock = DockStyle.Fill;
                ucNSX.Instance.BringToFront();
            }
            else
                ucNSX.Instance.BringToFront();
        }

        private void controlElement_NhacSi_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_NhacSi.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucNhacSi.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucNhacSi.Instance);
                ucNhacSi.Instance.Dock = DockStyle.Fill;
                ucNhacSi.Instance.BringToFront();
            }
            else
                ucNhacSi.Instance.BringToFront();
        }

        private void controlElement_BaiHat_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_BaiHat.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucBaiHat.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucBaiHat.Instance);
                ucBaiHat.Instance.Dock = DockStyle.Fill;
                ucBaiHat.Instance.BringToFront();
            }
            else
                ucBaiHat.Instance.BringToFront();
        }

        private void controlElement_CTAlbum_Click(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{controlGroup_DanhMuc.Text}/{controlElement_CTAlbum.Text}";
            if (!fluentDesignFormContainer.Controls.Contains(ucCTAlbum.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucCTAlbum.Instance);
                ucCTAlbum.Instance.Dock = DockStyle.Fill;
                ucCTAlbum.Instance.BringToFront();
            }
            else
                ucCTAlbum.Instance.BringToFront();
        }
    }
}
