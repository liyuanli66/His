using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_bil_cl_receipt
	/// </summary>
	public partial class his_bil_cl_receipt
	{
		public his_bil_cl_receipt()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_RECEIPT_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_bil_cl_receipt");
			strSql.Append(" where CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_RECEIPT_CODE;
			parameters[1].Value = CL_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_bil_cl_receipt model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_bil_cl_receipt(");
			strSql.Append("CL_RECEIPT_CODE,CL_CODE,CASHIER,RECEICPT_CODE,RECIVER_TIME,CASH_AMT,CARD_AMT,INSURANCE_AMT,SUM_AMT,REFUND_RECP_CODE,REFUND_DATE,REFUND_OPT,REDUCE_AMT,REDUCE_DATE,REDUCE_OPT,REDUCE_REASON,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@CL_RECEIPT_CODE,@CL_CODE,@CASHIER,@RECEICPT_CODE,@RECIVER_TIME,@CASH_AMT,@CARD_AMT,@INSURANCE_AMT,@SUM_AMT,@REFUND_RECP_CODE,@REFUND_DATE,@REFUND_OPT,@REDUCE_AMT,@REDUCE_DATE,@REDUCE_OPT,@REDUCE_REASON,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CASHIER", MySqlDbType.VarChar,18),
					new MySqlParameter("@RECEICPT_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@RECIVER_TIME", MySqlDbType.Date),
					new MySqlParameter("@CASH_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@CARD_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@INSURANCE_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@REFUND_RECP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@REFUND_DATE", MySqlDbType.Date),
					new MySqlParameter("@REFUND_OPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@REDUCE_AMT", MySqlDbType.Int32,11),
					new MySqlParameter("@REDUCE_DATE", MySqlDbType.Date),
					new MySqlParameter("@REDUCE_OPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@REDUCE_REASON", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.CL_RECEIPT_CODE;
			parameters[1].Value = model.CL_CODE;
			parameters[2].Value = model.CASHIER;
			parameters[3].Value = model.RECEICPT_CODE;
			parameters[4].Value = model.RECIVER_TIME;
			parameters[5].Value = model.CASH_AMT;
			parameters[6].Value = model.CARD_AMT;
			parameters[7].Value = model.INSURANCE_AMT;
			parameters[8].Value = model.SUM_AMT;
			parameters[9].Value = model.REFUND_RECP_CODE;
			parameters[10].Value = model.REFUND_DATE;
			parameters[11].Value = model.REFUND_OPT;
			parameters[12].Value = model.REDUCE_AMT;
			parameters[13].Value = model.REDUCE_DATE;
			parameters[14].Value = model.REDUCE_OPT;
			parameters[15].Value = model.REDUCE_REASON;
			parameters[16].Value = model.OPT_USER;
			parameters[17].Value = model.OPT_DATE;
			parameters[18].Value = model.OPT_TERM;
			parameters[19].Value = model.OPT_ORGA;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(HisClient.Model.his_bil_cl_receipt model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_bil_cl_receipt set ");
			strSql.Append("CASHIER=@CASHIER,");
			strSql.Append("RECEICPT_CODE=@RECEICPT_CODE,");
			strSql.Append("RECIVER_TIME=@RECIVER_TIME,");
			strSql.Append("CASH_AMT=@CASH_AMT,");
			strSql.Append("CARD_AMT=@CARD_AMT,");
			strSql.Append("INSURANCE_AMT=@INSURANCE_AMT,");
			strSql.Append("SUM_AMT=@SUM_AMT,");
			strSql.Append("REFUND_RECP_CODE=@REFUND_RECP_CODE,");
			strSql.Append("REFUND_DATE=@REFUND_DATE,");
			strSql.Append("REFUND_OPT=@REFUND_OPT,");
			strSql.Append("REDUCE_AMT=@REDUCE_AMT,");
			strSql.Append("REDUCE_DATE=@REDUCE_DATE,");
			strSql.Append("REDUCE_OPT=@REDUCE_OPT,");
			strSql.Append("REDUCE_REASON=@REDUCE_REASON,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CASHIER", MySqlDbType.VarChar,18),
					new MySqlParameter("@RECEICPT_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@RECIVER_TIME", MySqlDbType.Date),
					new MySqlParameter("@CASH_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@CARD_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@INSURANCE_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@REFUND_RECP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@REFUND_DATE", MySqlDbType.Date),
					new MySqlParameter("@REFUND_OPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@REDUCE_AMT", MySqlDbType.Int32,11),
					new MySqlParameter("@REDUCE_DATE", MySqlDbType.Date),
					new MySqlParameter("@REDUCE_OPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@REDUCE_REASON", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.CASHIER;
			parameters[1].Value = model.RECEICPT_CODE;
			parameters[2].Value = model.RECIVER_TIME;
			parameters[3].Value = model.CASH_AMT;
			parameters[4].Value = model.CARD_AMT;
			parameters[5].Value = model.INSURANCE_AMT;
			parameters[6].Value = model.SUM_AMT;
			parameters[7].Value = model.REFUND_RECP_CODE;
			parameters[8].Value = model.REFUND_DATE;
			parameters[9].Value = model.REFUND_OPT;
			parameters[10].Value = model.REDUCE_AMT;
			parameters[11].Value = model.REDUCE_DATE;
			parameters[12].Value = model.REDUCE_OPT;
			parameters[13].Value = model.REDUCE_REASON;
			parameters[14].Value = model.OPT_USER;
			parameters[15].Value = model.OPT_DATE;
			parameters[16].Value = model.OPT_TERM;
			parameters[17].Value = model.OPT_ORGA;
			parameters[18].Value = model.CL_RECEIPT_CODE;
			parameters[19].Value = model.CL_CODE;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_bil_cl_receipt ");
			strSql.Append(" where CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_RECEIPT_CODE;
			parameters[1].Value = CL_CODE;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public HisClient.Model.his_bil_cl_receipt GetModel(string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CL_RECEIPT_CODE,CL_CODE,CASHIER,RECEICPT_CODE,RECIVER_TIME,CASH_AMT,CARD_AMT,INSURANCE_AMT,SUM_AMT,REFUND_RECP_CODE,REFUND_DATE,REFUND_OPT,REDUCE_AMT,REDUCE_DATE,REDUCE_OPT,REDUCE_REASON,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_bil_cl_receipt ");
			strSql.Append(" where CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_RECEIPT_CODE;
			parameters[1].Value = CL_CODE;

			HisClient.Model.his_bil_cl_receipt model=new HisClient.Model.his_bil_cl_receipt();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public HisClient.Model.his_bil_cl_receipt DataRowToModel(DataRow row)
		{
			HisClient.Model.his_bil_cl_receipt model=new HisClient.Model.his_bil_cl_receipt();
			if (row != null)
			{
				if(row["CL_RECEIPT_CODE"]!=null)
				{
					model.CL_RECEIPT_CODE=row["CL_RECEIPT_CODE"].ToString();
				}
				if(row["CL_CODE"]!=null)
				{
					model.CL_CODE=row["CL_CODE"].ToString();
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
				if(row["REFUND_RECP_CODE"]!=null)
				{
					model.REFUND_RECP_CODE=row["REFUND_RECP_CODE"].ToString();
				}
				if(row["REFUND_DATE"]!=null && row["REFUND_DATE"].ToString()!="")
				{
					model.REFUND_DATE=DateTime.Parse(row["REFUND_DATE"].ToString());
				}
				if(row["REFUND_OPT"]!=null)
				{
					model.REFUND_OPT=row["REFUND_OPT"].ToString();
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
			strSql.Append("select CL_RECEIPT_CODE,CL_CODE,CASHIER,RECEICPT_CODE,RECIVER_TIME,CASH_AMT,CARD_AMT,INSURANCE_AMT,SUM_AMT,REFUND_RECP_CODE,REFUND_DATE,REFUND_OPT,REDUCE_AMT,REDUCE_DATE,REDUCE_OPT,REDUCE_REASON,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_bil_cl_receipt ");
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
			strSql.Append("select count(1) FROM his_bil_cl_receipt ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.CL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_bil_cl_receipt T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "his_bil_cl_receipt";
			parameters[1].Value = "CL_CODE";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

