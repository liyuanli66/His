using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_ds_export
	/// </summary>
	public partial class his_ds_export
	{
		public his_ds_export()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_ds_export");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_ds_export model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_ds_export(");
			strSql.Append("ID,EXPORT_CODE,MANUFACTURE_NAME,MANUFACTURE_CODE,EXPORT_TYPE,EXPORT_DEPT,CREATE_BY,CREATE_DATE,COST,OPERATOR_NAME,OPERATOR_DATE,CANCEL_OPERATOR,CANCEL_DATE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@EXPORT_CODE,@MANUFACTURE_NAME,@MANUFACTURE_CODE,@EXPORT_TYPE,@EXPORT_DEPT,@CREATE_BY,@CREATE_DATE,@COST,@OPERATOR_NAME,@OPERATOR_DATE,@CANCEL_OPERATOR,@CANCEL_DATE)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@EXPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@EXPORT_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@EXPORT_DEPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@COST", MySqlDbType.Decimal,12),
					new MySqlParameter("@OPERATOR_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPERATOR_DATE", MySqlDbType.Date),
					new MySqlParameter("@CANCEL_OPERATOR", MySqlDbType.VarChar,20),
					new MySqlParameter("@CANCEL_DATE", MySqlDbType.Date)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EXPORT_CODE;
			parameters[2].Value = model.MANUFACTURE_NAME;
			parameters[3].Value = model.MANUFACTURE_CODE;
			parameters[4].Value = model.EXPORT_TYPE;
			parameters[5].Value = model.EXPORT_DEPT;
			parameters[6].Value = model.CREATE_BY;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.COST;
			parameters[9].Value = model.OPERATOR_NAME;
			parameters[10].Value = model.OPERATOR_DATE;
			parameters[11].Value = model.CANCEL_OPERATOR;
			parameters[12].Value = model.CANCEL_DATE;

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
		public bool Update(HisClient.Model.his_ds_export model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_ds_export set ");
			strSql.Append("EXPORT_CODE=@EXPORT_CODE,");
			strSql.Append("MANUFACTURE_NAME=@MANUFACTURE_NAME,");
			strSql.Append("MANUFACTURE_CODE=@MANUFACTURE_CODE,");
			strSql.Append("EXPORT_TYPE=@EXPORT_TYPE,");
			strSql.Append("EXPORT_DEPT=@EXPORT_DEPT,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("COST=@COST,");
			strSql.Append("OPERATOR_NAME=@OPERATOR_NAME,");
			strSql.Append("OPERATOR_DATE=@OPERATOR_DATE,");
			strSql.Append("CANCEL_OPERATOR=@CANCEL_OPERATOR,");
			strSql.Append("CANCEL_DATE=@CANCEL_DATE");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EXPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@EXPORT_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@EXPORT_DEPT", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@COST", MySqlDbType.Decimal,12),
					new MySqlParameter("@OPERATOR_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPERATOR_DATE", MySqlDbType.Date),
					new MySqlParameter("@CANCEL_OPERATOR", MySqlDbType.VarChar,20),
					new MySqlParameter("@CANCEL_DATE", MySqlDbType.Date),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.EXPORT_CODE;
			parameters[1].Value = model.MANUFACTURE_NAME;
			parameters[2].Value = model.MANUFACTURE_CODE;
			parameters[3].Value = model.EXPORT_TYPE;
			parameters[4].Value = model.EXPORT_DEPT;
			parameters[5].Value = model.CREATE_BY;
			parameters[6].Value = model.CREATE_DATE;
			parameters[7].Value = model.COST;
			parameters[8].Value = model.OPERATOR_NAME;
			parameters[9].Value = model.OPERATOR_DATE;
			parameters[10].Value = model.CANCEL_OPERATOR;
			parameters[11].Value = model.CANCEL_DATE;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from his_ds_export ");
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
			strSql.Append("delete from his_ds_export ");
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
		public HisClient.Model.his_ds_export GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,EXPORT_CODE,MANUFACTURE_NAME,MANUFACTURE_CODE,EXPORT_TYPE,EXPORT_DEPT,CREATE_BY,CREATE_DATE,COST,OPERATOR_NAME,OPERATOR_DATE,CANCEL_OPERATOR,CANCEL_DATE from his_ds_export ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_ds_export model=new HisClient.Model.his_ds_export();
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
		public HisClient.Model.his_ds_export DataRowToModel(DataRow row)
		{
			HisClient.Model.his_ds_export model=new HisClient.Model.his_ds_export();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["EXPORT_CODE"]!=null)
				{
					model.EXPORT_CODE=row["EXPORT_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["EXPORT_TYPE"]!=null)
				{
					model.EXPORT_TYPE=row["EXPORT_TYPE"].ToString();
				}
				if(row["EXPORT_DEPT"]!=null)
				{
					model.EXPORT_DEPT=row["EXPORT_DEPT"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["COST"]!=null && row["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(row["COST"].ToString());
				}
				if(row["OPERATOR_NAME"]!=null)
				{
					model.OPERATOR_NAME=row["OPERATOR_NAME"].ToString();
				}
				if(row["OPERATOR_DATE"]!=null && row["OPERATOR_DATE"].ToString()!="")
				{
					model.OPERATOR_DATE=DateTime.Parse(row["OPERATOR_DATE"].ToString());
				}
				if(row["CANCEL_OPERATOR"]!=null)
				{
					model.CANCEL_OPERATOR=row["CANCEL_OPERATOR"].ToString();
				}
				if(row["CANCEL_DATE"]!=null && row["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(row["CANCEL_DATE"].ToString());
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
			strSql.Append("select ID,EXPORT_CODE,MANUFACTURE_NAME,MANUFACTURE_CODE,EXPORT_TYPE,EXPORT_DEPT,CREATE_BY,CREATE_DATE,COST,OPERATOR_NAME,OPERATOR_DATE,CANCEL_OPERATOR,CANCEL_DATE ");
			strSql.Append(" FROM his_ds_export ");
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
			strSql.Append("select count(1) FROM his_ds_export ");
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
			strSql.Append(")AS Row, T.*  from his_ds_export T ");
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
			parameters[0].Value = "his_ds_export";
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

