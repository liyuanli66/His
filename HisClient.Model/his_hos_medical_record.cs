using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_medical_record
		public class his_hos_medical_record
	{
   		     
      	/// <summary>
		/// IP
        /// </summary>		
		private string _ip;
        public string IP
        {
            get{ return _ip; }
            set{ _ip = value; }
        }        
		/// <summary>
		/// HIS_HOS_CODE
        /// </summary>		
		private string _his_hos_code;
        public string HIS_HOS_CODE
        {
            get{ return _his_hos_code; }
            set{ _his_hos_code = value; }
        }        
		/// <summary>
		/// Case_Code
        /// </summary>		
		private string _case_code;
        public string Case_Code
        {
            get{ return _case_code; }
            set{ _case_code = value; }
        }        
		/// <summary>
		/// Patient_Name
        /// </summary>		
		private string _patient_name;
        public string Patient_Name
        {
            get{ return _patient_name; }
            set{ _patient_name = value; }
        }        
		/// <summary>
		/// MD_Dept_ID
        /// </summary>		
		private string _md_dept_id;
        public string MD_Dept_ID
        {
            get{ return _md_dept_id; }
            set{ _md_dept_id = value; }
        }        
		/// <summary>
		/// MD_SickRoom_ID
        /// </summary>		
		private string _md_sickroom_id;
        public string MD_SickRoom_ID
        {
            get{ return _md_sickroom_id; }
            set{ _md_sickroom_id = value; }
        }        
		/// <summary>
		/// ME_Bed_ID
        /// </summary>		
		private string _me_bed_id;
        public string ME_Bed_ID
        {
            get{ return _me_bed_id; }
            set{ _me_bed_id = value; }
        }        
		/// <summary>
		/// In_Date
        /// </summary>		
		private DateTime _in_date;
        public DateTime In_Date
        {
            get{ return _in_date; }
            set{ _in_date = value; }
        }        
		/// <summary>
		/// Out_Date
        /// </summary>		
		private DateTime _out_date;
        public DateTime Out_Date
        {
            get{ return _out_date; }
            set{ _out_date = value; }
        }        
		/// <summary>
		/// Status
        /// </summary>		
		private string _status;
        public string Status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// In_Hospital_Order
        /// </summary>		
		private int _in_hospital_order;
        public int In_Hospital_Order
        {
            get{ return _in_hospital_order; }
            set{ _in_hospital_order = value; }
        }        
		/// <summary>
		/// Create_by
        /// </summary>		
		private string _create_by;
        public string Create_by
        {
            get{ return _create_by; }
            set{ _create_by = value; }
        }        
		/// <summary>
		/// Update_date
        /// </summary>		
		private DateTime _update_date;
        public DateTime Update_date
        {
            get{ return _update_date; }
            set{ _update_date = value; }
        }        
		/// <summary>
		/// Update_by
        /// </summary>		
		private string _update_by;
        public string Update_by
        {
            get{ return _update_by; }
            set{ _update_by = value; }
        }        
		/// <summary>
		/// is_removed
        /// </summary>		
		private string _is_removed;
        public string is_removed
        {
            get{ return _is_removed; }
            set{ _is_removed = value; }
        }        
		/// <summary>
		/// Help_Code
        /// </summary>		
		private string _help_code;
        public string Help_Code
        {
            get{ return _help_code; }
            set{ _help_code = value; }
        }        
		/// <summary>
		/// Create_date
        /// </summary>		
		private DateTime _create_date;
        public DateTime Create_date
        {
            get{ return _create_date; }
            set{ _create_date = value; }
        }        
		/// <summary>
		/// Charge_Doctor_Name
        /// </summary>		
		private string _charge_doctor_name;
        public string Charge_Doctor_Name
        {
            get{ return _charge_doctor_name; }
            set{ _charge_doctor_name = value; }
        }        
		/// <summary>
		/// Charge_Nurse_ID
        /// </summary>		
		private string _charge_nurse_id;
        public string Charge_Nurse_ID
        {
            get{ return _charge_nurse_id; }
            set{ _charge_nurse_id = value; }
        }        
		/// <summary>
		/// Charge_Nurse_Name
        /// </summary>		
		private string _charge_nurse_name;
        public string Charge_Nurse_Name
        {
            get{ return _charge_nurse_name; }
            set{ _charge_nurse_name = value; }
        }        
		/// <summary>
		/// Patient_Pay_Type
        /// </summary>		
		private string _patient_pay_type;
        public string Patient_Pay_Type
        {
            get{ return _patient_pay_type; }
            set{ _patient_pay_type = value; }
        }        
		/// <summary>
		/// NURSING_CLASS
        /// </summary>		
		private string _nursing_class;
        public string NURSING_CLASS
        {
            get{ return _nursing_class; }
            set{ _nursing_class = value; }
        }        
		/// <summary>
		/// PATIENT_CONDITION
        /// </summary>		
		private string _patient_condition;
        public string PATIENT_CONDITION
        {
            get{ return _patient_condition; }
            set{ _patient_condition = value; }
        }        
		/// <summary>
		/// ACCL_ACCT_ID
        /// </summary>		
		private string _accl_acct_id;
        public string ACCL_ACCT_ID
        {
            get{ return _accl_acct_id; }
            set{ _accl_acct_id = value; }
        }        
		/// <summary>
		/// TYPE
        /// </summary>		
		private string _type;
        public string TYPE
        {
            get{ return _type; }
            set{ _type = value; }
        }        
		/// <summary>
		/// CHANGE_DEPT_HELP
        /// </summary>		
		private string _change_dept_help;
        public string CHANGE_DEPT_HELP
        {
            get{ return _change_dept_help; }
            set{ _change_dept_help = value; }
        }        
		/// <summary>
		/// IN_WAY
        /// </summary>		
		private string _in_way;
        public string IN_WAY
        {
            get{ return _in_way; }
            set{ _in_way = value; }
        }        
		/// <summary>
		/// IN_WAY_Doctor
        /// </summary>		
		private string _in_way_doctor;
        public string IN_WAY_Doctor
        {
            get{ return _in_way_doctor; }
            set{ _in_way_doctor = value; }
        }        
		/// <summary>
		/// IS_INFECTION
        /// </summary>		
		private string _is_infection;
        public string IS_INFECTION
        {
            get{ return _is_infection; }
            set{ _is_infection = value; }
        }        
		/// <summary>
		/// INTRODUCER
        /// </summary>		
		private string _introducer;
        public string INTRODUCER
        {
            get{ return _introducer; }
            set{ _introducer = value; }
        }        
		/// <summary>
		/// ATTENDING_DOCTOR_ID
        /// </summary>		
		private string _attending_doctor_id;
        public string ATTENDING_DOCTOR_ID
        {
            get{ return _attending_doctor_id; }
            set{ _attending_doctor_id = value; }
        }        
		/// <summary>
		/// IN_HOS_AGE
        /// </summary>		
		private string _in_hos_age;
        public string IN_HOS_AGE
        {
            get{ return _in_hos_age; }
            set{ _in_hos_age = value; }
        }        
		/// <summary>
		/// MD_DEPT_NAME
        /// </summary>		
		private string _md_dept_name;
        public string MD_DEPT_NAME
        {
            get{ return _md_dept_name; }
            set{ _md_dept_name = value; }
        }        
		/// <summary>
		/// MD_BED_CODE
        /// </summary>		
		private string _md_bed_code;
        public string MD_BED_CODE
        {
            get{ return _md_bed_code; }
            set{ _md_bed_code = value; }
        }        
		/// <summary>
		/// MD_SICKROOM_NAME
        /// </summary>		
		private string _md_sickroom_name;
        public string MD_SICKROOM_NAME
        {
            get{ return _md_sickroom_name; }
            set{ _md_sickroom_name = value; }
        }        
		/// <summary>
		/// DOC_EDIT_IS
        /// </summary>		
		private int _doc_edit_is;
        public int DOC_EDIT_IS
        {
            get{ return _doc_edit_is; }
            set{ _doc_edit_is = value; }
        }        
		/// <summary>
		/// DOC_EDIT_Account
        /// </summary>		
		private string _doc_edit_account;
        public string DOC_EDIT_Account
        {
            get{ return _doc_edit_account; }
            set{ _doc_edit_account = value; }
        }        
		/// <summary>
		/// Nurse_EDIT_IS
        /// </summary>		
		private int _nurse_edit_is;
        public int Nurse_EDIT_IS
        {
            get{ return _nurse_edit_is; }
            set{ _nurse_edit_is = value; }
        }        
		/// <summary>
		/// Nurse_EDITAccount
        /// </summary>		
		private string _nurse_editaccount;
        public string Nurse_EDITAccount
        {
            get{ return _nurse_editaccount; }
            set{ _nurse_editaccount = value; }
        }        
		   
	}
}

