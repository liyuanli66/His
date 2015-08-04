using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_system:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_system
	{
		public his_comm_system()
		{}
		#region Model
		private string _id;
		private string _system_code;
		private string _system_name;
		private string _is_user;
		private string _hospital_code;
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
		public string SYSTEM_CODE
		{
			set{ _system_code=value;}
			get{return _system_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SYSTEM_NAME
		{
			set{ _system_name=value;}
			get{return _system_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IS_USER
		{
			set{ _is_user=value;}
			get{return _is_user;}
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

