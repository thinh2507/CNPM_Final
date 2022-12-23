
namespace QuanLyCaSi.UI.Modules
{
    partial class ucNhacSi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhacSi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortAsc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortDesc = new DevExpress.XtraBars.BarButtonItem();
            this.check_MaNS = new DevExpress.XtraBars.BarCheckItem();
            this.check_TenNS = new DevExpress.XtraBars.BarCheckItem();
            this.btn_toExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Task = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtGV_NhacSy = new System.Windows.Forms.DataGridView();
            this.txb_GhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txb_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenNS = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaNS = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NhacSy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.barButtonItem2,
            this.btn_sortAsc,
            this.btn_sortDesc,
            this.check_MaNS,
            this.check_TenNS,
            this.btn_toExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(801, 183);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_sortAsc
            // 
            this.btn_sortAsc.Caption = "Sort A to Z";
            this.btn_sortAsc.Id = 15;
            this.btn_sortAsc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btn_sortAsc.Name = "btn_sortAsc";
            this.btn_sortAsc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_sortAsc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sortAsc_ItemClick);
            // 
            // btn_sortDesc
            // 
            this.btn_sortDesc.Caption = "Sort Z to A";
            this.btn_sortDesc.Id = 16;
            this.btn_sortDesc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.btn_sortDesc.Name = "btn_sortDesc";
            this.btn_sortDesc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sortDesc_ItemClick);
            // 
            // check_MaNS
            // 
            this.check_MaNS.Caption = "MaNhacSi";
            this.check_MaNS.Id = 17;
            this.check_MaNS.Name = "check_MaNS";
            this.check_MaNS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_MaNS_ItemClick);
            // 
            // check_TenNS
            // 
            this.check_TenNS.Caption = "TenNhacSi";
            this.check_TenNS.Id = 18;
            this.check_TenNS.Name = "check_TenNS";
            this.check_TenNS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_TenNS_ItemClick);
            // 
            // btn_toExcel
            // 
            this.btn_toExcel.Caption = "To Excel";
            this.btn_toExcel.Id = 20;
            this.btn_toExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.btn_toExcel.Name = "btn_toExcel";
            this.btn_toExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_toExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_toExcel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroup_Task,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribGroup_Task
            // 
            this.ribGroup_Task.ItemLinks.Add(this.btn_Save);
            this.ribGroup_Task.ItemLinks.Add(this.btn_Delete);
            this.ribGroup_Task.ItemLinks.Add(this.btn_Cancel);
            this.ribGroup_Task.Name = "ribGroup_Task";
            this.ribGroup_Task.Text = "Task";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_sortAsc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_sortDesc);
            this.ribbonPageGroup2.ItemLinks.Add(this.check_MaNS);
            this.ribbonPageGroup2.ItemLinks.Add(this.check_TenNS);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sort";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_toExcel);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Export";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtGV_NhacSy);
            this.layoutControl1.Controls.Add(this.txb_GhiChu);
            this.layoutControl1.Controls.Add(this.txb_SDT);
            this.layoutControl1.Controls.Add(this.txb_TenNS);
            this.layoutControl1.Controls.Add(this.txb_MaNS);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 248, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(801, 430);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtGV_NhacSy
            // 
            this.dtGV_NhacSy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_NhacSy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGV_NhacSy.ColumnHeadersHeight = 30;
            this.dtGV_NhacSy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_NhacSy.Location = new System.Drawing.Point(20, 124);
            this.dtGV_NhacSy.Name = "dtGV_NhacSy";
            this.dtGV_NhacSy.RowHeadersWidth = 51;
            this.dtGV_NhacSy.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_NhacSy.RowTemplate.Height = 30;
            this.dtGV_NhacSy.Size = new System.Drawing.Size(761, 286);
            this.dtGV_NhacSy.TabIndex = 8;
            this.dtGV_NhacSy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_NhacSy_CellClick);
            // 
            // txb_GhiChu
            // 
            this.txb_GhiChu.Location = new System.Drawing.Point(509, 72);
            this.txb_GhiChu.MenuManager = this.ribbonControl1;
            this.txb_GhiChu.Name = "txb_GhiChu";
            this.txb_GhiChu.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_GhiChu.Size = new System.Drawing.Size(272, 32);
            this.txb_GhiChu.StyleController = this.layoutControl1;
            this.txb_GhiChu.TabIndex = 7;
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(509, 20);
            this.txb_SDT.MenuManager = this.ribbonControl1;
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_SDT.Size = new System.Drawing.Size(272, 32);
            this.txb_SDT.StyleController = this.layoutControl1;
            this.txb_SDT.TabIndex = 6;
            // 
            // txb_TenNS
            // 
            this.txb_TenNS.Location = new System.Drawing.Point(119, 72);
            this.txb_TenNS.MenuManager = this.ribbonControl1;
            this.txb_TenNS.Name = "txb_TenNS";
            this.txb_TenNS.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_TenNS.Size = new System.Drawing.Size(271, 32);
            this.txb_TenNS.StyleController = this.layoutControl1;
            this.txb_TenNS.TabIndex = 5;
            // 
            // txb_MaNS
            // 
            this.txb_MaNS.Location = new System.Drawing.Point(119, 20);
            this.txb_MaNS.MenuManager = this.ribbonControl1;
            this.txb_MaNS.Name = "txb_MaNS";
            this.txb_MaNS.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_MaNS.Size = new System.Drawing.Size(271, 32);
            this.txb_MaNS.StyleController = this.layoutControl1;
            this.txb_MaNS.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(801, 430);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txb_MaNS;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(390, 52);
            this.layoutControlItem1.Text = "MÃ NHẠC SĨ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txb_TenNS;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(390, 52);
            this.layoutControlItem2.Text = "TÊN NHẠC SĨ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txb_SDT;
            this.layoutControlItem3.Location = new System.Drawing.Point(390, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(391, 52);
            this.layoutControlItem3.Text = "SỐ ĐIỆN THOẠI";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txb_GhiChu;
            this.layoutControlItem4.Location = new System.Drawing.Point(390, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(391, 52);
            this.layoutControlItem4.Text = "GHI CHÚ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtGV_NhacSy;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(781, 306);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(801, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(801, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 613);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(801, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 613);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ucNhacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucNhacSi";
            this.Size = new System.Drawing.Size(801, 613);
            this.Load += new System.EventHandler(this.ucNhacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_NhacSy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Task;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DataGridView dtGV_NhacSy;
        private DevExpress.XtraEditors.TextEdit txb_GhiChu;
        private DevExpress.XtraEditors.TextEdit txb_SDT;
        private DevExpress.XtraEditors.TextEdit txb_TenNS;
        private DevExpress.XtraEditors.TextEdit txb_MaNS;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_sortAsc;
        private DevExpress.XtraBars.BarButtonItem btn_sortDesc;
        private DevExpress.XtraBars.BarCheckItem check_MaNS;
        private DevExpress.XtraBars.BarCheckItem check_TenNS;
        private DevExpress.XtraBars.BarButtonItem btn_toExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
