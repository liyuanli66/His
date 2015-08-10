using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_medinfo
		public partial class his_comm_medinfo
	{
   		     
		private readonly HisClient.DAL.his_comm_medinfo dal=new HisClient.DAL.his_comm_medinfo();
		public his_comm_medinfo()
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
		public void  Add(HisClient.Model.his_comm_medinfo model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_medinfo model)
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
		public HisClient.Model.his_comm_medinfo GetModel(string ID)
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
		public List<HisClient.Model.his_comm_medinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_medinfo> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_medinfo> modelList = new List<HisClient.Model.his_comm_medinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_medinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_medinfo();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.MED_CODE= dt.Rows[n]["MED_CODE"].ToString();
																																model.MED_NAME= dt.Rows[n]["MED_NAME"].ToString();
																																model.HELP_CODE= dt.Rows[n]["HELP_CODE"].ToString();
																																model.MENUFACTURE_CODE= dt.Rows[n]["MENUFACTURE_CODE"].ToString();
																																model.MED_SPC= dt.Rows[n]["MED_SPC"].ToString();
																																model.MED_UNIT= dt.Rows[n]["MED_UNIT"].ToString();
																																model.DOSAGE_CODE= dt.Rows[n]["DOSAGE_CODE"].ToString();
																																model.APPROVAL_NUMBER= dt.Rows[n]["APPROVAL_NUMBER"].ToString();
																																model.EFFICACY_CODE= dt.Rows[n]["EFFICACY_CODE"].ToString();
																																model.ORIGIN= dt.Rows[n]["ORIGIN"].ToString();
																																model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.MEDINFO_CODE= dt.Rows[n]["MEDINFO_CODE"].ToString();
																																model.PAKAGE_UNIT= dt.Rows[n]["PAKAGE_UNIT"].ToString();
																												if(dt.Rows[n]["PAKAGE_PM_NUMBER"].ToString()!="")
				{
					model.PAKAGE_PM_NUMBER=int.Parse(dt.Rows[n]["PAKAGE_PM_NUMBER"].ToString());
				}
																																if(dt.Rows[n]["DEFAULT_DOSAGE_AMOUNT"].ToString()!="")
				{
					model.DEFAULT_DOSAGE_AMOUNT=decimal.Parse(dt.Rows[n]["DEFAULT_DOSAGE_AMOUNT"].ToString());
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