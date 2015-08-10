using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_pm_checkinfo
	/// </summary>
	public partial class his_pm_checkinfo
	{
		public his_pm_checkinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_pm_checkinfo");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_pm_checkinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_pm_checkinfo(");
			strSql.Append("ID,MEDINFO_CODE,MED_SPC,MED_UNIT,MED_AMOUNT,REAL_AMOUNT,MED_PRICE,PURCHASE_PRICE,WHOLESALE_PRICE,VALIDITY_DATE,MED_MADETIME,BACHNO,DEPT_CODE,CREATE_DATE,CREATE_BY)");
			strSql.Append(" values (");
			strSql.Append("@ID,@MEDINFO_CODE,@MED_SPC,@MED_UNIT,@MED_AMOUNT,@REAL_AMOUNT,@MED_PRICE,@PURCHASE_PRICE,@WHOLESALE_PRICE,@VALIDITY_DATE,@MED_MADETIME,@BACHNO,@DEPT_CODE,@CREATE_DATE,@CREATE_BY)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_AMOUNT", MySqlDbType.Decimal,12),
					new MySqlParameter("@REAL_AMOUNT", MySqlDbType.Decimal,12),
					new MySqlParameter("@MED_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@PURCHASE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@WHOLESALE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@VALIDITY_DATE", MySqlDbType.Date),
					new MySqlParameter("@MED_MADETIME", MySqlDbType.Date),
					new MySqlParameter("@BACHNO", MySqlDbType.VarChar,128),
					new MySqlParameter("@DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MEDINFO_CODE;
			parameters[2].Value = model.MED_SPC;
			parameters[3].Value = model.MED_UNIT;
			parameters[4].Value = model.MED_AMOUNT;
			parameters[5].Value = model.REAL_AMOUNT;
			parameters[6].Value = model.MED_PRICE;
			parameters[7].Value = model.PURCHASE_PRICE;
			parameters[8].Value = model.WHOLESALE_PRICE;
			parameters[9].Value = model.VALIDITY_DATE;
			parameters[10].Value = model.MED_MADETIME;
			parameters[11].Value = model.BACHNO;
			parameters[12].Value = model.DEPT_CODE;
			parameters[13].Value = model.CREATE_DATE;
			parameters[14].Value = model.CREATE_BY;

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
		public bool Update(HisClient.Model.his_pm_checkinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_pm_checkinfo set ");
			strSql.Append("MEDINFO_CODE=@MEDINFO_CODE,");
			strSql.Append("MED_SPC=@MED_SPC,");
			strSql.Append("MED_UNIT=@MED_UNIT,");
			strSql.Append("MED_AMOUNT=@MED_AMOUNT,");
			strSql.Append("REAL_AMOUNT=@REAL_AMOUNT,");
			strSql.Append("MED_PRICE=@MED_PRICE,");
			strSql.Append("PURCHASE_PRICE=@PURCHASE_PRICE,");
			strSql.Append("WHOLESALE_PRICE=@WHOLESALE_PRICE,");
			strSql.Append("VALIDITY_DATE=@VALIDITY_DATE,");
			strSql.Append("MED_MADETIME=@MED_MADETIME,");
			strSql.Append("BACHNO=@BACHNO,");
			strSql.Append("DEPT_CODE=@DEPT_CODE,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_BY=@CREATE_BY");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_AMOUNT", MySqlDbType.Decimal,12),
					new MySqlParameter("@REAL_AMOUNT", MySqlDbType.Decimal,12),
					new MySqlParameter("@MED_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@PURCHASE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@WHOLESALE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@VALIDITY_DATE", MySqlDbType.Date),
					new MySqlParameter("@MED_MADETIME", MySqlDbType.Date),
					new MySqlParameter("@BACHNO", MySqlDbType.VarChar,128),
					new MySqlParameter("@DEPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.MEDINFO_CODE;
			parameters[1].Value = model.MED_SPC;
			parameters[2].Value = model.MED_UNIT;
			parameters[3].Value = model.MED_AMOUNT;
			parameters[4].Value = model.REAL_AMOUNT;
			parameters[5].Value = model.MED_PRICE;
			parameters[6].Value = model.PURCHASE_PRICE;
			parameters[7].Value = model.WHOLESALE_PRICE;
			parameters[8].Value = model.VALIDITY_DATE;
			parameters[9].Value = model.MED_MADETIME;
			parameters[10].Value = model.BACHNO;
			parameters[11].Value = model.DEPT_CODE;
			parameters[12].Value = model.CREATE_DATE;
			parameters[13].Value = model.CREATE_BY;
			parameters[14].Value = model.ID;

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
			strSql.Append("delete from his_pm_checkinfo ");
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
			strSql.Append("delete from his_pm_checkinfo ");
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
		public HisClient.Model.his_pm_checkinfo GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MEDINFO_CODE,MED_SPC,MED_UNIT,MED_AMOUNT,REAL_AMOUNT,MED_PRICE,PURCHASE_PRICE,WHOLESALE_PRICE,VALIDITY_DATE,MED_MADETIME,BACHNO,DEPT_CODE,CREATE_DATE,CREATE_BY from his_pm_checkinfo ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_pm_checkinfo model=new HisClient.Model.his_pm_checkinfo();
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
		public HisClient.Model.his_pm_checkinfo DataRowToModel(DataRow row)
		{
			HisClient.Model.his_pm_checkinfo model=new HisClient.Model.his_pm_checkinfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MEDINFO_CODE"]!=null)
				{
					model.MEDINFO_CODE=row["MEDINFO_CODE"].ToString();
				}
				if(row["MED_SPC"]!=null)
				{
					model.MED_SPC=row["MED_SPC"].ToString();
				}
				if(row["MED_UNIT"]!=null)
				{
					model.MED_UNIT=row["MED_UNIT"].ToString();
				}
				if(row["MED_AMOUNT"]!=null && row["MED_AMOUNT"].ToString()!="")
				{
					model.MED_AMOUNT=decimal.Parse(row["MED_AMOUNT"].ToString());
				}
				if(row["REAL_AMOUNT"]!=null && row["REAL_AMOUNT"].ToString()!="")
				{
					model.REAL_AMOUNT=decimal.Parse(row["REAL_AMOUNT"].ToString());
				}
				if(row["MED_PRICE"]!=null && row["MED_PRICE"].ToString()!="")
				{
					model.MED_PRICE=decimal.Parse(row["MED_PRICE"].ToString());
				}
				if(row["PURCHASE_PRICE"]!=null && row["PURCHASE_PRICE"].ToString()!="")
				{
					model.PURCHASE_PRICE=decimal.Parse(row["PURCHASE_PRICE"].ToString());
				}
				if(row["WHOLESALE_PRICE"]!=null && row["WHOLESALE_PRICE"].ToString()!="")
				{
					model.WHOLESALE_PRICE=decimal.Parse(row["WHOLESALE_PRICE"].ToString());
				}
				if(row["VALIDITY_DATE"]!=null && row["VALIDITY_DATE"].ToString()!="")
				{
					model.VALIDITY_DATE=DateTime.Parse(row["VALIDITY_DATE"].ToString());
				}
				if(row["MED_MADETIME"]!=null && row["MED_MADETIME"].ToString()!="")
				{
					model.MED_MADETIME=DateTime.Parse(row["MED_MADETIME"].ToString());
				}
				if(row["BACHNO"]!=null)
				{
					model.BACHNO=row["BACHNO"].ToString();
				}
				if(row["DEPT_CODE"]!=null)
				{
					model.DEPT_CODE=row["DEPT_CODE"].ToString();
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
			strSql.Append("select ID,MEDINFO_CODE,MED_SPC,MED_UNIT,MED_AMOUNT,REAL_AMOUNT,MED_PRICE,PURCHASE_PRICE,WHOLESALE_PRICE,VALIDITY_DATE,MED_MADETIME,BACHNO,DEPT_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_pm_checkinfo ");
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
			strSql.Append("select count(1) FROM his_pm_checkinfo ");
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
			strSql.Append(")AS Row, T.*  from his_pm_checkinfo T ");
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
			parameters[0].Value = "his_pm_checkinfo";
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

