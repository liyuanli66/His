using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_feeitem
		public class his_comm_feeitem
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
		/// FEEITEM_CODE
        /// </summary>		
		private string _feeitem_code;
        public string FEEITEM_CODE
        {
            get{ return _feeitem_code; }
            set{ _feeitem_code = value; }
        }        
		/// <summary>
		/// FEEITEM_NAME
        /// </summary>		
		private string _feeitem_name;
        public string FEEITEM_NAME
        {
            get{ return _feeitem_name; }
            set{ _feeitem_name = value; }
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
		/// FEEITEM_TYPE
        /// </summary>		
		private string _feeitem_type;
        public string FEEITEM_TYPE
        {
            get{ return _feeitem_type; }
            set{ _feeitem_type = value; }
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

