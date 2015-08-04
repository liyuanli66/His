﻿using System;
namespace HIS.Model
{
	/// <summary>
	/// comm_icd10_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class comm_icd10_type
	{
		public comm_icd10_type()
		{}
		#region Model
		private string _type_code;
		private string _id;
		private string _type_name;
		private DateTime? _create_date;
		private string _create_by;
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
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
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
