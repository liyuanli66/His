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
    public partial class frmCommDept : DevExpress.XtraEditors.XtraForm
    {
        public frmCommDept()
        {
            InitializeComponent();
        }

        #region 初始化窗体
        HisClient.BLL.his_comm_dept bll = new HisClient.BLL.his_comm_dept();
        private string strWhere = string.Empty;
        #endregion

        #region 事件
        private void frmCommDept_Load(object sender, EventArgs e)
        {
            Query("");
            //this.gridLookUpEdit1.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            //gridLookUpEdit1.Properties.DataSource = dts;
            //gridLookUpEdit1.Properties.DisplayMember = "jc";
            //gridLookUpEdit1.Properties.ValueMember = "Name";

            //GridColumn col1 = this.gridLookUpEdit1.Properties.View.Columns.AddField("jc");
            //col1.VisibleIndex = 0;
            //col1.Caption = "简称";
            //GridColumn col2 = this.gridLookUpEdit1.Properties.View.Columns.AddField("Name");
            //col2.VisibleIndex = 1;
            //col2.Caption = "名称";


            //this.gridLookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            //this.gridLookUpEdit1.Properties.View.BestFitColumns();
            //this.gridLookUpEdit1.Properties.ShowFooter = false;
            //this.gridLookUpEdit1.Properties.View.OptionsView.ShowAutoFilterRow = false;
            //this.gridLookUpEdit1.Properties.AutoComplete = false;
            //this.gridLookUpEdit1.Properties.ImmediatePopup = true;
            //// this.gridLookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.Contains;
            //this.gridLookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            if (txtCode.Text != string.Empty)
                strWhere += " and DEPT_CODE like '%" + txtCode.Text + "%'";

            if (txtName.Text != string.Empty)
                strWhere += " and DEPT_NAME like '%" + txtName.Text + "%'";

            if (txtHelpCode.Text != string.Empty)
                strWhere += " and HELP_CODE like '%" + txtHelpCode.Text + "%'";

            if(lpdDeptType.Text.Trim()!=string.Empty)
                strWhere += " and DEPT_TYPE ='" + lpdDeptType.EditValue + "'";

            if (lpdHospital.Text.Trim() != string.Empty)
                strWhere += " and HOSPITAL_CODE ='" + lpdHospital.EditValue.ToString() + "'";

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
                    HisClient.Model.his_comm_dept model = new Model.his_comm_dept();
                    model.ID = "123";
                    model.DEPT_CODE = txtCode.Text.Trim();
                    model.DEPT_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    model.DEPT_TYPE = lpdDeptType.EditValue.ToString();
                    model.HOSPITAL_CODE = lpdHospital.EditValue.ToString();
                    model.CREATE_DATE = DateTime.Now;
                    model.CREATE_BY = "登陆";
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
                    HisClient.Model.his_comm_dept model = new Model.his_comm_dept();
                    model.ID = txtName.ID;
                    model.DEPT_CODE = txtCode.Text.Trim();
                    model.DEPT_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    model.DEPT_TYPE = lpdDeptType.EditValue.ToString();
                    model.HOSPITAL_CODE = lpdHospital.EditValue.ToString();
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
        /// <summary>
        /// 回车焦点下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void txtHelpCode_KeyDown(object sender, KeyEventArgs e)
        {
            lpdDeptType.Focus();
        }

        private void lpdDeptType_KeyDown(object sender, KeyEventArgs e)
        {
            lpdHospital.Focus();
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

                object rowCodeObj = gridView1.GetRowCellValue(intRowHandle, "DEPT_CODE");
                if (rowCodeObj != null)
                {
                    this.txtCode.Text = rowCodeObj.ToString();
                }
                object rowNameObj = gridView1.GetRowCellValue(intRowHandle, "DEPT_NAME");
                if (rowNameObj != null)
                {
                    this.txtName.Text = rowNameObj.ToString();
                }
                object rowHelpCodeObj = gridView1.GetRowCellValue(intRowHandle, "HELP_CODE");
                if (rowHelpCodeObj != null)
                {
                    this.txtHelpCode.Text = rowHelpCodeObj.ToString();
                }
                //科室类型、医院赋值
            }
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
            txtName.ID = string.Empty;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtHelpCode.Text = string.Empty;
            lpdDeptType.Text = string.Empty;
            lpdDeptType.EditValue = string.Empty;
            lpdHospital.Text = string.Empty;
            lpdHospital.EditValue = string.Empty;
            Query("");
        }
        #endregion     


    }
}
