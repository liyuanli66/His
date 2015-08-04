using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_function:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_function
	{
		public his_comm_function()
		{}
		#region Model
		private string _id;
		private string _module_code;
		private string _function_code;
		private string _function_name;
		private string _is_use;
		private string _hospital_code;
		private string _remarks;
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
		public string MODULE_CODE
		{
			set{ _module_code=value;}
			get{return _module_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FUNCTION_CODE
		{
			set{ _function_code=value;}
			get{return _function_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FUNCTION_NAME
		{
			set{ _function_name=value;}
			get{return _function_name;}
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
		public string HOSPITAL_CODE
		{
			set{ _hospital_code=value;}
			get{return _hospital_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARKS
		{
			set{ _remarks=value;}
			get{return _remarks;}
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

