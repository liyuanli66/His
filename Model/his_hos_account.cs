using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_account
	{
		public his_hos_account()
		{}
		#region Model
		private string _hos_acc_code;
		private string _his_hos_code;
		private string _ip;
		private decimal _sum_in;
		private decimal _sum_out;
		private decimal? _account_balance;
		private decimal? _lower_limit;
		private string _opt_user;
		private DateTime _opt_date;
		private string _opt_term;
		private string _opt_orga;
		/// <summary>
		/// 
		/// </summary>
		public string HOS_ACC_CODE
		{
			set{ _hos_acc_code=value;}
			get{return _hos_acc_code;}
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
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SUM_IN
		{
			set{ _sum_in=value;}
			get{return _sum_in;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SUM_OUT
		{
			set{ _sum_out=value;}
			get{return _sum_out;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ACCOUNT_BALANCE
		{
			set{ _account_balance=value;}
			get{return _account_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LOWER_LIMIT
		{
			set{ _lower_limit=value;}
			get{return _lower_limit;}
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

