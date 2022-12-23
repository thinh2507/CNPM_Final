
namespace QuanLyCaSi.UI.Modules
{
    partial class ucBaiHat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBaiHat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortAsc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortDesc = new DevExpress.XtraBars.BarButtonItem();
            this.check_MaBH = new DevExpress.XtraBars.BarCheckItem();
            this.check_TenBH = new DevExpress.XtraBars.BarCheckItem();
            this.btn_toExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Save = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Delete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Cancel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lk_MaNS = new DevExpress.XtraEditors.LookUpEdit();
            this.dtGV_BaiHat = new System.Windows.Forms.DataGridView();
            this.txb_GhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txb_GiaiDieu = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenBH = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaBH = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_MaNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_BaiHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaiDieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenBH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaBH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.check_MaBH,
            this.check_TenBH,
            this.btn_toExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(827, 183);
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
            // check_MaBH
            // 
            this.check_MaBH.Caption = "MaBaiHat";
            this.check_MaBH.Id = 6;
            this.check_MaBH.Name = "check_MaBH";
            this.check_MaBH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_MaBH_ItemClick);
            // 
            // check_TenBH
            // 
            this.check_TenBH.Caption = "TenBaiHat";
            this.check_TenBH.Id = 7;
            this.check_TenBH.Name = "check_TenBH";
            this.check_TenBH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_TenBH_ItemClick);
            // 
            // btn_toExcel
            // 
            this.btn_toExcel.Caption = "To Excel";
            this.btn_toExcel.Id = 8;
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
            this.ribGroup_Delete.ItemLinks.Add(this.check_MaBH);
            this.ribGroup_Delete.ItemLinks.Add(this.check_TenBH);
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
            this.layoutControl1.Controls.Add(this.lk_MaNS);
            this.layoutControl1.Controls.Add(this.dtGV_BaiHat);
            this.layoutControl1.Controls.Add(this.txb_GhiChu);
            this.layoutControl1.Controls.Add(this.txb_GiaiDieu);
            this.layoutControl1.Controls.Add(this.txb_TenBH);
            this.layoutControl1.Controls.Add(this.txb_MaBH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 163, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(827, 345);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lk_MaNS
            // 
            this.lk_MaNS.Location = new System.Drawing.Point(97, 72);
            this.lk_MaNS.MenuManager = this.ribbonControl1;
            this.lk_MaNS.Name = "lk_MaNS";
            this.lk_MaNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_MaNS.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.lk_MaNS.Size = new System.Drawing.Size(306, 32);
            this.lk_MaNS.StyleController = this.layoutControl1;
            this.lk_MaNS.TabIndex = 10;
            // 
            // dtGV_BaiHat
            // 
            this.dtGV_BaiHat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_BaiHat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_BaiHat.ColumnHeadersHeight = 30;
            this.dtGV_BaiHat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_BaiHat.Location = new System.Drawing.Point(20, 176);
            this.dtGV_BaiHat.Name = "dtGV_BaiHat";
            this.dtGV_BaiHat.RowHeadersWidth = 51;
            this.dtGV_BaiHat.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_BaiHat.RowTemplate.Height = 30;
            this.dtGV_BaiHat.Size = new System.Drawing.Size(787, 149);
            this.dtGV_BaiHat.TabIndex = 9;
            this.dtGV_BaiHat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_BaiHat_CellClick);
            // 
            // txb_GhiChu
            // 
            this.txb_GhiChu.Location = new System.Drawing.Point(97, 124);
            this.txb_GhiChu.MenuManager = this.ribbonControl1;
            this.txb_GhiChu.Name = "txb_GhiChu";
            this.txb_GhiChu.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_GhiChu.Size = new System.Drawing.Size(306, 32);
            this.txb_GhiChu.StyleController = this.layoutControl1;
            this.txb_GhiChu.TabIndex = 8;
            // 
            // txb_GiaiDieu
            // 
            this.txb_GiaiDieu.Location = new System.Drawing.Point(500, 72);
            this.txb_GiaiDieu.MenuManager = this.ribbonControl1;
            this.txb_GiaiDieu.Name = "txb_GiaiDieu";
            this.txb_GiaiDieu.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_GiaiDieu.Size = new System.Drawing.Size(307, 32);
            this.txb_GiaiDieu.StyleController = this.layoutControl1;
            this.txb_GiaiDieu.TabIndex = 6;
            // 
            // txb_TenBH
            // 
            this.txb_TenBH.Location = new System.Drawing.Point(500, 20);
            this.txb_TenBH.MenuManager = this.ribbonControl1;
            this.txb_TenBH.Name = "txb_TenBH";
            this.txb_TenBH.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_TenBH.Size = new System.Drawing.Size(307, 32);
            this.txb_TenBH.StyleController = this.layoutControl1;
            this.txb_TenBH.TabIndex = 5;
            // 
            // txb_MaBH
            // 
            this.txb_MaBH.Location = new System.Drawing.Point(97, 20);
            this.txb_MaBH.MenuManager = this.ribbonControl1;
            this.txb_MaBH.Name = "txb_MaBH";
            this.txb_MaBH.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_MaBH.Size = new System.Drawing.Size(306, 32);
            this.txb_MaBH.StyleController = this.layoutControl1;
            this.txb_MaBH.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(827, 345);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txb_MaBH;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(403, 52);
            this.layoutControlItem1.Text = "MÃ BÀI HÁT";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txb_TenBH;
            this.layoutControlItem2.Location = new System.Drawing.Point(403, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem2.Text = "TÊN BÀI HÁT";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txb_GiaiDieu;
            this.layoutControlItem3.Location = new System.Drawing.Point(403, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem3.Text = "GIAI ĐIỆU";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txb_GhiChu;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(403, 52);
            this.layoutControlItem5.Text = "GHI CHÚ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(74, 16);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(403, 104);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(404, 52);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dtGV_BaiHat;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(807, 169);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lk_MaNS;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(403, 52);
            this.layoutControlItem4.Text = "NHẠC SĨ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(74, 17);
            // 
            // ucBaiHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucBaiHat";
            this.Size = new System.Drawing.Size(827, 528);
            this.Load += new System.EventHandler(this.ucBaiHat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lk_MaNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_BaiHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GiaiDieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenBH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaBH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit lk_MaNS;
        private System.Windows.Forms.DataGridView dtGV_BaiHat;
        private DevExpress.XtraEditors.TextEdit txb_GhiChu;
        private DevExpress.XtraEditors.TextEdit txb_GiaiDieu;
        private DevExpress.XtraEditors.TextEdit txb_TenBH;
        private DevExpress.XtraEditors.TextEdit txb_MaBH;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarButtonItem btn_sortAsc;
        private DevExpress.XtraBars.BarButtonItem btn_sortDesc;
        private DevExpress.XtraBars.BarCheckItem check_MaBH;
        private DevExpress.XtraBars.BarCheckItem check_TenBH;
        private DevExpress.XtraBars.BarButtonItem btn_toExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
