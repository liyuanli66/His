using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_doctor
		public partial class his_comm_doctor
	{
   		     
		private readonly HisClient.DAL.his_comm_doctor dal=new HisClient.DAL.his_comm_doctor();
		public his_comm_doctor()
		{}
		
		#region  Method
	

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(HisClient.Model.his_comm_doctor model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_doctor model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			
			return dal.Delete();
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HisClient.Model.his_comm_doctor GetModel()
		{
			
			return dal.GetModel();
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
		public List<HisClient.Model.his_comm_doctor> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_doctor> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_doctor> modelList = new List<HisClient.Model.his_comm_doctor>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_doctor model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_doctor();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.DOCTOR_CODE= dt.Rows[n]["DOCTOR_CODE"].ToString();
																																model.DOCTOR_NAME= dt.Rows[n]["DOCTOR_NAME"].ToString();
																																model.DEPT_CODE= dt.Rows[n]["DEPT_CODE"].ToString();
																																model.HISPITAL_CODE= dt.Rows[n]["HISPITAL_CODE"].ToString();
																																model.DOCTOR_SEX= dt.Rows[n]["DOCTOR_SEX"].ToString();
																																model.DOCTOR_TEL= dt.Rows[n]["DOCTOR_TEL"].ToString();
																																model.DOCTOR_NATION= dt.Rows[n]["DOCTOR_NATION"].ToString();
																																model.MERRIAGE_CODE= dt.Rows[n]["MERRIAGE_CODE"].ToString();
																																model.DOCTOR_EMAIL= dt.Rows[n]["DOCTOR_EMAIL"].ToString();
																																model.DOCTOR_TITLE= dt.Rows[n]["DOCTOR_TITLE"].ToString();
																																model.DOCTOR_TITLEGRADE= dt.Rows[n]["DOCTOR_TITLEGRADE"].ToString();
																																model.HELP_CODE= dt.Rows[n]["HELP_CODE"].ToString();
																																model.REMARK= dt.Rows[n]["REMARK"].ToString();
																						
				
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