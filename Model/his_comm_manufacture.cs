using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_manufacture:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_manufacture
	{
		public his_comm_manufacture()
		{}
		#region Model
		private string _id;
		private string _manufacture_code;
		private string _manufacture_name;
		private string _locality_type;
		private int? _credit_code;
		private string _manufacture_address;
		private string _link_man;
		private string _link_tel;
		private string _link_email;
		private string _fax;
		private string _aptitude;
		private DateTime? _aptitude_date;
		private string _help_code;
		private string _hospital_code;
		private DateTime? _create_date;
		private string _create_by;
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
		public string MANUFACTURE_CODE
		{
			set{ _manufacture_code=value;}
			get{return _manufacture_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANUFACTURE_NAME
		{
			set{ _manufacture_name=value;}
			get{return _manufacture_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOCALITY_TYPE
		{
			set{ _locality_type=value;}
			get{return _locality_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CREDIT_CODE
		{
			set{ _credit_code=value;}
			get{return _credit_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANUFACTURE_ADDRESS
		{
			set{ _manufacture_address=value;}
			get{return _manufacture_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINK_MAN
		{
			set{ _link_man=value;}
			get{return _link_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINK_TEL
		{
			set{ _link_tel=value;}
			get{return _link_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINK_EMAIL
		{
			set{ _link_email=value;}
			get{return _link_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAX
		{
			set{ _fax=value;}
			get{return _fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APTITUDE
		{
			set{ _aptitude=value;}
			get{return _aptitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? APTITUDE_DATE
		{
			set{ _aptitude_date=value;}
			get{return _aptitude_date;}
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
		public string HOSPITAL_CODE
		{
			set{ _hospital_code=value;}
			get{return _hospital_code;}
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
		#endregion Model

	}
}

