using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_prescription
	/// </summary>
	public partial class his_hos_prescription
	{
		public his_hos_prescription()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_prescription");
			strSql.Append(" where HOS_PRES_CODE=@HOS_PRES_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HOS_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HOS_PRES_CODE;
			parameters[1].Value = HIS_HOS_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_hos_prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_hos_prescription(");
			strSql.Append("HOS_PRES_CODE,HIS_HOS_CODE,STATUS,APPLY_DEPT_CODE,DOCTOR_CODE,OPERATE_DEPT_CODE,SUM_AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@HOS_PRES_CODE,@HIS_HOS_CODE,@STATUS,@APPLY_DEPT_CODE,@DOCTOR_CODE,@OPERATE_DEPT_CODE,@SUM_AMT,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HOS_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,1),
					new MySqlParameter("@APPLY_DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@OPERATE_DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.HOS_PRES_CODE;
			parameters[1].Value = model.HIS_HOS_CODE;
			parameters[2].Value = model.STATUS;
			parameters[3].Value = model.APPLY_DEPT_CODE;
			parameters[4].Value = model.DOCTOR_CODE;
			parameters[5].Value = model.OPERATE_DEPT_CODE;
			parameters[6].Value = model.SUM_AMT;
			parameters[7].Value = model.OPT_USER;
			parameters[8].Value = model.OPT_DATE;
			parameters[9].Value = model.OPT_TERM;
			parameters[10].Value = model.OPT_ORGA;

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
		public bool Update(HisClient.Model.his_hos_prescription model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_prescription set ");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("APPLY_DEPT_CODE=@APPLY_DEPT_CODE,");
			strSql.Append("DOCTOR_CODE=@DOCTOR_CODE,");
			strSql.Append("OPERATE_DEPT_CODE=@OPERATE_DEPT_CODE,");
			strSql.Append("SUM_AMT=@SUM_AMT,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where HOS_PRES_CODE=@HOS_PRES_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,1),
					new MySqlParameter("@APPLY_DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@OPERATE_DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@HOS_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.STATUS;
			parameters[1].Value = model.APPLY_DEPT_CODE;
			parameters[2].Value = model.DOCTOR_CODE;
			parameters[3].Value = model.OPERATE_DEPT_CODE;
			parameters[4].Value = model.SUM_AMT;
			parameters[5].Value = model.OPT_USER;
			parameters[6].Value = model.OPT_DATE;
			parameters[7].Value = model.OPT_TERM;
			parameters[8].Value = model.OPT_ORGA;
			parameters[9].Value = model.HOS_PRES_CODE;
			parameters[10].Value = model.HIS_HOS_CODE;

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
		public bool Delete(string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_prescription ");
			strSql.Append(" where HOS_PRES_CODE=@HOS_PRES_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HOS_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HOS_PRES_CODE;
			parameters[1].Value = HIS_HOS_CODE;

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
		public HisClient.Model.his_hos_prescription GetModel(string HOS_PRES_CODE,string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select HOS_PRES_CODE,HIS_HOS_CODE,STATUS,APPLY_DEPT_CODE,DOCTOR_CODE,OPERATE_DEPT_CODE,SUM_AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_hos_prescription ");
			strSql.Append(" where HOS_PRES_CODE=@HOS_PRES_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HOS_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HOS_PRES_CODE;
			parameters[1].Value = HIS_HOS_CODE;

			HisClient.Model.his_hos_prescription model=new HisClient.Model.his_hos_prescription();
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
		public HisClient.Model.his_hos_prescription DataRowToModel(DataRow row)
		{
			HisClient.Model.his_hos_prescription model=new HisClient.Model.his_hos_prescription();
			if (row != null)
			{
				if(row["HOS_PRES_CODE"]!=null)
				{
					model.HOS_PRES_CODE=row["HOS_PRES_CODE"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["APPLY_DEPT_CODE"]!=null)
				{
					model.APPLY_DEPT_CODE=row["APPLY_DEPT_CODE"].ToString();
				}
				if(row["DOCTOR_CODE"]!=null)
				{
					model.DOCTOR_CODE=row["DOCTOR_CODE"].ToString();
				}
				if(row["OPERATE_DEPT_CODE"]!=null)
				{
					model.OPERATE_DEPT_CODE=row["OPERATE_DEPT_CODE"].ToString();
				}
				if(row["SUM_AMT"]!=null && row["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(row["SUM_AMT"].ToString());
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
			strSql.Append("select HOS_PRES_CODE,HIS_HOS_CODE,STATUS,APPLY_DEPT_CODE,DOCTOR_CODE,OPERATE_DEPT_CODE,SUM_AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_hos_prescription ");
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
			strSql.Append("select count(1) FROM his_hos_prescription ");
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
				strSql.Append("order by T.HIS_HOS_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_hos_prescription T ");
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
			parameters[0].Value = "his_hos_prescription";
			parameters[1].Value = "HIS_HOS_CODE";
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

