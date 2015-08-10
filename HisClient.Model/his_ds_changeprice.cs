using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_ds_changeprice
		public class his_ds_changeprice
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
		/// MEMO
        /// </summary>		
		private string _memo;
        public string MEMO
        {
            get{ return _memo; }
            set{ _memo = value; }
        }        
		/// <summary>
		/// CHANGE_CODE
        /// </summary>		
		private string _change_code;
        public string CHANGE_CODE
        {
            get{ return _change_code; }
            set{ _change_code = value; }
        }        
		   
	}
}

