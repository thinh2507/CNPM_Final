
namespace QuanLyCaSi.UI.Modules
{
    partial class ucCTAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCTAlbum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroup_Save = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtGV_CT_Album = new System.Windows.Forms.DataGridView();
            this.lk_CaSi = new DevExpress.XtraEditors.LookUpEdit();
            this.lk_BaiHat = new DevExpress.XtraEditors.LookUpEdit();
            this.lk_Album = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_CT_Album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_CaSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_BaiHat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Album.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.btn_Cancel});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(752, 183);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroup_Save});
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtGV_CT_Album);
            this.layoutControl1.Controls.Add(this.lk_CaSi);
            this.layoutControl1.Controls.Add(this.lk_BaiHat);
            this.layoutControl1.Controls.Add(this.lk_Album);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 183);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 110, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(752, 292);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtGV_CT_Album
            // 
            this.dtGV_CT_Album.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGV_CT_Album.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGV_CT_Album.ColumnHeadersHeight = 30;
            this.dtGV_CT_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV_CT_Album.Location = new System.Drawing.Point(20, 176);
            this.dtGV_CT_Album.Name = "dtGV_CT_Album";
            this.dtGV_CT_Album.RowHeadersWidth = 51;
            this.dtGV_CT_Album.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGV_CT_Album.RowTemplate.Height = 30;
            this.dtGV_CT_Album.Size = new System.Drawing.Size(712, 96);
            this.dtGV_CT_Album.TabIndex = 7;
            this.dtGV_CT_Album.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV_CT_Album_CellClick);
            // 
            // lk_CaSi
            // 
            this.lk_CaSi.Location = new System.Drawing.Point(70, 124);
            this.lk_CaSi.MenuManager = this.ribbonControl1;
            this.lk_CaSi.Name = "lk_CaSi";
            this.lk_CaSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_CaSi.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.lk_CaSi.Size = new System.Drawing.Size(662, 32);
            this.lk_CaSi.StyleController = this.layoutControl1;
            this.lk_CaSi.TabIndex = 6;
            // 
            // lk_BaiHat
            // 
            this.lk_BaiHat.Location = new System.Drawing.Point(70, 72);
            this.lk_BaiHat.MenuManager = this.ribbonControl1;
            this.lk_BaiHat.Name = "lk_BaiHat";
            this.lk_BaiHat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_BaiHat.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.lk_BaiHat.Size = new System.Drawing.Size(662, 32);
            this.lk_BaiHat.StyleController = this.layoutControl1;
            this.lk_BaiHat.TabIndex = 5;
            // 
            // lk_Album
            // 
            this.lk_Album.Location = new System.Drawing.Point(70, 20);
            this.lk_Album.MenuManager = this.ribbonControl1;
            this.lk_Album.Name = "lk_Album";
            this.lk_Album.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_Album.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.lk_Album.Size = new System.Drawing.Size(662, 32);
            this.lk_Album.StyleController = this.layoutControl1;
            this.lk_Album.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(752, 292);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lk_Album;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(732, 52);
            this.layoutControlItem1.Text = "ALBUM";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lk_BaiHat;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(732, 52);
            this.layoutControlItem2.Text = "BÀI HÁT";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(47, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lk_CaSi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(732, 52);
            this.layoutControlItem3.Text = "CA SĨ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(47, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtGV_CT_Album;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(732, 116);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // ucCTAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ucCTAlbum";
            this.Size = new System.Drawing.Size(752, 475);
            this.Load += new System.EventHandler(this.ucCTAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV_CT_Album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_CaSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_BaiHat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_Album.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DataGridView dtGV_CT_Album;
        private DevExpress.XtraEditors.LookUpEdit lk_CaSi;
        private DevExpress.XtraEditors.LookUpEdit lk_BaiHat;
        private DevExpress.XtraEditors.LookUpEdit lk_Album;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
