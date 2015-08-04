using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_receipt
	/// </summary>
	public partial class his_hos_receipt
	{
		public his_hos_receipt()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_receipt");
			strSql.Append(" where HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_hos_receipt model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.HOS_RECEIPT_CODE != null)
			{
				strSql1.Append("HOS_RECEIPT_CODE,");
				strSql2.Append("'"+model.HOS_RECEIPT_CODE+"',");
			}
			if (model.HIS_HOS_CODE != null)
			{
				strSql1.Append("HIS_HOS_CODE,");
				strSql2.Append("'"+model.HIS_HOS_CODE+"',");
			}
			if (model.CASHIER != null)
			{
				strSql1.Append("CASHIER,");
				strSql2.Append("'"+model.CASHIER+"',");
			}
			if (model.RECEICPT_CODE != null)
			{
				strSql1.Append("RECEICPT_CODE,");
				strSql2.Append("'"+model.RECEICPT_CODE+"',");
			}
			if (model.RECIVER_TIME != null)
			{
				strSql1.Append("RECIVER_TIME,");
				strSql2.Append("'"+model.RECIVER_TIME+"',");
			}
			if (model.CASH_AMT != null)
			{
				strSql1.Append("CASH_AMT,");
				strSql2.Append(""+model.CASH_AMT+",");
			}
			if (model.CARD_AMT != null)
			{
				strSql1.Append("CARD_AMT,");
				strSql2.Append(""+model.CARD_AMT+",");
			}
			if (model.INSURANCE_AMT != null)
			{
				strSql1.Append("INSURANCE_AMT,");
				strSql2.Append(""+model.INSURANCE_AMT+",");
			}
			if (model.SUM_AMT != null)
			{
				strSql1.Append("SUM_AMT,");
				strSql2.Append(""+model.SUM_AMT+",");
			}
			if (model.REDUCE_AMT != null)
			{
				strSql1.Append("REDUCE_AMT,");
				strSql2.Append(""+model.REDUCE_AMT+",");
			}
			if (model.REDUCE_DATE != null)
			{
				strSql1.Append("REDUCE_DATE,");
				strSql2.Append("'"+model.REDUCE_DATE+"',");
			}
			if (model.REDUCE_OPT != null)
			{
				strSql1.Append("REDUCE_OPT,");
				strSql2.Append("'"+model.REDUCE_OPT+"',");
			}
			if (model.REDUCE_REASON != null)
			{
				strSql1.Append("REDUCE_REASON,");
				strSql2.Append("'"+model.REDUCE_REASON+"',");
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
			strSql.Append("insert into his_hos_receipt(");
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
		public bool Update(HIS.Model.his_hos_receipt model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_receipt set ");
			if (model.CASHIER != null)
			{
				strSql.Append("CASHIER='"+model.CASHIER+"',");
			}
			if (model.RECEICPT_CODE != null)
			{
				strSql.Append("RECEICPT_CODE='"+model.RECEICPT_CODE+"',");
			}
			if (model.RECIVER_TIME != null)
			{
				strSql.Append("RECIVER_TIME='"+model.RECIVER_TIME+"',");
			}
			if (model.CASH_AMT != null)
			{
				strSql.Append("CASH_AMT="+model.CASH_AMT+",");
			}
			if (model.CARD_AMT != null)
			{
				strSql.Append("CARD_AMT="+model.CARD_AMT+",");
			}
			if (model.INSURANCE_AMT != null)
			{
				strSql.Append("INSURANCE_AMT="+model.INSURANCE_AMT+",");
			}
			else
			{
				strSql.Append("INSURANCE_AMT= null ,");
			}
			if (model.SUM_AMT != null)
			{
				strSql.Append("SUM_AMT="+model.SUM_AMT+",");
			}
			else
			{
				strSql.Append("SUM_AMT= null ,");
			}
			if (model.REDUCE_AMT != null)
			{
				strSql.Append("REDUCE_AMT="+model.REDUCE_AMT+",");
			}
			else
			{
				strSql.Append("REDUCE_AMT= null ,");
			}
			if (model.REDUCE_DATE != null)
			{
				strSql.Append("REDUCE_DATE='"+model.REDUCE_DATE+"',");
			}
			else
			{
				strSql.Append("REDUCE_DATE= null ,");
			}
			if (model.REDUCE_OPT != null)
			{
				strSql.Append("REDUCE_OPT='"+model.REDUCE_OPT+"',");
			}
			else
			{
				strSql.Append("REDUCE_OPT= null ,");
			}
			if (model.REDUCE_REASON != null)
			{
				strSql.Append("REDUCE_REASON='"+model.REDUCE_REASON+"',");
			}
			else
			{
				strSql.Append("REDUCE_REASON= null ,");
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
			strSql.Append(" where HOS_RECEIPT_CODE='"+ model.HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+ model.HIS_HOS_CODE+"' ");
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
		public bool Delete(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_receipt ");
			strSql.Append(" where HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
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
		public HIS.Model.his_hos_receipt GetModel(string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" HOS_RECEIPT_CODE,HIS_HOS_CODE,CASHIER,RECEICPT_CODE,RECIVER_TIME,CASH_AMT,CARD_AMT,INSURANCE_AMT,SUM_AMT,REDUCE_AMT,REDUCE_DATE,REDUCE_OPT,REDUCE_REASON,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" from his_hos_receipt ");
			strSql.Append(" where HOS_RECEIPT_CODE='"+HOS_RECEIPT_CODE+"' and HIS_HOS_CODE='"+HIS_HOS_CODE+"' " );
			HIS.Model.his_hos_receipt model=new HIS.Model.his_hos_receipt();
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
		public HIS.Model.his_hos_receipt DataRowToModel(DataRow row)
		{
			HIS.Model.his_hos_receipt model=new HIS.Model.his_hos_receipt();
			if (row != null)
			{
				if(row["HOS_RECEIPT_CODE"]!=null)
				{
					model.HOS_RECEIPT_CODE=row["HOS_RECEIPT_CODE"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["CASHIER"]!=null)
				{
					model.CASHIER=row["CASHIER"].ToString();
				}
				if(row["RECEICPT_CODE"]!=null)
				{
					model.RECEICPT_CODE=row["RECEICPT_CODE"].ToString();
				}
				if(row["RECIVER_TIME"]!=null && row["RECIVER_TIME"].ToString()!="")
				{
					model.RECIVER_TIME=DateTime.Parse(row["RECIVER_TIME"].ToString());
				}
				if(row["CASH_AMT"]!=null && row["CASH_AMT"].ToString()!="")
				{
					model.CASH_AMT=decimal.Parse(row["CASH_AMT"].ToString());
				}
				if(row["CARD_AMT"]!=null && row["CARD_AMT"].ToString()!="")
				{
					model.CARD_AMT=decimal.Parse(row["CARD_AMT"].ToString());
				}
				if(row["INSURANCE_AMT"]!=null && row["INSURANCE_AMT"].ToString()!="")
				{
					model.INSURANCE_AMT=decimal.Parse(row["INSURANCE_AMT"].ToString());
				}
				if(row["SUM_AMT"]!=null && row["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(row["SUM_AMT"].ToString());
				}
				if(row["REDUCE_AMT"]!=null && row["REDUCE_AMT"].ToString()!="")
				{
					model.REDUCE_AMT=int.Parse(row["REDUCE_AMT"].ToString());
				}
				if(row["REDUCE_DATE"]!=null && row["REDUCE_DATE"].ToString()!="")
				{
					model.REDUCE_DATE=DateTime.Parse(row["REDUCE_DATE"].ToString());
				}
				if(row["REDUCE_OPT"]!=null)
				{
					model.REDUCE_OPT=row["REDUCE_OPT"].ToString();
				}
				if(row["REDUCE_REASON"]!=null)
				{
					model.REDUCE_REASON=row["REDUCE_REASON"].ToString();
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
			strSql.Append("select HOS_RECEIPT_CODE,HIS_HOS_CODE,CASHIER,RECEICPT_CODE,RECIVER_TIME,CASH_AMT,CARD_AMT,INSURANCE_AMT,SUM_AMT,REDUCE_AMT,REDUCE_DATE,REDUCE_OPT,REDUCE_REASON,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_hos_receipt ");
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
			strSql.Append("select count(1) FROM his_hos_receipt ");
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
				strSql.Append("order by T.HIS_HOS_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_hos_receipt T ");
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

