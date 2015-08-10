using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_cl_medical_record
		public partial class his_cl_medical_record
	{
   		     
		private readonly HisClient.DAL.his_cl_medical_record dal=new HisClient.DAL.his_cl_medical_record();
		public his_cl_medical_record()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_CODE)
		{
			return dal.Exists(CL_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_cl_medical_record model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_cl_medical_record model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CL_CODE)
		{
			
			return dal.Delete(CL_CODE);
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_cl_medical_record GetModel(string CL_CODE)
		{
			
			return dal.GetModel(CL_CODE);
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
		public List<HisClient.Model.his_cl_medical_record> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_cl_medical_record> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_cl_medical_record> modelList = new List<HisClient.Model.his_cl_medical_record>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_cl_medical_record model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_cl_medical_record();					
																	model.CL_CODE= dt.Rows[n]["CL_CODE"].ToString();
																																model.PHA_CODE= dt.Rows[n]["PHA_CODE"].ToString();
																																model.DOCTOR_CODE= dt.Rows[n]["DOCTOR_CODE"].ToString();
																												if(dt.Rows[n]["CL_DATE"].ToString()!="")
				{
					model.CL_DATE=DateTime.Parse(dt.Rows[n]["CL_DATE"].ToString());
				}
																																				model.IP= dt.Rows[n]["IP"].ToString();
																																model.ICD_CODE= dt.Rows[n]["ICD_CODE"].ToString();
																																model.ICD_NAME= dt.Rows[n]["ICD_NAME"].ToString();
																																model.MEMO= dt.Rows[n]["MEMO"].ToString();
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