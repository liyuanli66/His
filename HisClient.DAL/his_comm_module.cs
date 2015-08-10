using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_module
	/// </summary>
	public partial class his_comm_module
	{
		public his_comm_module()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_module");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_module model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_module(");
			strSql.Append("ID,MODULE_NAME,MODULE_CODE,SYSTEM_CODE,IS_USE,CREATE_DATE,CREATE_BY,HOSPITAL_CODE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MODULE_NAME,@MODULE_CODE,@SYSTEM_CODE,@IS_USE,@CREATE_DATE,@CREATE_BY,@HOSPITAL_CODE,@REMARK)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MODULE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MODULE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@SYSTEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@REMARK", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MODULE_NAME;
			parameters[2].Value = model.MODULE_CODE;
			parameters[3].Value = model.SYSTEM_CODE;
			parameters[4].Value = model.IS_USE;
			parameters[5].Value = model.CREATE_DATE;
			parameters[6].Value = model.CREATE_BY;
			parameters[7].Value = model.HOSPITAL_CODE;
			parameters[8].Value = model.REMARK;

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
		public bool Update(HisClient.Model.his_comm_module model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_module set ");
			strSql.Append("MODULE_NAME=@MODULE_NAME,");
			strSql.Append("MODULE_CODE=@MODULE_CODE,");
			strSql.Append("SYSTEM_CODE=@SYSTEM_CODE,");
			strSql.Append("IS_USE=@IS_USE,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("HOSPITAL_CODE=@HOSPITAL_CODE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MODULE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MODULE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@SYSTEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@IS_USE", MySqlDbType.VarChar,2),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@REMARK", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.MODULE_NAME;
			parameters[1].Value = model.MODULE_CODE;
			parameters[2].Value = model.SYSTEM_CODE;
			parameters[3].Value = model.IS_USE;
			parameters[4].Value = model.CREATE_DATE;
			parameters[5].Value = model.CREATE_BY;
			parameters[6].Value = model.HOSPITAL_CODE;
			parameters[7].Value = model.REMARK;
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
			strSql.Append("delete from his_comm_module ");
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
			strSql.Append("delete from his_comm_module ");
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
		public HisClient.Model.his_comm_module GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MODULE_NAME,MODULE_CODE,SYSTEM_CODE,IS_USE,CREATE_DATE,CREATE_BY,HOSPITAL_CODE,REMARK from his_comm_module ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_comm_module model=new HisClient.Model.his_comm_module();
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
		public HisClient.Model.his_comm_module DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_module model=new HisClient.Model.his_comm_module();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MODULE_NAME"]!=null)
				{
					model.MODULE_NAME=row["MODULE_NAME"].ToString();
				}
				if(row["MODULE_CODE"]!=null)
				{
					model.MODULE_CODE=row["MODULE_CODE"].ToString();
				}
				if(row["SYSTEM_CODE"]!=null)
				{
					model.SYSTEM_CODE=row["SYSTEM_CODE"].ToString();
				}
				if(row["IS_USE"]!=null)
				{
					model.IS_USE=row["IS_USE"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select ID,MODULE_NAME,MODULE_CODE,SYSTEM_CODE,IS_USE,CREATE_DATE,CREATE_BY,HOSPITAL_CODE,REMARK ");
			strSql.Append(" FROM his_comm_module ");
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
			strSql.Append("select count(1) FROM his_comm_module ");
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
			strSql.Append(")AS Row, T.*  from his_comm_module T ");
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
			parameters[0].Value = "his_comm_module";
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

