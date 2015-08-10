using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_cl_order_item
		public class his_cl_order_item
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
		/// CL_PRES_CODE
        /// </summary>		
		private string _cl_pres_code;
        public string CL_PRES_CODE
        {
            get{ return _cl_pres_code; }
            set{ _cl_pres_code = value; }
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
		/// ITEM_CODE
        /// </summary>		
		private string _item_code;
        public string ITEM_CODE
        {
            get{ return _item_code; }
            set{ _item_code = value; }
        }        
		/// <summary>
		/// ITEM_NAME
        /// </summary>		
		private string _item_name;
        public string ITEM_NAME
        {
            get{ return _item_name; }
            set{ _item_name = value; }
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
		/// PRICE
        /// </summary>		
		private decimal _price;
        public decimal PRICE
        {
            get{ return _price; }
            set{ _price = value; }
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
		/// SPEC
        /// </summary>		
		private string _spec;
        public string SPEC
        {
            get{ return _spec; }
            set{ _spec = value; }
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
		/// SUM_AMT
        /// </summary>		
		private decimal _sum_amt;
        public decimal SUM_AMT
        {
            get{ return _sum_amt; }
            set{ _sum_amt = value; }
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
		/// HERB_NUM
        /// </summary>		
		private decimal _herb_num;
        public decimal HERB_NUM
        {
            get{ return _herb_num; }
            set{ _herb_num = value; }
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

