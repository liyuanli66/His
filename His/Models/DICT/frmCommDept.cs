using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HisClient.Models.DICT
{
    public partial class frmCommDept : Form
    {
        public frmCommDept()
        {
            InitializeComponent();
            Query("");
        }

        #region 初始化窗体
        HisClient.BLL.his_comm_dept bll = new HisClient.BLL.his_comm_dept();
        private string strID = string.Empty;
        private string strWhere = string.Empty;
        #endregion

        #region 事件
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            if (txtDeptCode.Text != string.Empty)
                strWhere += " and DEPT_CODE like '%" + txtDeptCode.Text + "%'";

            if (txtDeptName.Text != string.Empty)
                strWhere += " and DEPT_NAME like '%" + txtDeptName.Text + "%'";

            if (txtHelpCode.Text != string.Empty)
                strWhere += " and HELP_CODE like '%" + txtHelpCode.Text + "%'";

            Query(strWhere);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (strID == string.Empty)
            { 

            }
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (strID != string.Empty)
            { 
                
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (strID != string.Empty)
            {
                bll.Delete(strID);
                clear();
            }
            
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion

        #region 方法

        private void Query(string strw)
        {
            DataSet ds = new DataSet();
            ds = bll.GetList(strw);
            //grid
            gridControl1.DataSource = ds.Tables[0];            
        }

        private void clear() 
        {
            strID = string.Empty;
            txtDeptCode.Text = string.Empty;
            txtDeptName.Text = string.Empty;
            txtHelpCode.Text = string.Empty;
            lpdDeptType.Text = string.Empty;
            lpdHospital.Text = string.Empty;
            Query("");
        }
        #endregion     

    }
}
