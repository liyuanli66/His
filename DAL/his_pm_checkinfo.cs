﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_pm_checkinfo
	/// </summary>
	public partial class his_pm_checkinfo
	{
		public his_pm_checkinfo()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_pm_checkinfo");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_pm_checkinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.MEDINFO_CODE != null)
			{
				strSql1.Append("MEDINFO_CODE,");
				strSql2.Append("'"+model.MEDINFO_CODE+"',");
			}
			if (model.MED_SPC != null)
			{
				strSql1.Append("MED_SPC,");
				strSql2.Append("'"+model.MED_SPC+"',");
			}
			if (model.MED_UNIT != null)
			{
				strSql1.Append("MED_UNIT,");
				strSql2.Append("'"+model.MED_UNIT+"',");
			}
			if (model.MED_AMOUNT != null)
			{
				strSql1.Append("MED_AMOUNT,");
				strSql2.Append(""+model.MED_AMOUNT+",");
			}
			if (model.REAL_AMOUNT != null)
			{
				strSql1.Append("REAL_AMOUNT,");
				strSql2.Append(""+model.REAL_AMOUNT+",");
			}
			if (model.MED_PRICE != null)
			{
				strSql1.Append("MED_PRICE,");
				strSql2.Append(""+model.MED_PRICE+",");
			}
			if (model.PURCHASE_PRICE != null)
			{
				strSql1.Append("PURCHASE_PRICE,");
				strSql2.Append(""+model.PURCHASE_PRICE+",");
			}
			if (model.WHOLESALE_PRICE != null)
			{
				strSql1.Append("WHOLESALE_PRICE,");
				strSql2.Append(""+model.WHOLESALE_PRICE+",");
			}
			if (model.VALIDITY_DATE != null)
			{
				strSql1.Append("VALIDITY_DATE,");
				strSql2.Append("'"+model.VALIDITY_DATE+"',");
			}
			if (model.MED_MADETIME != null)
			{
				strSql1.Append("MED_MADETIME,");
				strSql2.Append("'"+model.MED_MADETIME+"',");
			}
			if (model.BACHNO != null)
			{
				strSql1.Append("BACHNO,");
				strSql2.Append("'"+model.BACHNO+"',");
			}
			if (model.DEPT_CODE != null)
			{
				strSql1.Append("DEPT_CODE,");
				strSql2.Append("'"+model.DEPT_CODE+"',");
			}
			if (model.CREATE_DATE != null)
			{
				strSql1.Append("CREATE_DATE,");
				strSql2.Append("'"+model.CREATE_DATE+"',");
			}
			if (model.CREATE_BY != null)
			{
				strSql1.Append("CREATE_BY,");
				strSql2.Append("'"+model.CREATE_BY+"',");
			}
			strSql.Append("insert into his_pm_checkinfo(");
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
		public bool Update(HIS.Model.his_pm_checkinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_pm_checkinfo set ");
			if (model.MEDINFO_CODE != null)
			{
				strSql.Append("MEDINFO_CODE='"+model.MEDINFO_CODE+"',");
			}
			else
			{
				strSql.Append("MEDINFO_CODE= null ,");
			}
			if (model.MED_SPC != null)
			{
				strSql.Append("MED_SPC='"+model.MED_SPC+"',");
			}
			else
			{
				strSql.Append("MED_SPC= null ,");
			}
			if (model.MED_UNIT != null)
			{
				strSql.Append("MED_UNIT='"+model.MED_UNIT+"',");
			}
			else
			{
				strSql.Append("MED_UNIT= null ,");
			}
			if (model.MED_AMOUNT != null)
			{
				strSql.Append("MED_AMOUNT="+model.MED_AMOUNT+",");
			}
			else
			{
				strSql.Append("MED_AMOUNT= null ,");
			}
			if (model.REAL_AMOUNT != null)
			{
				strSql.Append("REAL_AMOUNT="+model.REAL_AMOUNT+",");
			}
			else
			{
				strSql.Append("REAL_AMOUNT= null ,");
			}
			if (model.MED_PRICE != null)
			{
				strSql.Append("MED_PRICE="+model.MED_PRICE+",");
			}
			else
			{
				strSql.Append("MED_PRICE= null ,");
			}
			if (model.PURCHASE_PRICE != null)
			{
				strSql.Append("PURCHASE_PRICE="+model.PURCHASE_PRICE+",");
			}
			else
			{
				strSql.Append("PURCHASE_PRICE= null ,");
			}
			if (model.WHOLESALE_PRICE != null)
			{
				strSql.Append("WHOLESALE_PRICE="+model.WHOLESALE_PRICE+",");
			}
			else
			{
				strSql.Append("WHOLESALE_PRICE= null ,");
			}
			if (model.VALIDITY_DATE != null)
			{
				strSql.Append("VALIDITY_DATE='"+model.VALIDITY_DATE+"',");
			}
			else
			{
				strSql.Append("VALIDITY_DATE= null ,");
			}
			if (model.MED_MADETIME != null)
			{
				strSql.Append("MED_MADETIME='"+model.MED_MADETIME+"',");
			}
			else
			{
				strSql.Append("MED_MADETIME= null ,");
			}
			if (model.BACHNO != null)
			{
				strSql.Append("BACHNO='"+model.BACHNO+"',");
			}
			else
			{
				strSql.Append("BACHNO= null ,");
			}
			if (model.DEPT_CODE != null)
			{
				strSql.Append("DEPT_CODE='"+model.DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("DEPT_CODE= null ,");
			}
			if (model.CREATE_DATE != null)
			{
				strSql.Append("CREATE_DATE='"+model.CREATE_DATE+"',");
			}
			else
			{
				strSql.Append("CREATE_DATE= null ,");
			}
			if (model.CREATE_BY != null)
			{
				strSql.Append("CREATE_BY='"+model.CREATE_BY+"',");
			}
			else
			{
				strSql.Append("CREATE_BY= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' ");
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
		public bool Delete(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_pm_checkinfo ");
			strSql.Append(" where ID='"+ID+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_pm_checkinfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public HIS.Model.his_pm_checkinfo GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,MEDINFO_CODE,MED_SPC,MED_UNIT,MED_AMOUNT,REAL_AMOUNT,MED_PRICE,PURCHASE_PRICE,WHOLESALE_PRICE,VALIDITY_DATE,MED_MADETIME,BACHNO,DEPT_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" from his_pm_checkinfo ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_pm_checkinfo model=new HIS.Model.his_pm_checkinfo();
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
		public HIS.Model.his_pm_checkinfo DataRowToModel(DataRow row)
		{
			HIS.Model.his_pm_checkinfo model=new HIS.Model.his_pm_checkinfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MEDINFO_CODE"]!=null)
				{
					model.MEDINFO_CODE=row["MEDINFO_CODE"].ToString();
				}
				if(row["MED_SPC"]!=null)
				{
					model.MED_SPC=row["MED_SPC"].ToString();
				}
				if(row["MED_UNIT"]!=null)
				{
					model.MED_UNIT=row["MED_UNIT"].ToString();
				}
				if(row["MED_AMOUNT"]!=null && row["MED_AMOUNT"].ToString()!="")
				{
					model.MED_AMOUNT=decimal.Parse(row["MED_AMOUNT"].ToString());
				}
				if(row["REAL_AMOUNT"]!=null && row["REAL_AMOUNT"].ToString()!="")
				{
					model.REAL_AMOUNT=decimal.Parse(row["REAL_AMOUNT"].ToString());
				}
				if(row["MED_PRICE"]!=null && row["MED_PRICE"].ToString()!="")
				{
					model.MED_PRICE=decimal.Parse(row["MED_PRICE"].ToString());
				}
				if(row["PURCHASE_PRICE"]!=null && row["PURCHASE_PRICE"].ToString()!="")
				{
					model.PURCHASE_PRICE=decimal.Parse(row["PURCHASE_PRICE"].ToString());
				}
				if(row["WHOLESALE_PRICE"]!=null && row["WHOLESALE_PRICE"].ToString()!="")
				{
					model.WHOLESALE_PRICE=decimal.Parse(row["WHOLESALE_PRICE"].ToString());
				}
				if(row["VALIDITY_DATE"]!=null && row["VALIDITY_DATE"].ToString()!="")
				{
					model.VALIDITY_DATE=DateTime.Parse(row["VALIDITY_DATE"].ToString());
				}
				if(row["MED_MADETIME"]!=null && row["MED_MADETIME"].ToString()!="")
				{
					model.MED_MADETIME=DateTime.Parse(row["MED_MADETIME"].ToString());
				}
				if(row["BACHNO"]!=null)
				{
					model.BACHNO=row["BACHNO"].ToString();
				}
				if(row["DEPT_CODE"]!=null)
				{
					model.DEPT_CODE=row["DEPT_CODE"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
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
			strSql.Append("select ID,MEDINFO_CODE,MED_SPC,MED_UNIT,MED_AMOUNT,REAL_AMOUNT,MED_PRICE,PURCHASE_PRICE,WHOLESALE_PRICE,VALIDITY_DATE,MED_MADETIME,BACHNO,DEPT_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_pm_checkinfo ");
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
			strSql.Append("select count(1) FROM his_pm_checkinfo ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from his_pm_checkinfo T ");
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
