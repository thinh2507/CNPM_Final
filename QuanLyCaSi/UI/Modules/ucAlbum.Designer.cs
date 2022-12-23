
namespace QuanLyCaSi.UI.Modules
{
    partial class ucAlbum
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAlbum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortAsc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortDesc = new DevExpress.XtraBars.BarButtonItem();
            this.check_MaAlb = new DevExpress.XtraBars.BarCheckItem();
            this.check_TenAlb = new DevExpress.XtraBars.BarCheckItem();
            this.check_Price = new DevExpress.XtraBars.BarCheckItem();
            this.btn_toExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Save = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Delete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Cancel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtGV_Album = new System.Windows.Forms.DataGridView();
            this.lk_MaNSX = new DevExpress.XtraEditors.LookUpEdit();
            this.txb_GiaTien = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenAlbum = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaAlbum = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_MaNSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenAlbum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaAlbum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_Save,
            this.btn_Delete,
            this.btn_Cancel,
            this.btn_sortAsc,
            this.btn_sortDesc,
            this.check_MaAlb,
            this.check_TenAlb,
            this.check_Price,
            this.btn_toExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(864, 183);
            // 
            // btn_Save
            // 
            this.btn_Save.Caption = "Save";
            this.btn_Save.Id = 1;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Save_ItemClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Delete";
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Delete_ItemClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Caption = "Cancel";
            this.btn_Cancel.Id = 3;
            this.btn_Cancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Cancel.ImageOptions.SvgImage")));
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Cancel_ItemClick);
            // 
            // btn_sortAsc
            // 
            this.btn_sortAsc.Caption = "Sort A to Z";
            this.btn_sortAsc.Id = 4;
            this.btn_sortAsc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btn_sortAsc.Name = "btn_sortAsc";
            this.btn_sortAsc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sortAsc_ItemClick);
            // 
            // btn_sortDesc
            // 
            this.btn_sortDesc.Caption = "Sort Z to A";
            this.btn_sortDesc.Id = 5;
            this.btn_sortDesc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btn_sortDesc.Name = "btn_sortDesc";
            this.btn_sortDesc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sortDesc_ItemClick);
            // 
            // check_MaAlb
            // 
            this.check_MaAlb.Caption = "MaAlbum";
            this.check_MaAlb.Id = 6;
            this.check_MaAlb.Name = "check_MaAlb";
            this.check_MaAlb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_MaAlb_ItemClick);
            // 
            // check_TenAlb
            // 
            this.check_TenAlb.Caption = "TenAlbum";
            this.check_TenAlb.Id = 7;
            this.check_TenAlb.Name = "check_TenAlb";
            this.check_TenAlb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_TenAlb_ItemClick);
            // 
            // check_Price
            // 
            this.check_Price.Caption = "GiaTien";
            this.check_Price.Id = 8;
            this.check_Price.Name = "check_Price";
            this.check_Price.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_Price_ItemClick);
            // 
            // btn_toExcel
            // 
            this.btn_toExcel.Caption = "To Excel";
            this.btn_toExcel.Id = 9;
            this.btn_toExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.btn_toExcel.Name = "btn_toExcel";
            this.btn_toExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_toExcel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroup_Save,
            this.ribGroup_Delete,
            this.ribGroup_Cancel});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribGroup_Save
            // 
            this.ribGroup_Save.ItemLinks.Add(this.btn_Save);
            this.ribGroup_Save.ItemLinks.Add(this.btn_Delete);
            this.ribGroup_Save.ItemLinks.Add(this.btn_Cancel);
            this.ribGroup_Save.Name = "ribGroup_Save";
            this.ribGroup_Save.Text = "Task";
            // 
            // ribGroup_Delete
            // 
            this.ribGroup_Delete.ItemLinks.Add(this.btn_sortAsc);
            this.ribGroup_Delete.ItemLinks.Add(this.btn_sortDesc);
            this.ribGroup_Delete.ItemLinks.Add(this.check_MaAlb);
            this.ribGroup_Delete.ItemLinks.Add(this.check_TenAlb);
            this.ribGroup_Delete.ItemLinks.Add(this.check_Price);
            this.ribGroup_Delete.Name = "ribGroup_Delete";
            this.ribGroup_Delete.Text = "Sort";
            // 
            // ribGroup_Cancel
            // 
            this.ribGroup_Cancel.ItemLinks.Add(this.btn_toExcel);
            this.ribGroup_Cancel.Name = "ribGroup_Cancel";
            this.ribGroup_Cancel.Text = "Export";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtGV_Album);
            this.layoutControl1.Controls.Add(this.lk_MaNSX);
            this.layoutControl1.Controls.Add(this.txb_GiaTien);
            this.layoutControl1.Controls.Add(this.txb_TenAlbum);
            this.layoutControl1.Controls.Add(this.txb_MaAlbum);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 166, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(864, 348);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtGV_Album
            // 
            this.dtGV_Album.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_Album.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_Album.ColumnHeadersHeight = 30;
            this.dtGV_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_Album.Location = new System.Drawing.Point(12, 116);
            this.dtGV_Album.Name = "dtGV_Album";
            this.dtGV_Album.RowHeadersWidth = 51;
            this.dtGV_Album.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_Album.RowTemplate.Height = 30;
            this.dtGV_Album.Size = new System.Drawing.Size(840, 220);
            this.dtGV_Album.TabIndex = 9;
            this.dtGV_Album.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_Album_CellClick);
            // 
            // lk_MaNSX
            // 
            this.lk_MaNSX.Location = new System.Drawing.Point(115, 72);
            this.lk_MaNSX.MenuManager = this.ribbonControl1;
            this.lk_MaNSX.Name = "lk_MaNSX";
            this.lk_MaNSX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_MaNSX.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.lk_MaNSX.Size = new System.Drawing.Size(307, 32);
            this.lk_MaNSX.StyleController = this.layoutControl1;
            this.lk_MaNSX.TabIndex = 8;
            // 
            // txb_GiaTien
            // 
            this.txb_GiaTien.Location = new System.Drawing.Point(537, 72);
            this.txb_GiaTien.MenuManager = this.ribbonControl1;
            this.txb_GiaTien.Name = "txb_GiaTien";
            this.txb_GiaTien.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_GiaTien.Size = new System.Drawing.Size(307, 32);
            this.txb_GiaTien.StyleController = this.layoutControl1;
            this.txb_GiaTien.TabIndex = 7;
            // 
            // txb_TenAlbum
            // 
            this.txb_TenAlbum.Location = new System.Drawing.Point(537, 20);
            this.txb_TenAlbum.MenuManager = this.ribbonControl1;
            this.txb_TenAlbum.Name = "txb_TenAlbum";
            this.txb_TenAlbum.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_TenAlbum.Size = new System.Drawing.Size(307, 32);
            this.txb_TenAlbum.StyleController = this.layoutControl1;
            this.txb_TenAlbum.TabIndex = 5;
            // 
            // txb_MaAlbum
            // 
            this.txb_MaAlbum.Location = new System.Drawing.Point(115, 20);
            this.txb_MaAlbum.MenuManager = this.ribbonControl1;
            this.txb_MaAlbum.Name = "txb_MaAlbum";
            this.txb_MaAlbum.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_MaAlbum.Size = new System.Drawing.Size(307, 32);
            this.txb_MaAlbum.StyleController = this.layoutControl1;
            this.txb_MaAlbum.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(864, 348);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txb_MaAlbum;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(422, 52);
            this.layoutControlItem1.Text = "MÃ ALBUM";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(92, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txb_TenAlbum;
            this.layoutControlItem2.Location = new System.Drawing.Point(422, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(422, 52);
            this.layoutControlItem2.Text = "TÊN ALBUM";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txb_GiaTien;
            this.layoutControlItem4.Location = new System.Drawing.Point(422, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(422, 52);
            this.layoutControlItem4.Text = "GIÁ TIỀN";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(92, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lk_MaNSX;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(422, 52);
            this.layoutControlItem3.Text = "NHÀ SẢN XUẤT";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtGV_Album;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(844, 224);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucAlbum";
            this.Size = new System.Drawing.Size(864, 531);
            this.Load += new System.EventHandler(this.ucAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_Album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_MaNSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenAlbum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaAlbum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Save;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Delete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Cancel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txb_GiaTien;
        private DevExpress.XtraEditors.TextEdit txb_TenAlbum;
        private DevExpress.XtraEditors.TextEdit txb_MaAlbum;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.DataGridView dtGV_Album;
        private DevExpress.XtraEditors.LookUpEdit lk_MaNSX;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btn_sortAsc;
        private DevExpress.XtraBars.BarButtonItem btn_sortDesc;
        private DevExpress.XtraBars.BarCheckItem check_MaAlb;
        private DevExpress.XtraBars.BarCheckItem check_TenAlb;
        private DevExpress.XtraBars.BarCheckItem check_Price;
        private DevExpress.XtraBars.BarButtonItem btn_toExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
