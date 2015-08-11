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
    public partial class frmCommDictInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmCommDictInfo()
        {
            InitializeComponent();
        }

        #region 初始化
        HisClient.BLL.his_comm_dict_info bll = new HisClient.BLL.his_comm_dict_info();
        HisClient.BLL.his_comm_dict_type blltype = new HisClient.BLL.his_comm_dict_type();
        ComFunc comfun = new ComFunc();
        #endregion

        #region 事件
        private void frmCommDictInfo_Load(object sender, EventArgs e)
        {
            DataBindType();
            Query("");
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strWhere = string.Empty;
            if (this.gLDictType.EditValue.ToString() != string.Empty)
                strWhere += " TYPE_CODE ='" + gLDictType.EditValue.ToString() + "'";

            if (txtCode.Text != string.Empty)
                strWhere += " and DICT_CODE like '%" + txtCode.Text + "%'";

            if (txtName.Text != string.Empty)
                strWhere += " and DICT_NAME like '%" + txtName.Text + "%'";

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
                if (gLDictType.EditValue.ToString() == string.Empty)
                {
                    MessageBox.Show("类型不可为空！");
                    return;
                }
                try
                {
                    HisClient.Model.his_comm_dict_info model = new Model.his_comm_dict_info();
                    model.ID = "123";
                    model.DICT_CODE = txtCode.Text.Trim();
                    model.DICT_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    model.TYPE_CODE = gLDictType.EditValue.ToString();
                    bll.Add(model);
                    MessageBox.Show("保存成功！");
                    clear();
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
                if (gLDictType.EditValue.ToString() == string.Empty) 
                {
                    MessageBox.Show("类型不可为空！");
                    return;
                }
                try
                {
                    HisClient.Model.his_comm_dict_info model = new Model.his_comm_dict_info();
                    model.ID = txtName.ID;
                    model.DICT_CODE = txtCode.Text.Trim();
                    model.DICT_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    model.TYPE_CODE = gLDictType.EditValue.ToString();
                    bll.Update(model);
                    MessageBox.Show("更新成功！");
                    clear();
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
                MessageBox.Show("删除成功！");
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
                this.gLDictType.Focus();
            }
        }
        private void lpdDictType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.gLDictType.Focus();
            }
        }
        private void gLDictType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtName.Focus();
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
        /// <summary>
        /// 当焦点行发生改变时执行 获取选中焦点行id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int intRowHandle = e.FocusedRowHandle;

            object rowIdObj = gridView1.GetRowCellValue(intRowHandle, "ID");

            if (DBNull.Value != rowIdObj)//做个判断否则获取不到id后报错
            {
                txtName.ID = rowIdObj.ToString();

                object rowTypeObj = gridView1.GetRowCellValue(intRowHandle, "TYPE_CODE");
                if (rowTypeObj != null)
                {
                    this.gLDictType.EditValue = rowTypeObj.ToString();
                }
                object rowCodeObj = gridView1.GetRowCellValue(intRowHandle, "DICT_CODE");
                if (rowCodeObj != null)
                {
                    this.txtCode.Text = rowCodeObj.ToString();
                }
                object rowNameObj = gridView1.GetRowCellValue(intRowHandle, "DICT_NAME");
                if (rowNameObj != null)
                {
                    this.txtName.Text = rowNameObj.ToString();
                }
                object rowHelpCodeObj = gridView1.GetRowCellValue(intRowHandle, "HELP_CODE");
                if (rowHelpCodeObj != null)
                {
                    this.txtHelpCode.Text = rowHelpCodeObj.ToString();
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
            txtName.ID = string.Empty;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtHelpCode.Text = string.Empty;
            gLDictType.EditValue = string.Empty;
            gLDictType.Text = string.Empty;
            Query("");
        }
        private void DataBindType()
        {
            try
            {
                DataSet dsDeptType = new DataSet();
                dsDeptType = blltype.GetList("");

                this.gLDictType.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
                gLDictType.Properties.DataSource = dsDeptType.Tables[0];
                gLDictType.Properties.DisplayMember = "TYPE_NAME";
                gLDictType.Properties.ValueMember = "ID";

                DevExpress.XtraGrid.Columns.GridColumn col1 = this.gLDictType.Properties.View.Columns.AddField("ID");
                col1.VisibleIndex = 0;
                col1.Caption = "ID";
                DevExpress.XtraGrid.Columns.GridColumn col2 = this.gLDictType.Properties.View.Columns.AddField("TYPE_CODE");
                col2.VisibleIndex = 1;
                col2.Caption = "编码";
                DevExpress.XtraGrid.Columns.GridColumn col3 = this.gLDictType.Properties.View.Columns.AddField("TYPE_NAME");
                col3.VisibleIndex = 2;
                col3.Caption = "名称";
                DevExpress.XtraGrid.Columns.GridColumn col4 = this.gLDictType.Properties.View.Columns.AddField("HELP_CODE");
                col3.VisibleIndex = 3;
                col3.Caption = "助记符";


                this.gLDictType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                this.gLDictType.Properties.View.BestFitColumns();
                this.gLDictType.Properties.ShowFooter = false;
                this.gLDictType.Properties.View.OptionsView.ShowAutoFilterRow = false;
                this.gLDictType.Properties.AutoComplete = false;
                this.gLDictType.Properties.ImmediatePopup = true;
                // this.gridLookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.Contains;
                this.gLDictType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion       

    }
}
