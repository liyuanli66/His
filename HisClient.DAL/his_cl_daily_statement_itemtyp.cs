using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_cl_daily_statement_itemtyp
	/// </summary>
	public partial class his_cl_daily_statement_itemtyp
	{
		public his_cl_daily_statement_itemtyp()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string DAILY_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_cl_daily_statement_itemtyp");
			strSql.Append(" where ID=@ID and DAILY_CODE=@DAILY_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DAILY_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = DAILY_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_cl_daily_statement_itemtyp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_cl_daily_statement_itemtyp(");
			strSql.Append("ID,DAILY_CODE,ITEM_TYPE,ITEM_SUM_PAY,ITEM_CASH_PAY,ITEM_CARD_PAY,ITEM_INSURANCE_PAY,STATUS)");
			strSql.Append(" values (");
			strSql.Append("@ID,@DAILY_CODE,@ITEM_TYPE,@ITEM_SUM_PAY,@ITEM_CASH_PAY,@ITEM_CARD_PAY,@ITEM_INSURANCE_PAY,@STATUS)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DAILY_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ITEM_TYPE", MySqlDbType.VarChar,20),
					new MySqlParameter("@ITEM_SUM_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_CASH_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_CARD_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_INSURANCE_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DAILY_CODE;
			parameters[2].Value = model.ITEM_TYPE;
			parameters[3].Value = model.ITEM_SUM_PAY;
			parameters[4].Value = model.ITEM_CASH_PAY;
			parameters[5].Value = model.ITEM_CARD_PAY;
			parameters[6].Value = model.ITEM_INSURANCE_PAY;
			parameters[7].Value = model.STATUS;

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
		public bool Update(HisClient.Model.his_cl_daily_statement_itemtyp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_cl_daily_statement_itemtyp set ");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("ITEM_SUM_PAY=@ITEM_SUM_PAY,");
			strSql.Append("ITEM_CASH_PAY=@ITEM_CASH_PAY,");
			strSql.Append("ITEM_CARD_PAY=@ITEM_CARD_PAY,");
			strSql.Append("ITEM_INSURANCE_PAY=@ITEM_INSURANCE_PAY,");
			strSql.Append("STATUS=@STATUS");
			strSql.Append(" where ID=@ID and DAILY_CODE=@DAILY_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ITEM_TYPE", MySqlDbType.VarChar,20),
					new MySqlParameter("@ITEM_SUM_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_CASH_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_CARD_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@ITEM_INSURANCE_PAY", MySqlDbType.Int32,11),
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,20),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DAILY_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ITEM_TYPE;
			parameters[1].Value = model.ITEM_SUM_PAY;
			parameters[2].Value = model.ITEM_CASH_PAY;
			parameters[3].Value = model.ITEM_CARD_PAY;
			parameters[4].Value = model.ITEM_INSURANCE_PAY;
			parameters[5].Value = model.STATUS;
			parameters[6].Value = model.ID;
			parameters[7].Value = model.DAILY_CODE;

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
		public bool Delete(string ID,string DAILY_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_cl_daily_statement_itemtyp ");
			strSql.Append(" where ID=@ID and DAILY_CODE=@DAILY_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DAILY_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = DAILY_CODE;

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
		public HisClient.Model.his_cl_daily_statement_itemtyp GetModel(string ID,string DAILY_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,DAILY_CODE,ITEM_TYPE,ITEM_SUM_PAY,ITEM_CASH_PAY,ITEM_CARD_PAY,ITEM_INSURANCE_PAY,STATUS from his_cl_daily_statement_itemtyp ");
			strSql.Append(" where ID=@ID and DAILY_CODE=@DAILY_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DAILY_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = DAILY_CODE;

			HisClient.Model.his_cl_daily_statement_itemtyp model=new HisClient.Model.his_cl_daily_statement_itemtyp();
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
		public HisClient.Model.his_cl_daily_statement_itemtyp DataRowToModel(DataRow row)
		{
			HisClient.Model.his_cl_daily_statement_itemtyp model=new HisClient.Model.his_cl_daily_statement_itemtyp();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DAILY_CODE"]!=null)
				{
					model.DAILY_CODE=row["DAILY_CODE"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,DAILY_CODE,ITEM_TYPE,ITEM_SUM_PAY,ITEM_CASH_PAY,ITEM_CARD_PAY,ITEM_INSURANCE_PAY,STATUS ");
			strSql.Append(" FROM his_cl_daily_statement_itemtyp ");
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
			strSql.Append("select count(1) FROM his_cl_daily_statement_itemtyp ");
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
				strSql.Append("order by T.DAILY_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_cl_daily_statement_itemtyp T ");
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
			parameters[0].Value = "his_cl_daily_statement_itemtyp";
			parameters[1].Value = "DAILY_CODE";
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

