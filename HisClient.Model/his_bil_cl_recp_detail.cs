using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_bil_cl_recp_detail
		public class his_bil_cl_recp_detail
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
		/// CL_RECEIPT_CODE
        /// </summary>		
		private string _cl_receipt_code;
        public string CL_RECEIPT_CODE
        {
            get{ return _cl_receipt_code; }
            set{ _cl_receipt_code = value; }
        }        
		/// <summary>
		/// CL_CODE
        /// </summary>		
		private string _cl_code;
        public string CL_CODE
        {
            get{ return _cl_code; }
            set{ _cl_code = value; }
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
		/// <summary>
		/// FEEITEM_CODE
        /// </summary>		
		private string _feeitem_code;
        public string FEEITEM_CODE
        {
            get{ return _feeitem_code; }
            set{ _feeitem_code = value; }
        }        
		/// <summary>
		/// FEEITEM_NAME
        /// </summary>		
		private string _feeitem_name;
        public string FEEITEM_NAME
        {
            get{ return _feeitem_name; }
            set{ _feeitem_name = value; }
        }        
		/// <summary>
		/// PRICE
        /// </summary>		
		private decimal _price;
        public decimal PRICE
        {
            get{ return _price; }
            set{ _price = value; }
        }        
		/// <summary>
		/// COUNT
        /// </summary>		
		private decimal _count;
        public decimal COUNT
        {
            get{ return _count; }
            set{ _count = value; }
        }        
		/// <summary>
		/// UNIT
        /// </summary>		
		private string _unit;
        public string UNIT
        {
            get{ return _unit; }
            set{ _unit = value; }
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
		   
	}
}

