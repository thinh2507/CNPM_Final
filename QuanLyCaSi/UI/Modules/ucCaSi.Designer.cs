
namespace QuanLyCaSi.UI.Modules
{
    partial class ucCaSi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCaSi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txb_SDT = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortAsc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sortDesc = new DevExpress.XtraBars.BarButtonItem();
            this.check_MaCS = new DevExpress.XtraBars.BarCheckItem();
            this.check_TenCS = new DevExpress.XtraBars.BarCheckItem();
            this.btn_toExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Save = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Delete = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroup_Cancel = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txb_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txb_TenCS = new DevExpress.XtraEditors.TextEdit();
            this.txb_MaCS = new DevExpress.XtraEditors.TextEdit();
            this.dtGV_CaSi = new System.Windows.Forms.DataGridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_CaSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txb_SDT);
            this.layoutControl1.Controls.Add(this.txb_DiaChi);
            this.layoutControl1.Controls.Add(this.txb_TenCS);
            this.layoutControl1.Controls.Add(this.txb_MaCS);
            this.layoutControl1.Controls.Add(this.dtGV_CaSi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(973, 223, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(992, 415);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(602, 72);
            this.txb_SDT.MenuManager = this.ribbonControl1;
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_SDT.Size = new System.Drawing.Size(370, 32);
            this.txb_SDT.StyleController = this.layoutControl1;
            this.txb_SDT.TabIndex = 8;
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
            this.check_MaCS,
            this.check_TenCS,
            this.btn_toExcel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(992, 183);
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
            // check_MaCS
            // 
            this.check_MaCS.Caption = "MaCaSi";
            this.check_MaCS.Id = 8;
            this.check_MaCS.Name = "check_MaCS";
            this.check_MaCS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_MaCS_ItemClick);
            // 
            // check_TenCS
            // 
            this.check_TenCS.Caption = "TenCaSi";
            this.check_TenCS.Id = 9;
            this.check_TenCS.Name = "check_TenCS";
            this.check_TenCS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.check_TenCS_ItemClick);
            // 
            // btn_toExcel
            // 
            this.btn_toExcel.Caption = "To Excel";
            this.btn_toExcel.Id = 11;
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
            this.ribGroup_Delete.ItemLinks.Add(this.check_MaCS);
            this.ribGroup_Delete.ItemLinks.Add(this.check_TenCS);
            this.ribGroup_Delete.Name = "ribGroup_Delete";
            this.ribGroup_Delete.Text = "Sort";
            // 
            // ribGroup_Cancel
            // 
            this.ribGroup_Cancel.ItemLinks.Add(this.btn_toExcel);
            this.ribGroup_Cancel.Name = "ribGroup_Cancel";
            this.ribGroup_Cancel.Text = "Export";
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(602, 20);
            this.txb_DiaChi.MenuManager = this.ribbonControl1;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_DiaChi.Size = new System.Drawing.Size(370, 32);
            this.txb_DiaChi.StyleController = this.layoutControl1;
            this.txb_DiaChi.TabIndex = 7;
            // 
            // txb_TenCS
            // 
            this.txb_TenCS.Location = new System.Drawing.Point(119, 72);
            this.txb_TenCS.MenuManager = this.ribbonControl1;
            this.txb_TenCS.Name = "txb_TenCS";
            this.txb_TenCS.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_TenCS.Size = new System.Drawing.Size(364, 32);
            this.txb_TenCS.StyleController = this.layoutControl1;
            this.txb_TenCS.TabIndex = 6;
            // 
            // txb_MaCS
            // 
            this.txb_MaCS.Location = new System.Drawing.Point(119, 20);
            this.txb_MaCS.MenuManager = this.ribbonControl1;
            this.txb_MaCS.Name = "txb_MaCS";
            this.txb_MaCS.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.txb_MaCS.Size = new System.Drawing.Size(364, 32);
            this.txb_MaCS.StyleController = this.layoutControl1;
            this.txb_MaCS.TabIndex = 5;
            // 
            // dtGV_CaSi
            // 
            this.dtGV_CaSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_CaSi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGV_CaSi.ColumnHeadersHeight = 30;
            this.dtGV_CaSi.Location = new System.Drawing.Point(20, 124);
            this.dtGV_CaSi.Name = "dtGV_CaSi";
            this.dtGV_CaSi.RowHeadersWidth = 51;
            this.dtGV_CaSi.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_CaSi.RowTemplate.Height = 30;
            this.dtGV_CaSi.Size = new System.Drawing.Size(952, 271);
            this.dtGV_CaSi.TabIndex = 4;
            this.dtGV_CaSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_CaSi_CellClick);
            // 
            // Root
            // 
            this.Root.AllowDrawBackground = false;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(992, 415);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtGV_CaSi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(972, 291);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txb_MaCS;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(483, 52);
            this.layoutControlItem2.Text = "MÃ CA SĨ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txb_TenCS;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(483, 52);
            this.layoutControlItem3.Text = "TÊN CA SĨ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txb_DiaChi;
            this.layoutControlItem4.Location = new System.Drawing.Point(483, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(489, 52);
            this.layoutControlItem4.Text = "ĐỊA CHỈ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txb_SDT;
            this.layoutControlItem5.Location = new System.Drawing.Point(483, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(489, 52);
            this.layoutControlItem5.Text = "SỐ ĐIỆN THOẠI";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 17);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sort";
            // 
            // ucCaSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucCaSi";
            this.Size = new System.Drawing.Size(992, 598);
            this.Load += new System.EventHandler(this.ucCaSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txb_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_TenCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_MaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_CaSi)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txb_SDT;
        private DevExpress.XtraEditors.TextEdit txb_DiaChi;
        private DevExpress.XtraEditors.TextEdit txb_TenCS;
        private DevExpress.XtraEditors.TextEdit txb_MaCS;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.DataGridView dtGV_CaSi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Save;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Cancel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Save;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Delete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup_Cancel;
        private DevExpress.XtraBars.BarButtonItem btn_sortAsc;
        private DevExpress.XtraBars.BarButtonItem btn_sortDesc;
        private DevExpress.XtraBars.BarCheckItem check_MaCS;
        private DevExpress.XtraBars.BarCheckItem check_TenCS;
        private DevExpress.XtraBars.BarButtonItem btn_toExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
