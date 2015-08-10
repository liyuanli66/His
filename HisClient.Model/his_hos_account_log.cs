using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_account_log
		public class his_hos_account_log
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
		/// AMT
        /// </summary>		
		private decimal _amt;
        public decimal AMT
        {
            get{ return _amt; }
            set{ _amt = value; }
        }        
		/// <summary>
		/// PAY_TYPE
        /// </summary>		
		private string _pay_type;
        public string PAY_TYPE
        {
            get{ return _pay_type; }
            set{ _pay_type = value; }
        }        
		/// <summary>
		/// IS_REFUND
        /// </summary>		
		private string _is_refund;
        public string IS_REFUND
        {
            get{ return _is_refund; }
            set{ _is_refund = value; }
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

