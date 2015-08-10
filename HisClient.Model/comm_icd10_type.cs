using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//comm_icd10_type
		public class comm_icd10_type
	{
   		     
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
		/// ID
        /// </summary>		
		private string _id;
        public string ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// TYPE_NAME
        /// </summary>		
		private string _type_name;
        public string TYPE_NAME
        {
            get{ return _type_name; }
            set{ _type_name = value; }
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

