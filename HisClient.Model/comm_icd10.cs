using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//comm_icd10
		public class comm_icd10
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
		/// ICD_CODE
        /// </summary>		
		private string _icd_code;
        public string ICD_CODE
        {
            get{ return _icd_code; }
            set{ _icd_code = value; }
        }        
		/// <summary>
		/// ICD_NAME
        /// </summary>		
		private string _icd_name;
        public string ICD_NAME
        {
            get{ return _icd_name; }
            set{ _icd_name = value; }
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
		/// TYPE_CODE
        /// </summary>		
		private string _type_code;
        public string TYPE_CODE
        {
            get{ return _type_code; }
            set{ _type_code = value; }
        }        
		   
	}
}

