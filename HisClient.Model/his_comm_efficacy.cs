using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_comm_efficacy
		public class his_comm_efficacy
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
		/// EFFICACY_CODE
        /// </summary>		
		private string _efficacy_code;
        public string EFFICACY_CODE
        {
            get{ return _efficacy_code; }
            set{ _efficacy_code = value; }
        }        
		/// <summary>
		/// EFFICACY_NAME
        /// </summary>		
		private string _efficacy_name;
        public string EFFICACY_NAME
        {
            get{ return _efficacy_name; }
            set{ _efficacy_name = value; }
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

