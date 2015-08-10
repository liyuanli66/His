using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_dict_info
		public class his_comm_dict_info
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
		/// TYPE_CODE
        /// </summary>		
		private string _type_code;
        public string TYPE_CODE
        {
            get{ return _type_code; }
            set{ _type_code = value; }
        }        
		/// <summary>
		/// DICT_CODE
        /// </summary>		
		private string _dict_code;
        public string DICT_CODE
        {
            get{ return _dict_code; }
            set{ _dict_code = value; }
        }        
		/// <summary>
		/// DICT_NAME
        /// </summary>		
		private string _dict_name;
        public string DICT_NAME
        {
            get{ return _dict_name; }
            set{ _dict_name = value; }
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

