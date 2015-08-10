using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_ds_exportinfo
		public class his_ds_exportinfo
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
		/// MEDINFO_CODE
        /// </summary>		
		private string _medinfo_code;
        public string MEDINFO_CODE
        {
            get{ return _medinfo_code; }
            set{ _medinfo_code = value; }
        }        
		/// <summary>
		/// MED_CODE
        /// </summary>		
		private string _med_code;
        public string MED_CODE
        {
            get{ return _med_code; }
            set{ _med_code = value; }
        }        
		/// <summary>
		/// MED_NAME
        /// </summary>		
		private string _med_name;
        public string MED_NAME
        {
            get{ return _med_name; }
            set{ _med_name = value; }
        }        
		/// <summary>
		/// PAKAGE_UNIT
        /// </summary>		
		private string _pakage_unit;
        public string PAKAGE_UNIT
        {
            get{ return _pakage_unit; }
            set{ _pakage_unit = value; }
        }        
		/// <summary>
		/// PAKAGE_AMOUNT
        /// </summary>		
		private decimal _pakage_amount;
        public decimal PAKAGE_AMOUNT
        {
            get{ return _pakage_amount; }
            set{ _pakage_amount = value; }
        }        
		/// <summary>
		/// MED_PRICE
        /// </summary>		
		private decimal _med_price;
        public decimal MED_PRICE
        {
            get{ return _med_price; }
            set{ _med_price = value; }
        }        
		/// <summary>
		/// PURCHASE_PRICE
        /// </summary>		
		private decimal _purchase_price;
        public decimal PURCHASE_PRICE
        {
            get{ return _purchase_price; }
            set{ _purchase_price = value; }
        }        
		/// <summary>
		/// VALIDITY_DATE
        /// </summary>		
		private DateTime _validity_date;
        public DateTime VALIDITY_DATE
        {
            get{ return _validity_date; }
            set{ _validity_date = value; }
        }        
		/// <summary>
		/// BATCHNO
        /// </summary>		
		private string _batchno;
        public string BATCHNO
        {
            get{ return _batchno; }
            set{ _batchno = value; }
        }        
		/// <summary>
		/// MED_MADETIME
        /// </summary>		
		private DateTime _med_madetime;
        public DateTime MED_MADETIME
        {
            get{ return _med_madetime; }
            set{ _med_madetime = value; }
        }        
		   
	}
}

