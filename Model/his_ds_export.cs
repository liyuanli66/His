using System;
namespace HIS.Model
{
	/// <summary>
	/// his_ds_export:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_ds_export
	{
		public his_ds_export()
		{}
		#region Model
		private string _id;
		private string _export_code;
		private string _manufacture_name;
		private string _manufacture_code;
		private string _export_type;
		private string _export_dept;
		private string _create_by;
		private DateTime? _create_date;
		private decimal? _cost;
		private string _operator_name;
		private DateTime? _operator_date;
		private string _cancel_operator;
		private DateTime? _cancel_date;
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
		public string MANUFACTURE_NAME
		{
			set{ _manufacture_name=value;}
			get{return _manufacture_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANUFACTURE_CODE
		{
			set{ _manufacture_code=value;}
			get{return _manufacture_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXPORT_TYPE
		{
			set{ _export_type=value;}
			get{return _export_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXPORT_DEPT
		{
			set{ _export_dept=value;}
			get{return _export_dept;}
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
		public decimal? COST
		{
			set{ _cost=value;}
			get{return _cost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPERATOR_NAME
		{
			set{ _operator_name=value;}
			get{return _operator_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OPERATOR_DATE
		{
			set{ _operator_date=value;}
			get{return _operator_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CANCEL_OPERATOR
		{
			set{ _cancel_operator=value;}
			get{return _cancel_operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CANCEL_DATE
		{
			set{ _cancel_date=value;}
			get{return _cancel_date;}
		}
		#endregion Model

	}
}

