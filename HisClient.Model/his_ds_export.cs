using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_ds_export
		public class his_ds_export
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
		/// EXPORT_CODE
        /// </summary>		
		private string _export_code;
        public string EXPORT_CODE
        {
            get{ return _export_code; }
            set{ _export_code = value; }
        }        
		/// <summary>
		/// MANUFACTURE_NAME
        /// </summary>		
		private string _manufacture_name;
        public string MANUFACTURE_NAME
        {
            get{ return _manufacture_name; }
            set{ _manufacture_name = value; }
        }        
		/// <summary>
		/// MANUFACTURE_CODE
        /// </summary>		
		private string _manufacture_code;
        public string MANUFACTURE_CODE
        {
            get{ return _manufacture_code; }
            set{ _manufacture_code = value; }
        }        
		/// <summary>
		/// EXPORT_TYPE
        /// </summary>		
		private string _export_type;
        public string EXPORT_TYPE
        {
            get{ return _export_type; }
            set{ _export_type = value; }
        }        
		/// <summary>
		/// EXPORT_DEPT
        /// </summary>		
		private string _export_dept;
        public string EXPORT_DEPT
        {
            get{ return _export_dept; }
            set{ _export_dept = value; }
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
		/// COST
        /// </summary>		
		private decimal _cost;
        public decimal COST
        {
            get{ return _cost; }
            set{ _cost = value; }
        }        
		/// <summary>
		/// OPERATOR_NAME
        /// </summary>		
		private string _operator_name;
        public string OPERATOR_NAME
        {
            get{ return _operator_name; }
            set{ _operator_name = value; }
        }        
		/// <summary>
		/// OPERATOR_DATE
        /// </summary>		
		private DateTime _operator_date;
        public DateTime OPERATOR_DATE
        {
            get{ return _operator_date; }
            set{ _operator_date = value; }
        }        
		/// <summary>
		/// CANCEL_OPERATOR
        /// </summary>		
		private string _cancel_operator;
        public string CANCEL_OPERATOR
        {
            get{ return _cancel_operator; }
            set{ _cancel_operator = value; }
        }        
		/// <summary>
		/// CANCEL_DATE
        /// </summary>		
		private DateTime _cancel_date;
        public DateTime CANCEL_DATE
        {
            get{ return _cancel_date; }
            set{ _cancel_date = value; }
        }        
		   
	}
}

