using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using HisClient.DAL;//Please add references

namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_function
	/// </summary>
	public partial class his_comm_function
	{
		public his_comm_function()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_function");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_function(");
			strSql.Append("ID,MODULE_CODE,FUNCTION_CODE,FUNCTION_NAME,IS_USE,HOSPITAL_CODE,REMARKS,CREATE_DATE,CREATE_BY)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MODULE_CODE,@FUNCTION_CODE,@FUNCTION_NAME,@IS_USE,@HOSPITAL_CODE,@REMARKS,@CREATE_DATE,@CREATE_BY)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MODULE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FUNCTION_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FUNCTION_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@REMARKS", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MODULE_CODE;
			parameters[2].Value = model.FUNCTION_CODE;
			parameters[3].Value = model.FUNCTION_NAME;
			parameters[4].Value = model.IS_USE;
			parameters[5].Value = model.HOSPITAL_CODE;
			parameters[6].Value = model.REMARKS;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.CREATE_BY;

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
		public bool Update(HisClient.Model.his_comm_function model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_function set ");
			strSql.Append("MODULE_CODE=@MODULE_CODE,");
			strSql.Append("FUNCTION_CODE=@FUNCTION_CODE,");
			strSql.Append("FUNCTION_NAME=@FUNCTION_NAME,");
			strSql.Append("IS_USE=@IS_USE,");
			strSql.Append("HOSPITAL_CODE=@HOSPITAL_CODE,");
			strSql.Append("REMARKS=@REMARKS,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_BY=@CREATE_BY");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MODULE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FUNCTION_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FUNCTION_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@REMARKS", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.MODULE_CODE;
			parameters[1].Value = model.FUNCTION_CODE;
			parameters[2].Value = model.FUNCTION_NAME;
			parameters[3].Value = model.IS_USE;
			parameters[4].Value = model.HOSPITAL_CODE;
			parameters[5].Value = model.REMARKS;
			parameters[6].Value = model.CREATE_DATE;
			parameters[7].Value = model.CREATE_BY;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from his_comm_function ");
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
			strSql.Append("delete from his_comm_function ");
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
		public HisClient.Model.his_comm_function GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MODULE_CODE,FUNCTION_CODE,FUNCTION_NAME,IS_USE,HOSPITAL_CODE,REMARKS,CREATE_DATE,CREATE_BY from his_comm_function ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_comm_function model=new HisClient.Model.his_comm_function();
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
		public HisClient.Model.his_comm_function DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_function model=new HisClient.Model.his_comm_function();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MODULE_CODE"]!=null)
				{
					model.MODULE_CODE=row["MODULE_CODE"].ToString();
				}
				if(row["FUNCTION_CODE"]!=null)
				{
					model.FUNCTION_CODE=row["FUNCTION_CODE"].ToString();
				}
				if(row["FUNCTION_NAME"]!=null)
				{
					model.FUNCTION_NAME=row["FUNCTION_NAME"].ToString();
				}
				if(row["IS_USE"]!=null)
				{
					model.IS_USE=row["IS_USE"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
				}
				if(row["REMARKS"]!=null)
				{
					model.REMARKS=row["REMARKS"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
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
			strSql.Append("select ID,MODULE_CODE,FUNCTION_CODE,FUNCTION_NAME,IS_USE,HOSPITAL_CODE,REMARKS,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_comm_function ");
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
			strSql.Append("select count(1) FROM his_comm_function ");
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
			strSql.Append(")AS Row, T.*  from his_comm_function T ");
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
			parameters[0].Value = "his_comm_function";
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

