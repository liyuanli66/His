using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_module:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_module
	{
		public his_comm_module()
		{}
		#region Model
		private string _id;
		private string _module_name;
		private string _module_code;
		private string _system_code;
		private string _is_use;
		private DateTime? _create_date;
		private string _create_by;
		private string _hospital_code;
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
		public string MODULE_NAME
		{
			set{ _module_name=value;}
			get{return _module_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MODULE_CODE
		{
			set{ _module_code=value;}
			get{return _module_code;}
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
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

