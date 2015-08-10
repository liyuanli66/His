using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_cl_medical_record
		public class his_cl_medical_record
	{
   		     
      	/// <summary>
		/// CL_CODE
        /// </summary>		
		private string _cl_code;
        public string CL_CODE
        {
            get{ return _cl_code; }
            set{ _cl_code = value; }
        }        
		/// <summary>
		/// PHA_CODE
        /// </summary>		
		private string _pha_code;
        public string PHA_CODE
        {
            get{ return _pha_code; }
            set{ _pha_code = value; }
        }        
		/// <summary>
		/// DOCTOR_CODE
        /// </summary>		
		private string _doctor_code;
        public string DOCTOR_CODE
        {
            get{ return _doctor_code; }
            set{ _doctor_code = value; }
        }        
		/// <summary>
		/// CL_DATE
        /// </summary>		
		private DateTime _cl_date;
        public DateTime CL_DATE
        {
            get{ return _cl_date; }
            set{ _cl_date = value; }
        }        
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
		/// ICD_CODE
        /// </summary>		
		private string _icd_code;
        public string ICD_CODE
        {
            get{ return _icd_code; }
            set{ _icd_code = value; }
        }        
		/// <summary>
		/// ICD_NAME
        /// </summary>		
		private string _icd_name;
        public string ICD_NAME
        {
            get{ return _icd_name; }
            set{ _icd_name = value; }
        }        
		/// <summary>
		/// MEMO
        /// </summary>		
		private string _memo;
        public string MEMO
        {
            get{ return _memo; }
            set{ _memo = value; }
        }        
		/// <summary>
		/// OPT_USER
        /// </summary>		
		private string _opt_user;
        public string OPT_USER
        {
            get{ return _opt_user; }
            set{ _opt_user = value; }
        }        
		/// <summary>
		/// OPT_DATE
        /// </summary>		
		private DateTime _opt_date;
        public DateTime OPT_DATE
        {
            get{ return _opt_date; }
            set{ _opt_date = value; }
        }        
		/// <summary>
		/// OPT_TERM
        /// </summary>		
		private string _opt_term;
        public string OPT_TERM
        {
            get{ return _opt_term; }
            set{ _opt_term = value; }
        }        
		/// <summary>
		/// OPT_ORGA
        /// </summary>		
		private string _opt_orga;
        public string OPT_ORGA
        {
            get{ return _opt_orga; }
            set{ _opt_orga = value; }
        }        
		   
	}
}

