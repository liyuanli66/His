using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_pm_importinfo
		public partial class his_pm_importinfo
	{
   		     
		private readonly HisClient.DAL.his_pm_importinfo dal=new HisClient.DAL.his_pm_importinfo();
		public his_pm_importinfo()
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
		public void  Add(HisClient.Model.his_pm_importinfo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_pm_importinfo model)
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
		public HisClient.Model.his_pm_importinfo GetModel(string ID)
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
		public List<HisClient.Model.his_pm_importinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_pm_importinfo> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_pm_importinfo> modelList = new List<HisClient.Model.his_pm_importinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_pm_importinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_pm_importinfo();					
																	model.IMPORT_CODE= dt.Rows[n]["IMPORT_CODE"].ToString();
																																model.ID= dt.Rows[n]["ID"].ToString();
																																model.MEDINFO_CODE= dt.Rows[n]["MEDINFO_CODE"].ToString();
																																model.MED_SPC= dt.Rows[n]["MED_SPC"].ToString();
																																model.MED_UNIT= dt.Rows[n]["MED_UNIT"].ToString();
																												if(dt.Rows[n]["MED_AMOUNT"].ToString()!="")
				{
					model.MED_AMOUNT=decimal.Parse(dt.Rows[n]["MED_AMOUNT"].ToString());
				}
																																if(dt.Rows[n]["MED_PRICE"].ToString()!="")
				{
					model.MED_PRICE=decimal.Parse(dt.Rows[n]["MED_PRICE"].ToString());
				}
																																if(dt.Rows[n]["PURCHASE_PRICE"].ToString()!="")
				{
					model.PURCHASE_PRICE=decimal.Parse(dt.Rows[n]["PURCHASE_PRICE"].ToString());
				}
																																if(dt.Rows[n]["WHOLESALE_PRICE"].ToString()!="")
				{
					model.WHOLESALE_PRICE=decimal.Parse(dt.Rows[n]["WHOLESALE_PRICE"].ToString());
				}
																																if(dt.Rows[n]["VALIDITY_DATE"].ToString()!="")
				{
					model.VALIDITY_DATE=DateTime.Parse(dt.Rows[n]["VALIDITY_DATE"].ToString());
				}
																																				model.BATCHNO= dt.Rows[n]["BATCHNO"].ToString();
																												if(dt.Rows[n]["MED_MADETIME"].ToString()!="")
				{
					model.MED_MADETIME=DateTime.Parse(dt.Rows[n]["MED_MADETIME"].ToString());
				}
																										
				
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