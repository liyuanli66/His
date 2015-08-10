using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_account
	/// </summary>
	public partial class his_comm_account
	{
		public his_comm_account()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_account");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_account(");
			strSql.Append("ID,ACCOUNT,PASSWORD,ROLE_CODE,USER_CODE,ADMIN_TYPE,IS_USE,AUTHORITY_XML,CREATE_DATE,CREATE_BY,LAST_LOGINTIME,HOSPITAL_CODE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ACCOUNT,@PASSWORD,@ROLE_CODE,@USER_CODE,@ADMIN_TYPE,@IS_USE,@AUTHORITY_XML,@CREATE_DATE,@CREATE_BY,@LAST_LOGINTIME,@HOSPITAL_CODE)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@ACCOUNT", MySqlDbType.VarChar,128),
					new MySqlParameter("@PASSWORD", MySqlDbType.VarChar,128),
					new MySqlParameter("@ROLE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@USER_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ADMIN_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@AUTHORITY_XML", MySqlDbType.VarChar,4000),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@LAST_LOGINTIME", MySqlDbType.Date),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ACCOUNT;
			parameters[2].Value = model.PASSWORD;
			parameters[3].Value = model.ROLE_CODE;
			parameters[4].Value = model.USER_CODE;
			parameters[5].Value = model.ADMIN_TYPE;
			parameters[6].Value = model.IS_USE;
			parameters[7].Value = model.AUTHORITY_XML;
			parameters[8].Value = model.CREATE_DATE;
			parameters[9].Value = model.CREATE_BY;
			parameters[10].Value = model.LAST_LOGINTIME;
			parameters[11].Value = model.HOSPITAL_CODE;

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
		public bool Update(HisClient.Model.his_comm_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_account set ");
			strSql.Append("ACCOUNT=@ACCOUNT,");
			strSql.Append("PASSWORD=@PASSWORD,");
			strSql.Append("ROLE_CODE=@ROLE_CODE,");
			strSql.Append("USER_CODE=@USER_CODE,");
			strSql.Append("ADMIN_TYPE=@ADMIN_TYPE,");
			strSql.Append("IS_USE=@IS_USE,");
			strSql.Append("AUTHORITY_XML=@AUTHORITY_XML,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("LAST_LOGINTIME=@LAST_LOGINTIME,");
			strSql.Append("HOSPITAL_CODE=@HOSPITAL_CODE");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ACCOUNT", MySqlDbType.VarChar,128),
					new MySqlParameter("@PASSWORD", MySqlDbType.VarChar,128),
					new MySqlParameter("@ROLE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@USER_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ADMIN_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@AUTHORITY_XML", MySqlDbType.VarChar,4000),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@LAST_LOGINTIME", MySqlDbType.Date),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ACCOUNT;
			parameters[1].Value = model.PASSWORD;
			parameters[2].Value = model.ROLE_CODE;
			parameters[3].Value = model.USER_CODE;
			parameters[4].Value = model.ADMIN_TYPE;
			parameters[5].Value = model.IS_USE;
			parameters[6].Value = model.AUTHORITY_XML;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.CREATE_BY;
			parameters[9].Value = model.LAST_LOGINTIME;
			parameters[10].Value = model.HOSPITAL_CODE;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from his_comm_account ");
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
		public HisClient.Model.his_comm_account GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ACCOUNT,PASSWORD,ROLE_CODE,USER_CODE,ADMIN_TYPE,IS_USE,AUTHORITY_XML,CREATE_DATE,CREATE_BY,LAST_LOGINTIME,HOSPITAL_CODE from his_comm_account ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_comm_account model=new HisClient.Model.his_comm_account();
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
		public HisClient.Model.his_comm_account DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_account model=new HisClient.Model.his_comm_account();
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
			parameters[0].Value = "his_comm_account";
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

