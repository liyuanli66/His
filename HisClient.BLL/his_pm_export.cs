using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_pm_export
		public partial class his_pm_export
	{
   		     
		private readonly HisClient.DAL.his_pm_export dal=new HisClient.DAL.his_pm_export();
		public his_pm_export()
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
		public void  Add(HisClient.Model.his_pm_export model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_pm_export model)
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
		public HisClient.Model.his_pm_export GetModel(string ID)
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
		public List<HisClient.Model.his_pm_export> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_pm_export> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_pm_export> modelList = new List<HisClient.Model.his_pm_export>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_pm_export model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_pm_export();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.EXPORT_CODE= dt.Rows[n]["EXPORT_CODE"].ToString();
																																model.RECEIVE_DEPT_CODE= dt.Rows[n]["RECEIVE_DEPT_CODE"].ToString();
																																model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.SEND_DEPT_CODE= dt.Rows[n]["SEND_DEPT_CODE"].ToString();
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