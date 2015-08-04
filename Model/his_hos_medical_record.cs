using System;
namespace HIS.Model
{
	/// <summary>
	/// his_hos_medical_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class his_hos_medical_record
	{
		public his_hos_medical_record()
		{}
		#region Model
		private string _ip;
		private string _his_hos_code;
		private string _case_code;
		private string _patient_name;
		private string _md_dept_id;
		private string _md_sickroom_id;
		private string _me_bed_id;
		private DateTime? _in_date;
		private DateTime? _out_date;
		private string _status;
		private int? _in_hospital_order;
		private string _create_by;
		private DateTime? _update_date;
		private string _update_by;
		private string _is_removed;
		private string _help_code;
		private DateTime? _create_date;
		private string _charge_doctor_name;
		private string _charge_nurse_id;
		private string _charge_nurse_name;
		private string _patient_pay_type;
		private string _nursing_class;
		private string _patient_condition;
		private string _accl_acct_id;
		private string _type;
		private string _change_dept_help;
		private string _in_way;
		private string _in_way_doctor;
		private string _is_infection;
		private string _introducer;
		private string _attending_doctor_id;
		private string _in_hos_age;
		private string _md_dept_name;
		private string _md_bed_code;
		private string _md_sickroom_name;
		private int? _doc_edit_is;
		private string _doc_edit_account;
		private int? _nurse_edit_is;
		private string _nurse_editaccount;
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
		public string HIS_HOS_CODE
		{
			set{ _his_hos_code=value;}
			get{return _his_hos_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Case_Code
		{
			set{ _case_code=value;}
			get{return _case_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Patient_Name
		{
			set{ _patient_name=value;}
			get{return _patient_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD_Dept_ID
		{
			set{ _md_dept_id=value;}
			get{return _md_dept_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD_SickRoom_ID
		{
			set{ _md_sickroom_id=value;}
			get{return _md_sickroom_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ME_Bed_ID
		{
			set{ _me_bed_id=value;}
			get{return _me_bed_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? In_Date
		{
			set{ _in_date=value;}
			get{return _in_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Out_Date
		{
			set{ _out_date=value;}
			get{return _out_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? In_Hospital_Order
		{
			set{ _in_hospital_order=value;}
			get{return _in_hospital_order;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Create_by
		{
			set{ _create_by=value;}
			get{return _create_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Update_date
		{
			set{ _update_date=value;}
			get{return _update_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Update_by
		{
			set{ _update_by=value;}
			get{return _update_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_removed
		{
			set{ _is_removed=value;}
			get{return _is_removed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Help_Code
		{
			set{ _help_code=value;}
			get{return _help_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Charge_Doctor_Name
		{
			set{ _charge_doctor_name=value;}
			get{return _charge_doctor_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Charge_Nurse_ID
		{
			set{ _charge_nurse_id=value;}
			get{return _charge_nurse_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Charge_Nurse_Name
		{
			set{ _charge_nurse_name=value;}
			get{return _charge_nurse_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Patient_Pay_Type
		{
			set{ _patient_pay_type=value;}
			get{return _patient_pay_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NURSING_CLASS
		{
			set{ _nursing_class=value;}
			get{return _nursing_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PATIENT_CONDITION
		{
			set{ _patient_condition=value;}
			get{return _patient_condition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACCL_ACCT_ID
		{
			set{ _accl_acct_id=value;}
			get{return _accl_acct_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHANGE_DEPT_HELP
		{
			set{ _change_dept_help=value;}
			get{return _change_dept_help;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_WAY
		{
			set{ _in_way=value;}
			get{return _in_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_WAY_Doctor
		{
			set{ _in_way_doctor=value;}
			get{return _in_way_doctor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IS_INFECTION
		{
			set{ _is_infection=value;}
			get{return _is_infection;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INTRODUCER
		{
			set{ _introducer=value;}
			get{return _introducer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ATTENDING_DOCTOR_ID
		{
			set{ _attending_doctor_id=value;}
			get{return _attending_doctor_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IN_HOS_AGE
		{
			set{ _in_hos_age=value;}
			get{return _in_hos_age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD_DEPT_NAME
		{
			set{ _md_dept_name=value;}
			get{return _md_dept_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD_BED_CODE
		{
			set{ _md_bed_code=value;}
			get{return _md_bed_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MD_SICKROOM_NAME
		{
			set{ _md_sickroom_name=value;}
			get{return _md_sickroom_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DOC_EDIT_IS
		{
			set{ _doc_edit_is=value;}
			get{return _doc_edit_is;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DOC_EDIT_Account
		{
			set{ _doc_edit_account=value;}
			get{return _doc_edit_account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Nurse_EDIT_IS
		{
			set{ _nurse_edit_is=value;}
			get{return _nurse_edit_is;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nurse_EDITAccount
		{
			set{ _nurse_editaccount=value;}
			get{return _nurse_editaccount;}
		}
		#endregion Model

	}
}

