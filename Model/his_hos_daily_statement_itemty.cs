using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_daily_statement_itemty:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_daily_statement_itemty
	{
		public his_hos_daily_statement_itemty()
		{}
		#region Model
		private string _id;
		private string _item_type;
		private int? _item_sum_pay;
		private int? _item_cash_pay;
		private int? _item_card_pay;
		private int? _item_insurance_pay;
		private string _status;
		private string _daily_code;
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
		public string ITEM_TYPE
		{
			set{ _item_type=value;}
			get{return _item_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ITEM_SUM_PAY
		{
			set{ _item_sum_pay=value;}
			get{return _item_sum_pay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ITEM_CASH_PAY
		{
			set{ _item_cash_pay=value;}
			get{return _item_cash_pay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ITEM_CARD_PAY
		{
			set{ _item_card_pay=value;}
			get{return _item_card_pay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ITEM_INSURANCE_PAY
		{
			set{ _item_insurance_pay=value;}
			get{return _item_insurance_pay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DAILY_CODE
		{
			set{ _daily_code=value;}
			get{return _daily_code;}
		}
		#endregion Model

	}
}

