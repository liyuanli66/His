﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_module
	/// </summary>
	public partial class his_comm_module
	{
		public his_comm_module()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_module");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_module model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.MODULE_NAME != null)
			{
				strSql1.Append("MODULE_NAME,");
				strSql2.Append("'"+model.MODULE_NAME+"',");
			}
			if (model.MODULE_CODE != null)
			{
				strSql1.Append("MODULE_CODE,");
				strSql2.Append("'"+model.MODULE_CODE+"',");
			}
			if (model.SYSTEM_CODE != null)
			{
				strSql1.Append("SYSTEM_CODE,");
				strSql2.Append("'"+model.SYSTEM_CODE+"',");
			}
			if (model.IS_USE != null)
			{
				strSql1.Append("IS_USE,");
				strSql2.Append("'"+model.IS_USE+"',");
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
			if (model.HOSPITAL_CODE != null)
			{
				strSql1.Append("HOSPITAL_CODE,");
				strSql2.Append("'"+model.HOSPITAL_CODE+"',");
			}
			if (model.REMARK != null)
			{
				strSql1.Append("REMARK,");
				strSql2.Append("'"+model.REMARK+"',");
			}
			strSql.Append("insert into his_comm_module(");
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
		public bool Update(HIS.Model.his_comm_module model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_module set ");
			if (model.MODULE_NAME != null)
			{
				strSql.Append("MODULE_NAME='"+model.MODULE_NAME+"',");
			}
			else
			{
				strSql.Append("MODULE_NAME= null ,");
			}
			if (model.MODULE_CODE != null)
			{
				strSql.Append("MODULE_CODE='"+model.MODULE_CODE+"',");
			}
			else
			{
				strSql.Append("MODULE_CODE= null ,");
			}
			if (model.SYSTEM_CODE != null)
			{
				strSql.Append("SYSTEM_CODE='"+model.SYSTEM_CODE+"',");
			}
			else
			{
				strSql.Append("SYSTEM_CODE= null ,");
			}
			if (model.IS_USE != null)
			{
				strSql.Append("IS_USE='"+model.IS_USE+"',");
			}
			else
			{
				strSql.Append("IS_USE= null ,");
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
			if (model.HOSPITAL_CODE != null)
			{
				strSql.Append("HOSPITAL_CODE='"+model.HOSPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HOSPITAL_CODE= null ,");
			}
			if (model.REMARK != null)
			{
				strSql.Append("REMARK='"+model.REMARK+"',");
			}
			else
			{
				strSql.Append("REMARK= null ,");
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
			strSql.Append("delete from his_comm_module ");
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
			strSql.Append("delete from his_comm_module ");
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
		public HIS.Model.his_comm_module GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,MODULE_NAME,MODULE_CODE,SYSTEM_CODE,IS_USE,CREATE_DATE,CREATE_BY,HOSPITAL_CODE,REMARK ");
			strSql.Append(" from his_comm_module ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_comm_module model=new HIS.Model.his_comm_module();
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
		public HIS.Model.his_comm_module DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_module model=new HIS.Model.his_comm_module();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MODULE_NAME"]!=null)
				{
					model.MODULE_NAME=row["MODULE_NAME"].ToString();
				}
				if(row["MODULE_CODE"]!=null)
				{
					model.MODULE_CODE=row["MODULE_CODE"].ToString();
				}
				if(row["SYSTEM_CODE"]!=null)
				{
					model.SYSTEM_CODE=row["SYSTEM_CODE"].ToString();
				}
				if(row["IS_USE"]!=null)
				{
					model.IS_USE=row["IS_USE"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select ID,MODULE_NAME,MODULE_CODE,SYSTEM_CODE,IS_USE,CREATE_DATE,CREATE_BY,HOSPITAL_CODE,REMARK ");
			strSql.Append(" FROM his_comm_module ");
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
			strSql.Append("select count(1) FROM his_comm_module ");
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
			strSql.Append(")AS Row, T.*  from his_comm_module T ");
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
