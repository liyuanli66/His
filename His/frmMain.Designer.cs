namespace HisClient
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.RGBitem = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ceshi = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDept = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDoctor = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDosage = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEfficacy = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barbtnDictType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.RGBitem,
            this.ceshi,
            this.barbtnDept,
            this.barbtnDoctor,
            this.barbtnDosage,
            this.barbtnEfficacy,
            this.barbtnDictType,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(810, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // RGBitem
            // 
            this.RGBitem.Caption = "ribbonGalleryBarItem1";
            this.RGBitem.Id = 1;
            this.RGBitem.Name = "RGBitem";
            this.RGBitem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.RGBitem_GalleryItemClick);
            // 
            // ceshi
            // 
            this.ceshi.Caption = "ceshi";
            this.ceshi.Id = 2;
            this.ceshi.LargeGlyph = global::HisClient.Properties.Resources._015;
            this.ceshi.Name = "ceshi";
            this.ceshi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // barbtnDept
            // 
            this.barbtnDept.Caption = "科室";
            this.barbtnDept.Id = 3;
            this.barbtnDept.LargeGlyph = global::HisClient.Properties.Resources.科室字典;
            this.barbtnDept.Name = "barbtnDept";
            this.barbtnDept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // barbtnDoctor
            // 
            this.barbtnDoctor.Caption = "医生";
            this.barbtnDoctor.Id = 4;
            this.barbtnDoctor.LargeGlyph = global::HisClient.Properties.Resources.医生字典;
            this.barbtnDoctor.Name = "barbtnDoctor";
            this.barbtnDoctor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // barbtnDosage
            // 
            this.barbtnDosage.Caption = "剂型";
            this.barbtnDosage.Id = 5;
            this.barbtnDosage.LargeGlyph = global::HisClient.Properties.Resources.剂型字典;
            this.barbtnDosage.Name = "barbtnDosage";
            this.barbtnDosage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // barbtnEfficacy
            // 
            this.barbtnEfficacy.Caption = "功效";
            this.barbtnEfficacy.Id = 6;
            this.barbtnEfficacy.LargeGlyph = global::HisClient.Properties.Resources.功效字典;
            this.barbtnEfficacy.Name = "barbtnEfficacy";
            this.barbtnEfficacy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "基础字典";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ceshi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnDosage);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnEfficacy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "临床字典";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnDept);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnDoctor);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnDictType);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "系统字典";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "皮肤选择";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.RGBitem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "皮肤";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 397);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(810, 31);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barbtnDictType
            // 
            this.barbtnDictType.Caption = "主字典类型";
            this.barbtnDictType.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnDictType.Glyph")));
            this.barbtnDictType.Id = 7;
            this.barbtnDictType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnDictType.LargeGlyph")));
            this.barbtnDictType.Name = "barbtnDictType";
            this.barbtnDictType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "主字典信息";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAllClick);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(810, 428);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "乡镇医院管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.RibbonGalleryBarItem RGBitem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem ceshi;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barbtnDept;
        private DevExpress.XtraBars.BarButtonItem barbtnDoctor;
        private DevExpress.XtraBars.BarButtonItem barbtnDosage;
        private DevExpress.XtraBars.BarButtonItem barbtnEfficacy;
        private DevExpress.XtraBars.BarButtonItem barbtnDictType;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}