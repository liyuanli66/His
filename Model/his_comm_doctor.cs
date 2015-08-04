using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_doctor:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_doctor
	{
		public his_comm_doctor()
		{}
		#region Model
		private string _id;
		private string _doctor_code;
		private string _doctor_name;
		private string _dept_code;
		private string _hispital_code;
		private string _doctor_sex;
		private string _doctor_tel;
		private string _doctor_nation;
		private string _merriage_code;
		private string _doctor_email;
		private string _doctor_title;
		private string _doctor_titlegrade;
		private string _help_code;
		private string _remark;
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
		public string DOCTOR_CODE
		{
			set{ _doctor_code=value;}
			get{return _doctor_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_NAME
		{
			set{ _doctor_name=value;}
			get{return _doctor_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPT_CODE
		{
			set{ _dept_code=value;}
			get{return _dept_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HISPITAL_CODE
		{
			set{ _hispital_code=value;}
			get{return _hispital_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_SEX
		{
			set{ _doctor_sex=value;}
			get{return _doctor_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_TEL
		{
			set{ _doctor_tel=value;}
			get{return _doctor_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_NATION
		{
			set{ _doctor_nation=value;}
			get{return _doctor_nation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MERRIAGE_CODE
		{
			set{ _merriage_code=value;}
			get{return _merriage_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_EMAIL
		{
			set{ _doctor_email=value;}
			get{return _doctor_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_TITLE
		{
			set{ _doctor_title=value;}
			get{return _doctor_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_TITLEGRADE
		{
			set{ _doctor_titlegrade=value;}
			get{return _doctor_titlegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HELP_CODE
		{
			set{ _help_code=value;}
			get{return _help_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

