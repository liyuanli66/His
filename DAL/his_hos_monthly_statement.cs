using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_monthly_statement
	/// </summary>
	public partial class his_hos_monthly_statement
	{
		public his_hos_monthly_statement()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_monthly_statement");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_monthly_statement model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.OPERATOR != null)
			{
				strSql1.Append("OPERATOR,");
				strSql2.Append("'"+model.OPERATOR+"',");
			}
			if (model.OPERATE_TIME != null)
			{
				strSql1.Append("OPERATE_TIME,");
				strSql2.Append("'"+model.OPERATE_TIME+"',");
			}
			if (model.RECIVER != null)
			{
				strSql1.Append("RECIVER,");
				strSql2.Append("'"+model.RECIVER+"',");
			}
			if (model.START_TIME != null)
			{
				strSql1.Append("START_TIME,");
				strSql2.Append("'"+model.START_TIME+"',");
			}
			if (model.END_TIME != null)
			{
				strSql1.Append("END_TIME,");
				strSql2.Append("'"+model.END_TIME+"',");
			}
			if (model.START_RECEIPT_CODE != null)
			{
				strSql1.Append("START_RECEIPT_CODE,");
				strSql2.Append("'"+model.START_RECEIPT_CODE+"',");
			}
			if (model.END_RECEIPT_CODE != null)
			{
				strSql1.Append("END_RECEIPT_CODE,");
				strSql2.Append("'"+model.END_RECEIPT_CODE+"',");
			}
			if (model.RECEIPT__NUM != null)
			{
				strSql1.Append("RECEIPT__NUM,");
				strSql2.Append("'"+model.RECEIPT__NUM+"',");
			}
			if (model.RETUEN_RECEIPT_NUM != null)
			{
				strSql1.Append("RETUEN_RECEIPT_NUM,");
				strSql2.Append("'"+model.RETUEN_RECEIPT_NUM+"',");
			}
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			strSql.Append("insert into his_hos_monthly_statement(");
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
		public bool Update(HIS.Model.his_hos_monthly_statement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_monthly_statement set ");
			if (model.OPERATOR != null)
			{
				strSql.Append("OPERATOR='"+model.OPERATOR+"',");
			}
			else
			{
				strSql.Append("OPERATOR= null ,");
			}
			if (model.OPERATE_TIME != null)
			{
				strSql.Append("OPERATE_TIME='"+model.OPERATE_TIME+"',");
			}
			else
			{
				strSql.Append("OPERATE_TIME= null ,");
			}
			if (model.RECIVER != null)
			{
				strSql.Append("RECIVER='"+model.RECIVER+"',");
			}
			else
			{
				strSql.Append("RECIVER= null ,");
			}
			if (model.START_TIME != null)
			{
				strSql.Append("START_TIME='"+model.START_TIME+"',");
			}
			else
			{
				strSql.Append("START_TIME= null ,");
			}
			if (model.END_TIME != null)
			{
				strSql.Append("END_TIME='"+model.END_TIME+"',");
			}
			else
			{
				strSql.Append("END_TIME= null ,");
			}
			if (model.START_RECEIPT_CODE != null)
			{
				strSql.Append("START_RECEIPT_CODE='"+model.START_RECEIPT_CODE+"',");
			}
			else
			{
				strSql.Append("START_RECEIPT_CODE= null ,");
			}
			if (model.END_RECEIPT_CODE != null)
			{
				strSql.Append("END_RECEIPT_CODE='"+model.END_RECEIPT_CODE+"',");
			}
			else
			{
				strSql.Append("END_RECEIPT_CODE= null ,");
			}
			if (model.RECEIPT__NUM != null)
			{
				strSql.Append("RECEIPT__NUM='"+model.RECEIPT__NUM+"',");
			}
			else
			{
				strSql.Append("RECEIPT__NUM= null ,");
			}
			if (model.RETUEN_RECEIPT_NUM != null)
			{
				strSql.Append("RETUEN_RECEIPT_NUM='"+model.RETUEN_RECEIPT_NUM+"',");
			}
			else
			{
				strSql.Append("RETUEN_RECEIPT_NUM= null ,");
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
			strSql.Append("delete from his_hos_monthly_statement ");
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
			strSql.Append("delete from his_hos_monthly_statement ");
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
		public HIS.Model.his_hos_monthly_statement GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" OPERATOR,OPERATE_TIME,RECIVER,START_TIME,END_TIME,START_RECEIPT_CODE,END_RECEIPT_CODE,RECEIPT__NUM,RETUEN_RECEIPT_NUM,ID ");
			strSql.Append(" from his_hos_monthly_statement ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_hos_monthly_statement model=new HIS.Model.his_hos_monthly_statement();
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
		public HIS.Model.his_hos_monthly_statement DataRowToModel(DataRow row)
		{
			HIS.Model.his_hos_monthly_statement model=new HIS.Model.his_hos_monthly_statement();
			if (row != null)
			{
				if(row["OPERATOR"]!=null)
				{
					model.OPERATOR=row["OPERATOR"].ToString();
				}
				if(row["OPERATE_TIME"]!=null && row["OPERATE_TIME"].ToString()!="")
				{
					model.OPERATE_TIME=DateTime.Parse(row["OPERATE_TIME"].ToString());
				}
				if(row["RECIVER"]!=null)
				{
					model.RECIVER=row["RECIVER"].ToString();
				}
				if(row["START_TIME"]!=null && row["START_TIME"].ToString()!="")
				{
					model.START_TIME=DateTime.Parse(row["START_TIME"].ToString());
				}
				if(row["END_TIME"]!=null && row["END_TIME"].ToString()!="")
				{
					model.END_TIME=DateTime.Parse(row["END_TIME"].ToString());
				}
				if(row["START_RECEIPT_CODE"]!=null)
				{
					model.START_RECEIPT_CODE=row["START_RECEIPT_CODE"].ToString();
				}
				if(row["END_RECEIPT_CODE"]!=null)
				{
					model.END_RECEIPT_CODE=row["END_RECEIPT_CODE"].ToString();
				}
				if(row["RECEIPT__NUM"]!=null)
				{
					model.RECEIPT__NUM=row["RECEIPT__NUM"].ToString();
				}
				if(row["RETUEN_RECEIPT_NUM"]!=null)
				{
					model.RETUEN_RECEIPT_NUM=row["RETUEN_RECEIPT_NUM"].ToString();
				}
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
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
			strSql.Append("select OPERATOR,OPERATE_TIME,RECIVER,START_TIME,END_TIME,START_RECEIPT_CODE,END_RECEIPT_CODE,RECEIPT__NUM,RETUEN_RECEIPT_NUM,ID ");
			strSql.Append(" FROM his_hos_monthly_statement ");
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
			strSql.Append("select count(1) FROM his_hos_monthly_statement ");
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
			strSql.Append(")AS Row, T.*  from his_hos_monthly_statement T ");
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

