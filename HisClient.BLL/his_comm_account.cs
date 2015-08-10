using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_account
		public partial class his_comm_account
	{
   		     
		private readonly HisClient.DAL.his_comm_account dal=new HisClient.DAL.his_comm_account();
		public his_comm_account()
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
		public void  Add(HisClient.Model.his_comm_account model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_account model)
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
		public HisClient.Model.his_comm_account GetModel(string ID)
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
		public List<HisClient.Model.his_comm_account> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_account> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_account> modelList = new List<HisClient.Model.his_comm_account>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_account model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_account();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.ACCOUNT= dt.Rows[n]["ACCOUNT"].ToString();
																																model.PASSWORD= dt.Rows[n]["PASSWORD"].ToString();
																																model.ROLE_CODE= dt.Rows[n]["ROLE_CODE"].ToString();
																																model.USER_CODE= dt.Rows[n]["USER_CODE"].ToString();
																																model.ADMIN_TYPE= dt.Rows[n]["ADMIN_TYPE"].ToString();
																																model.IS_USE= dt.Rows[n]["IS_USE"].ToString();
																																model.AUTHORITY_XML= dt.Rows[n]["AUTHORITY_XML"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["LAST_LOGINTIME"].ToString()!="")
				{
					model.LAST_LOGINTIME=DateTime.Parse(dt.Rows[n]["LAST_LOGINTIME"].ToString());
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