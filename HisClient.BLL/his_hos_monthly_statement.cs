using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_monthly_statement
		public partial class his_hos_monthly_statement
	{
   		     
		private readonly HisClient.DAL.his_hos_monthly_statement dal=new HisClient.DAL.his_hos_monthly_statement();
		public his_hos_monthly_statement()
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
		public void  Add(HisClient.Model.his_hos_monthly_statement model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_monthly_statement model)
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
		public HisClient.Model.his_hos_monthly_statement GetModel(string ID)
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
		public List<HisClient.Model.his_hos_monthly_statement> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_monthly_statement> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_monthly_statement> modelList = new List<HisClient.Model.his_hos_monthly_statement>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_monthly_statement model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_monthly_statement();					
																	model.OPERATOR= dt.Rows[n]["OPERATOR"].ToString();
																												if(dt.Rows[n]["OPERATE_TIME"].ToString()!="")
				{
					model.OPERATE_TIME=DateTime.Parse(dt.Rows[n]["OPERATE_TIME"].ToString());
				}
																																				model.RECIVER= dt.Rows[n]["RECIVER"].ToString();
																												if(dt.Rows[n]["START_TIME"].ToString()!="")
				{
					model.START_TIME=DateTime.Parse(dt.Rows[n]["START_TIME"].ToString());
				}
																																if(dt.Rows[n]["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(dt.Rows[n]["END_TIME"].ToString());
				}
																																				model.START_RECEIPT_CODE= dt.Rows[n]["START_RECEIPT_CODE"].ToString();
																																model.END_RECEIPT_CODE= dt.Rows[n]["END_RECEIPT_CODE"].ToString();
																																model.RECEIPT__NUM= dt.Rows[n]["RECEIPT__NUM"].ToString();
																																model.RETUEN_RECEIPT_NUM= dt.Rows[n]["RETUEN_RECEIPT_NUM"].ToString();
																																model.ID= dt.Rows[n]["ID"].ToString();
																						
				
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