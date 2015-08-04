using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_medtype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_medtype
	{
		public his_comm_medtype()
		{}
		#region Model
		private string _id;
		private string _type_code;
		private string _type_name;
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
		public string TYPE_CODE
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE_NAME
		{
			set{ _type_name=value;}
			get{return _type_name;}
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

