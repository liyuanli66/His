using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_pm_check
	/// </summary>
	public partial class his_pm_check
	{
		public his_pm_check()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_pm_check");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_pm_check model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.CHECK_CODE != null)
			{
				strSql1.Append("CHECK_CODE,");
				strSql2.Append("'"+model.CHECK_CODE+"',");
			}
			if (model.CREATE_BY != null)
			{
				strSql1.Append("CREATE_BY,");
				strSql2.Append("'"+model.CREATE_BY+"',");
			}
			if (model.CREATE_DATE != null)
			{
				strSql1.Append("CREATE_DATE,");
				strSql2.Append("'"+model.CREATE_DATE+"',");
			}
			if (model.DEPT_CODE != null)
			{
				strSql1.Append("DEPT_CODE,");
				strSql2.Append("'"+model.DEPT_CODE+"',");
			}
			if (model.DEPT_NAME != null)
			{
				strSql1.Append("DEPT_NAME,");
				strSql2.Append("'"+model.DEPT_NAME+"',");
			}
			if (model.MEMO != null)
			{
				strSql1.Append("MEMO,");
				strSql2.Append("'"+model.MEMO+"',");
			}
			if (model.LOSE_COST != null)
			{
				strSql1.Append("LOSE_COST,");
				strSql2.Append(""+model.LOSE_COST+",");
			}
			if (model.PROFIT_COST != null)
			{
				strSql1.Append("PROFIT_COST,");
				strSql2.Append(""+model.PROFIT_COST+",");
			}
			strSql.Append("insert into his_pm_check(");
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
		public bool Update(HIS.Model.his_pm_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_pm_check set ");
			if (model.CHECK_CODE != null)
			{
				strSql.Append("CHECK_CODE='"+model.CHECK_CODE+"',");
			}
			else
			{
				strSql.Append("CHECK_CODE= null ,");
			}
			if (model.CREATE_BY != null)
			{
				strSql.Append("CREATE_BY='"+model.CREATE_BY+"',");
			}
			else
			{
				strSql.Append("CREATE_BY= null ,");
			}
			if (model.CREATE_DATE != null)
			{
				strSql.Append("CREATE_DATE='"+model.CREATE_DATE+"',");
			}
			else
			{
				strSql.Append("CREATE_DATE= null ,");
			}
			if (model.DEPT_CODE != null)
			{
				strSql.Append("DEPT_CODE='"+model.DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("DEPT_CODE= null ,");
			}
			if (model.DEPT_NAME != null)
			{
				strSql.Append("DEPT_NAME='"+model.DEPT_NAME+"',");
			}
			else
			{
				strSql.Append("DEPT_NAME= null ,");
			}
			if (model.MEMO != null)
			{
				strSql.Append("MEMO='"+model.MEMO+"',");
			}
			else
			{
				strSql.Append("MEMO= null ,");
			}
			if (model.LOSE_COST != null)
			{
				strSql.Append("LOSE_COST="+model.LOSE_COST+",");
			}
			else
			{
				strSql.Append("LOSE_COST= null ,");
			}
			if (model.PROFIT_COST != null)
			{
				strSql.Append("PROFIT_COST="+model.PROFIT_COST+",");
			}
			else
			{
				strSql.Append("PROFIT_COST= null ,");
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
			strSql.Append("delete from his_pm_check ");
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
			strSql.Append("delete from his_pm_check ");
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
		public HIS.Model.his_pm_check GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,CHECK_CODE,CREATE_BY,CREATE_DATE,DEPT_CODE,DEPT_NAME,MEMO,LOSE_COST,PROFIT_COST ");
			strSql.Append(" from his_pm_check ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_pm_check model=new HIS.Model.his_pm_check();
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
		public HIS.Model.his_pm_check DataRowToModel(DataRow row)
		{
			HIS.Model.his_pm_check model=new HIS.Model.his_pm_check();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CHECK_CODE"]!=null)
				{
					model.CHECK_CODE=row["CHECK_CODE"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["DEPT_CODE"]!=null)
				{
					model.DEPT_CODE=row["DEPT_CODE"].ToString();
				}
				if(row["DEPT_NAME"]!=null)
				{
					model.DEPT_NAME=row["DEPT_NAME"].ToString();
				}
				if(row["MEMO"]!=null)
				{
					model.MEMO=row["MEMO"].ToString();
				}
				if(row["LOSE_COST"]!=null && row["LOSE_COST"].ToString()!="")
				{
					model.LOSE_COST=decimal.Parse(row["LOSE_COST"].ToString());
				}
				if(row["PROFIT_COST"]!=null && row["PROFIT_COST"].ToString()!="")
				{
					model.PROFIT_COST=decimal.Parse(row["PROFIT_COST"].ToString());
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
			strSql.Append("select ID,CHECK_CODE,CREATE_BY,CREATE_DATE,DEPT_CODE,DEPT_NAME,MEMO,LOSE_COST,PROFIT_COST ");
			strSql.Append(" FROM his_pm_check ");
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
			strSql.Append("select count(1) FROM his_pm_check ");
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
			strSql.Append(")AS Row, T.*  from his_pm_check T ");
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

