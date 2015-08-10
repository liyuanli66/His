using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_hos_pres_detail_cancle
		public partial class his_hos_pres_detail_cancle
	{
   		     
		private readonly HisClient.DAL.his_hos_pres_detail_cancle dal=new HisClient.DAL.his_hos_pres_detail_cancle();
		public his_hos_pres_detail_cancle()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			return dal.Exists(ID,HOS_PRES_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_hos_pres_detail_cancle model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_hos_pres_detail_cancle model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID,string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			
			return dal.Delete(ID,HOS_PRES_CODE,HIS_HOS_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_hos_pres_detail_cancle GetModel(string ID,string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			
			return dal.GetModel(ID,HOS_PRES_CODE,HIS_HOS_CODE);
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
		public List<HisClient.Model.his_hos_pres_detail_cancle> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_hos_pres_detail_cancle> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_hos_pres_detail_cancle> modelList = new List<HisClient.Model.his_hos_pres_detail_cancle>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_hos_pres_detail_cancle model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_hos_pres_detail_cancle();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.STATUS= dt.Rows[n]["STATUS"].ToString();
																																model.APPLY_DEPT_CODE= dt.Rows[n]["APPLY_DEPT_CODE"].ToString();
																																model.DOCTOR_CODE= dt.Rows[n]["DOCTOR_CODE"].ToString();
																																model.OPERATE_DEPT_CODE= dt.Rows[n]["OPERATE_DEPT_CODE"].ToString();
																												if(dt.Rows[n]["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(dt.Rows[n]["SUM_AMT"].ToString());
				}
																																				model.OPT_USER= dt.Rows[n]["OPT_USER"].ToString();
																												if(dt.Rows[n]["OPT_DATE"].ToString()!="")
				{
					model.OPT_DATE=DateTime.Parse(dt.Rows[n]["OPT_DATE"].ToString());
				}
																																				model.OPT_TERM= dt.Rows[n]["OPT_TERM"].ToString();
																																model.OPT_ORGA= dt.Rows[n]["OPT_ORGA"].ToString();
																																model.HOS_PRES_CODE= dt.Rows[n]["HOS_PRES_CODE"].ToString();
																																model.HIS_HOS_CODE= dt.Rows[n]["HIS_HOS_CODE"].ToString();
																						
				
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