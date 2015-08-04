using System;
namespace HIS.Model
{
	/// <summary>
	/// his_pm_export:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_pm_export
	{
		public his_pm_export()
		{}
		#region Model
		private string _id;
		private string _export_code;
		private string _receive_dept_code;
		private string _create_by;
		private DateTime? _create_date;
		private string _send_dept_code;
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
		public string EXPORT_CODE
		{
			set{ _export_code=value;}
			get{return _export_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECEIVE_DEPT_CODE
		{
			set{ _receive_dept_code=value;}
			get{return _receive_dept_code;}
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
		public DateTime? CREATE_DATE
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEND_DEPT_CODE
		{
			set{ _send_dept_code=value;}
			get{return _send_dept_code;}
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

