using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_monthly_statement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_monthly_statement
	{
		public his_hos_monthly_statement()
		{}
		#region Model
		private string _operator;
		private DateTime? _operate_time;
		private string _reciver;
		private DateTime? _start_time;
		private DateTime? _end_time;
		private string _start_receipt_code;
		private string _end_receipt_code;
		private string _receipt__num;
		private string _retuen_receipt_num;
		private string _id;
		/// <summary>
		/// 
		/// </summary>
		public string OPERATOR
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OPERATE_TIME
		{
			set{ _operate_time=value;}
			get{return _operate_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECIVER
		{
			set{ _reciver=value;}
			get{return _reciver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? START_TIME
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? END_TIME
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string START_RECEIPT_CODE
		{
			set{ _start_receipt_code=value;}
			get{return _start_receipt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string END_RECEIPT_CODE
		{
			set{ _end_receipt_code=value;}
			get{return _end_receipt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RECEIPT__NUM
		{
			set{ _receipt__num=value;}
			get{return _receipt__num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RETUEN_RECEIPT_NUM
		{
			set{ _retuen_receipt_num=value;}
			get{return _retuen_receipt_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		#endregion Model

	}
}

