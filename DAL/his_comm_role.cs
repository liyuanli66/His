using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_role
	/// </summary>
	public partial class his_comm_role
	{
		public his_comm_role()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_role");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_role model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.ROLE_CODE != null)
			{
				strSql1.Append("ROLE_CODE,");
				strSql2.Append("'"+model.ROLE_CODE+"',");
			}
			if (model.ROLE_NAME != null)
			{
				strSql1.Append("ROLE_NAME,");
				strSql2.Append("'"+model.ROLE_NAME+"',");
			}
			if (model.ROLE_XML != null)
			{
				strSql1.Append("ROLE_XML,");
				strSql2.Append("'"+model.ROLE_XML+"',");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql1.Append("HOSPITAL_CODE,");
				strSql2.Append("'"+model.HOSPITAL_CODE+"',");
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
			strSql.Append("insert into his_comm_role(");
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
		public bool Update(HIS.Model.his_comm_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_role set ");
			if (model.ROLE_CODE != null)
			{
				strSql.Append("ROLE_CODE='"+model.ROLE_CODE+"',");
			}
			else
			{
				strSql.Append("ROLE_CODE= null ,");
			}
			if (model.ROLE_NAME != null)
			{
				strSql.Append("ROLE_NAME='"+model.ROLE_NAME+"',");
			}
			else
			{
				strSql.Append("ROLE_NAME= null ,");
			}
			if (model.ROLE_XML != null)
			{
				strSql.Append("ROLE_XML='"+model.ROLE_XML+"',");
			}
			else
			{
				strSql.Append("ROLE_XML= null ,");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql.Append("HOSPITAL_CODE='"+model.HOSPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HOSPITAL_CODE= null ,");
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
			strSql.Append("delete from his_comm_role ");
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
			strSql.Append("delete from his_comm_role ");
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
		public HIS.Model.his_comm_role GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,ROLE_CODE,ROLE_NAME,ROLE_XML,HOSPITAL_CODE,IS_USE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" from his_comm_role ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_comm_role model=new HIS.Model.his_comm_role();
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
		public HIS.Model.his_comm_role DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_role model=new HIS.Model.his_comm_role();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ROLE_CODE"]!=null)
				{
					model.ROLE_CODE=row["ROLE_CODE"].ToString();
				}
				if(row["ROLE_NAME"]!=null)
				{
					model.ROLE_NAME=row["ROLE_NAME"].ToString();
				}
				if(row["ROLE_XML"]!=null)
				{
					model.ROLE_XML=row["ROLE_XML"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ROLE_CODE,ROLE_NAME,ROLE_XML,HOSPITAL_CODE,IS_USE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_comm_role ");
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
			strSql.Append("select count(1) FROM his_comm_role ");
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
			strSql.Append(")AS Row, T.*  from his_comm_role T ");
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

