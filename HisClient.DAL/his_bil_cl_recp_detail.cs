using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_bil_cl_recp_detail
	/// </summary>
	public partial class his_bil_cl_recp_detail
	{
		public his_bil_cl_recp_detail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_bil_cl_recp_detail");
			strSql.Append(" where ID=@ID and CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_RECEIPT_CODE;
			parameters[2].Value = CL_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_bil_cl_recp_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_bil_cl_recp_detail(");
			strSql.Append("ID,CL_RECEIPT_CODE,CL_CODE,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT)");
			strSql.Append(" values (");
			strSql.Append("@ID,@CL_RECEIPT_CODE,@CL_CODE,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA,@FEEITEM_CODE,@FEEITEM_NAME,@PRICE,@COUNT,@UNIT,@AMT)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@FEEITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FEEITEM_NAME", MySqlDbType.VarChar,18),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@AMT", MySqlDbType.Float,10)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CL_RECEIPT_CODE;
			parameters[2].Value = model.CL_CODE;
			parameters[3].Value = model.OPT_USER;
			parameters[4].Value = model.OPT_DATE;
			parameters[5].Value = model.OPT_TERM;
			parameters[6].Value = model.OPT_ORGA;
			parameters[7].Value = model.FEEITEM_CODE;
			parameters[8].Value = model.FEEITEM_NAME;
			parameters[9].Value = model.PRICE;
			parameters[10].Value = model.COUNT;
			parameters[11].Value = model.UNIT;
			parameters[12].Value = model.AMT;

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
		public bool Update(HisClient.Model.his_bil_cl_recp_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_bil_cl_recp_detail set ");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA,");
			strSql.Append("FEEITEM_CODE=@FEEITEM_CODE,");
			strSql.Append("FEEITEM_NAME=@FEEITEM_NAME,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("COUNT=@COUNT,");
			strSql.Append("UNIT=@UNIT,");
			strSql.Append("AMT=@AMT");
			strSql.Append(" where ID=@ID and CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@FEEITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@FEEITEM_NAME", MySqlDbType.VarChar,18),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@AMT", MySqlDbType.Float,10),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.OPT_USER;
			parameters[1].Value = model.OPT_DATE;
			parameters[2].Value = model.OPT_TERM;
			parameters[3].Value = model.OPT_ORGA;
			parameters[4].Value = model.FEEITEM_CODE;
			parameters[5].Value = model.FEEITEM_NAME;
			parameters[6].Value = model.PRICE;
			parameters[7].Value = model.COUNT;
			parameters[8].Value = model.UNIT;
			parameters[9].Value = model.AMT;
			parameters[10].Value = model.ID;
			parameters[11].Value = model.CL_RECEIPT_CODE;
			parameters[12].Value = model.CL_CODE;

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
		public bool Delete(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_bil_cl_recp_detail ");
			strSql.Append(" where ID=@ID and CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_RECEIPT_CODE;
			parameters[2].Value = CL_CODE;

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
		public HisClient.Model.his_bil_cl_recp_detail GetModel(string ID,string CL_RECEIPT_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CL_RECEIPT_CODE,CL_CODE,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT from his_bil_cl_recp_detail ");
			strSql.Append(" where ID=@ID and CL_RECEIPT_CODE=@CL_RECEIPT_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_RECEIPT_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_RECEIPT_CODE;
			parameters[2].Value = CL_CODE;

			HisClient.Model.his_bil_cl_recp_detail model=new HisClient.Model.his_bil_cl_recp_detail();
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
		public HisClient.Model.his_bil_cl_recp_detail DataRowToModel(DataRow row)
		{
			HisClient.Model.his_bil_cl_recp_detail model=new HisClient.Model.his_bil_cl_recp_detail();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CL_RECEIPT_CODE"]!=null)
				{
					model.CL_RECEIPT_CODE=row["CL_RECEIPT_CODE"].ToString();
				}
				if(row["CL_CODE"]!=null)
				{
					model.CL_CODE=row["CL_CODE"].ToString();
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CL_RECEIPT_CODE,CL_CODE,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA,FEEITEM_CODE,FEEITEM_NAME,PRICE,COUNT,UNIT,AMT ");
			strSql.Append(" FROM his_bil_cl_recp_detail ");
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
			strSql.Append("select count(1) FROM his_bil_cl_recp_detail ");
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
			strSql.Append(")AS Row, T.*  from his_bil_cl_recp_detail T ");
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
			parameters[0].Value = "his_bil_cl_recp_detail";
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

