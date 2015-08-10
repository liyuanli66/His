using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_hos_monthly_statement
		public class his_hos_monthly_statement
	{
   		     
      	/// <summary>
		/// OPERATOR
        /// </summary>		
		private string _operator;
        public string OPERATOR
        {
            get{ return _operator; }
            set{ _operator = value; }
        }        
		/// <summary>
		/// OPERATE_TIME
        /// </summary>		
		private DateTime _operate_time;
        public DateTime OPERATE_TIME
        {
            get{ return _operate_time; }
            set{ _operate_time = value; }
        }        
		/// <summary>
		/// RECIVER
        /// </summary>		
		private string _reciver;
        public string RECIVER
        {
            get{ return _reciver; }
            set{ _reciver = value; }
        }        
		/// <summary>
		/// START_TIME
        /// </summary>		
		private DateTime _start_time;
        public DateTime START_TIME
        {
            get{ return _start_time; }
            set{ _start_time = value; }
        }        
		/// <summary>
		/// END_TIME
        /// </summary>		
		private DateTime _end_time;
        public DateTime END_TIME
        {
            get{ return _end_time; }
            set{ _end_time = value; }
        }        
		/// <summary>
		/// START_RECEIPT_CODE
        /// </summary>		
		private string _start_receipt_code;
        public string START_RECEIPT_CODE
        {
            get{ return _start_receipt_code; }
            set{ _start_receipt_code = value; }
        }        
		/// <summary>
		/// END_RECEIPT_CODE
        /// </summary>		
		private string _end_receipt_code;
        public string END_RECEIPT_CODE
        {
            get{ return _end_receipt_code; }
            set{ _end_receipt_code = value; }
        }        
		/// <summary>
		/// RECEIPT__NUM
        /// </summary>		
		private string _receipt__num;
        public string RECEIPT__NUM
        {
            get{ return _receipt__num; }
            set{ _receipt__num = value; }
        }        
		/// <summary>
		/// RETUEN_RECEIPT_NUM
        /// </summary>		
		private string _retuen_receipt_num;
        public string RETUEN_RECEIPT_NUM
        {
            get{ return _retuen_receipt_num; }
            set{ _retuen_receipt_num = value; }
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
		   
	}
}

