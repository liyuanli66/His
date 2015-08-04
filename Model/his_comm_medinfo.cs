using System;
namespace HIS.Model
{
	/// <summary>
	/// his_comm_medinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_comm_medinfo
	{
		public his_comm_medinfo()
		{}
		#region Model
		private string _id;
		private string _med_code;
		private string _med_name;
		private string _help_code;
		private string _menufacture_code;
		private string _med_spc;
		private string _med_unit;
		private string _dosage_code;
		private string _approval_number;
		private string _efficacy_code;
		private string _origin;
		private string _create_by;
		private DateTime? _create_date;
		private string _medinfo_code;
		private string _pakage_unit;
		private int? _pakage_pm_number;
		private decimal? _default_dosage_amount;
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
		public string MED_CODE
		{
			set{ _med_code=value;}
			get{return _med_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MED_NAME
		{
			set{ _med_name=value;}
			get{return _med_name;}
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
		public string MENUFACTURE_CODE
		{
			set{ _menufacture_code=value;}
			get{return _menufacture_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MED_SPC
		{
			set{ _med_spc=value;}
			get{return _med_spc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MED_UNIT
		{
			set{ _med_unit=value;}
			get{return _med_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOSAGE_CODE
		{
			set{ _dosage_code=value;}
			get{return _dosage_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string APPROVAL_NUMBER
		{
			set{ _approval_number=value;}
			get{return _approval_number;}
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
		public string ORIGIN
		{
			set{ _origin=value;}
			get{return _origin;}
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
		public string MEDINFO_CODE
		{
			set{ _medinfo_code=value;}
			get{return _medinfo_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAKAGE_UNIT
		{
			set{ _pakage_unit=value;}
			get{return _pakage_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PAKAGE_PM_NUMBER
		{
			set{ _pakage_pm_number=value;}
			get{return _pakage_pm_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DEFAULT_DOSAGE_AMOUNT
		{
			set{ _default_dosage_amount=value;}
			get{return _default_dosage_amount;}
		}
		#endregion Model

	}
}

