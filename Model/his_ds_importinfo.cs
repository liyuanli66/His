using System;
namespace HIS.Model
{
	/// <summary>
	/// his_ds_importinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_ds_importinfo
	{
		public his_ds_importinfo()
		{}
		#region Model
		private string _id;
		private string _import_code;
		private string _med_code;
		private string _med_name;
		private string _pakage_unit;
		private int? _pakage_amount;
		private string _menufacture_code;
		private string _medinfo_code;
		private string _med_spc;
		private decimal? _med_price;
		private decimal? _purchase_price;
		private DateTime? _validity_date;
		private string _batchno;
		private DateTime? _med_madetime;
		private decimal? _wholesale_price;
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
		public int? PAKAGE_AMOUNT
		{
			set{ _pakage_amount=value;}
			get{return _pakage_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MENUFACTURE_CODE
		{
			set{ _menufacture_code=value;}
			get{return _menufacture_code;}
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
		public string MED_SPC
		{
			set{ _med_spc=value;}
			get{return _med_spc;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? WHOLESALE_PRICE
		{
			set{ _wholesale_price=value;}
			get{return _wholesale_price;}
		}
		#endregion Model

	}
}

