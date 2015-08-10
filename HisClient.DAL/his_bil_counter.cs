using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_bil_counter
	/// </summary>
	public partial class his_bil_counter
	{
		public his_bil_counter()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_bil_counter");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_bil_counter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_bil_counter(");
			strSql.Append("ID,CASHIER,START_IVNNO,END_IVNNO,RECP_TYPE,USE_TYPE,RECP_COUNT,PRE_CODE,REFOUNDED_COUNT,INVALID_COUNT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@ID,@CASHIER,@START_IVNNO,@END_IVNNO,@RECP_TYPE,@USE_TYPE,@RECP_COUNT,@PRE_CODE,@REFOUNDED_COUNT,@INVALID_COUNT,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CASHIER", MySqlDbType.VarChar,128),
					new MySqlParameter("@START_IVNNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@END_IVNNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@RECP_TYPE", MySqlDbType.VarChar,20),
					new MySqlParameter("@USE_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@RECP_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@PRE_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@REFOUNDED_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@INVALID_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CASHIER;
			parameters[2].Value = model.START_IVNNO;
			parameters[3].Value = model.END_IVNNO;
			parameters[4].Value = model.RECP_TYPE;
			parameters[5].Value = model.USE_TYPE;
			parameters[6].Value = model.RECP_COUNT;
			parameters[7].Value = model.PRE_CODE;
			parameters[8].Value = model.REFOUNDED_COUNT;
			parameters[9].Value = model.INVALID_COUNT;
			parameters[10].Value = model.OPT_USER;
			parameters[11].Value = model.OPT_DATE;
			parameters[12].Value = model.OPT_TERM;
			parameters[13].Value = model.OPT_ORGA;

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
		public bool Update(HisClient.Model.his_bil_counter model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_bil_counter set ");
			strSql.Append("CASHIER=@CASHIER,");
			strSql.Append("START_IVNNO=@START_IVNNO,");
			strSql.Append("END_IVNNO=@END_IVNNO,");
			strSql.Append("RECP_TYPE=@RECP_TYPE,");
			strSql.Append("USE_TYPE=@USE_TYPE,");
			strSql.Append("RECP_COUNT=@RECP_COUNT,");
			strSql.Append("PRE_CODE=@PRE_CODE,");
			strSql.Append("REFOUNDED_COUNT=@REFOUNDED_COUNT,");
			strSql.Append("INVALID_COUNT=@INVALID_COUNT,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CASHIER", MySqlDbType.VarChar,128),
					new MySqlParameter("@START_IVNNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@END_IVNNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@RECP_TYPE", MySqlDbType.VarChar,20),
					new MySqlParameter("@USE_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@RECP_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@PRE_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@REFOUNDED_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@INVALID_COUNT", MySqlDbType.Float,5),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.CASHIER;
			parameters[1].Value = model.START_IVNNO;
			parameters[2].Value = model.END_IVNNO;
			parameters[3].Value = model.RECP_TYPE;
			parameters[4].Value = model.USE_TYPE;
			parameters[5].Value = model.RECP_COUNT;
			parameters[6].Value = model.PRE_CODE;
			parameters[7].Value = model.REFOUNDED_COUNT;
			parameters[8].Value = model.INVALID_COUNT;
			parameters[9].Value = model.OPT_USER;
			parameters[10].Value = model.OPT_DATE;
			parameters[11].Value = model.OPT_TERM;
			parameters[12].Value = model.OPT_ORGA;
			parameters[13].Value = model.ID;

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
			strSql.Append("delete from his_bil_counter ");
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
		public HisClient.Model.his_bil_counter GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CASHIER,START_IVNNO,END_IVNNO,RECP_TYPE,USE_TYPE,RECP_COUNT,PRE_CODE,REFOUNDED_COUNT,INVALID_COUNT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_bil_counter ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_bil_counter model=new HisClient.Model.his_bil_counter();
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
		public HisClient.Model.his_bil_counter DataRowToModel(DataRow row)
		{
			HisClient.Model.his_bil_counter model=new HisClient.Model.his_bil_counter();
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
			parameters[0].Value = "his_bil_counter";
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

