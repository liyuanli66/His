﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_receipt_cancle
		public class his_hos_receipt_cancle
	{
   		     
      	/// <summary>
		/// HOS_RECEIPT_CODE
        /// </summary>		
		private string _hos_receipt_code;
        public string HOS_RECEIPT_CODE
        {
            get{ return _hos_receipt_code; }
            set{ _hos_receipt_code = value; }
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
		/// CASHIER
        /// </summary>		
		private string _cashier;
        public string CASHIER
        {
            get{ return _cashier; }
            set{ _cashier = value; }
        }        
		/// <summary>
		/// RECEICPT_CODE
        /// </summary>		
		private string _receicpt_code;
        public string RECEICPT_CODE
        {
            get{ return _receicpt_code; }
            set{ _receicpt_code = value; }
        }        
		/// <summary>
		/// RECIVER_TIME
        /// </summary>		
		private DateTime _reciver_time;
        public DateTime RECIVER_TIME
        {
            get{ return _reciver_time; }
            set{ _reciver_time = value; }
        }        
		/// <summary>
		/// CASH_AMT
        /// </summary>		
		private decimal _cash_amt;
        public decimal CASH_AMT
        {
            get{ return _cash_amt; }
            set{ _cash_amt = value; }
        }        
		/// <summary>
		/// CARD_AMT
        /// </summary>		
		private decimal _card_amt;
        public decimal CARD_AMT
        {
            get{ return _card_amt; }
            set{ _card_amt = value; }
        }        
		/// <summary>
		/// INSURANCE_AMT
        /// </summary>		
		private decimal _insurance_amt;
        public decimal INSURANCE_AMT
        {
            get{ return _insurance_amt; }
            set{ _insurance_amt = value; }
        }        
		/// <summary>
		/// SUM_AMT
        /// </summary>		
		private decimal _sum_amt;
        public decimal SUM_AMT
        {
            get{ return _sum_amt; }
            set{ _sum_amt = value; }
        }        
		/// <summary>
		/// REDUCE_AMT
        /// </summary>		
		private int _reduce_amt;
        public int REDUCE_AMT
        {
            get{ return _reduce_amt; }
            set{ _reduce_amt = value; }
        }        
		/// <summary>
		/// REDUCE_DATE
        /// </summary>		
		private DateTime _reduce_date;
        public DateTime REDUCE_DATE
        {
            get{ return _reduce_date; }
            set{ _reduce_date = value; }
        }        
		/// <summary>
		/// REDUCE_OPT
        /// </summary>		
		private string _reduce_opt;
        public string REDUCE_OPT
        {
            get{ return _reduce_opt; }
            set{ _reduce_opt = value; }
        }        
		/// <summary>
		/// REDUCE_REASON
        /// </summary>		
		private string _reduce_reason;
        public string REDUCE_REASON
        {
            get{ return _reduce_reason; }
            set{ _reduce_reason = value; }
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

