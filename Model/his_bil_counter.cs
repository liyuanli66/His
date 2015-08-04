using System;
namespace HIS.Model
{
	/// <summary>
	/// his_bil_counter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_bil_counter
	{
		public his_bil_counter()
		{}
		#region Model
		private string _id;
		private string _cashier;
		private string _start_ivnno;
		private string _end_ivnno;
		private string _recp_type;
		private string _use_type;
		private decimal _recp_count;
		private string _pre_code;
		private decimal _refounded_count;
		private decimal _invalid_count;
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
		public string CASHIER
		{
			set{ _cashier=value;}
			get{return _cashier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string START_IVNNO
		{
			set{ _start_ivnno=value;}
			get{return _start_ivnno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string END_IVNNO
		{
			set{ _end_ivnno=value;}
			get{return _end_ivnno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECP_TYPE
		{
			set{ _recp_type=value;}
			get{return _recp_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_TYPE
		{
			set{ _use_type=value;}
			get{return _use_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal RECP_COUNT
		{
			set{ _recp_count=value;}
			get{return _recp_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PRE_CODE
		{
			set{ _pre_code=value;}
			get{return _pre_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal REFOUNDED_COUNT
		{
			set{ _refounded_count=value;}
			get{return _refounded_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal INVALID_COUNT
		{
			set{ _invalid_count=value;}
			get{return _invalid_count;}
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

