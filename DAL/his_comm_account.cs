using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_account
	/// </summary>
	public partial class his_comm_account
	{
		public his_comm_account()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_account");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_account model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.ACCOUNT != null)
			{
				strSql1.Append("ACCOUNT,");
				strSql2.Append("'"+model.ACCOUNT+"',");
			}
			if (model.PASSWORD != null)
			{
				strSql1.Append("PASSWORD,");
				strSql2.Append("'"+model.PASSWORD+"',");
			}
			if (model.ROLE_CODE != null)
			{
				strSql1.Append("ROLE_CODE,");
				strSql2.Append("'"+model.ROLE_CODE+"',");
			}
			if (model.USER_CODE != null)
			{
				strSql1.Append("USER_CODE,");
				strSql2.Append("'"+model.USER_CODE+"',");
			}
			if (model.ADMIN_TYPE != null)
			{
				strSql1.Append("ADMIN_TYPE,");
				strSql2.Append("'"+model.ADMIN_TYPE+"',");
			}
			if (model.IS_USE != null)
			{
				strSql1.Append("IS_USE,");
				strSql2.Append("'"+model.IS_USE+"',");
			}
			if (model.AUTHORITY_XML != null)
			{
				strSql1.Append("AUTHORITY_XML,");
				strSql2.Append("'"+model.AUTHORITY_XML+"',");
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
			if (model.LAST_LOGINTIME != null)
			{
				strSql1.Append("LAST_LOGINTIME,");
				strSql2.Append("'"+model.LAST_LOGINTIME+"',");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql1.Append("HOSPITAL_CODE,");
				strSql2.Append("'"+model.HOSPITAL_CODE+"',");
			}
			strSql.Append("insert into his_comm_account(");
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
		public bool Update(HIS.Model.his_comm_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_account set ");
			if (model.ACCOUNT != null)
			{
				strSql.Append("ACCOUNT='"+model.ACCOUNT+"',");
			}
			else
			{
				strSql.Append("ACCOUNT= null ,");
			}
			if (model.PASSWORD != null)
			{
				strSql.Append("PASSWORD='"+model.PASSWORD+"',");
			}
			else
			{
				strSql.Append("PASSWORD= null ,");
			}
			if (model.ROLE_CODE != null)
			{
				strSql.Append("ROLE_CODE='"+model.ROLE_CODE+"',");
			}
			else
			{
				strSql.Append("ROLE_CODE= null ,");
			}
			if (model.USER_CODE != null)
			{
				strSql.Append("USER_CODE='"+model.USER_CODE+"',");
			}
			else
			{
				strSql.Append("USER_CODE= null ,");
			}
			if (model.ADMIN_TYPE != null)
			{
				strSql.Append("ADMIN_TYPE='"+model.ADMIN_TYPE+"',");
			}
			else
			{
				strSql.Append("ADMIN_TYPE= null ,");
			}
			if (model.IS_USE != null)
			{
				strSql.Append("IS_USE='"+model.IS_USE+"',");
			}
			else
			{
				strSql.Append("IS_USE= null ,");
			}
			if (model.AUTHORITY_XML != null)
			{
				strSql.Append("AUTHORITY_XML='"+model.AUTHORITY_XML+"',");
			}
			else
			{
				strSql.Append("AUTHORITY_XML= null ,");
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
			if (model.LAST_LOGINTIME != null)
			{
				strSql.Append("LAST_LOGINTIME='"+model.LAST_LOGINTIME+"',");
			}
			else
			{
				strSql.Append("LAST_LOGINTIME= null ,");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql.Append("HOSPITAL_CODE='"+model.HOSPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HOSPITAL_CODE= null ,");
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
			strSql.Append("delete from his_comm_account ");
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
			strSql.Append("delete from his_comm_account ");
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
		public HIS.Model.his_comm_account GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,ACCOUNT,PASSWORD,ROLE_CODE,USER_CODE,ADMIN_TYPE,IS_USE,AUTHORITY_XML,CREATE_DATE,CREATE_BY,LAST_LOGINTIME,HOSPITAL_CODE ");
			strSql.Append(" from his_comm_account ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_comm_account model=new HIS.Model.his_comm_account();
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
		public HIS.Model.his_comm_account DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_account model=new HIS.Model.his_comm_account();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ACCOUNT"]!=null)
				{
					model.ACCOUNT=row["ACCOUNT"].ToString();
				}
				if(row["PASSWORD"]!=null)
				{
					model.PASSWORD=row["PASSWORD"].ToString();
				}
				if(row["ROLE_CODE"]!=null)
				{
					model.ROLE_CODE=row["ROLE_CODE"].ToString();
				}
				if(row["USER_CODE"]!=null)
				{
					model.USER_CODE=row["USER_CODE"].ToString();
				}
				if(row["ADMIN_TYPE"]!=null)
				{
					model.ADMIN_TYPE=row["ADMIN_TYPE"].ToString();
				}
				if(row["IS_USE"]!=null)
				{
					model.IS_USE=row["IS_USE"].ToString();
				}
				if(row["AUTHORITY_XML"]!=null)
				{
					model.AUTHORITY_XML=row["AUTHORITY_XML"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["LAST_LOGINTIME"]!=null && row["LAST_LOGINTIME"].ToString()!="")
				{
					model.LAST_LOGINTIME=DateTime.Parse(row["LAST_LOGINTIME"].ToString());
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
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
			strSql.Append("select ID,ACCOUNT,PASSWORD,ROLE_CODE,USER_CODE,ADMIN_TYPE,IS_USE,AUTHORITY_XML,CREATE_DATE,CREATE_BY,LAST_LOGINTIME,HOSPITAL_CODE ");
			strSql.Append(" FROM his_comm_account ");
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
			strSql.Append("select count(1) FROM his_comm_account ");
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
			strSql.Append(")AS Row, T.*  from his_comm_account T ");
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

