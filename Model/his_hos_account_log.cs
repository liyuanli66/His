using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_account_log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_account_log
	{
		public his_hos_account_log()
		{}
		#region Model
		private string _id;
		private string _hos_acc_code;
		private string _his_hos_code;
		private decimal? _amt;
		private string _pay_type;
		private string _is_refund;
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
		public decimal? AMT
		{
			set{ _amt=value;}
			get{return _amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAY_TYPE
		{
			set{ _pay_type=value;}
			get{return _pay_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IS_REFUND
		{
			set{ _is_refund=value;}
			get{return _is_refund;}
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

