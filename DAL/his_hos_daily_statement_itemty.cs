using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_daily_statement_itemty
	/// </summary>
	public partial class his_hos_daily_statement_itemty
	{
		public his_hos_daily_statement_itemty()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string DAILY_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_daily_statement_itemty");
			strSql.Append(" where ID='"+ID+"' and DAILY_CODE='"+DAILY_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_daily_statement_itemty model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.ITEM_TYPE != null)
			{
				strSql1.Append("ITEM_TYPE,");
				strSql2.Append("'"+model.ITEM_TYPE+"',");
			}
			if (model.ITEM_SUM_PAY != null)
			{
				strSql1.Append("ITEM_SUM_PAY,");
				strSql2.Append(""+model.ITEM_SUM_PAY+",");
			}
			if (model.ITEM_CASH_PAY != null)
			{
				strSql1.Append("ITEM_CASH_PAY,");
				strSql2.Append(""+model.ITEM_CASH_PAY+",");
			}
			if (model.ITEM_CARD_PAY != null)
			{
				strSql1.Append("ITEM_CARD_PAY,");
				strSql2.Append(""+model.ITEM_CARD_PAY+",");
			}
			if (model.ITEM_INSURANCE_PAY != null)
			{
				strSql1.Append("ITEM_INSURANCE_PAY,");
				strSql2.Append(""+model.ITEM_INSURANCE_PAY+",");
			}
			if (model.STATUS != null)
			{
				strSql1.Append("STATUS,");
				strSql2.Append("'"+model.STATUS+"',");
			}
			if (model.DAILY_CODE != null)
			{
				strSql1.Append("DAILY_CODE,");
				strSql2.Append("'"+model.DAILY_CODE+"',");
			}
			strSql.Append("insert into his_hos_daily_statement_itemty(");
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
		public bool Update(HIS.Model.his_hos_daily_statement_itemty model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_daily_statement_itemty set ");
			if (model.ITEM_TYPE != null)
			{
				strSql.Append("ITEM_TYPE='"+model.ITEM_TYPE+"',");
			}
			else
			{
				strSql.Append("ITEM_TYPE= null ,");
			}
			if (model.ITEM_SUM_PAY != null)
			{
				strSql.Append("ITEM_SUM_PAY="+model.ITEM_SUM_PAY+",");
			}
			else
			{
				strSql.Append("ITEM_SUM_PAY= null ,");
			}
			if (model.ITEM_CASH_PAY != null)
			{
				strSql.Append("ITEM_CASH_PAY="+model.ITEM_CASH_PAY+",");
			}
			else
			{
				strSql.Append("ITEM_CASH_PAY= null ,");
			}
			if (model.ITEM_CARD_PAY != null)
			{
				strSql.Append("ITEM_CARD_PAY="+model.ITEM_CARD_PAY+",");
			}
			else
			{
				strSql.Append("ITEM_CARD_PAY= null ,");
			}
			if (model.ITEM_INSURANCE_PAY != null)
			{
				strSql.Append("ITEM_INSURANCE_PAY="+model.ITEM_INSURANCE_PAY+",");
			}
			else
			{
				strSql.Append("ITEM_INSURANCE_PAY= null ,");
			}
			if (model.STATUS != null)
			{
				strSql.Append("STATUS='"+model.STATUS+"',");
			}
			else
			{
				strSql.Append("STATUS= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' and DAILY_CODE='"+ model.DAILY_CODE+"' ");
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
		public bool Delete(string ID,string DAILY_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_daily_statement_itemty ");
			strSql.Append(" where ID='"+ID+"' and DAILY_CODE='"+DAILY_CODE+"' " );
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
		public HIS.Model.his_hos_daily_statement_itemty GetModel(string ID,string DAILY_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,ITEM_TYPE,ITEM_SUM_PAY,ITEM_CASH_PAY,ITEM_CARD_PAY,ITEM_INSURANCE_PAY,STATUS,DAILY_CODE ");
			strSql.Append(" from his_hos_daily_statement_itemty ");
			strSql.Append(" where ID='"+ID+"' and DAILY_CODE='"+DAILY_CODE+"' " );
			HIS.Model.his_hos_daily_statement_itemty model=new HIS.Model.his_hos_daily_statement_itemty();
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
		public HIS.Model.his_hos_daily_statement_itemty DataRowToModel(DataRow row)
		{
			HIS.Model.his_hos_daily_statement_itemty model=new HIS.Model.his_hos_daily_statement_itemty();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["ITEM_SUM_PAY"]!=null && row["ITEM_SUM_PAY"].ToString()!="")
				{
					model.ITEM_SUM_PAY=int.Parse(row["ITEM_SUM_PAY"].ToString());
				}
				if(row["ITEM_CASH_PAY"]!=null && row["ITEM_CASH_PAY"].ToString()!="")
				{
					model.ITEM_CASH_PAY=int.Parse(row["ITEM_CASH_PAY"].ToString());
				}
				if(row["ITEM_CARD_PAY"]!=null && row["ITEM_CARD_PAY"].ToString()!="")
				{
					model.ITEM_CARD_PAY=int.Parse(row["ITEM_CARD_PAY"].ToString());
				}
				if(row["ITEM_INSURANCE_PAY"]!=null && row["ITEM_INSURANCE_PAY"].ToString()!="")
				{
					model.ITEM_INSURANCE_PAY=int.Parse(row["ITEM_INSURANCE_PAY"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["DAILY_CODE"]!=null)
				{
					model.DAILY_CODE=row["DAILY_CODE"].ToString();
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
			strSql.Append("select ID,ITEM_TYPE,ITEM_SUM_PAY,ITEM_CASH_PAY,ITEM_CARD_PAY,ITEM_INSURANCE_PAY,STATUS,DAILY_CODE ");
			strSql.Append(" FROM his_hos_daily_statement_itemty ");
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
			strSql.Append("select count(1) FROM his_hos_daily_statement_itemty ");
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
				strSql.Append("order by T.DAILY_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_hos_daily_statement_itemty T ");
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

