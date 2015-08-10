using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_ds_import
		public partial class his_ds_import
	{
   		     
		private readonly HisClient.DAL.his_ds_import dal=new HisClient.DAL.his_ds_import();
		public his_ds_import()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_ds_import model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_ds_import model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID)
		{
			
			return dal.Delete(ID);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_ds_import GetModel(string ID)
		{
			
			return dal.GetModel(ID);
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
		public List<HisClient.Model.his_ds_import> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_ds_import> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_ds_import> modelList = new List<HisClient.Model.his_ds_import>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_ds_import model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_ds_import();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.IMPORT_CODE= dt.Rows[n]["IMPORT_CODE"].ToString();
																																model.IMPORT_TYPE= dt.Rows[n]["IMPORT_TYPE"].ToString();
																																model.MANUFACTURE_CODE= dt.Rows[n]["MANUFACTURE_CODE"].ToString();
																																model.MANUFACTURE_NAME= dt.Rows[n]["MANUFACTURE_NAME"].ToString();
																																model.INVOICE_NO= dt.Rows[n]["INVOICE_NO"].ToString();
																																model.ACCOUNT_FLAG= dt.Rows[n]["ACCOUNT_FLAG"].ToString();
																												if(dt.Rows[n]["ACCOUNT_DATE"].ToString()!="")
				{
					model.ACCOUNT_DATE=DateTime.Parse(dt.Rows[n]["ACCOUNT_DATE"].ToString());
				}
																																				model.ISPAY_FLAG= dt.Rows[n]["ISPAY_FLAG"].ToString();
																												if(dt.Rows[n]["PAY_TIME"].ToString()!="")
				{
					model.PAY_TIME=DateTime.Parse(dt.Rows[n]["PAY_TIME"].ToString());
				}
																																				model.CONTRACT_NO= dt.Rows[n]["CONTRACT_NO"].ToString();
																																model.IMPORT_FLAG= dt.Rows[n]["IMPORT_FLAG"].ToString();
																												if(dt.Rows[n]["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(dt.Rows[n]["COST"].ToString());
				}
																																				model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.PURCHASER= dt.Rows[n]["PURCHASER"].ToString();
																												if(dt.Rows[n]["PURCHASE_DATE"].ToString()!="")
				{
					model.PURCHASE_DATE=DateTime.Parse(dt.Rows[n]["PURCHASE_DATE"].ToString());
				}
																																				model.CANCEL_OPRATOR= dt.Rows[n]["CANCEL_OPRATOR"].ToString();
																												if(dt.Rows[n]["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(dt.Rows[n]["CANCEL_DATE"].ToString());
				}
																																				model.HOSPITAL_CODE= dt.Rows[n]["HOSPITAL_CODE"].ToString();
																						
				
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