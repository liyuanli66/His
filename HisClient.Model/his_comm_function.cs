using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_function
		public class his_comm_function
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
		/// MODULE_CODE
        /// </summary>		
		private string _module_code;
        public string MODULE_CODE
        {
            get{ return _module_code; }
            set{ _module_code = value; }
        }        
		/// <summary>
		/// FUNCTION_CODE
        /// </summary>		
		private string _function_code;
        public string FUNCTION_CODE
        {
            get{ return _function_code; }
            set{ _function_code = value; }
        }        
		/// <summary>
		/// FUNCTION_NAME
        /// </summary>		
		private string _function_name;
        public string FUNCTION_NAME
        {
            get{ return _function_name; }
            set{ _function_name = value; }
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
		/// HOSPITAL_CODE
        /// </summary>		
		private string _hospital_code;
        public string HOSPITAL_CODE
        {
            get{ return _hospital_code; }
            set{ _hospital_code = value; }
        }        
		/// <summary>
		/// REMARKS
        /// </summary>		
		private string _remarks;
        public string REMARKS
        {
            get{ return _remarks; }
            set{ _remarks = value; }
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

