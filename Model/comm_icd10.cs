using System;
namespace HIS.Model
{
	/// <summary>
	/// comm_icd10:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class comm_icd10
	{
		public comm_icd10()
		{}
		#region Model
		private string _id;
		private string _icd_code;
		private string _icd_name;
		private string _help_code;
		private string _type_code;
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
		public string ICD_CODE
		{
			set{ _icd_code=value;}
			get{return _icd_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ICD_NAME
		{
			set{ _icd_name=value;}
			get{return _icd_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HELP_CODE
		{
			set{ _help_code=value;}
			get{return _help_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE_CODE
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		#endregion Model

	}
}

