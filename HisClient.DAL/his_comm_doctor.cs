using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_doctor
	/// </summary>
	public partial class his_comm_doctor
	{
		public his_comm_doctor()
		{}
		#region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from his_comm_doctor");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_doctor(");
            strSql.Append("ID,DOCTOR_CODE,DOCTOR_NAME,DEPT_CODE,HISPITAL_CODE,DOCTOR_SEX,DOCTOR_TEL,DOCTOR_NATION,MERRIAGE_CODE,DOCTOR_EMAIL,DOCTOR_TITLE,DOCTOR_TITLEGRADE,HELP_CODE,REMARK,USER_TYPE)");
			strSql.Append(" values (");
            strSql.Append("@ID,@DOCTOR_CODE,@DOCTOR_NAME,@DEPT_CODE,@HISPITAL_CODE,@DOCTOR_SEX,@DOCTOR_TEL,@DOCTOR_NATION,@MERRIAGE_CODE,@DOCTOR_EMAIL,@DOCTOR_TITLE,@DOCTOR_TITLEGRADE,@HELP_CODE,@REMARK,@USER_TYPE)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HISPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_SEX", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_TEL", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOCTOR_NATION", MySqlDbType.VarChar,18),
					new MySqlParameter("@MERRIAGE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_EMAIL", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOCTOR_TITLE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_TITLEGRADE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@REMARK", MySqlDbType.VarChar,128),
                    new MySqlParameter("@USER_TYPE", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DOCTOR_CODE;
			parameters[2].Value = model.DOCTOR_NAME;
			parameters[3].Value = model.DEPT_CODE;
			parameters[4].Value = model.HISPITAL_CODE;
			parameters[5].Value = model.DOCTOR_SEX;
			parameters[6].Value = model.DOCTOR_TEL;
			parameters[7].Value = model.DOCTOR_NATION;
			parameters[8].Value = model.MERRIAGE_CODE;
			parameters[9].Value = model.DOCTOR_EMAIL;
			parameters[10].Value = model.DOCTOR_TITLE;
			parameters[11].Value = model.DOCTOR_TITLEGRADE;
			parameters[12].Value = model.HELP_CODE;
            parameters[13].Value = model.REMARK;
            parameters[14].Value = model.USER_TYPE;

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
		public bool Update(HisClient.Model.his_comm_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_doctor set ");
			strSql.Append("ID=@ID,");
			strSql.Append("DOCTOR_CODE=@DOCTOR_CODE,");
			strSql.Append("DOCTOR_NAME=@DOCTOR_NAME,");
			strSql.Append("DEPT_CODE=@DEPT_CODE,");
			strSql.Append("HISPITAL_CODE=@HISPITAL_CODE,");
			strSql.Append("DOCTOR_SEX=@DOCTOR_SEX,");
			strSql.Append("DOCTOR_TEL=@DOCTOR_TEL,");
			strSql.Append("DOCTOR_NATION=@DOCTOR_NATION,");
			strSql.Append("MERRIAGE_CODE=@MERRIAGE_CODE,");
			strSql.Append("DOCTOR_EMAIL=@DOCTOR_EMAIL,");
			strSql.Append("DOCTOR_TITLE=@DOCTOR_TITLE,");
			strSql.Append("DOCTOR_TITLEGRADE=@DOCTOR_TITLEGRADE,");
			strSql.Append("HELP_CODE=@HELP_CODE,");
			strSql.Append("REMARK=@REMARK");
            strSql.Append("USER_TYPE=@USER_TYPE");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HISPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_SEX", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_TEL", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOCTOR_NATION", MySqlDbType.VarChar,18),
					new MySqlParameter("@MERRIAGE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_EMAIL", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOCTOR_TITLE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_TITLEGRADE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@REMARK", MySqlDbType.VarChar,128),
                    new MySqlParameter("@USER_TYPE", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DOCTOR_CODE;
			parameters[2].Value = model.DOCTOR_NAME;
			parameters[3].Value = model.DEPT_CODE;
			parameters[4].Value = model.HISPITAL_CODE;
			parameters[5].Value = model.DOCTOR_SEX;
			parameters[6].Value = model.DOCTOR_TEL;
			parameters[7].Value = model.DOCTOR_NATION;
			parameters[8].Value = model.MERRIAGE_CODE;
			parameters[9].Value = model.DOCTOR_EMAIL;
			parameters[10].Value = model.DOCTOR_TITLE;
			parameters[11].Value = model.DOCTOR_TITLEGRADE;
			parameters[12].Value = model.HELP_CODE;
			parameters[13].Value = model.REMARK;
            parameters[14].Value = model.USER_TYPE;

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
			strSql.Append("delete from his_comm_doctor ");
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from his_comm_doctor ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public HisClient.Model.his_comm_doctor GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,DOCTOR_CODE,DOCTOR_NAME,DEPT_CODE,HISPITAL_CODE,DOCTOR_SEX,DOCTOR_TEL,DOCTOR_NATION,MERRIAGE_CODE,DOCTOR_EMAIL,DOCTOR_TITLE,DOCTOR_TITLEGRADE,HELP_CODE,REMARK,USER_TYPE from his_comm_doctor ");
            strSql.Append(" where ID=@ID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
            parameters[0].Value = ID;

			HisClient.Model.his_comm_doctor model=new HisClient.Model.his_comm_doctor();
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
		public HisClient.Model.his_comm_doctor DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_doctor model=new HisClient.Model.his_comm_doctor();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DOCTOR_CODE"]!=null)
				{
					model.DOCTOR_CODE=row["DOCTOR_CODE"].ToString();
				}
				if(row["DOCTOR_NAME"]!=null)
				{
					model.DOCTOR_NAME=row["DOCTOR_NAME"].ToString();
				}
				if(row["DEPT_CODE"]!=null)
				{
					model.DEPT_CODE=row["DEPT_CODE"].ToString();
				}
				if(row["HISPITAL_CODE"]!=null)
				{
					model.HISPITAL_CODE=row["HISPITAL_CODE"].ToString();
				}
				if(row["DOCTOR_SEX"]!=null)
				{
					model.DOCTOR_SEX=row["DOCTOR_SEX"].ToString();
				}
				if(row["DOCTOR_TEL"]!=null)
				{
					model.DOCTOR_TEL=row["DOCTOR_TEL"].ToString();
				}
				if(row["DOCTOR_NATION"]!=null)
				{
					model.DOCTOR_NATION=row["DOCTOR_NATION"].ToString();
				}
				if(row["MERRIAGE_CODE"]!=null)
				{
					model.MERRIAGE_CODE=row["MERRIAGE_CODE"].ToString();
				}
				if(row["DOCTOR_EMAIL"]!=null)
				{
					model.DOCTOR_EMAIL=row["DOCTOR_EMAIL"].ToString();
				}
				if(row["DOCTOR_TITLE"]!=null)
				{
					model.DOCTOR_TITLE=row["DOCTOR_TITLE"].ToString();
				}
				if(row["DOCTOR_TITLEGRADE"]!=null)
				{
					model.DOCTOR_TITLEGRADE=row["DOCTOR_TITLEGRADE"].ToString();
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
				}
                if (row["USER_TYPE"] != null)
                {
                    model.USER_TYPE = row["USER_TYPE"].ToString();
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
            strSql.Append("select ID,DOCTOR_CODE,DOCTOR_NAME,DEPT_CODE,HISPITAL_CODE,DOCTOR_SEX,DOCTOR_TEL,DOCTOR_NATION,MERRIAGE_CODE,DOCTOR_EMAIL,DOCTOR_TITLE,DOCTOR_TITLEGRADE,HELP_CODE,REMARK,USER_TYPE ");
			strSql.Append(" FROM his_comm_doctor ");
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
			strSql.Append("select count(1) FROM his_comm_doctor ");
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
			strSql.Append(")AS Row, T.*  from his_comm_doctor T ");
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
			parameters[0].Value = "his_comm_doctor";
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

