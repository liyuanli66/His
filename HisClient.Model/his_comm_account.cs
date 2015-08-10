using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_account
		public class his_comm_account
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
		/// ACCOUNT
        /// </summary>		
		private string _account;
        public string ACCOUNT
        {
            get{ return _account; }
            set{ _account = value; }
        }        
		/// <summary>
		/// PASSWORD
        /// </summary>		
		private string _password;
        public string PASSWORD
        {
            get{ return _password; }
            set{ _password = value; }
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
		/// USER_CODE
        /// </summary>		
		private string _user_code;
        public string USER_CODE
        {
            get{ return _user_code; }
            set{ _user_code = value; }
        }        
		/// <summary>
		/// ADMIN_TYPE
        /// </summary>		
		private string _admin_type;
        public string ADMIN_TYPE
        {
            get{ return _admin_type; }
            set{ _admin_type = value; }
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
		/// AUTHORITY_XML
        /// </summary>		
		private string _authority_xml;
        public string AUTHORITY_XML
        {
            get{ return _authority_xml; }
            set{ _authority_xml = value; }
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
		/// <summary>
		/// LAST_LOGINTIME
        /// </summary>		
		private DateTime _last_logintime;
        public DateTime LAST_LOGINTIME
        {
            get{ return _last_logintime; }
            set{ _last_logintime = value; }
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
		   
	}
}

