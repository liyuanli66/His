using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_receipt_detail_cancle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_receipt_detail_cancle
	{
		public his_hos_receipt_detail_cancle()
		{}
		#region Model
		private string _id;
		private string _hos_receipt_code;
		private string _his_hos_code;
		private string _feeitem_code;
		private string _feeitem_name;
		private decimal _price;
		private decimal? _count;
		private string _unit;
		private decimal? _amt;
		private string _opt_user;
		private DateTime _opt_date;
		private string _opt_term;
		private string _opt_orga;
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
		public string HOS_RECEIPT_CODE
		{
			set{ _hos_receipt_code=value;}
			get{return _hos_receipt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HIS_HOS_CODE
		{
			set{ _his_hos_code=value;}
			get{return _his_hos_code;}
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
		public decimal PRICE
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COUNT
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UNIT
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AMT
		{
			set{ _amt=value;}
			get{return _amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_USER
		{
			set{ _opt_user=value;}
			get{return _opt_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OPT_DATE
		{
			set{ _opt_date=value;}
			get{return _opt_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_TERM
		{
			set{ _opt_term=value;}
			get{return _opt_term;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_ORGA
		{
			set{ _opt_orga=value;}
			get{return _opt_orga;}
		}
		#endregion Model

	}
}

