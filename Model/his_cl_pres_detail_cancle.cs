using System;
namespace HIS.Model
{
	/// <summary>
	/// his_cl_pres_detail_cancle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_cl_pres_detail_cancle
	{
		public his_cl_pres_detail_cancle()
		{}
		#region Model
		private string _id;
		private string _cl_pres_code;
		private string _cl_code;
		private string _status;
		private string _apply_dept_code;
		private string _doctor_code;
		private string _operate_dept_code;
		private decimal? _sum_amt;
		private string _opt_user;
		private DateTime _opt_date;
		private string _opt_term;
		private string _opt_orga;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CL_PRES_CODE
		{
			set{ _cl_pres_code=value;}
			get{return _cl_pres_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CL_CODE
		{
			set{ _cl_code=value;}
			get{return _cl_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPLY_DEPT_CODE
		{
			set{ _apply_dept_code=value;}
			get{return _apply_dept_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_CODE
		{
			set{ _doctor_code=value;}
			get{return _doctor_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPERATE_DEPT_CODE
		{
			set{ _operate_dept_code=value;}
			get{return _operate_dept_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SUM_AMT
		{
			set{ _sum_amt=value;}
			get{return _sum_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_USER
		{
			set{ _opt_user=value;}
			get{return _opt_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OPT_DATE
		{
			set{ _opt_date=value;}
			get{return _opt_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_TERM
		{
			set{ _opt_term=value;}
			get{return _opt_term;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_ORGA
		{
			set{ _opt_orga=value;}
			get{return _opt_orga;}
		}
		#endregion Model

	}
}

