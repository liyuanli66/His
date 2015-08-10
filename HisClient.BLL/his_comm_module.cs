using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_module
		public partial class his_comm_module
	{
   		     
		private readonly HisClient.DAL.his_comm_module dal=new HisClient.DAL.his_comm_module();
		public his_comm_module()
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
		public void  Add(HisClient.Model.his_comm_module model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_module model)
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
		public HisClient.Model.his_comm_module GetModel(string ID)
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
		public List<HisClient.Model.his_comm_module> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_module> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_module> modelList = new List<HisClient.Model.his_comm_module>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_module model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_module();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.MODULE_NAME= dt.Rows[n]["MODULE_NAME"].ToString();
																																model.MODULE_CODE= dt.Rows[n]["MODULE_CODE"].ToString();
																																model.SYSTEM_CODE= dt.Rows[n]["SYSTEM_CODE"].ToString();
																																model.IS_USE= dt.Rows[n]["IS_USE"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																																model.HOSPITAL_CODE= dt.Rows[n]["HOSPITAL_CODE"].ToString();
																																model.REMARK= dt.Rows[n]["REMARK"].ToString();
																						
				
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