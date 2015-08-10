using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_medname
		public class his_comm_medname
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
		/// TYPE_CODE
        /// </summary>		
		private string _type_code;
        public string TYPE_CODE
        {
            get{ return _type_code; }
            set{ _type_code = value; }
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

