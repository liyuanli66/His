using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using HisClient.Model;
namespace HisClient.BLL {
	 	//comm_icd10_type
		public partial class comm_icd10_type
	{
   		     
		private readonly HisClient.DAL.comm_icd10_type dal=new HisClient.DAL.comm_icd10_type();
		public comm_icd10_type()
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
		public void  Add(HisClient.Model.comm_icd10_type model)
		{
						dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HisClient.Model.comm_icd10_type model)
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
		public HisClient.Model.comm_icd10_type GetModel(string ID)
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
		public List<HisClient.Model.comm_icd10_type> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HisClient.Model.comm_icd10_type> DataTableToList(DataTable dt)
		{
			List<HisClient.Model.comm_icd10_type> modelList = new List<HisClient.Model.comm_icd10_type>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HisClient.Model.comm_icd10_type model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new HisClient.Model.comm_icd10_type();					
																	model.TYPE_CODE= dt.Rows[n]["TYPE_CODE"].ToString();
																																model.ID= dt.Rows[n]["ID"].ToString();
																																model.TYPE_NAME= dt.Rows[n]["TYPE_NAME"].ToString();
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