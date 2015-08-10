using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_role
		public class his_comm_role
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
		/// ROLE_CODE
        /// </summary>		
		private string _role_code;
        public string ROLE_CODE
        {
            get{ return _role_code; }
            set{ _role_code = value; }
        }        
		/// <summary>
		/// ROLE_NAME
        /// </summary>		
		private string _role_name;
        public string ROLE_NAME
        {
            get{ return _role_name; }
            set{ _role_name = value; }
        }        
		/// <summary>
		/// ROLE_XML
        /// </summary>		
		private string _role_xml;
        public string ROLE_XML
        {
            get{ return _role_xml; }
            set{ _role_xml = value; }
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
		/// IS_USE
        /// </summary>		
		private string _is_use;
        public string IS_USE
        {
            get{ return _is_use; }
            set{ _is_use = value; }
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

