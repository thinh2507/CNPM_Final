
namespace QuanLyCaSi.UI.Modules
{
    partial class ucNSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNSX));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortAsc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortDesc = new DevExpress.XtraBars.BarButtonItem();
            this.check_MaNSX = new DevExpress.XtraBars.BarCheckItem();
            this.check_TenCty = new DevExpress.XtraBars.BarCheckItem();
            this.btn_toExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Save = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Delete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Cancel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtGV_NSX = new System.Windows.Forms.DataGridView();
            this.txb_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenCty = new DevExpress.XtraEditors.TextEdit();
            this.txb_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaNSX = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenCty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.check_MaNSX,
            this.check_TenCty,
            this.btn_toExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(828, 183);
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
            // check_MaNSX
            // 
            this.check_MaNSX.Caption = "MaNSX";
            this.check_MaNSX.Id = 6;
            this.check_MaNSX.Name = "check_MaNSX";
            this.check_MaNSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_MaNSX_ItemClick);
            // 
            // check_TenCty
            // 
            this.check_TenCty.Caption = "TenCongTy";
            this.check_TenCty.Id = 7;
            this.check_TenCty.Name = "check_TenCty";
            this.check_TenCty.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_TenCty_ItemClick);
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
            this.ribGroup_Delete.ItemLinks.Add(this.check_MaNSX);
            this.ribGroup_Delete.ItemLinks.Add(this.check_TenCty);
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
            this.layoutControl1.Controls.Add(this.dtGV_NSX);
            this.layoutControl1.Controls.Add(this.txb_SDT);
            this.layoutControl1.Controls.Add(this.txb_TenCty);
            this.layoutControl1.Controls.Add(this.txb_DiaChi);
            this.layoutControl1.Controls.Add(this.txb_MaNSX);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 163, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(828, 345);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtGV_NSX
            // 
            this.dtGV_NSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_NSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_NSX.ColumnHeadersHeight = 30;
            this.dtGV_NSX.Location = new System.Drawing.Point(20, 124);
            this.dtGV_NSX.Name = "dtGV_NSX";
            this.dtGV_NSX.RowHeadersWidth = 51;
            this.dtGV_NSX.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_NSX.RowTemplate.Height = 30;
            this.dtGV_NSX.Size = new System.Drawing.Size(788, 201);
            this.dtGV_NSX.TabIndex = 8;
            this.dtGV_NSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_NSX_CellClick);
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(541, 72);
            this.txb_SDT.MenuManager = this.ribbonControl1;
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_SDT.Size = new System.Drawing.Size(267, 32);
            this.txb_SDT.StyleController = this.layoutControl1;
            this.txb_SDT.TabIndex = 7;
            // 
            // txb_TenCty
            // 
            this.txb_TenCty.Location = new System.Drawing.Point(137, 72);
            this.txb_TenCty.MenuManager = this.ribbonControl1;
            this.txb_TenCty.Name = "txb_TenCty";
            this.txb_TenCty.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_TenCty.Size = new System.Drawing.Size(267, 32);
            this.txb_TenCty.StyleController = this.layoutControl1;
            this.txb_TenCty.TabIndex = 6;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(541, 20);
            this.txb_DiaChi.MenuManager = this.ribbonControl1;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_DiaChi.Size = new System.Drawing.Size(267, 32);
            this.txb_DiaChi.StyleController = this.layoutControl1;
            this.txb_DiaChi.TabIndex = 5;
            // 
            // txb_MaNSX
            // 
            this.txb_MaNSX.Location = new System.Drawing.Point(137, 20);
            this.txb_MaNSX.MenuManager = this.ribbonControl1;
            this.txb_MaNSX.Name = "txb_MaNSX";
            this.txb_MaNSX.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_MaNSX.Size = new System.Drawing.Size(267, 32);
            this.txb_MaNSX.StyleController = this.layoutControl1;
            this.txb_MaNSX.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(828, 345);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txb_MaNSX;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem1.Text = "MÃ NHÀ SẢN XUẤT";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txb_DiaChi;
            this.layoutControlItem2.Location = new System.Drawing.Point(404, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem2.Text = "ĐỊA CHỈ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txb_TenCty;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem3.Text = "TÊN CÔNG TY";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(114, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txb_SDT;
            this.layoutControlItem4.Location = new System.Drawing.Point(404, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(404, 52);
            this.layoutControlItem4.Text = "SỐ ĐIỆN THOẠI";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtGV_NSX;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(808, 221);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucNSX";
            this.Size = new System.Drawing.Size(828, 528);
            this.Load += new System.EventHandler(this.ucNSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenCty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private System.Windows.Forms.DataGridView dtGV_NSX;
        private DevExpress.XtraEditors.TextEdit txb_SDT;
        private DevExpress.XtraEditors.TextEdit txb_TenCty;
        private DevExpress.XtraEditors.TextEdit txb_DiaChi;
        private DevExpress.XtraEditors.TextEdit txb_MaNSX;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarButtonItem btn_sortAsc;
        private DevExpress.XtraBars.BarButtonItem btn_sortDesc;
        private DevExpress.XtraBars.BarCheckItem check_MaNSX;
        private DevExpress.XtraBars.BarCheckItem check_TenCty;
        private DevExpress.XtraBars.BarButtonItem btn_toExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
