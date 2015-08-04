using System;
namespace HIS.Model
{
	/// <summary>
	/// his_pm_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_pm_check
	{
		public his_pm_check()
		{}
		#region Model
		private string _id;
		private string _check_code;
		private string _create_by;
		private DateTime? _create_date;
		private string _dept_code;
		private string _dept_name;
		private string _memo;
		private decimal? _lose_cost;
		private decimal? _profit_cost;
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
		public string CHECK_CODE
		{
			set{ _check_code=value;}
			get{return _check_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_BY
		{
			set{ _create_by=value;}
			get{return _create_by;}
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
		public string DEPT_CODE
		{
			set{ _dept_code=value;}
			get{return _dept_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPT_NAME
		{
			set{ _dept_name=value;}
			get{return _dept_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LOSE_COST
		{
			set{ _lose_cost=value;}
			get{return _lose_cost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PROFIT_COST
		{
			set{ _profit_cost=value;}
			get{return _profit_cost;}
		}
		#endregion Model

	}
}

