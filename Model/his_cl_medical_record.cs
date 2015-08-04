using System;
namespace HIS.Model
{
	/// <summary>
	/// his_cl_medical_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_cl_medical_record
	{
		public his_cl_medical_record()
		{}
		#region Model
		private string _cl_code;
		private string _pha_code;
		private string _doctor_code;
		private DateTime? _cl_date;
		private string _ip;
		private string _icd_code;
		private string _icd_name;
		private string _memo;
		private string _opt_user;
		private DateTime _opt_date;
		private string _opt_term;
		private string _opt_orga;
		/// <summary>
		/// 
		/// </summary>
		public string CL_CODE
		{
			set{ _cl_code=value;}
			get{return _cl_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHA_CODE
		{
			set{ _pha_code=value;}
			get{return _pha_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOCTOR_CODE
		{
			set{ _doctor_code=value;}
			get{return _doctor_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CL_DATE
		{
			set{ _cl_date=value;}
			get{return _cl_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
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
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_USER
		{
			set{ _opt_user=value;}
			get{return _opt_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OPT_DATE
		{
			set{ _opt_date=value;}
			get{return _opt_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_TERM
		{
			set{ _opt_term=value;}
			get{return _opt_term;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OPT_ORGA
		{
			set{ _opt_orga=value;}
			get{return _opt_orga;}
		}
		#endregion Model

	}
}

