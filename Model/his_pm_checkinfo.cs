﻿using System;
namespace HIS.Model
{
	/// <summary>
	/// his_pm_checkinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_pm_checkinfo
	{
		public his_pm_checkinfo()
		{}
		#region Model
		private string _id;
		private string _medinfo_code;
		private string _med_spc;
		private string _med_unit;
		private decimal? _med_amount;
		private decimal? _real_amount;
		private decimal? _med_price;
		private decimal? _purchase_price;
		private decimal? _wholesale_price;
		private DateTime? _validity_date;
		private DateTime? _med_madetime;
		private string _bachno;
		private string _dept_code;
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
		public string MED_UNIT
		{
			set{ _med_unit=value;}
			get{return _med_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MED_AMOUNT
		{
			set{ _med_amount=value;}
			get{return _med_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? REAL_AMOUNT
		{
			set{ _real_amount=value;}
			get{return _real_amount;}
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
		public decimal? WHOLESALE_PRICE
		{
			set{ _wholesale_price=value;}
			get{return _wholesale_price;}
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
		public DateTime? MED_MADETIME
		{
			set{ _med_madetime=value;}
			get{return _med_madetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BACHNO
		{
			set{ _bachno=value;}
			get{return _bachno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPT_CODE
		{
			set{ _dept_code=value;}
			get{return _dept_code;}
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
