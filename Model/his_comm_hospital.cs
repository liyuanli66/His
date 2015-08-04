using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_hospital:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_hospital
	{
		public his_comm_hospital()
		{}
		#region Model
		private string _id;
		private string _hospital_code;
		private string _hospital_name;
		private string _hospital_level;
		private string _help_code;
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
		public string HOSPITAL_CODE
		{
			set{ _hospital_code=value;}
			get{return _hospital_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HOSPITAL_NAME
		{
			set{ _hospital_name=value;}
			get{return _hospital_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HOSPITAL_LEVEL
		{
			set{ _hospital_level=value;}
			get{return _hospital_level;}
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

