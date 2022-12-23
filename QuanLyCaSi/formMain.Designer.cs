
namespace QuanLyCaSi
{
    partial class formMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.controlGroup_DanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_CaSi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_NhacSi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_BaiHat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_Album = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_CTAlbum = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.controlElement_NSX = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(667, 434);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlGroup_DanhMuc});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 434);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // controlGroup_DanhMuc
            // 
            this.controlGroup_DanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.controlElement_CaSi,
            this.controlElement_NhacSi,
            this.controlElement_BaiHat,
            this.controlElement_Album,
            this.controlElement_CTAlbum,
            this.controlElement_NSX});
            this.controlGroup_DanhMuc.Expanded = true;
            this.controlGroup_DanhMuc.Name = "controlGroup_DanhMuc";
            this.controlGroup_DanhMuc.Text = "Danh mục";
            // 
            // controlElement_CaSi
            // 
            this.controlElement_CaSi.Name = "controlElement_CaSi";
            this.controlElement_CaSi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_CaSi.Text = "Ca sĩ";
            this.controlElement_CaSi.Click += new System.EventHandler(this.controlElement_CaSi_Click);
            // 
            // controlElement_NhacSi
            // 
            this.controlElement_NhacSi.Name = "controlElement_NhacSi";
            this.controlElement_NhacSi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_NhacSi.Text = "Nhạc sĩ";
            this.controlElement_NhacSi.Click += new System.EventHandler(this.controlElement_NhacSi_Click);
            // 
            // controlElement_BaiHat
            // 
            this.controlElement_BaiHat.Name = "controlElement_BaiHat";
            this.controlElement_BaiHat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_BaiHat.Text = "Bài hát";
            this.controlElement_BaiHat.Click += new System.EventHandler(this.controlElement_BaiHat_Click);
            // 
            // controlElement_Album
            // 
            this.controlElement_Album.Name = "controlElement_Album";
            this.controlElement_Album.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_Album.Text = "Album";
            this.controlElement_Album.Click += new System.EventHandler(this.controlElement_Album_Click);
            // 
            // controlElement_CTAlbum
            // 
            this.controlElement_CTAlbum.Name = "controlElement_CTAlbum";
            this.controlElement_CTAlbum.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_CTAlbum.Text = "Chi tiết album";
            this.controlElement_CTAlbum.Click += new System.EventHandler(this.controlElement_CTAlbum_Click);
            // 
            // controlElement_NSX
            // 
            this.controlElement_NSX.Name = "controlElement_NSX";
            this.controlElement_NSX.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.controlElement_NSX.Text = "Nhà sản xuất";
            this.controlElement_NSX.Click += new System.EventHandler(this.controlElement_NSX_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(927, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "barStaticItem1";
            this.itemNav.Id = 0;
            this.itemNav.Name = "itemNav";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 473);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "formMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "formMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlGroup_DanhMuc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_CaSi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_NhacSi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_BaiHat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_Album;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_CTAlbum;
        private DevExpress.XtraBars.Navigation.AccordionControlElement controlElement_NSX;
        private DevExpress.XtraBars.BarStaticItem itemNav;
    }
}