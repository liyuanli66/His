using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:comm_icd10
	/// </summary>
	public partial class comm_icd10
	{
		public comm_icd10()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from comm_icd10");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.comm_icd10 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into comm_icd10(");
			strSql.Append("ID,ICD_CODE,ICD_NAME,HELP_CODE,TYPE_CODE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@ICD_CODE,@ICD_NAME,@HELP_CODE,@TYPE_CODE)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@ICD_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ICD_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@TYPE_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ICD_CODE;
			parameters[2].Value = model.ICD_NAME;
			parameters[3].Value = model.HELP_CODE;
			parameters[4].Value = model.TYPE_CODE;

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
		public bool Update(HisClient.Model.comm_icd10 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update comm_icd10 set ");
			strSql.Append("ICD_CODE=@ICD_CODE,");
			strSql.Append("ICD_NAME=@ICD_NAME,");
			strSql.Append("HELP_CODE=@HELP_CODE,");
			strSql.Append("TYPE_CODE=@TYPE_CODE");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ICD_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ICD_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@TYPE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ICD_CODE;
			parameters[1].Value = model.ICD_NAME;
			parameters[2].Value = model.HELP_CODE;
			parameters[3].Value = model.TYPE_CODE;
			parameters[4].Value = model.ID;

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
			strSql.Append("delete from comm_icd10 ");
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
		public HisClient.Model.comm_icd10 GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ICD_CODE,ICD_NAME,HELP_CODE,TYPE_CODE from comm_icd10 ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.comm_icd10 model=new HisClient.Model.comm_icd10();
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
		public HisClient.Model.comm_icd10 DataRowToModel(DataRow row)
		{
			HisClient.Model.comm_icd10 model=new HisClient.Model.comm_icd10();
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
			parameters[0].Value = "comm_icd10";
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

