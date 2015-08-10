using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_pm_import
		public class his_pm_import
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
		/// SEND_DEPT_CODE
        /// </summary>		
		private string _send_dept_code;
        public string SEND_DEPT_CODE
        {
            get{ return _send_dept_code; }
            set{ _send_dept_code = value; }
        }        
		/// <summary>
		/// RECEIVE_DEPT_CODE
        /// </summary>		
		private string _receive_dept_code;
        public string RECEIVE_DEPT_CODE
        {
            get{ return _receive_dept_code; }
            set{ _receive_dept_code = value; }
        }        
		/// <summary>
		/// PAKAGE_OUT_CODE
        /// </summary>		
		private string _pakage_out_code;
        public string PAKAGE_OUT_CODE
        {
            get{ return _pakage_out_code; }
            set{ _pakage_out_code = value; }
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
		/// IMPORT_CODE
        /// </summary>		
		private string _import_code;
        public string IMPORT_CODE
        {
            get{ return _import_code; }
            set{ _import_code = value; }
        }        
		   
	}
}

