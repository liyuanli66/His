using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_daily_statement_itemty
		public class his_hos_daily_statement_itemty
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
		/// ITEM_TYPE
        /// </summary>		
		private string _item_type;
        public string ITEM_TYPE
        {
            get{ return _item_type; }
            set{ _item_type = value; }
        }        
		/// <summary>
		/// ITEM_SUM_PAY
        /// </summary>		
		private int _item_sum_pay;
        public int ITEM_SUM_PAY
        {
            get{ return _item_sum_pay; }
            set{ _item_sum_pay = value; }
        }        
		/// <summary>
		/// ITEM_CASH_PAY
        /// </summary>		
		private int _item_cash_pay;
        public int ITEM_CASH_PAY
        {
            get{ return _item_cash_pay; }
            set{ _item_cash_pay = value; }
        }        
		/// <summary>
		/// ITEM_CARD_PAY
        /// </summary>		
		private int _item_card_pay;
        public int ITEM_CARD_PAY
        {
            get{ return _item_card_pay; }
            set{ _item_card_pay = value; }
        }        
		/// <summary>
		/// ITEM_INSURANCE_PAY
        /// </summary>		
		private int _item_insurance_pay;
        public int ITEM_INSURANCE_PAY
        {
            get{ return _item_insurance_pay; }
            set{ _item_insurance_pay = value; }
        }        
		/// <summary>
		/// STATUS
        /// </summary>		
		private string _status;
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// DAILY_CODE
        /// </summary>		
		private string _daily_code;
        public string DAILY_CODE
        {
            get{ return _daily_code; }
            set{ _daily_code = value; }
        }        
		   
	}
}

