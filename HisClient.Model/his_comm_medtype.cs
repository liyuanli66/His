using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_medtype
		public class his_comm_medtype
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
		/// TYPE_NAME
        /// </summary>		
		private string _type_name;
        public string TYPE_NAME
        {
            get{ return _type_name; }
            set{ _type_name = value; }
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
		   
	}
}

