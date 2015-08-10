﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HisClient.Models.DICT
{
    public partial class frmCommDosage : Form
    {
        public frmCommDosage()
        {
            InitializeComponent();
        }

        #region 初始化
        HisClient.BLL.his_comm_dosage bll = new HisClient.BLL.his_comm_dosage();
        private string strID = string.Empty;
        private string strWhere = string.Empty;
        ComFunc comfun = new ComFunc();
        #endregion

        #region 事件
        private void frmCommDosage_Load(object sender, EventArgs e)
        {
            Query("");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            if (txtCode.Text != string.Empty)
                strWhere += " and EFFICACY_CODE like '%" + txtCode.Text + "%'";

            if (txtName.Text != string.Empty)
                strWhere += " and EFFICACY_NAME like '%" + txtName.Text + "%'";

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
            if (txtName.ID == string.Empty)
            {
                if (txtCode.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("编码不可为空！");
                    return;
                }
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("名称不可为空！");
                    return;
                }
                try
                {
                    HisClient.Model.his_comm_dosage model = new Model.his_comm_dosage();
                    model.ID = "123";
                    model.DOSAGE_CODE = txtCode.Text.Trim();
                    model.DOSAGE_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    bll.Add(model);
                    MessageBox.Show("保存成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.ID != string.Empty)
            {
                if (txtCode.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("编码不可为空！");
                    return;
                }
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("名称不可为空！");
                    return;
                }
                try
                {
                    HisClient.Model.his_comm_dosage model = new Model.his_comm_dosage();
                    model.ID = "123";
                    model.DOSAGE_CODE = txtCode.Text.Trim();
                    model.DOSAGE_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    bll.Update(model);
                    MessageBox.Show("更新成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.ID != string.Empty)
            {
                bll.Delete(txtName.ID);
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

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName.Focus();
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text != string.Empty)
                {
                    PinYin py = new PinYin(txtName.Text.Trim());
                    string strShort = py.GetChineseSpell();
                    this.txtHelpCode.Text = strShort;
                    txtHelpCode.Focus();
                }
            }
        }
        #endregion

        #region 方法

        private void Query(string strw)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = bll.GetList(strw);
                //grid
                gridControl1.Dock = DockStyle.Fill;
                gridControl1.DataSource = ds.Tables[0];
                //gridView1.Columns.Clear();
                //ComFunc comfun = new ComFunc();
                //comfun.dgvstyle(gridView1, 0, "aa", "第一", 10, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void clear()
        {
            strID = string.Empty;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtHelpCode.Text = string.Empty;
            Query("");
        }
        #endregion     
    }
}