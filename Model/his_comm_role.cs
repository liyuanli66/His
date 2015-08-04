using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_role
	{
		public his_comm_role()
		{}
		#region Model
		private string _id;
		private string _role_code;
		private string _role_name;
		private string _role_xml;
		private string _hospital_code;
		private string _is_use;
		private DateTime? _create_date;
		private string _create_by;
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
		public string ROLE_CODE
		{
			set{ _role_code=value;}
			get{return _role_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLE_NAME
		{
			set{ _role_name=value;}
			get{return _role_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLE_XML
		{
			set{ _role_xml=value;}
			get{return _role_xml;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HOSPITAL_CODE
		{
			set{ _hospital_code=value;}
			get{return _hospital_code;}
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
		#endregion Model

	}
}

