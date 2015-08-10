using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_account
		public partial class his_hos_account
	{
   		     
		private readonly HisClient.DAL.his_hos_account dal=new HisClient.DAL.his_hos_account();
		public his_hos_account()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HOS_ACC_CODE,string HIS_HOS_CODE)
		{
			return dal.Exists(HOS_ACC_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_hos_account model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_account model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HOS_ACC_CODE,string HIS_HOS_CODE)
		{
			
			return dal.Delete(HOS_ACC_CODE,HIS_HOS_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_hos_account GetModel(string HOS_ACC_CODE,string HIS_HOS_CODE)
		{
			
			return dal.GetModel(HOS_ACC_CODE,HIS_HOS_CODE);
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
		public List<HisClient.Model.his_hos_account> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_account> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_account> modelList = new List<HisClient.Model.his_hos_account>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_account model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_account();					
																	model.HOS_ACC_CODE= dt.Rows[n]["HOS_ACC_CODE"].ToString();
																																model.HIS_HOS_CODE= dt.Rows[n]["HIS_HOS_CODE"].ToString();
																																model.IP= dt.Rows[n]["IP"].ToString();
																												if(dt.Rows[n]["SUM_IN"].ToString()!="")
				{
					model.SUM_IN=decimal.Parse(dt.Rows[n]["SUM_IN"].ToString());
				}
																																if(dt.Rows[n]["SUM_OUT"].ToString()!="")
				{
					model.SUM_OUT=decimal.Parse(dt.Rows[n]["SUM_OUT"].ToString());
				}
																																if(dt.Rows[n]["ACCOUNT_BALANCE"].ToString()!="")
				{
					model.ACCOUNT_BALANCE=decimal.Parse(dt.Rows[n]["ACCOUNT_BALANCE"].ToString());
				}
																																if(dt.Rows[n]["LOWER_LIMIT"].ToString()!="")
				{
					model.LOWER_LIMIT=decimal.Parse(dt.Rows[n]["LOWER_LIMIT"].ToString());
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