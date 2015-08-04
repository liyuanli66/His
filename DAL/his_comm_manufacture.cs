using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_manufacture
	/// </summary>
	public partial class his_comm_manufacture
	{
		public his_comm_manufacture()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_comm_manufacture");
			strSql.Append(" where ID='"+ID+"' ");
			return DbHelperMySQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_manufacture model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.MANUFACTURE_CODE != null)
			{
				strSql1.Append("MANUFACTURE_CODE,");
				strSql2.Append("'"+model.MANUFACTURE_CODE+"',");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql1.Append("MANUFACTURE_NAME,");
				strSql2.Append("'"+model.MANUFACTURE_NAME+"',");
			}
			if (model.LOCALITY_TYPE != null)
			{
				strSql1.Append("LOCALITY_TYPE,");
				strSql2.Append("'"+model.LOCALITY_TYPE+"',");
			}
			if (model.CREDIT_CODE != null)
			{
				strSql1.Append("CREDIT_CODE,");
				strSql2.Append(""+model.CREDIT_CODE+",");
			}
			if (model.MANUFACTURE_ADDRESS != null)
			{
				strSql1.Append("MANUFACTURE_ADDRESS,");
				strSql2.Append("'"+model.MANUFACTURE_ADDRESS+"',");
			}
			if (model.LINK_MAN != null)
			{
				strSql1.Append("LINK_MAN,");
				strSql2.Append("'"+model.LINK_MAN+"',");
			}
			if (model.LINK_TEL != null)
			{
				strSql1.Append("LINK_TEL,");
				strSql2.Append("'"+model.LINK_TEL+"',");
			}
			if (model.LINK_EMAIL != null)
			{
				strSql1.Append("LINK_EMAIL,");
				strSql2.Append("'"+model.LINK_EMAIL+"',");
			}
			if (model.FAX != null)
			{
				strSql1.Append("FAX,");
				strSql2.Append("'"+model.FAX+"',");
			}
			if (model.APTITUDE != null)
			{
				strSql1.Append("APTITUDE,");
				strSql2.Append("'"+model.APTITUDE+"',");
			}
			if (model.APTITUDE_DATE != null)
			{
				strSql1.Append("APTITUDE_DATE,");
				strSql2.Append("'"+model.APTITUDE_DATE+"',");
			}
			if (model.HELP_CODE != null)
			{
				strSql1.Append("HELP_CODE,");
				strSql2.Append("'"+model.HELP_CODE+"',");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql1.Append("HOSPITAL_CODE,");
				strSql2.Append("'"+model.HOSPITAL_CODE+"',");
			}
			if (model.CREATE_DATE != null)
			{
				strSql1.Append("CREATE_DATE,");
				strSql2.Append("'"+model.CREATE_DATE+"',");
			}
			if (model.CREATE_BY != null)
			{
				strSql1.Append("CREATE_BY,");
				strSql2.Append("'"+model.CREATE_BY+"',");
			}
			strSql.Append("insert into his_comm_manufacture(");
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
		public bool Update(HIS.Model.his_comm_manufacture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_manufacture set ");
			if (model.MANUFACTURE_CODE != null)
			{
				strSql.Append("MANUFACTURE_CODE='"+model.MANUFACTURE_CODE+"',");
			}
			if (model.MANUFACTURE_NAME != null)
			{
				strSql.Append("MANUFACTURE_NAME='"+model.MANUFACTURE_NAME+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_NAME= null ,");
			}
			if (model.LOCALITY_TYPE != null)
			{
				strSql.Append("LOCALITY_TYPE='"+model.LOCALITY_TYPE+"',");
			}
			else
			{
				strSql.Append("LOCALITY_TYPE= null ,");
			}
			if (model.CREDIT_CODE != null)
			{
				strSql.Append("CREDIT_CODE="+model.CREDIT_CODE+",");
			}
			else
			{
				strSql.Append("CREDIT_CODE= null ,");
			}
			if (model.MANUFACTURE_ADDRESS != null)
			{
				strSql.Append("MANUFACTURE_ADDRESS='"+model.MANUFACTURE_ADDRESS+"',");
			}
			else
			{
				strSql.Append("MANUFACTURE_ADDRESS= null ,");
			}
			if (model.LINK_MAN != null)
			{
				strSql.Append("LINK_MAN='"+model.LINK_MAN+"',");
			}
			else
			{
				strSql.Append("LINK_MAN= null ,");
			}
			if (model.LINK_TEL != null)
			{
				strSql.Append("LINK_TEL='"+model.LINK_TEL+"',");
			}
			else
			{
				strSql.Append("LINK_TEL= null ,");
			}
			if (model.LINK_EMAIL != null)
			{
				strSql.Append("LINK_EMAIL='"+model.LINK_EMAIL+"',");
			}
			else
			{
				strSql.Append("LINK_EMAIL= null ,");
			}
			if (model.FAX != null)
			{
				strSql.Append("FAX='"+model.FAX+"',");
			}
			else
			{
				strSql.Append("FAX= null ,");
			}
			if (model.APTITUDE != null)
			{
				strSql.Append("APTITUDE='"+model.APTITUDE+"',");
			}
			else
			{
				strSql.Append("APTITUDE= null ,");
			}
			if (model.APTITUDE_DATE != null)
			{
				strSql.Append("APTITUDE_DATE='"+model.APTITUDE_DATE+"',");
			}
			else
			{
				strSql.Append("APTITUDE_DATE= null ,");
			}
			if (model.HELP_CODE != null)
			{
				strSql.Append("HELP_CODE='"+model.HELP_CODE+"',");
			}
			else
			{
				strSql.Append("HELP_CODE= null ,");
			}
			if (model.HOSPITAL_CODE != null)
			{
				strSql.Append("HOSPITAL_CODE='"+model.HOSPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HOSPITAL_CODE= null ,");
			}
			if (model.CREATE_DATE != null)
			{
				strSql.Append("CREATE_DATE='"+model.CREATE_DATE+"',");
			}
			else
			{
				strSql.Append("CREATE_DATE= null ,");
			}
			if (model.CREATE_BY != null)
			{
				strSql.Append("CREATE_BY='"+model.CREATE_BY+"',");
			}
			else
			{
				strSql.Append("CREATE_BY= null ,");
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
			strSql.Append("delete from his_comm_manufacture ");
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
			strSql.Append("delete from his_comm_manufacture ");
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
		public HIS.Model.his_comm_manufacture GetModel(string ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,MANUFACTURE_CODE,MANUFACTURE_NAME,LOCALITY_TYPE,CREDIT_CODE,MANUFACTURE_ADDRESS,LINK_MAN,LINK_TEL,LINK_EMAIL,FAX,APTITUDE,APTITUDE_DATE,HELP_CODE,HOSPITAL_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" from his_comm_manufacture ");
			strSql.Append(" where ID='"+ID+"' " );
			HIS.Model.his_comm_manufacture model=new HIS.Model.his_comm_manufacture();
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
		public HIS.Model.his_comm_manufacture DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_manufacture model=new HIS.Model.his_comm_manufacture();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["MANUFACTURE_CODE"]!=null)
				{
					model.MANUFACTURE_CODE=row["MANUFACTURE_CODE"].ToString();
				}
				if(row["MANUFACTURE_NAME"]!=null)
				{
					model.MANUFACTURE_NAME=row["MANUFACTURE_NAME"].ToString();
				}
				if(row["LOCALITY_TYPE"]!=null)
				{
					model.LOCALITY_TYPE=row["LOCALITY_TYPE"].ToString();
				}
				if(row["CREDIT_CODE"]!=null && row["CREDIT_CODE"].ToString()!="")
				{
					model.CREDIT_CODE=int.Parse(row["CREDIT_CODE"].ToString());
				}
				if(row["MANUFACTURE_ADDRESS"]!=null)
				{
					model.MANUFACTURE_ADDRESS=row["MANUFACTURE_ADDRESS"].ToString();
				}
				if(row["LINK_MAN"]!=null)
				{
					model.LINK_MAN=row["LINK_MAN"].ToString();
				}
				if(row["LINK_TEL"]!=null)
				{
					model.LINK_TEL=row["LINK_TEL"].ToString();
				}
				if(row["LINK_EMAIL"]!=null)
				{
					model.LINK_EMAIL=row["LINK_EMAIL"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["APTITUDE"]!=null)
				{
					model.APTITUDE=row["APTITUDE"].ToString();
				}
				if(row["APTITUDE_DATE"]!=null && row["APTITUDE_DATE"].ToString()!="")
				{
					model.APTITUDE_DATE=DateTime.Parse(row["APTITUDE_DATE"].ToString());
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["HOSPITAL_CODE"]!=null)
				{
					model.HOSPITAL_CODE=row["HOSPITAL_CODE"].ToString();
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
			strSql.Append("select ID,MANUFACTURE_CODE,MANUFACTURE_NAME,LOCALITY_TYPE,CREDIT_CODE,MANUFACTURE_ADDRESS,LINK_MAN,LINK_TEL,LINK_EMAIL,FAX,APTITUDE,APTITUDE_DATE,HELP_CODE,HOSPITAL_CODE,CREATE_DATE,CREATE_BY ");
			strSql.Append(" FROM his_comm_manufacture ");
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
			strSql.Append("select count(1) FROM his_comm_manufacture ");
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
			strSql.Append(")AS Row, T.*  from his_comm_manufacture T ");
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

