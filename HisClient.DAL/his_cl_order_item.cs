using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_cl_order_item
	/// </summary>
	public partial class his_cl_order_item
	{
		public his_cl_order_item()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_cl_order_item");
			strSql.Append(" where ID=@ID and CL_PRES_CODE=@CL_PRES_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_PRES_CODE;
			parameters[2].Value = CL_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_cl_order_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_cl_order_item(");
			strSql.Append("ID,CL_PRES_CODE,CL_CODE,ITEM_CODE,ITEM_NAME,COUNT,PRICE,ITEM_TYPE,SPEC,UNIT,SUM_AMT,STATUS,HERB_NUM,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA)");
			strSql.Append(" values (");
			strSql.Append("@ID,@CL_PRES_CODE,@CL_CODE,@ITEM_CODE,@ITEM_NAME,@COUNT,@PRICE,@ITEM_TYPE,@SPEC,@UNIT,@SUM_AMT,@STATUS,@HERB_NUM,@OPT_USER,@OPT_DATE,@OPT_TERM,@OPT_ORGA)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ITEM_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@ITEM_TYPE", MySqlDbType.VarChar,1),
					new MySqlParameter("@SPEC", MySqlDbType.VarChar,128),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,1),
					new MySqlParameter("@HERB_NUM", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CL_PRES_CODE;
			parameters[2].Value = model.CL_CODE;
			parameters[3].Value = model.ITEM_CODE;
			parameters[4].Value = model.ITEM_NAME;
			parameters[5].Value = model.COUNT;
			parameters[6].Value = model.PRICE;
			parameters[7].Value = model.ITEM_TYPE;
			parameters[8].Value = model.SPEC;
			parameters[9].Value = model.UNIT;
			parameters[10].Value = model.SUM_AMT;
			parameters[11].Value = model.STATUS;
			parameters[12].Value = model.HERB_NUM;
			parameters[13].Value = model.OPT_USER;
			parameters[14].Value = model.OPT_DATE;
			parameters[15].Value = model.OPT_TERM;
			parameters[16].Value = model.OPT_ORGA;

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
		public bool Update(HisClient.Model.his_cl_order_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_cl_order_item set ");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("COUNT=@COUNT,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("SPEC=@SPEC,");
			strSql.Append("UNIT=@UNIT,");
			strSql.Append("SUM_AMT=@SUM_AMT,");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("HERB_NUM=@HERB_NUM,");
			strSql.Append("OPT_USER=@OPT_USER,");
			strSql.Append("OPT_DATE=@OPT_DATE,");
			strSql.Append("OPT_TERM=@OPT_TERM,");
			strSql.Append("OPT_ORGA=@OPT_ORGA");
			strSql.Append(" where ID=@ID and CL_PRES_CODE=@CL_PRES_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ITEM_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@ITEM_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@COUNT", MySqlDbType.Float,10),
					new MySqlParameter("@PRICE", MySqlDbType.Float,10),
					new MySqlParameter("@ITEM_TYPE", MySqlDbType.VarChar,1),
					new MySqlParameter("@SPEC", MySqlDbType.VarChar,128),
					new MySqlParameter("@UNIT", MySqlDbType.VarChar,128),
					new MySqlParameter("@SUM_AMT", MySqlDbType.Float,10),
					new MySqlParameter("@STATUS", MySqlDbType.VarChar,1),
					new MySqlParameter("@HERB_NUM", MySqlDbType.Float,10),
					new MySqlParameter("@OPT_USER", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_DATE", MySqlDbType.Date),
					new MySqlParameter("@OPT_TERM", MySqlDbType.VarChar,128),
					new MySqlParameter("@OPT_ORGA", MySqlDbType.VarChar,128),
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.ITEM_CODE;
			parameters[1].Value = model.ITEM_NAME;
			parameters[2].Value = model.COUNT;
			parameters[3].Value = model.PRICE;
			parameters[4].Value = model.ITEM_TYPE;
			parameters[5].Value = model.SPEC;
			parameters[6].Value = model.UNIT;
			parameters[7].Value = model.SUM_AMT;
			parameters[8].Value = model.STATUS;
			parameters[9].Value = model.HERB_NUM;
			parameters[10].Value = model.OPT_USER;
			parameters[11].Value = model.OPT_DATE;
			parameters[12].Value = model.OPT_TERM;
			parameters[13].Value = model.OPT_ORGA;
			parameters[14].Value = model.ID;
			parameters[15].Value = model.CL_PRES_CODE;
			parameters[16].Value = model.CL_CODE;

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
		public bool Delete(string ID,string CL_PRES_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_cl_order_item ");
			strSql.Append(" where ID=@ID and CL_PRES_CODE=@CL_PRES_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_PRES_CODE;
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
		public HisClient.Model.his_cl_order_item GetModel(string ID,string CL_PRES_CODE,string CL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CL_PRES_CODE,CL_CODE,ITEM_CODE,ITEM_NAME,COUNT,PRICE,ITEM_TYPE,SPEC,UNIT,SUM_AMT,STATUS,HERB_NUM,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA from his_cl_order_item ");
			strSql.Append(" where ID=@ID and CL_PRES_CODE=@CL_PRES_CODE and CL_CODE=@CL_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_PRES_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@CL_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = ID;
			parameters[1].Value = CL_PRES_CODE;
			parameters[2].Value = CL_CODE;

			HisClient.Model.his_cl_order_item model=new HisClient.Model.his_cl_order_item();
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
		public HisClient.Model.his_cl_order_item DataRowToModel(DataRow row)
		{
			HisClient.Model.his_cl_order_item model=new HisClient.Model.his_cl_order_item();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["CL_PRES_CODE"]!=null)
				{
					model.CL_PRES_CODE=row["CL_PRES_CODE"].ToString();
				}
				if(row["CL_CODE"]!=null)
				{
					model.CL_CODE=row["CL_CODE"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["COUNT"]!=null && row["COUNT"].ToString()!="")
				{
					model.COUNT=decimal.Parse(row["COUNT"].ToString());
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["SPEC"]!=null)
				{
					model.SPEC=row["SPEC"].ToString();
				}
				if(row["UNIT"]!=null)
				{
					model.UNIT=row["UNIT"].ToString();
				}
				if(row["SUM_AMT"]!=null && row["SUM_AMT"].ToString()!="")
				{
					model.SUM_AMT=decimal.Parse(row["SUM_AMT"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["HERB_NUM"]!=null && row["HERB_NUM"].ToString()!="")
				{
					model.HERB_NUM=decimal.Parse(row["HERB_NUM"].ToString());
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
			strSql.Append("select ID,CL_PRES_CODE,CL_CODE,ITEM_CODE,ITEM_NAME,COUNT,PRICE,ITEM_TYPE,SPEC,UNIT,SUM_AMT,STATUS,HERB_NUM,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" FROM his_cl_order_item ");
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
			strSql.Append("select count(1) FROM his_cl_order_item ");
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
			strSql.Append(")AS Row, T.*  from his_cl_order_item T ");
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
			parameters[0].Value = "his_cl_order_item";
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

