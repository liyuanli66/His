﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace HisClient.Model{
	 	//his_pm_stock
		public class his_pm_stock
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
		/// MEDINFO_CODE
        /// </summary>		
		private string _medinfo_code;
        public string MEDINFO_CODE
        {
            get{ return _medinfo_code; }
            set{ _medinfo_code = value; }
        }        
		/// <summary>
		/// MED_SPC
        /// </summary>		
		private string _med_spc;
        public string MED_SPC
        {
            get{ return _med_spc; }
            set{ _med_spc = value; }
        }        
		/// <summary>
		/// MED_UNIT
        /// </summary>		
		private string _med_unit;
        public string MED_UNIT
        {
            get{ return _med_unit; }
            set{ _med_unit = value; }
        }        
		/// <summary>
		/// MED_AMOUNT
        /// </summary>		
		private decimal _med_amount;
        public decimal MED_AMOUNT
        {
            get{ return _med_amount; }
            set{ _med_amount = value; }
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
		/// WHOLESALE_PRICE
        /// </summary>		
		private decimal _wholesale_price;
        public decimal WHOLESALE_PRICE
        {
            get{ return _wholesale_price; }
            set{ _wholesale_price = value; }
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
		/// MED_MADETIME
        /// </summary>		
		private DateTime _med_madetime;
        public DateTime MED_MADETIME
        {
            get{ return _med_madetime; }
            set{ _med_madetime = value; }
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
		/// DEPT_CODE
        /// </summary>		
		private string _dept_code;
        public string DEPT_CODE
        {
            get{ return _dept_code; }
            set{ _dept_code = value; }
        }        
		   
	}
}

