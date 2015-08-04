﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using HIS.Model;
namespace HIS.BLL
{
	/// <summary>
	/// his_cl_prescription
	/// </summary>
	public partial class his_cl_prescription
	{
		private readonly HIS.DAL.his_cl_prescription dal=new HIS.DAL.his_cl_prescription();
		public his_cl_prescription()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_PRES_CODE,string CL_CODE)
		{
			return dal.Exists(CL_PRES_CODE,CL_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_cl_prescription model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HIS.Model.his_cl_prescription model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CL_PRES_CODE,string CL_CODE)
		{
			
			return dal.Delete(CL_PRES_CODE,CL_CODE);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_cl_prescription GetModel(string CL_PRES_CODE,string CL_CODE)
		{
			
			return dal.GetModel(CL_PRES_CODE,CL_CODE);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public HIS.Model.his_cl_prescription GetModelByCache(string CL_PRES_CODE,string CL_CODE)
		{
			
			string CacheKey = "his_cl_prescriptionModel-" + CL_PRES_CODE+CL_CODE;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CL_PRES_CODE,CL_CODE);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (HIS.Model.his_cl_prescription)objModel;
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
		public List<HIS.Model.his_cl_prescription> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HIS.Model.his_cl_prescription> DataTableToList(DataTable dt)
		{
			List<HIS.Model.his_cl_prescription> modelList = new List<HIS.Model.his_cl_prescription>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HIS.Model.his_cl_prescription model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
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

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
