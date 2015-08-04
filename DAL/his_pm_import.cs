using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_pm_import
	/// </summary>
	public partial class his_pm_import
	{
		public his_pm_import()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_pm_import");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_pm_import model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.SEND_DEPT_CODE != null)
			{
				strSql1.Append("SEND_DEPT_CODE,");
				strSql2.Append("'"+model.SEND_DEPT_CODE+"',");
			}
			if (model.RECEIVE_DEPT_CODE != null)
			{
				strSql1.Append("RECEIVE_DEPT_CODE,");
				strSql2.Append("'"+model.RECEIVE_DEPT_CODE+"',");
			}
			if (model.PAKAGE_OUT_CODE != null)
			{
				strSql1.Append("PAKAGE_OUT_CODE,");
				strSql2.Append("'"+model.PAKAGE_OUT_CODE+"',");
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
			if (model.IMPORT_CODE != null)
			{
				strSql1.Append("IMPORT_CODE,");
				strSql2.Append("'"+model.IMPORT_CODE+"',");
			}
			strSql.Append("insert into his_pm_import(");
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
		public bool Update(HIS.Model.his_pm_import model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_pm_import set ");
			if (model.SEND_DEPT_CODE != null)
			{
				strSql.Append("SEND_DEPT_CODE='"+model.SEND_DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("SEND_DEPT_CODE= null ,");
			}
			if (model.RECEIVE_DEPT_CODE != null)
			{
				strSql.Append("RECEIVE_DEPT_CODE='"+model.RECEIVE_DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("RECEIVE_DEPT_CODE= null ,");
			}
			if (model.PAKAGE_OUT_CODE != null)
			{
				strSql.Append("PAKAGE_OUT_CODE='"+model.PAKAGE_OUT_CODE+"',");
			}
			else
			{
				strSql.Append("PAKAGE_OUT_CODE= null ,");
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
			if (model.IMPORT_CODE != null)
			{
				strSql.Append("IMPORT_CODE='"+model.IMPORT_CODE+"',");
			}
			else
			{
				strSql.Append("IMPORT_CODE= null ,");
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
			strSql.Append("delete from his_pm_import ");
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
			strSql.Append("delete from his_pm_import ");
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
		public HIS.Model.his_pm_import GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,SEND_DEPT_CODE,RECEIVE_DEPT_CODE,PAKAGE_OUT_CODE,CREATE_BY,CREATE_DATE,IMPORT_CODE ");
			strSql.Append(" from his_pm_import ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_pm_import model=new HIS.Model.his_pm_import();
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
		public HIS.Model.his_pm_import DataRowToModel(DataRow row)
		{
			HIS.Model.his_pm_import model=new HIS.Model.his_pm_import();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["SEND_DEPT_CODE"]!=null)
				{
					model.SEND_DEPT_CODE=row["SEND_DEPT_CODE"].ToString();
				}
				if(row["RECEIVE_DEPT_CODE"]!=null)
				{
					model.RECEIVE_DEPT_CODE=row["RECEIVE_DEPT_CODE"].ToString();
				}
				if(row["PAKAGE_OUT_CODE"]!=null)
				{
					model.PAKAGE_OUT_CODE=row["PAKAGE_OUT_CODE"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["IMPORT_CODE"]!=null)
				{
					model.IMPORT_CODE=row["IMPORT_CODE"].ToString();
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
			strSql.Append("select ID,SEND_DEPT_CODE,RECEIVE_DEPT_CODE,PAKAGE_OUT_CODE,CREATE_BY,CREATE_DATE,IMPORT_CODE ");
			strSql.Append(" FROM his_pm_import ");
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
			strSql.Append("select count(1) FROM his_pm_import ");
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
			strSql.Append(")AS Row, T.*  from his_pm_import T ");
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

