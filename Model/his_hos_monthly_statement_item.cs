using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_monthly_statement_item:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_monthly_statement_item
	{
		public his_hos_monthly_statement_item()
		{}
		#region Model
		private string _item_type;
		private int? _item_sum_pay;
		private int? _item_cash_pay;
		private int? _item_card_pay;
		private int? _item_insurance_pay;
		private string _status;
		private string _id;
		private string _monthly_code;
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
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MONTHLY_CODE
		{
			set{ _monthly_code=value;}
			get{return _monthly_code;}
		}
		#endregion Model

	}
}

