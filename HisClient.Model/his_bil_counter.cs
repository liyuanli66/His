using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_bil_counter
		public class his_bil_counter
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
		/// CASHIER
        /// </summary>		
		private string _cashier;
        public string CASHIER
        {
            get{ return _cashier; }
            set{ _cashier = value; }
        }        
		/// <summary>
		/// START_IVNNO
        /// </summary>		
		private string _start_ivnno;
        public string START_IVNNO
        {
            get{ return _start_ivnno; }
            set{ _start_ivnno = value; }
        }        
		/// <summary>
		/// END_IVNNO
        /// </summary>		
		private string _end_ivnno;
        public string END_IVNNO
        {
            get{ return _end_ivnno; }
            set{ _end_ivnno = value; }
        }        
		/// <summary>
		/// RECP_TYPE
        /// </summary>		
		private string _recp_type;
        public string RECP_TYPE
        {
            get{ return _recp_type; }
            set{ _recp_type = value; }
        }        
		/// <summary>
		/// USE_TYPE
        /// </summary>		
		private string _use_type;
        public string USE_TYPE
        {
            get{ return _use_type; }
            set{ _use_type = value; }
        }        
		/// <summary>
		/// RECP_COUNT
        /// </summary>		
		private decimal _recp_count;
        public decimal RECP_COUNT
        {
            get{ return _recp_count; }
            set{ _recp_count = value; }
        }        
		/// <summary>
		/// PRE_CODE
        /// </summary>		
		private string _pre_code;
        public string PRE_CODE
        {
            get{ return _pre_code; }
            set{ _pre_code = value; }
        }        
		/// <summary>
		/// REFOUNDED_COUNT
        /// </summary>		
		private decimal _refounded_count;
        public decimal REFOUNDED_COUNT
        {
            get{ return _refounded_count; }
            set{ _refounded_count = value; }
        }        
		/// <summary>
		/// INVALID_COUNT
        /// </summary>		
		private decimal _invalid_count;
        public decimal INVALID_COUNT
        {
            get{ return _invalid_count; }
            set{ _invalid_count = value; }
        }        
		/// <summary>
		/// OPT_USER
        /// </summary>		
		private string _opt_user;
        public string OPT_USER
        {
            get{ return _opt_user; }
            set{ _opt_user = value; }
        }        
		/// <summary>
		/// OPT_DATE
        /// </summary>		
		private DateTime _opt_date;
        public DateTime OPT_DATE
        {
            get{ return _opt_date; }
            set{ _opt_date = value; }
        }        
		/// <summary>
		/// OPT_TERM
        /// </summary>		
		private string _opt_term;
        public string OPT_TERM
        {
            get{ return _opt_term; }
            set{ _opt_term = value; }
        }        
		/// <summary>
		/// OPT_ORGA
        /// </summary>		
		private string _opt_orga;
        public string OPT_ORGA
        {
            get{ return _opt_orga; }
            set{ _opt_orga = value; }
        }        
		   
	}
}

