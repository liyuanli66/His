using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_pm_export
		public class his_pm_export
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
		/// EXPORT_CODE
        /// </summary>		
		private string _export_code;
        public string EXPORT_CODE
        {
            get{ return _export_code; }
            set{ _export_code = value; }
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
		/// SEND_DEPT_CODE
        /// </summary>		
		private string _send_dept_code;
        public string SEND_DEPT_CODE
        {
            get{ return _send_dept_code; }
            set{ _send_dept_code = value; }
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

