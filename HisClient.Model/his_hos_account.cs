using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_account
		public class his_hos_account
	{
   		     
      	/// <summary>
		/// HOS_ACC_CODE
        /// </summary>		
		private string _hos_acc_code;
        public string HOS_ACC_CODE
        {
            get{ return _hos_acc_code; }
            set{ _hos_acc_code = value; }
        }        
		/// <summary>
		/// HIS_HOS_CODE
        /// </summary>		
		private string _his_hos_code;
        public string HIS_HOS_CODE
        {
            get{ return _his_hos_code; }
            set{ _his_hos_code = value; }
        }        
		/// <summary>
		/// IP
        /// </summary>		
		private string _ip;
        public string IP
        {
            get{ return _ip; }
            set{ _ip = value; }
        }        
		/// <summary>
		/// SUM_IN
        /// </summary>		
		private decimal _sum_in;
        public decimal SUM_IN
        {
            get{ return _sum_in; }
            set{ _sum_in = value; }
        }        
		/// <summary>
		/// SUM_OUT
        /// </summary>		
		private decimal _sum_out;
        public decimal SUM_OUT
        {
            get{ return _sum_out; }
            set{ _sum_out = value; }
        }        
		/// <summary>
		/// ACCOUNT_BALANCE
        /// </summary>		
		private decimal _account_balance;
        public decimal ACCOUNT_BALANCE
        {
            get{ return _account_balance; }
            set{ _account_balance = value; }
        }        
		/// <summary>
		/// LOWER_LIMIT
        /// </summary>		
		private decimal _lower_limit;
        public decimal LOWER_LIMIT
        {
            get{ return _lower_limit; }
            set{ _lower_limit = value; }
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

