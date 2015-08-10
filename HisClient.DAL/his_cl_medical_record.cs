using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_cl_medical_record
	/// </summary>
	public partial class his_cl_medical_record
	{
		public his_cl_medical_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_cl_medical_record");
			strSql.Append(" where CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_cl_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_cl_medical_record(");
			strSql.Append("CL_CODE,PHA_CODE,DOCTOR_CODE,CL_DATE,IP,ICD_CODE,ICD_NAME,MEMO,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@CL_CODE,@PHA_CODE,@DOCTOR_CODE,@CL_DATE,@IP,@ICD_CODE,@ICD_NAME,@MEMO,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@PHA_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_DATE", MySqlDbType.Date),
					new MySqlParameter("@IP", MySqlDbType.VarChar,18),
					new MySqlParameter("@ICD_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@ICD_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MEMO", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.CL_CODE;
			parameters[1].Value = model.PHA_CODE;
			parameters[2].Value = model.DOCTOR_CODE;
			parameters[3].Value = model.CL_DATE;
			parameters[4].Value = model.IP;
			parameters[5].Value = model.ICD_CODE;
			parameters[6].Value = model.ICD_NAME;
			parameters[7].Value = model.MEMO;
			parameters[8].Value = model.OPT_USER;
			parameters[9].Value = model.OPT_DATE;
			parameters[10].Value = model.OPT_TERM;
			parameters[11].Value = model.OPT_ORGA;

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
		public bool Update(HisClient.Model.his_cl_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_cl_medical_record set ");
			strSql.Append("PHA_CODE=@PHA_CODE,");
			strSql.Append("DOCTOR_CODE=@DOCTOR_CODE,");
			strSql.Append("CL_DATE=@CL_DATE,");
			strSql.Append("IP=@IP,");
			strSql.Append("ICD_CODE=@ICD_CODE,");
			strSql.Append("ICD_NAME=@ICD_NAME,");
			strSql.Append("MEMO=@MEMO,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PHA_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@DOCTOR_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_DATE", MySqlDbType.Date),
					new MySqlParameter("@IP", MySqlDbType.VarChar,18),
					new MySqlParameter("@ICD_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@ICD_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MEMO", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.PHA_CODE;
			parameters[1].Value = model.DOCTOR_CODE;
			parameters[2].Value = model.CL_DATE;
			parameters[3].Value = model.IP;
			parameters[4].Value = model.ICD_CODE;
			parameters[5].Value = model.ICD_NAME;
			parameters[6].Value = model.MEMO;
			parameters[7].Value = model.OPT_USER;
			parameters[8].Value = model.OPT_DATE;
			parameters[9].Value = model.OPT_TERM;
			parameters[10].Value = model.OPT_ORGA;
			parameters[11].Value = model.CL_CODE;

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
		public bool Delete(string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_cl_medical_record ");
			strSql.Append(" where CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_CODE;

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
		public bool DeleteList(string CL_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_cl_medical_record ");
			strSql.Append(" where CL_CODE in ("+CL_CODElist + ")  ");
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
		public HisClient.Model.his_cl_medical_record GetModel(string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CL_CODE,PHA_CODE,DOCTOR_CODE,CL_DATE,IP,ICD_CODE,ICD_NAME,MEMO,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_cl_medical_record ");
			strSql.Append(" where CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = CL_CODE;

			HisClient.Model.his_cl_medical_record model=new HisClient.Model.his_cl_medical_record();
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
		public HisClient.Model.his_cl_medical_record DataRowToModel(DataRow row)
		{
			HisClient.Model.his_cl_medical_record model=new HisClient.Model.his_cl_medical_record();
			if (row != null)
			{
				if(row["CL_CODE"]!=null)
				{
					model.CL_CODE=row["CL_CODE"].ToString();
				}
				if(row["PHA_CODE"]!=null)
				{
					model.PHA_CODE=row["PHA_CODE"].ToString();
				}
				if(row["DOCTOR_CODE"]!=null)
				{
					model.DOCTOR_CODE=row["DOCTOR_CODE"].ToString();
				}
				if(row["CL_DATE"]!=null && row["CL_DATE"].ToString()!="")
				{
					model.CL_DATE=DateTime.Parse(row["CL_DATE"].ToString());
				}
				if(row["IP"]!=null)
				{
					model.IP=row["IP"].ToString();
				}
				if(row["ICD_CODE"]!=null)
				{
					model.ICD_CODE=row["ICD_CODE"].ToString();
				}
				if(row["ICD_NAME"]!=null)
				{
					model.ICD_NAME=row["ICD_NAME"].ToString();
				}
				if(row["MEMO"]!=null)
				{
					model.MEMO=row["MEMO"].ToString();
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
			strSql.Append("select CL_CODE,PHA_CODE,DOCTOR_CODE,CL_DATE,IP,ICD_CODE,ICD_NAME,MEMO,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_cl_medical_record ");
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
			strSql.Append("select count(1) FROM his_cl_medical_record ");
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
				strSql.Append("order by T.CL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from his_cl_medical_record T ");
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
			parameters[0].Value = "his_cl_medical_record";
			parameters[1].Value = "CL_CODE";
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

