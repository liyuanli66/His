using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_bil_counter
		public partial class his_bil_counter
	{
   		     
		private readonly HisClient.DAL.his_bil_counter dal=new HisClient.DAL.his_bil_counter();
		public his_bil_counter()
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
		public void  Add(HisClient.Model.his_bil_counter model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_bil_counter model)
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
		public HisClient.Model.his_bil_counter GetModel(string ID)
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
		public List<HisClient.Model.his_bil_counter> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_bil_counter> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_bil_counter> modelList = new List<HisClient.Model.his_bil_counter>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_bil_counter model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_bil_counter();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.CASHIER= dt.Rows[n]["CASHIER"].ToString();
																																model.START_IVNNO= dt.Rows[n]["START_IVNNO"].ToString();
																																model.END_IVNNO= dt.Rows[n]["END_IVNNO"].ToString();
																																model.RECP_TYPE= dt.Rows[n]["RECP_TYPE"].ToString();
																																model.USE_TYPE= dt.Rows[n]["USE_TYPE"].ToString();
																												if(dt.Rows[n]["RECP_COUNT"].ToString()!="")
				{
					model.RECP_COUNT=decimal.Parse(dt.Rows[n]["RECP_COUNT"].ToString());
				}
																																				model.PRE_CODE= dt.Rows[n]["PRE_CODE"].ToString();
																												if(dt.Rows[n]["REFOUNDED_COUNT"].ToString()!="")
				{
					model.REFOUNDED_COUNT=decimal.Parse(dt.Rows[n]["REFOUNDED_COUNT"].ToString());
				}
																																if(dt.Rows[n]["INVALID_COUNT"].ToString()!="")
				{
					model.INVALID_COUNT=decimal.Parse(dt.Rows[n]["INVALID_COUNT"].ToString());
				}
																																				model.OPT_USER= dt.Rows[n]["OPT_USER"].ToString();
																												if(dt.Rows[n]["OPT_DATE"].ToString()!="")
				{
					model.OPT_DATE=DateTime.Parse(dt.Rows[n]["OPT_DATE"].ToString());
				}
																																				model.OPT_TERM= dt.Rows[n]["OPT_TERM"].ToString();
																																model.OPT_ORGA= dt.Rows[n]["OPT_ORGA"].ToString();
																						
				
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