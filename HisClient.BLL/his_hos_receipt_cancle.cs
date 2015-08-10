using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_receipt_cancle
		public partial class his_hos_receipt_cancle
	{
   		     
		private readonly HisClient.DAL.his_hos_receipt_cancle dal=new HisClient.DAL.his_hos_receipt_cancle();
		public his_hos_receipt_cancle()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			return dal.Exists(HOS_RECEIPT_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_hos_receipt_cancle model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_receipt_cancle model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			return dal.Delete(HOS_RECEIPT_CODE,HIS_HOS_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_hos_receipt_cancle GetModel(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			return dal.GetModel(HOS_RECEIPT_CODE,HIS_HOS_CODE);
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
		public List<HisClient.Model.his_hos_receipt_cancle> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_receipt_cancle> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_receipt_cancle> modelList = new List<HisClient.Model.his_hos_receipt_cancle>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_receipt_cancle model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_receipt_cancle();					
																	model.HOS_RECEIPT_CODE= dt.Rows[n]["HOS_RECEIPT_CODE"].ToString();
																																model.HIS_HOS_CODE= dt.Rows[n]["HIS_HOS_CODE"].ToString();
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