using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_system
		public class his_comm_system
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
		/// SYSTEM_CODE
        /// </summary>		
		private string _system_code;
        public string SYSTEM_CODE
        {
            get{ return _system_code; }
            set{ _system_code = value; }
        }        
		/// <summary>
		/// SYSTEM_NAME
        /// </summary>		
		private string _system_name;
        public string SYSTEM_NAME
        {
            get{ return _system_name; }
            set{ _system_name = value; }
        }        
		/// <summary>
		/// IS_USER
        /// </summary>		
		private string _is_user;
        public string IS_USER
        {
            get{ return _is_user; }
            set{ _is_user = value; }
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

