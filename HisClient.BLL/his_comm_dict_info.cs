using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_dict_info
		public partial class his_comm_dict_info
	{
   		     
		private readonly HisClient.DAL.his_comm_dict_info dal=new HisClient.DAL.his_comm_dict_info();
		public his_comm_dict_info()
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
		public void  Add(HisClient.Model.his_comm_dict_info model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_dict_info model)
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
		public HisClient.Model.his_comm_dict_info GetModel(string ID)
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
		public List<HisClient.Model.his_comm_dict_info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_dict_info> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_dict_info> modelList = new List<HisClient.Model.his_comm_dict_info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_dict_info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_dict_info();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.TYPE_CODE= dt.Rows[n]["TYPE_CODE"].ToString();
																																model.DICT_CODE= dt.Rows[n]["DICT_CODE"].ToString();
																																model.DICT_NAME= dt.Rows[n]["DICT_NAME"].ToString();
																																model.HELP_CODE= dt.Rows[n]["HELP_CODE"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																						
				
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