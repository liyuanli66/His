using System;
namespace HIS.Model
{
	/// <summary>
	/// his_ds_import:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_ds_import
	{
		public his_ds_import()
		{}
		#region Model
		private string _id;
		private string _import_code;
		private string _import_type;
		private string _manufacture_code;
		private string _manufacture_name;
		private string _invoice_no;
		private string _account_flag;
		private DateTime? _account_date;
		private string _ispay_flag;
		private DateTime? _pay_time;
		private string _contract_no;
		private string _import_flag;
		private decimal? _cost;
		private string _create_by;
		private DateTime? _create_date;
		private string _purchaser;
		private DateTime? _purchase_date;
		private string _cancel_oprator;
		private DateTime? _cancel_date;
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
		public string IMPORT_CODE
		{
			set{ _import_code=value;}
			get{return _import_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMPORT_TYPE
		{
			set{ _import_type=value;}
			get{return _import_type;}
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
		public string MANUFACTURE_NAME
		{
			set{ _manufacture_name=value;}
			get{return _manufacture_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INVOICE_NO
		{
			set{ _invoice_no=value;}
			get{return _invoice_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCOUNT_FLAG
		{
			set{ _account_flag=value;}
			get{return _account_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ACCOUNT_DATE
		{
			set{ _account_date=value;}
			get{return _account_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ISPAY_FLAG
		{
			set{ _ispay_flag=value;}
			get{return _ispay_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PAY_TIME
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONTRACT_NO
		{
			set{ _contract_no=value;}
			get{return _contract_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMPORT_FLAG
		{
			set{ _import_flag=value;}
			get{return _import_flag;}
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
		public string PURCHASER
		{
			set{ _purchaser=value;}
			get{return _purchaser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PURCHASE_DATE
		{
			set{ _purchase_date=value;}
			get{return _purchase_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CANCEL_OPRATOR
		{
			set{ _cancel_oprator=value;}
			get{return _cancel_oprator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CANCEL_DATE
		{
			set{ _cancel_date=value;}
			get{return _cancel_date;}
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

