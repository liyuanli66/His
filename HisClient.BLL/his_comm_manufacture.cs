using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.DAL;
using HisClient.Model;
namespace HisClient.BLL {
	 	//his_comm_manufacture
		public partial class his_comm_manufacture
	{
   		     
		private readonly HisClient.DAL.his_comm_manufacture dal=new HisClient.DAL.his_comm_manufacture();
		public his_comm_manufacture()
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
		public void  Add(HisClient.Model.his_comm_manufacture model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.his_comm_manufacture model)
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
		public HisClient.Model.his_comm_manufacture GetModel(string ID)
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
		public List<HisClient.Model.his_comm_manufacture> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.his_comm_manufacture> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.his_comm_manufacture> modelList = new List<HisClient.Model.his_comm_manufacture>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.his_comm_manufacture model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.his_comm_manufacture();					
																	model.ID= dt.Rows[n]["ID"].ToString();
																																model.MANUFACTURE_CODE= dt.Rows[n]["MANUFACTURE_CODE"].ToString();
																																model.MANUFACTURE_NAME= dt.Rows[n]["MANUFACTURE_NAME"].ToString();
																																model.LOCALITY_TYPE= dt.Rows[n]["LOCALITY_TYPE"].ToString();
																												if(dt.Rows[n]["CREDIT_CODE"].ToString()!="")
				{
					model.CREDIT_CODE=int.Parse(dt.Rows[n]["CREDIT_CODE"].ToString());
				}
																																				model.MANUFACTURE_ADDRESS= dt.Rows[n]["MANUFACTURE_ADDRESS"].ToString();
																																model.LINK_MAN= dt.Rows[n]["LINK_MAN"].ToString();
																																model.LINK_TEL= dt.Rows[n]["LINK_TEL"].ToString();
																																model.LINK_EMAIL= dt.Rows[n]["LINK_EMAIL"].ToString();
																																model.FAX= dt.Rows[n]["FAX"].ToString();
																																model.APTITUDE= dt.Rows[n]["APTITUDE"].ToString();
																												if(dt.Rows[n]["APTITUDE_DATE"].ToString()!="")
				{
					model.APTITUDE_DATE=DateTime.Parse(dt.Rows[n]["APTITUDE_DATE"].ToString());
				}
																																				model.HELP_CODE= dt.Rows[n]["HELP_CODE"].ToString();
																																model.HOSPITAL_CODE= dt.Rows[n]["HOSPITAL_CODE"].ToString();
																												if(dt.Rows[n]["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(dt.Rows[n]["CREATE_DATE"].ToString());
				}
																																				model.CREATE_BY= dt.Rows[n]["CREATE_BY"].ToString();
																						
				
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