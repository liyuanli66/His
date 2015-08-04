using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_account
	{
		public his_comm_account()
		{}
		#region Model
		private string _id;
		private string _account;
		private string _password;
		private string _role_code;
		private string _user_code;
		private string _admin_type;
		private string _is_use;
		private string _authority_xml;
		private DateTime? _create_date;
		private string _create_by;
		private DateTime? _last_logintime;
		private string _hospital_code;
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
		public string ACCOUNT
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PASSWORD
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLE_CODE
		{
			set{ _role_code=value;}
			get{return _role_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_CODE
		{
			set{ _user_code=value;}
			get{return _user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADMIN_TYPE
		{
			set{ _admin_type=value;}
			get{return _admin_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IS_USE
		{
			set{ _is_use=value;}
			get{return _is_use;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AUTHORITY_XML
		{
			set{ _authority_xml=value;}
			get{return _authority_xml;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_DATE
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			set{ _create_by=value;}
			get{return _create_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_LOGINTIME
		{
			set{ _last_logintime=value;}
			get{return _last_logintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HOSPITAL_CODE
		{
			set{ _hospital_code=value;}
			get{return _hospital_code;}
		}
		#endregion Model

	}
}

