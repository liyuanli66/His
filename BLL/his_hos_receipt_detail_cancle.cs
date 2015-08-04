using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using HIS.Model;
namespace HIS.BLL
{
	/// <summary>
	/// his_hos_receipt_detail_cancle
	/// </summary>
	public partial class his_hos_receipt_detail_cancle
	{
		private readonly HIS.DAL.his_hos_receipt_detail_cancle dal=new HIS.DAL.his_hos_receipt_detail_cancle();
		public his_hos_receipt_detail_cancle()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			return dal.Exists(ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_receipt_detail_cancle model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HIS.Model.his_hos_receipt_detail_cancle model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			return dal.Delete(ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_hos_receipt_detail_cancle GetModel(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			return dal.GetModel(ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public HIS.Model.his_hos_receipt_detail_cancle GetModelByCache(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			string CacheKey = "his_hos_receipt_detail_cancleModel-" + ID+HOS_RECEIPT_CODE+HIS_HOS_CODE;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (HIS.Model.his_hos_receipt_detail_cancle)objModel;
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
		public List<HIS.Model.his_hos_receipt_detail_cancle> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HIS.Model.his_hos_receipt_detail_cancle> DataTableToList(DataTable dt)
		{
			List<HIS.Model.his_hos_receipt_detail_cancle> modelList = new List<HIS.Model.his_hos_receipt_detail_cancle>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				HIS.Model.his_hos_receipt_detail_cancle model;
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

