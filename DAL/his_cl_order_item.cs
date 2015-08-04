using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_cl_order_item
	/// </summary>
	public partial class his_cl_order_item
	{
		public his_cl_order_item()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID,string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_cl_order_item");
			strSql.Append(" where ID='"+ID+"' and CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_cl_order_item model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.CL_PRES_CODE != null)
			{
				strSql1.Append("CL_PRES_CODE,");
				strSql2.Append("'"+model.CL_PRES_CODE+"',");
			}
			if (model.CL_CODE != null)
			{
				strSql1.Append("CL_CODE,");
				strSql2.Append("'"+model.CL_CODE+"',");
			}
			if (model.ITEM_CODE != null)
			{
				strSql1.Append("ITEM_CODE,");
				strSql2.Append("'"+model.ITEM_CODE+"',");
			}
			if (model.ITEM_NAME != null)
			{
				strSql1.Append("ITEM_NAME,");
				strSql2.Append("'"+model.ITEM_NAME+"',");
			}
			if (model.COUNT != null)
			{
				strSql1.Append("COUNT,");
				strSql2.Append(""+model.COUNT+",");
			}
			if (model.PRICE != null)
			{
				strSql1.Append("PRICE,");
				strSql2.Append(""+model.PRICE+",");
			}
			if (model.ITEM_TYPE != null)
			{
				strSql1.Append("ITEM_TYPE,");
				strSql2.Append("'"+model.ITEM_TYPE+"',");
			}
			if (model.SPEC != null)
			{
				strSql1.Append("SPEC,");
				strSql2.Append("'"+model.SPEC+"',");
			}
			if (model.UNIT != null)
			{
				strSql1.Append("UNIT,");
				strSql2.Append("'"+model.UNIT+"',");
			}
			if (model.SUM_AMT != null)
			{
				strSql1.Append("SUM_AMT,");
				strSql2.Append(""+model.SUM_AMT+",");
			}
			if (model.STATUS != null)
			{
				strSql1.Append("STATUS,");
				strSql2.Append("'"+model.STATUS+"',");
			}
			if (model.HERB_NUM != null)
			{
				strSql1.Append("HERB_NUM,");
				strSql2.Append(""+model.HERB_NUM+",");
			}
			if (model.OPT_USER != null)
			{
				strSql1.Append("OPT_USER,");
				strSql2.Append("'"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql1.Append("OPT_DATE,");
				strSql2.Append("'"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql1.Append("OPT_TERM,");
				strSql2.Append("'"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql1.Append("OPT_ORGA,");
				strSql2.Append("'"+model.OPT_ORGA+"',");
			}
			strSql.Append("insert into his_cl_order_item(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
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
		/// 更新一条数据
		/// </summary>
		public bool Update(HIS.Model.his_cl_order_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_cl_order_item set ");
			if (model.ITEM_CODE != null)
			{
				strSql.Append("ITEM_CODE='"+model.ITEM_CODE+"',");
			}
			else
			{
				strSql.Append("ITEM_CODE= null ,");
			}
			if (model.ITEM_NAME != null)
			{
				strSql.Append("ITEM_NAME='"+model.ITEM_NAME+"',");
			}
			else
			{
				strSql.Append("ITEM_NAME= null ,");
			}
			if (model.COUNT != null)
			{
				strSql.Append("COUNT="+model.COUNT+",");
			}
			else
			{
				strSql.Append("COUNT= null ,");
			}
			if (model.PRICE != null)
			{
				strSql.Append("PRICE="+model.PRICE+",");
			}
			else
			{
				strSql.Append("PRICE= null ,");
			}
			if (model.ITEM_TYPE != null)
			{
				strSql.Append("ITEM_TYPE='"+model.ITEM_TYPE+"',");
			}
			else
			{
				strSql.Append("ITEM_TYPE= null ,");
			}
			if (model.SPEC != null)
			{
				strSql.Append("SPEC='"+model.SPEC+"',");
			}
			else
			{
				strSql.Append("SPEC= null ,");
			}
			if (model.UNIT != null)
			{
				strSql.Append("UNIT='"+model.UNIT+"',");
			}
			else
			{
				strSql.Append("UNIT= null ,");
			}
			if (model.SUM_AMT != null)
			{
				strSql.Append("SUM_AMT="+model.SUM_AMT+",");
			}
			else
			{
				strSql.Append("SUM_AMT= null ,");
			}
			if (model.STATUS != null)
			{
				strSql.Append("STATUS='"+model.STATUS+"',");
			}
			else
			{
				strSql.Append("STATUS= null ,");
			}
			if (model.HERB_NUM != null)
			{
				strSql.Append("HERB_NUM="+model.HERB_NUM+",");
			}
			else
			{
				strSql.Append("HERB_NUM= null ,");
			}
			if (model.OPT_USER != null)
			{
				strSql.Append("OPT_USER='"+model.OPT_USER+"',");
			}
			if (model.OPT_DATE != null)
			{
				strSql.Append("OPT_DATE='"+model.OPT_DATE+"',");
			}
			if (model.OPT_TERM != null)
			{
				strSql.Append("OPT_TERM='"+model.OPT_TERM+"',");
			}
			if (model.OPT_ORGA != null)
			{
				strSql.Append("OPT_ORGA='"+model.OPT_ORGA+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' and CL_PRES_CODE='"+ model.CL_PRES_CODE+"' and CL_CODE='"+ model.CL_CODE+"' ");
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
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
			strSql.Append(" where ID='"+ID+"' and CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
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
		public HIS.Model.his_cl_order_item GetModel(string ID,string CL_PRES_CODE,string CL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,CL_PRES_CODE,CL_CODE,ITEM_CODE,ITEM_NAME,COUNT,PRICE,ITEM_TYPE,SPEC,UNIT,SUM_AMT,STATUS,HERB_NUM,OPT_USER,OPT_DATE,OPT_TERM,OPT_ORGA ");
			strSql.Append(" from his_cl_order_item ");
			strSql.Append(" where ID='"+ID+"' and CL_PRES_CODE='"+CL_PRES_CODE+"' and CL_CODE='"+CL_CODE+"' " );
			HIS.Model.his_cl_order_item model=new HIS.Model.his_cl_order_item();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString());
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
		public HIS.Model.his_cl_order_item DataRowToModel(DataRow row)
		{
			HIS.Model.his_cl_order_item model=new HIS.Model.his_cl_order_item();
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
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

