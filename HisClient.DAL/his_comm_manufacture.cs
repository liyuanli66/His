using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_manufacture
	/// </summary>
	public partial class his_comm_manufacture
	{
		public his_comm_manufacture()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_manufacture");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_manufacture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_manufacture(");
			strSql.Append("ID,MANUFACTURE_CODE,MANUFACTURE_NAME,LOCALITY_TYPE,CREDIT_CODE,MANUFACTURE_ADDRESS,LINK_MAN,LINK_TEL,LINK_EMAIL,FAX,APTITUDE,APTITUDE_DATE,HELP_CODE,HOSPITAL_CODE,CREATE_DATE,CREATE_BY)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MANUFACTURE_CODE,@MANUFACTURE_NAME,@LOCALITY_TYPE,@CREDIT_CODE,@MANUFACTURE_ADDRESS,@LINK_MAN,@LINK_TEL,@LINK_EMAIL,@FAX,@APTITUDE,@APTITUDE_DATE,@HELP_CODE,@HOSPITAL_CODE,@CREATE_DATE,@CREATE_BY)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@LOCALITY_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@CREDIT_CODE", MySqlDbType.Int32,11),
					new MySqlParameter("@MANUFACTURE_ADDRESS", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_MAN", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_TEL", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_EMAIL", MySqlDbType.VarChar,128),
					new MySqlParameter("@FAX", MySqlDbType.VarChar,128),
					new MySqlParameter("@APTITUDE", MySqlDbType.VarChar,128),
					new MySqlParameter("@APTITUDE_DATE", MySqlDbType.Date),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MANUFACTURE_CODE;
			parameters[2].Value = model.MANUFACTURE_NAME;
			parameters[3].Value = model.LOCALITY_TYPE;
			parameters[4].Value = model.CREDIT_CODE;
			parameters[5].Value = model.MANUFACTURE_ADDRESS;
			parameters[6].Value = model.LINK_MAN;
			parameters[7].Value = model.LINK_TEL;
			parameters[8].Value = model.LINK_EMAIL;
			parameters[9].Value = model.FAX;
			parameters[10].Value = model.APTITUDE;
			parameters[11].Value = model.APTITUDE_DATE;
			parameters[12].Value = model.HELP_CODE;
			parameters[13].Value = model.HOSPITAL_CODE;
			parameters[14].Value = model.CREATE_DATE;
			parameters[15].Value = model.CREATE_BY;

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
		public bool Update(HisClient.Model.his_comm_manufacture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_manufacture set ");
			strSql.Append("MANUFACTURE_CODE=@MANUFACTURE_CODE,");
			strSql.Append("MANUFACTURE_NAME=@MANUFACTURE_NAME,");
			strSql.Append("LOCALITY_TYPE=@LOCALITY_TYPE,");
			strSql.Append("CREDIT_CODE=@CREDIT_CODE,");
			strSql.Append("MANUFACTURE_ADDRESS=@MANUFACTURE_ADDRESS,");
			strSql.Append("LINK_MAN=@LINK_MAN,");
			strSql.Append("LINK_TEL=@LINK_TEL,");
			strSql.Append("LINK_EMAIL=@LINK_EMAIL,");
			strSql.Append("FAX=@FAX,");
			strSql.Append("APTITUDE=@APTITUDE,");
			strSql.Append("APTITUDE_DATE=@APTITUDE_DATE,");
			strSql.Append("HELP_CODE=@HELP_CODE,");
			strSql.Append("HOSPITAL_CODE=@HOSPITAL_CODE,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_BY=@CREATE_BY");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@LOCALITY_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@CREDIT_CODE", MySqlDbType.Int32,11),
					new MySqlParameter("@MANUFACTURE_ADDRESS", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_MAN", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_TEL", MySqlDbType.VarChar,128),
					new MySqlParameter("@LINK_EMAIL", MySqlDbType.VarChar,128),
					new MySqlParameter("@FAX", MySqlDbType.VarChar,128),
					new MySqlParameter("@APTITUDE", MySqlDbType.VarChar,128),
					new MySqlParameter("@APTITUDE_DATE", MySqlDbType.Date),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.MANUFACTURE_CODE;
			parameters[1].Value = model.MANUFACTURE_NAME;
			parameters[2].Value = model.LOCALITY_TYPE;
			parameters[3].Value = model.CREDIT_CODE;
			parameters[4].Value = model.MANUFACTURE_ADDRESS;
			parameters[5].Value = model.LINK_MAN;
			parameters[6].Value = model.LINK_TEL;
			parameters[7].Value = model.LINK_EMAIL;
			parameters[8].Value = model.FAX;
			parameters[9].Value = model.APTITUDE;
			parameters[10].Value = model.APTITUDE_DATE;
			parameters[11].Value = model.HELP_CODE;
			parameters[12].Value = model.HOSPITAL_CODE;
			parameters[13].Value = model.CREATE_DATE;
			parameters[14].Value = model.CREATE_BY;
			parameters[15].Value = model.ID;

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
			strSql.Append("delete from his_comm_manufacture ");
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
			strSql.Append("delete from his_comm_manufacture ");
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
		public HisClient.Model.his_comm_manufacture GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MANUFACTURE_CODE,MANUFACTURE_NAME,LOCALITY_TYPE,CREDIT_CODE,MANUFACTURE_ADDRESS,LINK_MAN,LINK_TEL,LINK_EMAIL,FAX,APTITUDE,APTITUDE_DATE,HELP_CODE,HOSPITAL_CODE,CREATE_DATE,CREATE_BY from his_comm_manufacture ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_comm_manufacture model=new HisClient.Model.his_comm_manufacture();
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
		public HisClient.Model.his_comm_manufacture DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_manufacture model=new HisClient.Model.his_comm_manufacture();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["LOCALITY_TYPE"]!=null)
				{
					model.LOCALITY_TYPE=row["LOCALITY_TYPE"].ToString();
				}
				if(row["CREDIT_CODE"]!=null && row["CREDIT_CODE"].ToString()!="")
				{
					model.CREDIT_CODE=int.Parse(row["CREDIT_CODE"].ToString());
				}
				if(row["MANUFACTURE_ADDRESS"]!=null)
				{
					model.MANUFACTURE_ADDRESS=row["MANUFACTURE_ADDRESS"].ToString();
				}
				if(row["LINK_MAN"]!=null)
				{
					model.LINK_MAN=row["LINK_MAN"].ToString();
				}
				if(row["LINK_TEL"]!=null)
				{
					model.LINK_TEL=row["LINK_TEL"].ToString();
				}
				if(row["LINK_EMAIL"]!=null)
				{
					model.LINK_EMAIL=row["LINK_EMAIL"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["APTITUDE"]!=null)
				{
					model.APTITUDE=row["APTITUDE"].ToString();
				}
				if(row["APTITUDE_DATE"]!=null && row["APTITUDE_DATE"].ToString()!="")
				{
					model.APTITUDE_DATE=DateTime.Parse(row["APTITUDE_DATE"].ToString());
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
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
			strSql.Append("select ID,MANUFACTURE_CODE,MANUFACTURE_NAME,LOCALITY_TYPE,CREDIT_CODE,MANUFACTURE_ADDRESS,LINK_MAN,LINK_TEL,LINK_EMAIL,FAX,APTITUDE,APTITUDE_DATE,HELP_CODE,HOSPITAL_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_comm_manufacture ");
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
			strSql.Append("select count(1) FROM his_comm_manufacture ");
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
			strSql.Append(")AS Row, T.*  from his_comm_manufacture T ");
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
			parameters[0].Value = "his_comm_manufacture";
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

