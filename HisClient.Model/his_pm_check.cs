using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_pm_check
		public class his_pm_check
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
		/// CHECK_CODE
        /// </summary>		
		private string _check_code;
        public string CHECK_CODE
        {
            get{ return _check_code; }
            set{ _check_code = value; }
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
		/// CREATE_DATE
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
        }        
		/// <summary>
		/// DEPT_CODE
        /// </summary>		
		private string _dept_code;
        public string DEPT_CODE
        {
            get{ return _dept_code; }
            set{ _dept_code = value; }
        }        
		/// <summary>
		/// DEPT_NAME
        /// </summary>		
		private string _dept_name;
        public string DEPT_NAME
        {
            get{ return _dept_name; }
            set{ _dept_name = value; }
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
		/// LOSE_COST
        /// </summary>		
		private decimal _lose_cost;
        public decimal LOSE_COST
        {
            get{ return _lose_cost; }
            set{ _lose_cost = value; }
        }        
		/// <summary>
		/// PROFIT_COST
        /// </summary>		
		private decimal _profit_cost;
        public decimal PROFIT_COST
        {
            get{ return _profit_cost; }
            set{ _profit_cost = value; }
        }        
		   
	}
}

