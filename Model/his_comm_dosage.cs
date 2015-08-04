using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_dosage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_dosage
	{
		public his_comm_dosage()
		{}
		#region Model
		private string _id;
		private string _dosage_code;
		private string _dosage_name;
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
		public string DOSAGE_CODE
		{
			set{ _dosage_code=value;}
			get{return _dosage_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOSAGE_NAME
		{
			set{ _dosage_name=value;}
			get{return _dosage_name;}
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

