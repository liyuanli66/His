using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:comm_icd10
	/// </summary>
	public partial class comm_icd10
	{
		public comm_icd10()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from comm_icd10");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.comm_icd10 model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.ICD_CODE != null)
			{
				strSql1.Append("ICD_CODE,");
				strSql2.Append("'"+model.ICD_CODE+"',");
			}
			if (model.ICD_NAME != null)
			{
				strSql1.Append("ICD_NAME,");
				strSql2.Append("'"+model.ICD_NAME+"',");
			}
			if (model.HELP_CODE != null)
			{
				strSql1.Append("HELP_CODE,");
				strSql2.Append("'"+model.HELP_CODE+"',");
			}
			if (model.TYPE_CODE != null)
			{
				strSql1.Append("TYPE_CODE,");
				strSql2.Append("'"+model.TYPE_CODE+"',");
			}
			strSql.Append("insert into comm_icd10(");
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
		public bool Update(HIS.Model.comm_icd10 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update comm_icd10 set ");
			if (model.ICD_CODE != null)
			{
				strSql.Append("ICD_CODE='"+model.ICD_CODE+"',");
			}
			else
			{
				strSql.Append("ICD_CODE= null ,");
			}
			if (model.ICD_NAME != null)
			{
				strSql.Append("ICD_NAME='"+model.ICD_NAME+"',");
			}
			else
			{
				strSql.Append("ICD_NAME= null ,");
			}
			if (model.HELP_CODE != null)
			{
				strSql.Append("HELP_CODE='"+model.HELP_CODE+"',");
			}
			else
			{
				strSql.Append("HELP_CODE= null ,");
			}
			if (model.TYPE_CODE != null)
			{
				strSql.Append("TYPE_CODE='"+model.TYPE_CODE+"',");
			}
			else
			{
				strSql.Append("TYPE_CODE= null ,");
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
			strSql.Append("delete from comm_icd10 ");
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
			strSql.Append("delete from comm_icd10 ");
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
		public HIS.Model.comm_icd10 GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,ICD_CODE,ICD_NAME,HELP_CODE,TYPE_CODE ");
			strSql.Append(" from comm_icd10 ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.comm_icd10 model=new HIS.Model.comm_icd10();
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
		public HIS.Model.comm_icd10 DataRowToModel(DataRow row)
		{
			HIS.Model.comm_icd10 model=new HIS.Model.comm_icd10();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ICD_CODE"]!=null)
				{
					model.ICD_CODE=row["ICD_CODE"].ToString();
				}
				if(row["ICD_NAME"]!=null)
				{
					model.ICD_NAME=row["ICD_NAME"].ToString();
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["TYPE_CODE"]!=null)
				{
					model.TYPE_CODE=row["TYPE_CODE"].ToString();
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
			strSql.Append("select ID,ICD_CODE,ICD_NAME,HELP_CODE,TYPE_CODE ");
			strSql.Append(" FROM comm_icd10 ");
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
			strSql.Append("select count(1) FROM comm_icd10 ");
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
			strSql.Append(")AS Row, T.*  from comm_icd10 T ");
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

