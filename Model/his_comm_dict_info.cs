﻿using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_dict_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_dict_info
	{
		public his_comm_dict_info()
		{}
		#region Model
		private string _id;
		private string _type_code;
		private string _dict_code;
		private string _dict_name;
		private string _help_code;
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
		public string TYPE_CODE
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DICT_CODE
		{
			set{ _dict_code=value;}
			get{return _dict_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DICT_NAME
		{
			set{ _dict_name=value;}
			get{return _dict_name;}
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

