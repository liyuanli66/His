using System;
namespace HIS.Model
{
	/// <summary>
	/// his_ds_exportinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_ds_exportinfo
	{
		public his_ds_exportinfo()
		{}
		#region Model
		private string _id;
		private string _export_code;
		private string _medinfo_code;
		private string _med_code;
		private string _med_name;
		private string _pakage_unit;
		private decimal? _pakage_amount;
		private decimal? _med_price;
		private decimal? _purchase_price;
		private DateTime? _validity_date;
		private string _batchno;
		private DateTime? _med_madetime;
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
		public string MEDINFO_CODE
		{
			set{ _medinfo_code=value;}
			get{return _medinfo_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MED_CODE
		{
			set{ _med_code=value;}
			get{return _med_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MED_NAME
		{
			set{ _med_name=value;}
			get{return _med_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAKAGE_UNIT
		{
			set{ _pakage_unit=value;}
			get{return _pakage_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PAKAGE_AMOUNT
		{
			set{ _pakage_amount=value;}
			get{return _pakage_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MED_PRICE
		{
			set{ _med_price=value;}
			get{return _med_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PURCHASE_PRICE
		{
			set{ _purchase_price=value;}
			get{return _purchase_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? VALIDITY_DATE
		{
			set{ _validity_date=value;}
			get{return _validity_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BATCHNO
		{
			set{ _batchno=value;}
			get{return _batchno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MED_MADETIME
		{
			set{ _med_madetime=value;}
			get{return _med_madetime;}
		}
		#endregion Model

	}
}

