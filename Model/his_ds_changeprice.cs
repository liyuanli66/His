using System;
namespace HIS.Model
{
	/// <summary>
	/// his_ds_changeprice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_ds_changeprice
	{
		public his_ds_changeprice()
		{}
		#region Model
		private string _id;
		private DateTime? _create_date;
		private string _create_by;
		private string _memo;
		private string _change_code;
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
		public string CHANGE_CODE
		{
			set{ _change_code=value;}
			get{return _change_code;}
		}
		#endregion Model

	}
}

