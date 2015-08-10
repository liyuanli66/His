using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_bil_cl_recp_detail
		public partial class his_bil_cl_recp_detail
	{
   		     
		private readonly HisClient.DAL.his_bil_cl_recp_detail dal=new HisClient.DAL.his_bil_cl_recp_detail();
		public his_bil_cl_recp_detail()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			return dal.Exists(ID,CL_RECEIPT_CODE,CL_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_bil_cl_recp_detail model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_bil_cl_recp_detail model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			return dal.Delete(ID,CL_RECEIPT_CODE,CL_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_bil_cl_recp_detail GetModel(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			return dal.GetModel(ID,CL_RECEIPT_CODE,CL_CODE);
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
		public List<HisClient.Model.his_bil_cl_recp_detail> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_bil_cl_recp_detail> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_bil_cl_recp_detail> modelList = new List<HisClient.Model.his_bil_cl_recp_detail>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_bil_cl_recp_detail model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_bil_cl_recp_detail();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.CL_RECEIPT_CODE= dt.Rows[n]["CL_RECEIPT_CODE"].ToString();
																																model.CL_CODE= dt.Rows[n]["CL_CODE"].ToString();
																																model.OPT_USER= dt.Rows[n]["OPT_USER"].ToString();
																												if(dt.Rows[n]["OPT_DATE"].ToString()!="")
				{
					model.OPT_DATE=DateTime.Parse(dt.Rows[n]["OPT_DATE"].ToString());
				}
																																				model.OPT_TERM= dt.Rows[n]["OPT_TERM"].ToString();
																																model.OPT_ORGA= dt.Rows[n]["OPT_ORGA"].ToString();
																																model.FEEITEM_CODE= dt.Rows[n]["FEEITEM_CODE"].ToString();
																																model.FEEITEM_NAME= dt.Rows[n]["FEEITEM_NAME"].ToString();
																												if(dt.Rows[n]["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(dt.Rows[n]["PRICE"].ToString());
				}
																																if(dt.Rows[n]["COUNT"].ToString()!="")
				{
					model.COUNT=decimal.Parse(dt.Rows[n]["COUNT"].ToString());
				}
																																				model.UNIT= dt.Rows[n]["UNIT"].ToString();
																												if(dt.Rows[n]["AMT"].ToString()!="")
				{
					model.AMT=decimal.Parse(dt.Rows[n]["AMT"].ToString());
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