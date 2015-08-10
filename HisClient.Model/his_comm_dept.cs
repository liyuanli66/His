using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_dept
		public class his_comm_dept
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
		/// DEPT_CODE
        /// </summary>		
		private string _dept_code;
        public string DEPT_CODE
        {
            get{ return _dept_code; }
            set{ _dept_code = value; }
        }        
		/// <summary>
		/// DEPT_NAME
        /// </summary>		
		private string _dept_name;
        public string DEPT_NAME
        {
            get{ return _dept_name; }
            set{ _dept_name = value; }
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
		/// DEPT_TYPE
        /// </summary>		
		private string _dept_type;
        public string DEPT_TYPE
        {
            get{ return _dept_type; }
            set{ _dept_type = value; }
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

