using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_ds_importinfo
	/// </summary>
	public partial class his_ds_importinfo
	{
		public his_ds_importinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_ds_importinfo");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_ds_importinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_ds_importinfo(");
			strSql.Append("ID,IMPORT_CODE,MED_CODE,MED_NAME,PAKAGE_UNIT,PAKAGE_AMOUNT,MENUFACTURE_CODE,MEDINFO_CODE,MED_SPC,MED_PRICE,PURCHASE_PRICE,VALIDITY_DATE,BATCHNO,MED_MADETIME,WHOLESALE_PRICE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@IMPORT_CODE,@MED_CODE,@MED_NAME,@PAKAGE_UNIT,@PAKAGE_AMOUNT,@MENUFACTURE_CODE,@MEDINFO_CODE,@MED_SPC,@MED_PRICE,@PURCHASE_PRICE,@VALIDITY_DATE,@BATCHNO,@MED_MADETIME,@WHOLESALE_PRICE)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@IMPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@PAKAGE_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@PAKAGE_AMOUNT", MySqlDbType.Int32,11),
					new MySqlParameter("@MENUFACTURE_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@PURCHASE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@VALIDITY_DATE", MySqlDbType.Date),
					new MySqlParameter("@BATCHNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@MED_MADETIME", MySqlDbType.Date),
					new MySqlParameter("@WHOLESALE_PRICE", MySqlDbType.Decimal,12)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.IMPORT_CODE;
			parameters[2].Value = model.MED_CODE;
			parameters[3].Value = model.MED_NAME;
			parameters[4].Value = model.PAKAGE_UNIT;
			parameters[5].Value = model.PAKAGE_AMOUNT;
			parameters[6].Value = model.MENUFACTURE_CODE;
			parameters[7].Value = model.MEDINFO_CODE;
			parameters[8].Value = model.MED_SPC;
			parameters[9].Value = model.MED_PRICE;
			parameters[10].Value = model.PURCHASE_PRICE;
			parameters[11].Value = model.VALIDITY_DATE;
			parameters[12].Value = model.BATCHNO;
			parameters[13].Value = model.MED_MADETIME;
			parameters[14].Value = model.WHOLESALE_PRICE;

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
		public bool Update(HisClient.Model.his_ds_importinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_ds_importinfo set ");
			strSql.Append("IMPORT_CODE=@IMPORT_CODE,");
			strSql.Append("MED_CODE=@MED_CODE,");
			strSql.Append("MED_NAME=@MED_NAME,");
			strSql.Append("PAKAGE_UNIT=@PAKAGE_UNIT,");
			strSql.Append("PAKAGE_AMOUNT=@PAKAGE_AMOUNT,");
			strSql.Append("MENUFACTURE_CODE=@MENUFACTURE_CODE,");
			strSql.Append("MEDINFO_CODE=@MEDINFO_CODE,");
			strSql.Append("MED_SPC=@MED_SPC,");
			strSql.Append("MED_PRICE=@MED_PRICE,");
			strSql.Append("PURCHASE_PRICE=@PURCHASE_PRICE,");
			strSql.Append("VALIDITY_DATE=@VALIDITY_DATE,");
			strSql.Append("BATCHNO=@BATCHNO,");
			strSql.Append("MED_MADETIME=@MED_MADETIME,");
			strSql.Append("WHOLESALE_PRICE=@WHOLESALE_PRICE");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IMPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MED_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@PAKAGE_UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@PAKAGE_AMOUNT", MySqlDbType.Int32,11),
					new MySqlParameter("@MENUFACTURE_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@MEDINFO_CODE", MySqlDbType.VarChar,20),
					new MySqlParameter("@MED_SPC", MySqlDbType.VarChar,128),
					new MySqlParameter("@MED_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@PURCHASE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@VALIDITY_DATE", MySqlDbType.Date),
					new MySqlParameter("@BATCHNO", MySqlDbType.VarChar,20),
					new MySqlParameter("@MED_MADETIME", MySqlDbType.Date),
					new MySqlParameter("@WHOLESALE_PRICE", MySqlDbType.Decimal,12),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.IMPORT_CODE;
			parameters[1].Value = model.MED_CODE;
			parameters[2].Value = model.MED_NAME;
			parameters[3].Value = model.PAKAGE_UNIT;
			parameters[4].Value = model.PAKAGE_AMOUNT;
			parameters[5].Value = model.MENUFACTURE_CODE;
			parameters[6].Value = model.MEDINFO_CODE;
			parameters[7].Value = model.MED_SPC;
			parameters[8].Value = model.MED_PRICE;
			parameters[9].Value = model.PURCHASE_PRICE;
			parameters[10].Value = model.VALIDITY_DATE;
			parameters[11].Value = model.BATCHNO;
			parameters[12].Value = model.MED_MADETIME;
			parameters[13].Value = model.WHOLESALE_PRICE;
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
			strSql.Append("delete from his_ds_importinfo ");
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
			strSql.Append("delete from his_ds_importinfo ");
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
		public HisClient.Model.his_ds_importinfo GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,IMPORT_CODE,MED_CODE,MED_NAME,PAKAGE_UNIT,PAKAGE_AMOUNT,MENUFACTURE_CODE,MEDINFO_CODE,MED_SPC,MED_PRICE,PURCHASE_PRICE,VALIDITY_DATE,BATCHNO,MED_MADETIME,WHOLESALE_PRICE from his_ds_importinfo ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_ds_importinfo model=new HisClient.Model.his_ds_importinfo();
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
		public HisClient.Model.his_ds_importinfo DataRowToModel(DataRow row)
		{
			HisClient.Model.his_ds_importinfo model=new HisClient.Model.his_ds_importinfo();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["IMPORT_CODE"]!=null)
				{
					model.IMPORT_CODE=row["IMPORT_CODE"].ToString();
				}
				if(row["MED_CODE"]!=null)
				{
					model.MED_CODE=row["MED_CODE"].ToString();
				}
				if(row["MED_NAME"]!=null)
				{
					model.MED_NAME=row["MED_NAME"].ToString();
				}
				if(row["PAKAGE_UNIT"]!=null)
				{
					model.PAKAGE_UNIT=row["PAKAGE_UNIT"].ToString();
				}
				if(row["PAKAGE_AMOUNT"]!=null && row["PAKAGE_AMOUNT"].ToString()!="")
				{
					model.PAKAGE_AMOUNT=int.Parse(row["PAKAGE_AMOUNT"].ToString());
				}
				if(row["MENUFACTURE_CODE"]!=null)
				{
					model.MENUFACTURE_CODE=row["MENUFACTURE_CODE"].ToString();
				}
				if(row["MEDINFO_CODE"]!=null)
				{
					model.MEDINFO_CODE=row["MEDINFO_CODE"].ToString();
				}
				if(row["MED_SPC"]!=null)
				{
					model.MED_SPC=row["MED_SPC"].ToString();
				}
				if(row["MED_PRICE"]!=null && row["MED_PRICE"].ToString()!="")
				{
					model.MED_PRICE=decimal.Parse(row["MED_PRICE"].ToString());
				}
				if(row["PURCHASE_PRICE"]!=null && row["PURCHASE_PRICE"].ToString()!="")
				{
					model.PURCHASE_PRICE=decimal.Parse(row["PURCHASE_PRICE"].ToString());
				}
				if(row["VALIDITY_DATE"]!=null && row["VALIDITY_DATE"].ToString()!="")
				{
					model.VALIDITY_DATE=DateTime.Parse(row["VALIDITY_DATE"].ToString());
				}
				if(row["BATCHNO"]!=null)
				{
					model.BATCHNO=row["BATCHNO"].ToString();
				}
				if(row["MED_MADETIME"]!=null && row["MED_MADETIME"].ToString()!="")
				{
					model.MED_MADETIME=DateTime.Parse(row["MED_MADETIME"].ToString());
				}
				if(row["WHOLESALE_PRICE"]!=null && row["WHOLESALE_PRICE"].ToString()!="")
				{
					model.WHOLESALE_PRICE=decimal.Parse(row["WHOLESALE_PRICE"].ToString());
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
			strSql.Append("select ID,IMPORT_CODE,MED_CODE,MED_NAME,PAKAGE_UNIT,PAKAGE_AMOUNT,MENUFACTURE_CODE,MEDINFO_CODE,MED_SPC,MED_PRICE,PURCHASE_PRICE,VALIDITY_DATE,BATCHNO,MED_MADETIME,WHOLESALE_PRICE ");
			strSql.Append(" FROM his_ds_importinfo ");
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
			strSql.Append("select count(1) FROM his_ds_importinfo ");
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
			strSql.Append(")AS Row, T.*  from his_ds_importinfo T ");
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
			parameters[0].Value = "his_ds_importinfo";
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

