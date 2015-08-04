using System;
namespace HIS.Model
{
	/// <summary>
	/// his_bil_cl_receipt:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_bil_cl_receipt
	{
		public his_bil_cl_receipt()
		{}
		#region Model
		private string _cl_receipt_code;
		private string _cl_code;
		private string _cashier;
		private string _receicpt_code;
		private DateTime _reciver_time;
		private decimal _cash_amt;
		private decimal _card_amt;
		private decimal? _insurance_amt;
		private decimal? _sum_amt;
		private string _refund_recp_code;
		private DateTime? _refund_date;
		private string _refund_opt;
		private int? _reduce_amt;
		private DateTime? _reduce_date;
		private string _reduce_opt;
		private string _reduce_reason;
		private string _opt_user;
		private DateTime _opt_date;
		private string _opt_term;
		private string _opt_orga;
		/// <summary>
		/// 
		/// </summary>
		public string CL_RECEIPT_CODE
		{
			set{ _cl_receipt_code=value;}
			get{return _cl_receipt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CL_CODE
		{
			set{ _cl_code=value;}
			get{return _cl_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CASHIER
		{
			set{ _cashier=value;}
			get{return _cashier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECEICPT_CODE
		{
			set{ _receicpt_code=value;}
			get{return _receicpt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RECIVER_TIME
		{
			set{ _reciver_time=value;}
			get{return _reciver_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CASH_AMT
		{
			set{ _cash_amt=value;}
			get{return _cash_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal CARD_AMT
		{
			set{ _card_amt=value;}
			get{return _card_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? INSURANCE_AMT
		{
			set{ _insurance_amt=value;}
			get{return _insurance_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SUM_AMT
		{
			set{ _sum_amt=value;}
			get{return _sum_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REFUND_RECP_CODE
		{
			set{ _refund_recp_code=value;}
			get{return _refund_recp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? REFUND_DATE
		{
			set{ _refund_date=value;}
			get{return _refund_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REFUND_OPT
		{
			set{ _refund_opt=value;}
			get{return _refund_opt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? REDUCE_AMT
		{
			set{ _reduce_amt=value;}
			get{return _reduce_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? REDUCE_DATE
		{
			set{ _reduce_date=value;}
			get{return _reduce_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REDUCE_OPT
		{
			set{ _reduce_opt=value;}
			get{return _reduce_opt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REDUCE_REASON
		{
			set{ _reduce_reason=value;}
			get{return _reduce_reason;}
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

