using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_medinfo
	/// </summary>
	public partial class his_comm_medinfo
	{
		public his_comm_medinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_medinfo");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_comm_medinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_comm_medinfo(");
			strSql.Append("ID,MED_CODE,MED_NAME,HELP_CODE,MENUFACTURE_CODE,MED_SPC,MED_UNIT,DOSAGE_CODE,APPROVAL_NUMBER,EFFICACY_CODE,ORIGIN,CREATE_BY,CREATE_DATE,MEDINFO_CODE,PAKAGE_UNIT,PAKAGE_PM_NUMBER,DEFAULT_DOSAGE_AMOUNT)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MED_CODE,@MED_NAME,@HELP_CODE,@MENUFACTURE_CODE,@MED_SPC,@MED_UNIT,@DOSAGE_CODE,@APPROVAL_NUMBER,@EFFICACY_CODE,@ORIGIN,@CREATE_BY,@CREATE_DATE,@MEDINFO_CODE,@PAKAGE_UNIT,@PAKAGE_PM_NUMBER,@DEFAULT_DOSAGE_AMOUNT)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@MENUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOSAGE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@APPROVAL_NUMBER", MySqlDbType.VarChar,128),
					new MySqlParameter("@EFFICACY_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ORIGIN", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@PAKAGE_UNIT", MySqlDbType.VarChar,20),
					new MySqlParameter("@PAKAGE_PM_NUMBER", MySqlDbType.Int32,11),
					new MySqlParameter("@DEFAULT_DOSAGE_AMOUNT", MySqlDbType.Decimal,12)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MED_CODE;
			parameters[2].Value = model.MED_NAME;
			parameters[3].Value = model.HELP_CODE;
			parameters[4].Value = model.MENUFACTURE_CODE;
			parameters[5].Value = model.MED_SPC;
			parameters[6].Value = model.MED_UNIT;
			parameters[7].Value = model.DOSAGE_CODE;
			parameters[8].Value = model.APPROVAL_NUMBER;
			parameters[9].Value = model.EFFICACY_CODE;
			parameters[10].Value = model.ORIGIN;
			parameters[11].Value = model.CREATE_BY;
			parameters[12].Value = model.CREATE_DATE;
			parameters[13].Value = model.MEDINFO_CODE;
			parameters[14].Value = model.PAKAGE_UNIT;
			parameters[15].Value = model.PAKAGE_PM_NUMBER;
			parameters[16].Value = model.DEFAULT_DOSAGE_AMOUNT;

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
		public bool Update(HisClient.Model.his_comm_medinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_medinfo set ");
			strSql.Append("MED_CODE=@MED_CODE,");
			strSql.Append("MED_NAME=@MED_NAME,");
			strSql.Append("HELP_CODE=@HELP_CODE,");
			strSql.Append("MENUFACTURE_CODE=@MENUFACTURE_CODE,");
			strSql.Append("MED_SPC=@MED_SPC,");
			strSql.Append("MED_UNIT=@MED_UNIT,");
			strSql.Append("DOSAGE_CODE=@DOSAGE_CODE,");
			strSql.Append("APPROVAL_NUMBER=@APPROVAL_NUMBER,");
			strSql.Append("EFFICACY_CODE=@EFFICACY_CODE,");
			strSql.Append("ORIGIN=@ORIGIN,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("MEDINFO_CODE=@MEDINFO_CODE,");
			strSql.Append("PAKAGE_UNIT=@PAKAGE_UNIT,");
			strSql.Append("PAKAGE_PM_NUMBER=@PAKAGE_PM_NUMBER,");
			strSql.Append("DEFAULT_DOSAGE_AMOUNT=@DEFAULT_DOSAGE_AMOUNT");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MED_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@HELP_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@MENUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOSAGE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@APPROVAL_NUMBER", MySqlDbType.VarChar,128),
					new MySqlParameter("@EFFICACY_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ORIGIN", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@PAKAGE_UNIT", MySqlDbType.VarChar,20),
					new MySqlParameter("@PAKAGE_PM_NUMBER", MySqlDbType.Int32,11),
					new MySqlParameter("@DEFAULT_DOSAGE_AMOUNT", MySqlDbType.Decimal,12),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.MED_CODE;
			parameters[1].Value = model.MED_NAME;
			parameters[2].Value = model.HELP_CODE;
			parameters[3].Value = model.MENUFACTURE_CODE;
			parameters[4].Value = model.MED_SPC;
			parameters[5].Value = model.MED_UNIT;
			parameters[6].Value = model.DOSAGE_CODE;
			parameters[7].Value = model.APPROVAL_NUMBER;
			parameters[8].Value = model.EFFICACY_CODE;
			parameters[9].Value = model.ORIGIN;
			parameters[10].Value = model.CREATE_BY;
			parameters[11].Value = model.CREATE_DATE;
			parameters[12].Value = model.MEDINFO_CODE;
			parameters[13].Value = model.PAKAGE_UNIT;
			parameters[14].Value = model.PAKAGE_PM_NUMBER;
			parameters[15].Value = model.DEFAULT_DOSAGE_AMOUNT;
			parameters[16].Value = model.ID;

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
			strSql.Append("delete from his_comm_medinfo ");
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
			strSql.Append("delete from his_comm_medinfo ");
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
		public HisClient.Model.his_comm_medinfo GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MED_CODE,MED_NAME,HELP_CODE,MENUFACTURE_CODE,MED_SPC,MED_UNIT,DOSAGE_CODE,APPROVAL_NUMBER,EFFICACY_CODE,ORIGIN,CREATE_BY,CREATE_DATE,MEDINFO_CODE,PAKAGE_UNIT,PAKAGE_PM_NUMBER,DEFAULT_DOSAGE_AMOUNT from his_comm_medinfo ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_comm_medinfo model=new HisClient.Model.his_comm_medinfo();
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
		public HisClient.Model.his_comm_medinfo DataRowToModel(DataRow row)
		{
			HisClient.Model.his_comm_medinfo model=new HisClient.Model.his_comm_medinfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MED_CODE"]!=null)
				{
					model.MED_CODE=row["MED_CODE"].ToString();
				}
				if(row["MED_NAME"]!=null)
				{
					model.MED_NAME=row["MED_NAME"].ToString();
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["MENUFACTURE_CODE"]!=null)
				{
					model.MENUFACTURE_CODE=row["MENUFACTURE_CODE"].ToString();
				}
				if(row["MED_SPC"]!=null)
				{
					model.MED_SPC=row["MED_SPC"].ToString();
				}
				if(row["MED_UNIT"]!=null)
				{
					model.MED_UNIT=row["MED_UNIT"].ToString();
				}
				if(row["DOSAGE_CODE"]!=null)
				{
					model.DOSAGE_CODE=row["DOSAGE_CODE"].ToString();
				}
				if(row["APPROVAL_NUMBER"]!=null)
				{
					model.APPROVAL_NUMBER=row["APPROVAL_NUMBER"].ToString();
				}
				if(row["EFFICACY_CODE"]!=null)
				{
					model.EFFICACY_CODE=row["EFFICACY_CODE"].ToString();
				}
				if(row["ORIGIN"]!=null)
				{
					model.ORIGIN=row["ORIGIN"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["MEDINFO_CODE"]!=null)
				{
					model.MEDINFO_CODE=row["MEDINFO_CODE"].ToString();
				}
				if(row["PAKAGE_UNIT"]!=null)
				{
					model.PAKAGE_UNIT=row["PAKAGE_UNIT"].ToString();
				}
				if(row["PAKAGE_PM_NUMBER"]!=null && row["PAKAGE_PM_NUMBER"].ToString()!="")
				{
					model.PAKAGE_PM_NUMBER=int.Parse(row["PAKAGE_PM_NUMBER"].ToString());
				}
				if(row["DEFAULT_DOSAGE_AMOUNT"]!=null && row["DEFAULT_DOSAGE_AMOUNT"].ToString()!="")
				{
					model.DEFAULT_DOSAGE_AMOUNT=decimal.Parse(row["DEFAULT_DOSAGE_AMOUNT"].ToString());
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
			strSql.Append("select ID,MED_CODE,MED_NAME,HELP_CODE,MENUFACTURE_CODE,MED_SPC,MED_UNIT,DOSAGE_CODE,APPROVAL_NUMBER,EFFICACY_CODE,ORIGIN,CREATE_BY,CREATE_DATE,MEDINFO_CODE,PAKAGE_UNIT,PAKAGE_PM_NUMBER,DEFAULT_DOSAGE_AMOUNT ");
			strSql.Append(" FROM his_comm_medinfo ");
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
			strSql.Append("select count(1) FROM his_comm_medinfo ");
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
			strSql.Append(")AS Row, T.*  from his_comm_medinfo T ");
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
			parameters[0].Value = "his_comm_medinfo";
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

