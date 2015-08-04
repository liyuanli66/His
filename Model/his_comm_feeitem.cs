using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_feeitem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_feeitem
	{
		public his_comm_feeitem()
		{}
		#region Model
		private string _id;
		private string _feeitem_code;
		private string _feeitem_name;
		private string _help_code;
		private string _feeitem_type;
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
		public string FEEITEM_CODE
		{
			set{ _feeitem_code=value;}
			get{return _feeitem_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FEEITEM_NAME
		{
			set{ _feeitem_name=value;}
			get{return _feeitem_name;}
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
		public string FEEITEM_TYPE
		{
			set{ _feeitem_type=value;}
			get{return _feeitem_type;}
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

