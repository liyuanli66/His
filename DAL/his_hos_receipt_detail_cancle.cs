﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_receipt_detail_cancle
	/// </summary>
	public partial class his_hos_receipt_detail_cancle
	{
		public his_hos_receipt_detail_cancle()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_receipt_detail_cancle");
			strSql.Append(" where ID='"+ID+"' and HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_receipt_detail_cancle model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.HOS_RECEIPT_CODE != null)
			{
				strSql1.Append("HOS_RECEIPT_CODE,");
				strSql2.Append("'"+model.HOS_RECEIPT_CODE+"',");
			}
			if (model.HIS_HOS_CODE != null)
			{
				strSql1.Append("HIS_HOS_CODE,");
				strSql2.Append("'"+model.HIS_HOS_CODE+"',");
			}
			if (model.FEEITEM_CODE != null)
			{
				strSql1.Append("FEEITEM_CODE,");
				strSql2.Append("'"+model.FEEITEM_CODE+"',");
			}
			if (model.FEEITEM_NAME != null)
			{
				strSql1.Append("FEEITEM_NAME,");
				strSql2.Append("'"+model.FEEITEM_NAME+"',");
			}
			if (model.PRICE != null)
			{
				strSql1.Append("PRICE,");
				strSql2.Append(""+model.PRICE+",");
			}
			if (model.COUNT != null)
			{
				strSql1.Append("COUNT,");
				strSql2.Append(""+model.COUNT+",");
			}
			if (model.UNIT != null)
			{
				strSql1.Append("UNIT,");
				strSql2.Append("'"+model.UNIT+"',");
			}
			if (model.AMT != null)
			{
				strSql1.Append("AMT,");
				strSql2.Append(""+model.AMT+",");
			}
			if (model.OPT_USER != null)
			{
				strSql1.Append("OPT_USER,");
				strSql2.Append("'"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql1.Append("OPT_DATE,");
				strSql2.Append("'"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql1.Append("OPT_TERM,");
				strSql2.Append("'"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql1.Append("OPT_ORGA,");
				strSql2.Append("'"+model.OPT_ORGA+"',");
			}
			strSql.Append("insert into his_hos_receipt_detail_cancle(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HIS.Model.his_hos_receipt_detail_cancle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_receipt_detail_cancle set ");
			if (model.FEEITEM_CODE != null)
			{
				strSql.Append("FEEITEM_CODE='"+model.FEEITEM_CODE+"',");
			}
			if (model.FEEITEM_NAME != null)
			{
				strSql.Append("FEEITEM_NAME='"+model.FEEITEM_NAME+"',");
			}
			if (model.PRICE != null)
			{
				strSql.Append("PRICE="+model.PRICE+",");
			}
			if (model.COUNT != null)
			{
				strSql.Append("COUNT="+model.COUNT+",");
			}
			else
			{
				strSql.Append("COUNT= null ,");
			}
			if (model.UNIT != null)
			{
				strSql.Append("UNIT='"+model.UNIT+"',");
			}
			else
			{
				strSql.Append("UNIT= null ,");
			}
			if (model.AMT != null)
			{
				strSql.Append("AMT="+model.AMT+",");
			}
			else
			{
				strSql.Append("AMT= null ,");
			}
			if (model.OPT_USER != null)
			{
				strSql.Append("OPT_USER='"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql.Append("OPT_DATE='"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql.Append("OPT_TERM='"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql.Append("OPT_ORGA='"+model.OPT_ORGA+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' and HOS_RECEIPT_CODE='"+ model.HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+ model.HIS_HOS_CODE+"' ");
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_receipt_detail_cancle ");
			strSql.Append(" where ID='"+ID+"' and HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_hos_receipt_detail_cancle GetModel(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,HOS_RECEIPT_CODE,HIS_HOS_CODE,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" from his_hos_receipt_detail_cancle ");
			strSql.Append(" where ID='"+ID+"' and HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
			HIS.Model.his_hos_receipt_detail_cancle model=new HIS.Model.his_hos_receipt_detail_cancle();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_hos_receipt_detail_cancle DataRowToModel(DataRow row)
		{
			HIS.Model.his_hos_receipt_detail_cancle model=new HIS.Model.his_hos_receipt_detail_cancle();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["HOS_RECEIPT_CODE"]!=null)
				{
					model.HOS_RECEIPT_CODE=row["HOS_RECEIPT_CODE"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["FEEITEM_CODE"]!=null)
				{
					model.FEEITEM_CODE=row["FEEITEM_CODE"].ToString();
				}
				if(row["FEEITEM_NAME"]!=null)
				{
					model.FEEITEM_NAME=row["FEEITEM_NAME"].ToString();
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["COUNT"]!=null && row["COUNT"].ToString()!="")
				{
					model.COUNT=decimal.Parse(row["COUNT"].ToString());
				}
				if(row["UNIT"]!=null)
				{
					model.UNIT=row["UNIT"].ToString();
				}
				if(row["AMT"]!=null && row["AMT"].ToString()!="")
				{
					model.AMT=decimal.Parse(row["AMT"].ToString());
				}
				if(row["OPT_USER"]!=null)
				{
					model.OPT_USER=row["OPT_USER"].ToString();
				}
				if(row["OPT_DATE"]!=null && row["OPT_DATE"].ToString()!="")
				{
					model.OPT_DATE=DateTime.Parse(row["OPT_DATE"].ToString());
				}
				if(row["OPT_TERM"]!=null)
				{
					model.OPT_TERM=row["OPT_TERM"].ToString();
				}
				if(row["OPT_ORGA"]!=null)
				{
					model.OPT_ORGA=row["OPT_ORGA"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HOS_RECEIPT_CODE,HIS_HOS_CODE,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_hos_receipt_detail_cancle ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM his_hos_receipt_detail_cancle ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.HIS_HOS_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_hos_receipt_detail_cancle T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

