using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;

namespace HisClient
{
    /// <summary>
    /// 常用公共变量或方法
    /// </summary>
    public class ComFunc
    {
        private static RibbonForm _main;

        /// <summary>
        /// 主窗体
        /// </summary>
        public static RibbonForm Main
        {
            set
            {
                _main = value;
            }
            get
            {
                if (_main == null)
                {
                    _main = new frmMain();
                }
                return _main;
            }
        }


        public static void IfOpenFrom(Form frmQue)
        {
            //标识主窗体中是否已打开待激活窗口，初始定义没有打开
            bool hasMe = false;
            if (Main.MdiChildren.Length > 0)
            {
                foreach (Form frmAct in Main.MdiChildren)
                {
                    if (frmQue.GetType() == frmAct.GetType() && frmQue.Text == frmAct.Text)
                    {
                        //查找到已打开的待激活窗口，将原子窗体前置显示并更改为标识true
                        frmAct.BringToFront();
                        hasMe = true;
                        break;
                    }
                }
            }

            if (!hasMe)  //主窗口中没有找到待激活子窗口，则Show子窗口
            {
                frmQue.MdiParent = Main;
                frmQue.Show();
            }
        }

        /// <summary>
        /// 获取当前程序运行路径
        /// </summary>
        /// <returns></returns>
        public static string GetAppDirectory()
        {
            return System.Windows.Forms.Application.StartupPath.EndsWith("\\") ? System.Windows.Forms.Application.StartupPath : System.Windows.Forms.Application.StartupPath + "\\";
        }

        /// <summary>
        /// 获得本机的内网IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddres()
        {
            string ip = "";

            try
            {
                string strHostName = Dns.GetHostName(); //得到本机的主机名  
                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                //foreach (IPAddress ipAdds in ipEntry.AddressList)
                //{
                //    ip = ipAdds.ToString();
                //    if (ip.StartsWith("10."))
                //        break;

                //}
            }
            catch (Exception ex)
            {
                LoggingService.Error(ex.ToString());
            }
            return ip;
        }

        /// <summary>
        /// gridcontol 格式化
        /// </summary>
        /// <param name="dg">要设置的gridview</param>
        /// <param name="colnum">显示的顺序号</param>
        /// <param name="fildname">绑定字段</param>
        /// <param name="caption">标题</param>
        /// <param name="width">宽度</param>
        /// <param name="visble">是否显示列</param>
        /// <param name="filter">是否加自动排序</param>
        /// <param name="align">位置</param>
        /// <param name="fixedstyle">冻结列</param>
        /// <param name="GroupPanel">是否显视gridview上的panel</param>
        public void dgvstyle(GridView dg, int colnum, string fildname, string caption, int width, bool visible, bool filter, DevExpress.Utils.HorzAlignment align, DevExpress.XtraGrid.Columns.FixedStyle fixedstyle, bool GroupPanel)
        {

            DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
            col.Caption = caption;
            col.FieldName = fildname;
            col.VisibleIndex = colnum;
            //限制dgv可修改用这个不可以复制一个单元格
            // col.OptionsColumn.AllowEdit=false;                     
            dg.Columns.Add(col);
            dg.Columns[colnum].Visible = visible;
            dg.Columns[colnum].AppearanceCell.TextOptions.HAlignment = align;
            if (width >= 0)
            {
                dg.Columns[colnum].Width = width;
            }
            dg.Columns[colnum].OptionsColumn.ReadOnly = true;
            dg.OptionsView.ShowGroupPanel = GroupPanel;
            dg.Columns[colnum].OptionsFilter.AllowAutoFilter = filter;
            dg.Columns[colnum].OptionsFilter.AllowFilter = filter;
            dg.Columns[colnum].OptionsFilter.ImmediateUpdateAutoFilter = filter;
            dg.Columns[colnum].Fixed = fixedstyle;
        }
        /// <summary>
        /// gridcontol 格式化
        /// </summary>
        /// <param name="dg">要设置的gridview</param>
        /// <param name="colnum">显示的顺序号</param>
        /// <param name="fildname">绑定字段</param>
        /// <param name="caption">标题</param>
        /// <param name="width">宽度</param>
        /// <param name="visble">是否显示列</param>
        /// <param name="filter">是否加自动排序</param>
        /// <param name="align">位置</param>
        /// <param name="fixedstyle">冻结列</param>
        public void dgvstyle(GridView dg, int colnum, string fildname, string caption, int width, bool visible, bool filter, DevExpress.Utils.HorzAlignment align)
        {

            DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
            col.Caption = caption;
            col.FieldName = fildname;
            col.VisibleIndex = colnum;
            //限制dgv可修改用这个不可以复制一个单元格
            // col.OptionsColumn.AllowEdit=false;                     
            dg.Columns.Add(col);
            dg.Columns[colnum].Visible = visible;
            dg.Columns[colnum].AppearanceCell.TextOptions.HAlignment = align;
            if (width >= 0)
            {
                dg.Columns[colnum].Width = width;
            }
            dg.Columns[colnum].OptionsColumn.ReadOnly = true;

            dg.OptionsView.ShowGroupPanel = true;
            dg.Columns[colnum].OptionsFilter.AllowAutoFilter = filter;
            dg.Columns[colnum].OptionsFilter.AllowFilter = filter;
            dg.Columns[colnum].OptionsFilter.ImmediateUpdateAutoFilter = filter;

        }
        /// <summary>
        /// 是否显示行号
        /// </summary>
        /// <param name="dg">gridview</param>
        /// <param name="visble">是否显示</param>
        /// <param name="width">行号宽度</param>
        public void boolgridindex(GridView dg, bool visble, int width)
        {
            dg.IndicatorWidth = width;
            if (visble)
            {
                dg.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gridview_CustomDrawRowIndicator);
            }
        }
        private void gridview_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

    }


    public class ListItem
    {

        public ListItem(string _text, string _value)
        {
            Value = _value;
            Test = _text;
        }
        private string value;

        /// <summary>
        /// Item值
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        private string test;

        /// <summary>
        /// Item显示值
        /// </summary>
        public string Test
        {
            get { return test; }
            set { test = value; }
        }

    }

}