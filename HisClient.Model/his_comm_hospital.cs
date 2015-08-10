using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_hospital
		public class his_comm_hospital
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
		/// HOSPITAL_CODE
        /// </summary>		
		private string _hospital_code;
        public string HOSPITAL_CODE
        {
            get{ return _hospital_code; }
            set{ _hospital_code = value; }
        }        
		/// <summary>
		/// HOSPITAL_NAME
        /// </summary>		
		private string _hospital_name;
        public string HOSPITAL_NAME
        {
            get{ return _hospital_name; }
            set{ _hospital_name = value; }
        }        
		/// <summary>
		/// HOSPITAL_LEVEL
        /// </summary>		
		private string _hospital_level;
        public string HOSPITAL_LEVEL
        {
            get{ return _hospital_level; }
            set{ _hospital_level = value; }
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

