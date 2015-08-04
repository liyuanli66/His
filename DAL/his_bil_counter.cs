using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_bil_counter
	/// </summary>
	public partial class his_bil_counter
	{
		public his_bil_counter()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_bil_counter");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_bil_counter model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.CASHIER != null)
			{
				strSql1.Append("CASHIER,");
				strSql2.Append("'"+model.CASHIER+"',");
			}
			if (model.START_IVNNO != null)
			{
				strSql1.Append("START_IVNNO,");
				strSql2.Append("'"+model.START_IVNNO+"',");
			}
			if (model.END_IVNNO != null)
			{
				strSql1.Append("END_IVNNO,");
				strSql2.Append("'"+model.END_IVNNO+"',");
			}
			if (model.RECP_TYPE != null)
			{
				strSql1.Append("RECP_TYPE,");
				strSql2.Append("'"+model.RECP_TYPE+"',");
			}
			if (model.USE_TYPE != null)
			{
				strSql1.Append("USE_TYPE,");
				strSql2.Append("'"+model.USE_TYPE+"',");
			}
			if (model.RECP_COUNT != null)
			{
				strSql1.Append("RECP_COUNT,");
				strSql2.Append(""+model.RECP_COUNT+",");
			}
			if (model.PRE_CODE != null)
			{
				strSql1.Append("PRE_CODE,");
				strSql2.Append("'"+model.PRE_CODE+"',");
			}
			if (model.REFOUNDED_COUNT != null)
			{
				strSql1.Append("REFOUNDED_COUNT,");
				strSql2.Append(""+model.REFOUNDED_COUNT+",");
			}
			if (model.INVALID_COUNT != null)
			{
				strSql1.Append("INVALID_COUNT,");
				strSql2.Append(""+model.INVALID_COUNT+",");
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
			strSql.Append("insert into his_bil_counter(");
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
		public bool Update(HIS.Model.his_bil_counter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_bil_counter set ");
			if (model.CASHIER != null)
			{
				strSql.Append("CASHIER='"+model.CASHIER+"',");
			}
			if (model.START_IVNNO != null)
			{
				strSql.Append("START_IVNNO='"+model.START_IVNNO+"',");
			}
			if (model.END_IVNNO != null)
			{
				strSql.Append("END_IVNNO='"+model.END_IVNNO+"',");
			}
			if (model.RECP_TYPE != null)
			{
				strSql.Append("RECP_TYPE='"+model.RECP_TYPE+"',");
			}
			else
			{
				strSql.Append("RECP_TYPE= null ,");
			}
			if (model.USE_TYPE != null)
			{
				strSql.Append("USE_TYPE='"+model.USE_TYPE+"',");
			}
			if (model.RECP_COUNT != null)
			{
				strSql.Append("RECP_COUNT="+model.RECP_COUNT+",");
			}
			if (model.PRE_CODE != null)
			{
				strSql.Append("PRE_CODE='"+model.PRE_CODE+"',");
			}
			else
			{
				strSql.Append("PRE_CODE= null ,");
			}
			if (model.REFOUNDED_COUNT != null)
			{
				strSql.Append("REFOUNDED_COUNT="+model.REFOUNDED_COUNT+",");
			}
			if (model.INVALID_COUNT != null)
			{
				strSql.Append("INVALID_COUNT="+model.INVALID_COUNT+",");
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
			strSql.Append("delete from his_bil_counter ");
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
			strSql.Append("delete from his_bil_counter ");
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
		public HIS.Model.his_bil_counter GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,CASHIER,START_IVNNO,END_IVNNO,RECP_TYPE,USE_TYPE,RECP_COUNT,PRE_CODE,REFOUNDED_COUNT,INVALID_COUNT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" from his_bil_counter ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_bil_counter model=new HIS.Model.his_bil_counter();
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
		public HIS.Model.his_bil_counter DataRowToModel(DataRow row)
		{
			HIS.Model.his_bil_counter model=new HIS.Model.his_bil_counter();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CASHIER"]!=null)
				{
					model.CASHIER=row["CASHIER"].ToString();
				}
				if(row["START_IVNNO"]!=null)
				{
					model.START_IVNNO=row["START_IVNNO"].ToString();
				}
				if(row["END_IVNNO"]!=null)
				{
					model.END_IVNNO=row["END_IVNNO"].ToString();
				}
				if(row["RECP_TYPE"]!=null)
				{
					model.RECP_TYPE=row["RECP_TYPE"].ToString();
				}
				if(row["USE_TYPE"]!=null)
				{
					model.USE_TYPE=row["USE_TYPE"].ToString();
				}
				if(row["RECP_COUNT"]!=null && row["RECP_COUNT"].ToString()!="")
				{
					model.RECP_COUNT=decimal.Parse(row["RECP_COUNT"].ToString());
				}
				if(row["PRE_CODE"]!=null)
				{
					model.PRE_CODE=row["PRE_CODE"].ToString();
				}
				if(row["REFOUNDED_COUNT"]!=null && row["REFOUNDED_COUNT"].ToString()!="")
				{
					model.REFOUNDED_COUNT=decimal.Parse(row["REFOUNDED_COUNT"].ToString());
				}
				if(row["INVALID_COUNT"]!=null && row["INVALID_COUNT"].ToString()!="")
				{
					model.INVALID_COUNT=decimal.Parse(row["INVALID_COUNT"].ToString());
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
			strSql.Append("select ID,CASHIER,START_IVNNO,END_IVNNO,RECP_TYPE,USE_TYPE,RECP_COUNT,PRE_CODE,REFOUNDED_COUNT,INVALID_COUNT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_bil_counter ");
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
			strSql.Append("select count(1) FROM his_bil_counter ");
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
			strSql.Append(")AS Row, T.*  from his_bil_counter T ");
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

