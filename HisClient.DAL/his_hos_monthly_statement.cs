using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_monthly_statement
	/// </summary>
	public partial class his_hos_monthly_statement
	{
		public his_hos_monthly_statement()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_monthly_statement");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_hos_monthly_statement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_hos_monthly_statement(");
			strSql.Append("OPERATOR,OPERATE_TIME,RECIVER,START_TIME,END_TIME,START_RECEIPT_CODE,END_RECEIPT_CODE,RECEIPT__NUM,RETUEN_RECEIPT_NUM,ID)");
			strSql.Append(" values (");
			strSql.Append("@OPERATOR,@OPERATE_TIME,@RECIVER,@START_TIME,@END_TIME,@START_RECEIPT_CODE,@END_RECEIPT_CODE,@RECEIPT__NUM,@RETUEN_RECEIPT_NUM,@ID)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OPERATOR", MySqlDbType.VarChar,18),
					new MySqlParameter("@OPERATE_TIME", MySqlDbType.Date),
					new MySqlParameter("@RECIVER", MySqlDbType.VarChar,18),
					new MySqlParameter("@START_TIME", MySqlDbType.Date),
					new MySqlParameter("@END_TIME", MySqlDbType.Date),
					new MySqlParameter("@START_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@END_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@RECEIPT__NUM", MySqlDbType.VarChar,18),
					new MySqlParameter("@RETUEN_RECEIPT_NUM", MySqlDbType.VarChar,18),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.OPERATOR;
			parameters[1].Value = model.OPERATE_TIME;
			parameters[2].Value = model.RECIVER;
			parameters[3].Value = model.START_TIME;
			parameters[4].Value = model.END_TIME;
			parameters[5].Value = model.START_RECEIPT_CODE;
			parameters[6].Value = model.END_RECEIPT_CODE;
			parameters[7].Value = model.RECEIPT__NUM;
			parameters[8].Value = model.RETUEN_RECEIPT_NUM;
			parameters[9].Value = model.ID;

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
		public bool Update(HisClient.Model.his_hos_monthly_statement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_monthly_statement set ");
			strSql.Append("OPERATOR=@OPERATOR,");
			strSql.Append("OPERATE_TIME=@OPERATE_TIME,");
			strSql.Append("RECIVER=@RECIVER,");
			strSql.Append("START_TIME=@START_TIME,");
			strSql.Append("END_TIME=@END_TIME,");
			strSql.Append("START_RECEIPT_CODE=@START_RECEIPT_CODE,");
			strSql.Append("END_RECEIPT_CODE=@END_RECEIPT_CODE,");
			strSql.Append("RECEIPT__NUM=@RECEIPT__NUM,");
			strSql.Append("RETUEN_RECEIPT_NUM=@RETUEN_RECEIPT_NUM");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OPERATOR", MySqlDbType.VarChar,18),
					new MySqlParameter("@OPERATE_TIME", MySqlDbType.Date),
					new MySqlParameter("@RECIVER", MySqlDbType.VarChar,18),
					new MySqlParameter("@START_TIME", MySqlDbType.Date),
					new MySqlParameter("@END_TIME", MySqlDbType.Date),
					new MySqlParameter("@START_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@END_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@RECEIPT__NUM", MySqlDbType.VarChar,18),
					new MySqlParameter("@RETUEN_RECEIPT_NUM", MySqlDbType.VarChar,18),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.OPERATOR;
			parameters[1].Value = model.OPERATE_TIME;
			parameters[2].Value = model.RECIVER;
			parameters[3].Value = model.START_TIME;
			parameters[4].Value = model.END_TIME;
			parameters[5].Value = model.START_RECEIPT_CODE;
			parameters[6].Value = model.END_RECEIPT_CODE;
			parameters[7].Value = model.RECEIPT__NUM;
			parameters[8].Value = model.RETUEN_RECEIPT_NUM;
			parameters[9].Value = model.ID;

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
		public bool Delete(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_monthly_statement ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

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
		public HisClient.Model.his_hos_monthly_statement GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OPERATOR,OPERATE_TIME,RECIVER,START_TIME,END_TIME,START_RECEIPT_CODE,END_RECEIPT_CODE,RECEIPT__NUM,RETUEN_RECEIPT_NUM,ID from his_hos_monthly_statement ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_hos_monthly_statement model=new HisClient.Model.his_hos_monthly_statement();
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
		public HisClient.Model.his_hos_monthly_statement DataRowToModel(DataRow row)
		{
			HisClient.Model.his_hos_monthly_statement model=new HisClient.Model.his_hos_monthly_statement();
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
			parameters[0].Value = "his_hos_monthly_statement";
			parameters[1].Value = "ID";
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

