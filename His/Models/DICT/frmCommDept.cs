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
        HisClient.BLL.his_comm_dict_info dictbll = new BLL.his_comm_dict_info();

        #endregion

        #region 事件
        private void frmCommDept_Load(object sender, EventArgs e)
        {
            DataBindDeptType();
            DataBindHospital();
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
            if (txtCode.Text != string.Empty)
                strWhere += " DEPT_CODE like '%" + txtCode.Text + "%'";

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
                    model.ID = "1";
                    model.DEPT_CODE = txtCode.Text.Trim();
                    model.DEPT_NAME = txtName.Text.Trim();
                    model.HELP_CODE = txtHelpCode.Text.Trim();
                    if (lpdDeptType.EditValue != null)
                    {
                        model.DEPT_TYPE = lpdDeptType.EditValue.ToString();
                    }
                    if (lpdHospital.EditValue != null)
                    {
                        model.HOSPITAL_CODE = lpdHospital.EditValue.ToString();
                    }
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
            if (e.KeyCode == Keys.Enter)
            {
                lpdDeptType.Focus();
            }
        }

        private void lpdDeptType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lpdHospital.Focus();
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
            if (intRowHandle >= 0)
            {
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
                    object rowTypeObj = gridView1.GetRowCellValue(intRowHandle, "DEPT_TYPE");
                    if (rowTypeObj != null)
                    {
                        this.lpdDeptType.EditValue = rowTypeObj.ToString();
                    }
                    object rowHospitalObj = gridView1.GetRowCellValue(intRowHandle, "HOSPITAL_CODE");
                    if (rowHospitalObj != null)
                    {
                        this.lpdHospital.EditValue = rowHospitalObj.ToString();
                    }
                }
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
            gridView1.Columns.Clear();
            ComFunc comfun = new ComFunc();
            comfun.dgvstyle(gridView1, 0, "ID", "序号", 5, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 1, "DEPT_CODE", "科室编码", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 2, "DEPT_NAME", "科室名称", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 3, "HELP_CODE", "助记符", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 4, "DEPT_TYPE", "科室类型", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 5, "HOSPITAl_CODE", "所属医院", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 6, "CREATE_DATE", "创建时间", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 7, "CREATE_BY", "创建人", 15, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);

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
        private void DataBindDeptType() 
        {
            try
            {
                DataSet dsDeptType = new DataSet();
                dsDeptType = dictbll.GetList("  TYPE_CODE='DEPT_TYPE'");

                this.lpdDeptType.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
                lpdDeptType.Properties.DataSource = dsDeptType.Tables[0];
                lpdDeptType.Properties.DisplayMember = "DICT_NAME";
                lpdDeptType.Properties.ValueMember = "DICT_CODE";

                DevExpress.XtraGrid.Columns.GridColumn col1 = this.lpdDeptType.Properties.View.Columns.AddField("ID");
                col1.VisibleIndex = 0;
                col1.Caption = "ID";
                DevExpress.XtraGrid.Columns.GridColumn col2 = this.lpdDeptType.Properties.View.Columns.AddField("DICT_CODE");
                col2.VisibleIndex = 0;
                col2.Caption = "编码";
                DevExpress.XtraGrid.Columns.GridColumn col3 = this.lpdDeptType.Properties.View.Columns.AddField("DICT_NAME");
                col3.VisibleIndex = 1;
                col3.Caption = "名称";
                DevExpress.XtraGrid.Columns.GridColumn col4 = this.lpdDeptType.Properties.View.Columns.AddField("HELP_CODE");
                col3.VisibleIndex = 3;
                col3.Caption = "助记符";


                this.lpdDeptType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                this.lpdDeptType.Properties.View.BestFitColumns();
                this.lpdDeptType.Properties.ShowFooter = false;
                this.lpdDeptType.Properties.View.OptionsView.ShowAutoFilterRow = false;
                this.lpdDeptType.Properties.AutoComplete = false;
                this.lpdDeptType.Properties.ImmediatePopup = true;
                // this.gridLookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.Contains;
                this.lpdDeptType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DataBindHospital()
        {
            try
            {
                DataSet dsDeptType = new DataSet();
                dsDeptType = dictbll.GetList("  TYPE_CODE='HOSPITAL'");

                this.lpdHospital.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
                lpdHospital.Properties.DataSource = dsDeptType.Tables[0];
                lpdHospital.Properties.DisplayMember = "DICT_NAME";
                lpdHospital.Properties.ValueMember = "DICT_CODE";

                DevExpress.XtraGrid.Columns.GridColumn col1 = this.lpdHospital.Properties.View.Columns.AddField("ID");
                col1.VisibleIndex = 0;
                col1.Caption = "ID";
                DevExpress.XtraGrid.Columns.GridColumn col2 = this.lpdHospital.Properties.View.Columns.AddField("DICT_CODE");
                col2.VisibleIndex = 0;
                col2.Caption = "编码";
                DevExpress.XtraGrid.Columns.GridColumn col3 = this.lpdHospital.Properties.View.Columns.AddField("DICT_NAME");
                col3.VisibleIndex = 1;
                col3.Caption = "名称";
                DevExpress.XtraGrid.Columns.GridColumn col4 = this.lpdHospital.Properties.View.Columns.AddField("HELP_CODE");
                col3.VisibleIndex = 3;
                col3.Caption = "助记符";


                this.lpdHospital.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
                this.lpdHospital.Properties.View.BestFitColumns();
                this.lpdHospital.Properties.ShowFooter = false;
                this.lpdHospital.Properties.View.OptionsView.ShowAutoFilterRow = false;
                this.lpdHospital.Properties.AutoComplete = false;
                this.lpdHospital.Properties.ImmediatePopup = true;
                // this.gridLookUpEdit1.Properties.PopupFilterMode = PopupFilterMode.Contains;
                this.lpdHospital.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion     


    }
}
