using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_ds_export
	/// </summary>
	public partial class his_ds_export
	{
		public his_ds_export()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_ds_export");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_ds_export model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.EXPORT_CODE != null)
			{
				strSql1.Append("EXPORT_CODE,");
				strSql2.Append("'"+model.EXPORT_CODE+"',");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql1.Append("MANUFACTURE_NAME,");
				strSql2.Append("'"+model.MANUFACTURE_NAME+"',");
			}
			if (model.MANUFACTURE_CODE != null)
			{
				strSql1.Append("MANUFACTURE_CODE,");
				strSql2.Append("'"+model.MANUFACTURE_CODE+"',");
			}
			if (model.EXPORT_TYPE != null)
			{
				strSql1.Append("EXPORT_TYPE,");
				strSql2.Append("'"+model.EXPORT_TYPE+"',");
			}
			if (model.EXPORT_DEPT != null)
			{
				strSql1.Append("EXPORT_DEPT,");
				strSql2.Append("'"+model.EXPORT_DEPT+"',");
			}
			if (model.CREATE_BY != null)
			{
				strSql1.Append("CREATE_BY,");
				strSql2.Append("'"+model.CREATE_BY+"',");
			}
			if (model.CREATE_DATE != null)
			{
				strSql1.Append("CREATE_DATE,");
				strSql2.Append("'"+model.CREATE_DATE+"',");
			}
			if (model.COST != null)
			{
				strSql1.Append("COST,");
				strSql2.Append(""+model.COST+",");
			}
			if (model.OPERATOR_NAME != null)
			{
				strSql1.Append("OPERATOR_NAME,");
				strSql2.Append("'"+model.OPERATOR_NAME+"',");
			}
			if (model.OPERATOR_DATE != null)
			{
				strSql1.Append("OPERATOR_DATE,");
				strSql2.Append("'"+model.OPERATOR_DATE+"',");
			}
			if (model.CANCEL_OPERATOR != null)
			{
				strSql1.Append("CANCEL_OPERATOR,");
				strSql2.Append("'"+model.CANCEL_OPERATOR+"',");
			}
			if (model.CANCEL_DATE != null)
			{
				strSql1.Append("CANCEL_DATE,");
				strSql2.Append("'"+model.CANCEL_DATE+"',");
			}
			strSql.Append("insert into his_ds_export(");
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
		public bool Update(HIS.Model.his_ds_export model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_ds_export set ");
			if (model.EXPORT_CODE != null)
			{
				strSql.Append("EXPORT_CODE='"+model.EXPORT_CODE+"',");
			}
			else
			{
				strSql.Append("EXPORT_CODE= null ,");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql.Append("MANUFACTURE_NAME='"+model.MANUFACTURE_NAME+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_NAME= null ,");
			}
			if (model.MANUFACTURE_CODE != null)
			{
				strSql.Append("MANUFACTURE_CODE='"+model.MANUFACTURE_CODE+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_CODE= null ,");
			}
			if (model.EXPORT_TYPE != null)
			{
				strSql.Append("EXPORT_TYPE='"+model.EXPORT_TYPE+"',");
			}
			else
			{
				strSql.Append("EXPORT_TYPE= null ,");
			}
			if (model.EXPORT_DEPT != null)
			{
				strSql.Append("EXPORT_DEPT='"+model.EXPORT_DEPT+"',");
			}
			else
			{
				strSql.Append("EXPORT_DEPT= null ,");
			}
			if (model.CREATE_BY != null)
			{
				strSql.Append("CREATE_BY='"+model.CREATE_BY+"',");
			}
			else
			{
				strSql.Append("CREATE_BY= null ,");
			}
			if (model.CREATE_DATE != null)
			{
				strSql.Append("CREATE_DATE='"+model.CREATE_DATE+"',");
			}
			else
			{
				strSql.Append("CREATE_DATE= null ,");
			}
			if (model.COST != null)
			{
				strSql.Append("COST="+model.COST+",");
			}
			else
			{
				strSql.Append("COST= null ,");
			}
			if (model.OPERATOR_NAME != null)
			{
				strSql.Append("OPERATOR_NAME='"+model.OPERATOR_NAME+"',");
			}
			else
			{
				strSql.Append("OPERATOR_NAME= null ,");
			}
			if (model.OPERATOR_DATE != null)
			{
				strSql.Append("OPERATOR_DATE='"+model.OPERATOR_DATE+"',");
			}
			else
			{
				strSql.Append("OPERATOR_DATE= null ,");
			}
			if (model.CANCEL_OPERATOR != null)
			{
				strSql.Append("CANCEL_OPERATOR='"+model.CANCEL_OPERATOR+"',");
			}
			else
			{
				strSql.Append("CANCEL_OPERATOR= null ,");
			}
			if (model.CANCEL_DATE != null)
			{
				strSql.Append("CANCEL_DATE='"+model.CANCEL_DATE+"',");
			}
			else
			{
				strSql.Append("CANCEL_DATE= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ID='"+ model.ID+"' ");
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
		public bool Delete(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_ds_export ");
			strSql.Append(" where ID='"+ID+"' " );
			int rowsAffected=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_ds_export ");
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
		public HIS.Model.his_ds_export GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,EXPORT_CODE,MANUFACTURE_NAME,MANUFACTURE_CODE,EXPORT_TYPE,EXPORT_DEPT,CREATE_BY,CREATE_DATE,COST,OPERATOR_NAME,OPERATOR_DATE,CANCEL_OPERATOR,CANCEL_DATE ");
			strSql.Append(" from his_ds_export ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_ds_export model=new HIS.Model.his_ds_export();
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
		public HIS.Model.his_ds_export DataRowToModel(DataRow row)
		{
			HIS.Model.his_ds_export model=new HIS.Model.his_ds_export();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["EXPORT_CODE"]!=null)
				{
					model.EXPORT_CODE=row["EXPORT_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["EXPORT_TYPE"]!=null)
				{
					model.EXPORT_TYPE=row["EXPORT_TYPE"].ToString();
				}
				if(row["EXPORT_DEPT"]!=null)
				{
					model.EXPORT_DEPT=row["EXPORT_DEPT"].ToString();
				}
				if(row["CREATE_BY"]!=null)
				{
					model.CREATE_BY=row["CREATE_BY"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["COST"]!=null && row["COST"].ToString()!="")
				{
					model.COST=decimal.Parse(row["COST"].ToString());
				}
				if(row["OPERATOR_NAME"]!=null)
				{
					model.OPERATOR_NAME=row["OPERATOR_NAME"].ToString();
				}
				if(row["OPERATOR_DATE"]!=null && row["OPERATOR_DATE"].ToString()!="")
				{
					model.OPERATOR_DATE=DateTime.Parse(row["OPERATOR_DATE"].ToString());
				}
				if(row["CANCEL_OPERATOR"]!=null)
				{
					model.CANCEL_OPERATOR=row["CANCEL_OPERATOR"].ToString();
				}
				if(row["CANCEL_DATE"]!=null && row["CANCEL_DATE"].ToString()!="")
				{
					model.CANCEL_DATE=DateTime.Parse(row["CANCEL_DATE"].ToString());
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
			strSql.Append("select ID,EXPORT_CODE,MANUFACTURE_NAME,MANUFACTURE_CODE,EXPORT_TYPE,EXPORT_DEPT,CREATE_BY,CREATE_DATE,COST,OPERATOR_NAME,OPERATOR_DATE,CANCEL_OPERATOR,CANCEL_DATE ");
			strSql.Append(" FROM his_ds_export ");
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
			strSql.Append("select count(1) FROM his_ds_export ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from his_ds_export T ");
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

