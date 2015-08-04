using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_efficacy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_efficacy
	{
		public his_comm_efficacy()
		{}
		#region Model
		private string _id;
		private string _efficacy_code;
		private string _efficacy_name;
		private string _help_code;
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
		public string EFFICACY_CODE
		{
			set{ _efficacy_code=value;}
			get{return _efficacy_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EFFICACY_NAME
		{
			set{ _efficacy_name=value;}
			get{return _efficacy_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HELP_CODE
		{
			set{ _help_code=value;}
			get{return _help_code;}
		}
		#endregion Model

	}
}

