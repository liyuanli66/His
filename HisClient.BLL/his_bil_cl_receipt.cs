using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_bil_cl_receipt
		public partial class his_bil_cl_receipt
	{
   		     
		private readonly HisClient.DAL.his_bil_cl_receipt dal=new HisClient.DAL.his_bil_cl_receipt();
		public his_bil_cl_receipt()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_RECEIPT_CODE,string CL_CODE)
		{
			return dal.Exists(CL_RECEIPT_CODE,CL_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_bil_cl_receipt model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_bil_cl_receipt model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			return dal.Delete(CL_RECEIPT_CODE,CL_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_bil_cl_receipt GetModel(string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			return dal.GetModel(CL_RECEIPT_CODE,CL_CODE);
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
		public List<HisClient.Model.his_bil_cl_receipt> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_bil_cl_receipt> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_bil_cl_receipt> modelList = new List<HisClient.Model.his_bil_cl_receipt>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_bil_cl_receipt model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_bil_cl_receipt();					
																	model.CL_RECEIPT_CODE= dt.Rows[n]["CL_RECEIPT_CODE"].ToString();
																																model.CL_CODE= dt.Rows[n]["CL_CODE"].ToString();
																																model.CASHIER= dt.Rows[n]["CASHIER"].ToString();
																																model.RECEICPT_CODE= dt.Rows[n]["RECEICPT_CODE"].ToString();
																												if(dt.Rows[n]["RECIVER_TIME"].ToString()!="")
				{
					model.RECIVER_TIME=DateTime.Parse(dt.Rows[n]["RECIVER_TIME"].ToString());
				}
																																if(dt.Rows[n]["CASH_AMT"].ToString()!="")
				{
					model.CASH_AMT=decimal.Parse(dt.Rows[n]["CASH_AMT"].ToString());
				}
																																if(dt.Rows[n]["CARD_AMT"].ToString()!="")
				{
					model.CARD_AMT=decimal.Parse(dt.Rows[n]["CARD_AMT"].ToString());
				}
																																if(dt.Rows[n]["INSURANCE_AMT"].ToString()!="")
				{
					model.INSURANCE_AMT=decimal.Parse(dt.Rows[n]["INSURANCE_AMT"].ToString());
				}
																																if(dt.Rows[n]["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(dt.Rows[n]["SUM_AMT"].ToString());
				}
																																				model.REFUND_RECP_CODE= dt.Rows[n]["REFUND_RECP_CODE"].ToString();
																												if(dt.Rows[n]["REFUND_DATE"].ToString()!="")
				{
					model.REFUND_DATE=DateTime.Parse(dt.Rows[n]["REFUND_DATE"].ToString());
				}
																																				model.REFUND_OPT= dt.Rows[n]["REFUND_OPT"].ToString();
																												if(dt.Rows[n]["REDUCE_AMT"].ToString()!="")
				{
					model.REDUCE_AMT=int.Parse(dt.Rows[n]["REDUCE_AMT"].ToString());
				}
																																if(dt.Rows[n]["REDUCE_DATE"].ToString()!="")
				{
					model.REDUCE_DATE=DateTime.Parse(dt.Rows[n]["REDUCE_DATE"].ToString());
				}
																																				model.REDUCE_OPT= dt.Rows[n]["REDUCE_OPT"].ToString();
																																model.REDUCE_REASON= dt.Rows[n]["REDUCE_REASON"].ToString();
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