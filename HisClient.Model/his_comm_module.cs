using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_module
		public class his_comm_module
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
		/// MODULE_NAME
        /// </summary>		
		private string _module_name;
        public string MODULE_NAME
        {
            get{ return _module_name; }
            set{ _module_name = value; }
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
		/// SYSTEM_CODE
        /// </summary>		
		private string _system_code;
        public string SYSTEM_CODE
        {
            get{ return _system_code; }
            set{ _system_code = value; }
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
		/// REMARK
        /// </summary>		
		private string _remark;
        public string REMARK
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		   
	}
}

