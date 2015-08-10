using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_dosage
		public class his_comm_dosage
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
		/// DOSAGE_CODE
        /// </summary>		
		private string _dosage_code;
        public string DOSAGE_CODE
        {
            get{ return _dosage_code; }
            set{ _dosage_code = value; }
        }        
		/// <summary>
		/// DOSAGE_NAME
        /// </summary>		
		private string _dosage_name;
        public string DOSAGE_NAME
        {
            get{ return _dosage_name; }
            set{ _dosage_name = value; }
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
		/// CREATE_DATE
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
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
		   
	}
}

