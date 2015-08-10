﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_daily_statement_itemty
		public partial class his_hos_daily_statement_itemty
	{
   		     
		private readonly HisClient.DAL.his_hos_daily_statement_itemty dal=new HisClient.DAL.his_hos_daily_statement_itemty();
		public his_hos_daily_statement_itemty()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string DAILY_CODE)
		{
			return dal.Exists(ID,DAILY_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_hos_daily_statement_itemty model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_daily_statement_itemty model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID,string DAILY_CODE)
		{
			
			return dal.Delete(ID,DAILY_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_hos_daily_statement_itemty GetModel(string ID,string DAILY_CODE)
		{
			
			return dal.GetModel(ID,DAILY_CODE);
		}

		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_daily_statement_itemty> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_daily_statement_itemty> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_daily_statement_itemty> modelList = new List<HisClient.Model.his_hos_daily_statement_itemty>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_daily_statement_itemty model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_daily_statement_itemty();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.ITEM_TYPE= dt.Rows[n]["ITEM_TYPE"].ToString();
																												if(dt.Rows[n]["ITEM_SUM_PAY"].ToString()!="")
				{
					model.ITEM_SUM_PAY=int.Parse(dt.Rows[n]["ITEM_SUM_PAY"].ToString());
				}
																																if(dt.Rows[n]["ITEM_CASH_PAY"].ToString()!="")
				{
					model.ITEM_CASH_PAY=int.Parse(dt.Rows[n]["ITEM_CASH_PAY"].ToString());
				}
																																if(dt.Rows[n]["ITEM_CARD_PAY"].ToString()!="")
				{
					model.ITEM_CARD_PAY=int.Parse(dt.Rows[n]["ITEM_CARD_PAY"].ToString());
				}
																																if(dt.Rows[n]["ITEM_INSURANCE_PAY"].ToString()!="")
				{
					model.ITEM_INSURANCE_PAY=int.Parse(dt.Rows[n]["ITEM_INSURANCE_PAY"].ToString());
				}
																																				model.STATUS= dt.Rows[n]["STATUS"].ToString();
																																model.DAILY_CODE= dt.Rows[n]["DAILY_CODE"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}