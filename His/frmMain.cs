using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;
namespace HisClient
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
           SkinHelper.InitSkinGallery(RGBitem, true);
           SkinHelper.InitSkinPopupMenu(popupMenu1);
            ComFunc.Main = this;
        }

       
        #region 初始化窗体
        Form frmcreate = null;
        #endregion

       

       
        #region 事件
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            useskin();
        }
        /// <summary>
        /// 所有button共用事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAllClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string title = e.Item.Caption.ToString();
           
            MenuItemClick(null, title);

        }
        /// <summary>
        /// 主题皮肤选择记忆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RGBitem_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string name = string.Empty;
            string caption = string.Empty;
            if (RGBitem.Gallery == null) return;
            caption = RGBitem.Gallery.GetCheckedItems()[0].Caption;//主题的描述
            caption = caption.Replace("主题：", "");
            //name = bsiPaintStyle.Manager.PressedLink.Item.Tag.ToString();//主题的名称
            RGBitem.Caption = "主题：" + caption;
           
            Properties.Settings.Default.defaultskin = caption.ToString();
            Properties.Settings.Default.Save();
        }
        #endregion
        #region 方法
        /// <summary>
        /// 处理窗体共用类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ItemCaption"></param>
        public void MenuItemClick(object sender, string ItemCaption)
        {  
            switch (ItemCaption)
            {
                case "ceshi":
                    frmcreate = new HisClient.Form1();
                    frmcreate.WindowState = FormWindowState.Maximized;
                    break;
                case "科室":
                    frmcreate = new HisClient.Models.DICT.frmCommDept();
                    frmcreate.WindowState = FormWindowState.Maximized;
                    break;
                case "医生":
                    frmcreate = new HisClient.Models.DICT.frmCommDoctor();
                    frmcreate.WindowState = FormWindowState.Maximized;
                    break;

                case "剂型":
                    frmcreate = new HisClient.Models.DICT.frmCommDosage();
                    frmcreate.WindowState = FormWindowState.Maximized;
                    break;
                case "功效":
                    frmcreate = new HisClient.Models.DICT.frmCommEfficacy();
                    frmcreate.WindowState = FormWindowState.Maximized;
                    break;
            }
             //判断窗体是否打开
            if (frmcreate != null)
            {
                ComFunc.IfOpenFrom(frmcreate);
            }
        }
        /// <summary>
        /// 皮肤调用
        /// </summary>
        private void useskin()
        {
            SkinHelper.InitSkinGallery(RGBitem);
            string skinname = Properties.Settings.Default.defaultskin.ToString();
            if (skinname == string.Empty)
            {
                return;
            }
            UserLookAndFeel.Default.SetSkinStyle(skinname);//设置主题样式
            RGBitem.Caption = "主题：" + skinname;
        }

       
        #endregion


       

    }
}
