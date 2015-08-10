using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_receipt_detail_cancle
	/// </summary>
	public partial class his_hos_receipt_detail_cancle
	{
		public his_hos_receipt_detail_cancle()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_receipt_detail_cancle");
			strSql.Append(" where ID=@ID and HOS_RECEIPT_CODE=@HOS_RECEIPT_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOS_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = HOS_RECEIPT_CODE;
			parameters[2].Value = HIS_HOS_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_hos_receipt_detail_cancle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_hos_receipt_detail_cancle(");
			strSql.Append("ID,HOS_RECEIPT_CODE,HIS_HOS_CODE,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@ID,@HOS_RECEIPT_CODE,@HIS_HOS_CODE,@FEEITEM_CODE,@FEEITEM_NAME,@PRICE,@COUNT,@UNIT,@AMT,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOS_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FEEITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FEEITEM_NAME", MySqlDbType.VarChar,18),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@AMT", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.HOS_RECEIPT_CODE;
			parameters[2].Value = model.HIS_HOS_CODE;
			parameters[3].Value = model.FEEITEM_CODE;
			parameters[4].Value = model.FEEITEM_NAME;
			parameters[5].Value = model.PRICE;
			parameters[6].Value = model.COUNT;
			parameters[7].Value = model.UNIT;
			parameters[8].Value = model.AMT;
			parameters[9].Value = model.OPT_USER;
			parameters[10].Value = model.OPT_DATE;
			parameters[11].Value = model.OPT_TERM;
			parameters[12].Value = model.OPT_ORGA;

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
		public bool Update(HisClient.Model.his_hos_receipt_detail_cancle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_receipt_detail_cancle set ");
			strSql.Append("FEEITEM_CODE=@FEEITEM_CODE,");
			strSql.Append("FEEITEM_NAME=@FEEITEM_NAME,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("COUNT=@COUNT,");
			strSql.Append("UNIT=@UNIT,");
			strSql.Append("AMT=@AMT,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where ID=@ID and HOS_RECEIPT_CODE=@HOS_RECEIPT_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@FEEITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FEEITEM_NAME", MySqlDbType.VarChar,18),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@AMT", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOS_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.FEEITEM_CODE;
			parameters[1].Value = model.FEEITEM_NAME;
			parameters[2].Value = model.PRICE;
			parameters[3].Value = model.COUNT;
			parameters[4].Value = model.UNIT;
			parameters[5].Value = model.AMT;
			parameters[6].Value = model.OPT_USER;
			parameters[7].Value = model.OPT_DATE;
			parameters[8].Value = model.OPT_TERM;
			parameters[9].Value = model.OPT_ORGA;
			parameters[10].Value = model.ID;
			parameters[11].Value = model.HOS_RECEIPT_CODE;
			parameters[12].Value = model.HIS_HOS_CODE;

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
		public bool Delete(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_receipt_detail_cancle ");
			strSql.Append(" where ID=@ID and HOS_RECEIPT_CODE=@HOS_RECEIPT_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOS_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = HOS_RECEIPT_CODE;
			parameters[2].Value = HIS_HOS_CODE;

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
		public HisClient.Model.his_hos_receipt_detail_cancle GetModel(string ID,string HOS_RECEIPT_CODE,string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HOS_RECEIPT_CODE,HIS_HOS_CODE,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_hos_receipt_detail_cancle ");
			strSql.Append(" where ID=@ID and HOS_RECEIPT_CODE=@HOS_RECEIPT_CODE and HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@HOS_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = HOS_RECEIPT_CODE;
			parameters[2].Value = HIS_HOS_CODE;

			HisClient.Model.his_hos_receipt_detail_cancle model=new HisClient.Model.his_hos_receipt_detail_cancle();
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
		public HisClient.Model.his_hos_receipt_detail_cancle DataRowToModel(DataRow row)
		{
			HisClient.Model.his_hos_receipt_detail_cancle model=new HisClient.Model.his_hos_receipt_detail_cancle();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["HOS_RECEIPT_CODE"]!=null)
				{
					model.HOS_RECEIPT_CODE=row["HOS_RECEIPT_CODE"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["FEEITEM_CODE"]!=null)
				{
					model.FEEITEM_CODE=row["FEEITEM_CODE"].ToString();
				}
				if(row["FEEITEM_NAME"]!=null)
				{
					model.FEEITEM_NAME=row["FEEITEM_NAME"].ToString();
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["COUNT"]!=null && row["COUNT"].ToString()!="")
				{
					model.COUNT=decimal.Parse(row["COUNT"].ToString());
				}
				if(row["UNIT"]!=null)
				{
					model.UNIT=row["UNIT"].ToString();
				}
				if(row["AMT"]!=null && row["AMT"].ToString()!="")
				{
					model.AMT=decimal.Parse(row["AMT"].ToString());
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
			strSql.Append("select ID,HOS_RECEIPT_CODE,HIS_HOS_CODE,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_hos_receipt_detail_cancle ");
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
			strSql.Append("select count(1) FROM his_hos_receipt_detail_cancle ");
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
			strSql.Append(")AS Row, T.*  from his_hos_receipt_detail_cancle T ");
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
			parameters[0].Value = "his_hos_receipt_detail_cancle";
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

