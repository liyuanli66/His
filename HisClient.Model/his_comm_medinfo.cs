using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_medinfo
		public class his_comm_medinfo
	{
   		     
      	/// <summary>
		/// ID
        /// </summary>		
		private string _id;
        public string ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// MED_CODE
        /// </summary>		
		private string _med_code;
        public string MED_CODE
        {
            get{ return _med_code; }
            set{ _med_code = value; }
        }        
		/// <summary>
		/// MED_NAME
        /// </summary>		
		private string _med_name;
        public string MED_NAME
        {
            get{ return _med_name; }
            set{ _med_name = value; }
        }        
		/// <summary>
		/// HELP_CODE
        /// </summary>		
		private string _help_code;
        public string HELP_CODE
        {
            get{ return _help_code; }
            set{ _help_code = value; }
        }        
		/// <summary>
		/// MENUFACTURE_CODE
        /// </summary>		
		private string _menufacture_code;
        public string MENUFACTURE_CODE
        {
            get{ return _menufacture_code; }
            set{ _menufacture_code = value; }
        }        
		/// <summary>
		/// MED_SPC
        /// </summary>		
		private string _med_spc;
        public string MED_SPC
        {
            get{ return _med_spc; }
            set{ _med_spc = value; }
        }        
		/// <summary>
		/// MED_UNIT
        /// </summary>		
		private string _med_unit;
        public string MED_UNIT
        {
            get{ return _med_unit; }
            set{ _med_unit = value; }
        }        
		/// <summary>
		/// DOSAGE_CODE
        /// </summary>		
		private string _dosage_code;
        public string DOSAGE_CODE
        {
            get{ return _dosage_code; }
            set{ _dosage_code = value; }
        }        
		/// <summary>
		/// APPROVAL_NUMBER
        /// </summary>		
		private string _approval_number;
        public string APPROVAL_NUMBER
        {
            get{ return _approval_number; }
            set{ _approval_number = value; }
        }        
		/// <summary>
		/// EFFICACY_CODE
        /// </summary>		
		private string _efficacy_code;
        public string EFFICACY_CODE
        {
            get{ return _efficacy_code; }
            set{ _efficacy_code = value; }
        }        
		/// <summary>
		/// ORIGIN
        /// </summary>		
		private string _origin;
        public string ORIGIN
        {
            get{ return _origin; }
            set{ _origin = value; }
        }        
		/// <summary>
		/// CREATE_BY
        /// </summary>		
		private string _create_by;
        public string CREATE_BY
        {
            get{ return _create_by; }
            set{ _create_by = value; }
        }        
		/// <summary>
		/// CREATE_DATE
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
        }        
		/// <summary>
		/// MEDINFO_CODE
        /// </summary>		
		private string _medinfo_code;
        public string MEDINFO_CODE
        {
            get{ return _medinfo_code; }
            set{ _medinfo_code = value; }
        }        
		/// <summary>
		/// PAKAGE_UNIT
        /// </summary>		
		private string _pakage_unit;
        public string PAKAGE_UNIT
        {
            get{ return _pakage_unit; }
            set{ _pakage_unit = value; }
        }        
		/// <summary>
		/// PAKAGE_PM_NUMBER
        /// </summary>		
		private int _pakage_pm_number;
        public int PAKAGE_PM_NUMBER
        {
            get{ return _pakage_pm_number; }
            set{ _pakage_pm_number = value; }
        }        
		/// <summary>
		/// DEFAULT_DOSAGE_AMOUNT
        /// </summary>		
		private decimal _default_dosage_amount;
        public decimal DEFAULT_DOSAGE_AMOUNT
        {
            get{ return _default_dosage_amount; }
            set{ _default_dosage_amount = value; }
        }        
		   
	}
}

