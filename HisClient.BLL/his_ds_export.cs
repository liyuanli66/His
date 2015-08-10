using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_ds_export
		public partial class his_ds_export
	{
   		     
		private readonly HisClient.DAL.his_ds_export dal=new HisClient.DAL.his_ds_export();
		public his_ds_export()
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
		public void  Add(HisClient.Model.his_ds_export model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_ds_export model)
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
		public HisClient.Model.his_ds_export GetModel(string ID)
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
		public List<HisClient.Model.his_ds_export> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_ds_export> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_ds_export> modelList = new List<HisClient.Model.his_ds_export>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_ds_export model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_ds_export();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.EXPORT_CODE= dt.Rows[n]["EXPORT_CODE"].ToString();
																																model.MANUFACTURE_NAME= dt.Rows[n]["MANUFACTURE_NAME"].ToString();
																																model.MANUFACTURE_CODE= dt.Rows[n]["MANUFACTURE_CODE"].ToString();
																																model.EXPORT_TYPE= dt.Rows[n]["EXPORT_TYPE"].ToString();
																																model.EXPORT_DEPT= dt.Rows[n]["EXPORT_DEPT"].ToString();
																																model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																if(dt.Rows[n]["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(dt.Rows[n]["COST"].ToString());
				}
																																				model.OPERATOR_NAME= dt.Rows[n]["OPERATOR_NAME"].ToString();
																												if(dt.Rows[n]["OPERATOR_DATE"].ToString()!="")
				{
					model.OPERATOR_DATE=DateTime.Parse(dt.Rows[n]["OPERATOR_DATE"].ToString());
				}
																																				model.CANCEL_OPERATOR= dt.Rows[n]["CANCEL_OPERATOR"].ToString();
																												if(dt.Rows[n]["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(dt.Rows[n]["CANCEL_DATE"].ToString());
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