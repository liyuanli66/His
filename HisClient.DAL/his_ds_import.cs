using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_ds_import
	/// </summary>
	public partial class his_ds_import
	{
		public his_ds_import()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_ds_import");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_ds_import model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_ds_import(");
			strSql.Append("ID,IMPORT_CODE,IMPORT_TYPE,MANUFACTURE_CODE,MANUFACTURE_NAME,INVOICE_NO,ACCOUNT_FLAG,ACCOUNT_DATE,ISPAY_FLAG,PAY_TIME,CONTRACT_NO,IMPORT_FLAG,COST,CREATE_BY,CREATE_DATE,PURCHASER,PURCHASE_DATE,CANCEL_OPRATOR,CANCEL_DATE,HOSPITAL_CODE)");
			strSql.Append(" values (");
			strSql.Append("@ID,@IMPORT_CODE,@IMPORT_TYPE,@MANUFACTURE_CODE,@MANUFACTURE_NAME,@INVOICE_NO,@ACCOUNT_FLAG,@ACCOUNT_DATE,@ISPAY_FLAG,@PAY_TIME,@CONTRACT_NO,@IMPORT_FLAG,@COST,@CREATE_BY,@CREATE_DATE,@PURCHASER,@PURCHASE_DATE,@CANCEL_OPRATOR,@CANCEL_DATE,@HOSPITAL_CODE)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@IMPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@IMPORT_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@INVOICE_NO", MySqlDbType.VarChar,128),
					new MySqlParameter("@ACCOUNT_FLAG", MySqlDbType.VarChar,2),
					new MySqlParameter("@ACCOUNT_DATE", MySqlDbType.Date),
					new MySqlParameter("@ISPAY_FLAG", MySqlDbType.VarChar,2),
					new MySqlParameter("@PAY_TIME", MySqlDbType.Date),
					new MySqlParameter("@CONTRACT_NO", MySqlDbType.VarChar,128),
					new MySqlParameter("@IMPORT_FLAG", MySqlDbType.VarChar,20),
					new MySqlParameter("@COST", MySqlDbType.Decimal,12),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,20),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@PURCHASER", MySqlDbType.VarChar,128),
					new MySqlParameter("@PURCHASE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CANCEL_OPRATOR", MySqlDbType.VarChar,20),
					new MySqlParameter("@CANCEL_DATE", MySqlDbType.Date),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.IMPORT_CODE;
			parameters[2].Value = model.IMPORT_TYPE;
			parameters[3].Value = model.MANUFACTURE_CODE;
			parameters[4].Value = model.MANUFACTURE_NAME;
			parameters[5].Value = model.INVOICE_NO;
			parameters[6].Value = model.ACCOUNT_FLAG;
			parameters[7].Value = model.ACCOUNT_DATE;
			parameters[8].Value = model.ISPAY_FLAG;
			parameters[9].Value = model.PAY_TIME;
			parameters[10].Value = model.CONTRACT_NO;
			parameters[11].Value = model.IMPORT_FLAG;
			parameters[12].Value = model.COST;
			parameters[13].Value = model.CREATE_BY;
			parameters[14].Value = model.CREATE_DATE;
			parameters[15].Value = model.PURCHASER;
			parameters[16].Value = model.PURCHASE_DATE;
			parameters[17].Value = model.CANCEL_OPRATOR;
			parameters[18].Value = model.CANCEL_DATE;
			parameters[19].Value = model.HOSPITAL_CODE;

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
		public bool Update(HisClient.Model.his_ds_import model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_ds_import set ");
			strSql.Append("IMPORT_CODE=@IMPORT_CODE,");
			strSql.Append("IMPORT_TYPE=@IMPORT_TYPE,");
			strSql.Append("MANUFACTURE_CODE=@MANUFACTURE_CODE,");
			strSql.Append("MANUFACTURE_NAME=@MANUFACTURE_NAME,");
			strSql.Append("INVOICE_NO=@INVOICE_NO,");
			strSql.Append("ACCOUNT_FLAG=@ACCOUNT_FLAG,");
			strSql.Append("ACCOUNT_DATE=@ACCOUNT_DATE,");
			strSql.Append("ISPAY_FLAG=@ISPAY_FLAG,");
			strSql.Append("PAY_TIME=@PAY_TIME,");
			strSql.Append("CONTRACT_NO=@CONTRACT_NO,");
			strSql.Append("IMPORT_FLAG=@IMPORT_FLAG,");
			strSql.Append("COST=@COST,");
			strSql.Append("CREATE_BY=@CREATE_BY,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("PURCHASER=@PURCHASER,");
			strSql.Append("PURCHASE_DATE=@PURCHASE_DATE,");
			strSql.Append("CANCEL_OPRATOR=@CANCEL_OPRATOR,");
			strSql.Append("CANCEL_DATE=@CANCEL_DATE,");
			strSql.Append("HOSPITAL_CODE=@HOSPITAL_CODE");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IMPORT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@IMPORT_TYPE", MySqlDbType.VarChar,2),
					new MySqlParameter("@MANUFACTURE_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@MANUFACTURE_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@INVOICE_NO", MySqlDbType.VarChar,128),
					new MySqlParameter("@ACCOUNT_FLAG", MySqlDbType.VarChar,2),
					new MySqlParameter("@ACCOUNT_DATE", MySqlDbType.Date),
					new MySqlParameter("@ISPAY_FLAG", MySqlDbType.VarChar,2),
					new MySqlParameter("@PAY_TIME", MySqlDbType.Date),
					new MySqlParameter("@CONTRACT_NO", MySqlDbType.VarChar,128),
					new MySqlParameter("@IMPORT_FLAG", MySqlDbType.VarChar,20),
					new MySqlParameter("@COST", MySqlDbType.Decimal,12),
					new MySqlParameter("@CREATE_BY", MySqlDbType.VarChar,20),
					new MySqlParameter("@CREATE_DATE", MySqlDbType.Date),
					new MySqlParameter("@PURCHASER", MySqlDbType.VarChar,128),
					new MySqlParameter("@PURCHASE_DATE", MySqlDbType.Date),
					new MySqlParameter("@CANCEL_OPRATOR", MySqlDbType.VarChar,20),
					new MySqlParameter("@CANCEL_DATE", MySqlDbType.Date),
					new MySqlParameter("@HOSPITAL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.IMPORT_CODE;
			parameters[1].Value = model.IMPORT_TYPE;
			parameters[2].Value = model.MANUFACTURE_CODE;
			parameters[3].Value = model.MANUFACTURE_NAME;
			parameters[4].Value = model.INVOICE_NO;
			parameters[5].Value = model.ACCOUNT_FLAG;
			parameters[6].Value = model.ACCOUNT_DATE;
			parameters[7].Value = model.ISPAY_FLAG;
			parameters[8].Value = model.PAY_TIME;
			parameters[9].Value = model.CONTRACT_NO;
			parameters[10].Value = model.IMPORT_FLAG;
			parameters[11].Value = model.COST;
			parameters[12].Value = model.CREATE_BY;
			parameters[13].Value = model.CREATE_DATE;
			parameters[14].Value = model.PURCHASER;
			parameters[15].Value = model.PURCHASE_DATE;
			parameters[16].Value = model.CANCEL_OPRATOR;
			parameters[17].Value = model.CANCEL_DATE;
			parameters[18].Value = model.HOSPITAL_CODE;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from his_ds_import ");
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
			strSql.Append("delete from his_ds_import ");
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
		public HisClient.Model.his_ds_import GetModel(string ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,IMPORT_CODE,IMPORT_TYPE,MANUFACTURE_CODE,MANUFACTURE_NAME,INVOICE_NO,ACCOUNT_FLAG,ACCOUNT_DATE,ISPAY_FLAG,PAY_TIME,CONTRACT_NO,IMPORT_FLAG,COST,CREATE_BY,CREATE_DATE,PURCHASER,PURCHASE_DATE,CANCEL_OPRATOR,CANCEL_DATE,HOSPITAL_CODE from his_ds_import ");
			strSql.Append(" where ID=@ID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;

			HisClient.Model.his_ds_import model=new HisClient.Model.his_ds_import();
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
		public HisClient.Model.his_ds_import DataRowToModel(DataRow row)
		{
			HisClient.Model.his_ds_import model=new HisClient.Model.his_ds_import();
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
				if(row["IMPORT_TYPE"]!=null)
				{
					model.IMPORT_TYPE=row["IMPORT_TYPE"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["INVOICE_NO"]!=null)
				{
					model.INVOICE_NO=row["INVOICE_NO"].ToString();
				}
				if(row["ACCOUNT_FLAG"]!=null)
				{
					model.ACCOUNT_FLAG=row["ACCOUNT_FLAG"].ToString();
				}
				if(row["ACCOUNT_DATE"]!=null && row["ACCOUNT_DATE"].ToString()!="")
				{
					model.ACCOUNT_DATE=DateTime.Parse(row["ACCOUNT_DATE"].ToString());
				}
				if(row["ISPAY_FLAG"]!=null)
				{
					model.ISPAY_FLAG=row["ISPAY_FLAG"].ToString();
				}
				if(row["PAY_TIME"]!=null && row["PAY_TIME"].ToString()!="")
				{
					model.PAY_TIME=DateTime.Parse(row["PAY_TIME"].ToString());
				}
				if(row["CONTRACT_NO"]!=null)
				{
					model.CONTRACT_NO=row["CONTRACT_NO"].ToString();
				}
				if(row["IMPORT_FLAG"]!=null)
				{
					model.IMPORT_FLAG=row["IMPORT_FLAG"].ToString();
				}
				if(row["COST"]!=null && row["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(row["COST"].ToString());
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["PURCHASER"]!=null)
				{
					model.PURCHASER=row["PURCHASER"].ToString();
				}
				if(row["PURCHASE_DATE"]!=null && row["PURCHASE_DATE"].ToString()!="")
				{
					model.PURCHASE_DATE=DateTime.Parse(row["PURCHASE_DATE"].ToString());
				}
				if(row["CANCEL_OPRATOR"]!=null)
				{
					model.CANCEL_OPRATOR=row["CANCEL_OPRATOR"].ToString();
				}
				if(row["CANCEL_DATE"]!=null && row["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(row["CANCEL_DATE"].ToString());
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
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
			strSql.Append("select ID,IMPORT_CODE,IMPORT_TYPE,MANUFACTURE_CODE,MANUFACTURE_NAME,INVOICE_NO,ACCOUNT_FLAG,ACCOUNT_DATE,ISPAY_FLAG,PAY_TIME,CONTRACT_NO,IMPORT_FLAG,COST,CREATE_BY,CREATE_DATE,PURCHASER,PURCHASE_DATE,CANCEL_OPRATOR,CANCEL_DATE,HOSPITAL_CODE ");
			strSql.Append(" FROM his_ds_import ");
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
			strSql.Append("select count(1) FROM his_ds_import ");
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
			strSql.Append(")AS Row, T.*  from his_ds_import T ");
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
			parameters[0].Value = "his_ds_import";
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

