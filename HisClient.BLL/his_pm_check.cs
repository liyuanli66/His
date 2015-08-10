using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_pm_check
		public partial class his_pm_check
	{
   		     
		private readonly HisClient.DAL.his_pm_check dal=new HisClient.DAL.his_pm_check();
		public his_pm_check()
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
		public void  Add(HisClient.Model.his_pm_check model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_pm_check model)
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
		public HisClient.Model.his_pm_check GetModel(string ID)
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
		public List<HisClient.Model.his_pm_check> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_pm_check> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_pm_check> modelList = new List<HisClient.Model.his_pm_check>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_pm_check model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_pm_check();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.CHECK_CODE= dt.Rows[n]["CHECK_CODE"].ToString();
																																model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.DEPT_CODE= dt.Rows[n]["DEPT_CODE"].ToString();
																																model.DEPT_NAME= dt.Rows[n]["DEPT_NAME"].ToString();
																																model.MEMO= dt.Rows[n]["MEMO"].ToString();
																												if(dt.Rows[n]["LOSE_COST"].ToString()!="")
				{
					model.LOSE_COST=decimal.Parse(dt.Rows[n]["LOSE_COST"].ToString());
				}
																																if(dt.Rows[n]["PROFIT_COST"].ToString()!="")
				{
					model.PROFIT_COST=decimal.Parse(dt.Rows[n]["PROFIT_COST"].ToString());
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