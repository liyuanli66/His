using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace HIS.DAL
{
	/// <summary>
	/// 数据访问类:his_comm_doctor
	/// </summary>
	public partial class his_comm_doctor
	{
		public his_comm_doctor()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HIS.Model.his_comm_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.ID != null)
			{
				strSql1.Append("ID,");
				strSql2.Append("'"+model.ID+"',");
			}
			if (model.DOCTOR_CODE != null)
			{
				strSql1.Append("DOCTOR_CODE,");
				strSql2.Append("'"+model.DOCTOR_CODE+"',");
			}
			if (model.DOCTOR_NAME != null)
			{
				strSql1.Append("DOCTOR_NAME,");
				strSql2.Append("'"+model.DOCTOR_NAME+"',");
			}
			if (model.DEPT_CODE != null)
			{
				strSql1.Append("DEPT_CODE,");
				strSql2.Append("'"+model.DEPT_CODE+"',");
			}
			if (model.HISPITAL_CODE != null)
			{
				strSql1.Append("HISPITAL_CODE,");
				strSql2.Append("'"+model.HISPITAL_CODE+"',");
			}
			if (model.DOCTOR_SEX != null)
			{
				strSql1.Append("DOCTOR_SEX,");
				strSql2.Append("'"+model.DOCTOR_SEX+"',");
			}
			if (model.DOCTOR_TEL != null)
			{
				strSql1.Append("DOCTOR_TEL,");
				strSql2.Append("'"+model.DOCTOR_TEL+"',");
			}
			if (model.DOCTOR_NATION != null)
			{
				strSql1.Append("DOCTOR_NATION,");
				strSql2.Append("'"+model.DOCTOR_NATION+"',");
			}
			if (model.MERRIAGE_CODE != null)
			{
				strSql1.Append("MERRIAGE_CODE,");
				strSql2.Append("'"+model.MERRIAGE_CODE+"',");
			}
			if (model.DOCTOR_EMAIL != null)
			{
				strSql1.Append("DOCTOR_EMAIL,");
				strSql2.Append("'"+model.DOCTOR_EMAIL+"',");
			}
			if (model.DOCTOR_TITLE != null)
			{
				strSql1.Append("DOCTOR_TITLE,");
				strSql2.Append("'"+model.DOCTOR_TITLE+"',");
			}
			if (model.DOCTOR_TITLEGRADE != null)
			{
				strSql1.Append("DOCTOR_TITLEGRADE,");
				strSql2.Append("'"+model.DOCTOR_TITLEGRADE+"',");
			}
			if (model.HELP_CODE != null)
			{
				strSql1.Append("HELP_CODE,");
				strSql2.Append("'"+model.HELP_CODE+"',");
			}
			if (model.REMARK != null)
			{
				strSql1.Append("REMARK,");
				strSql2.Append("'"+model.REMARK+"',");
			}
			strSql.Append("insert into his_comm_doctor(");
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
		public bool Update(HIS.Model.his_comm_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_comm_doctor set ");
			if (model.ID != null)
			{
				strSql.Append("ID='"+model.ID+"',");
			}
			else
			{
				strSql.Append("ID= null ,");
			}
			if (model.DOCTOR_CODE != null)
			{
				strSql.Append("DOCTOR_CODE='"+model.DOCTOR_CODE+"',");
			}
			else
			{
				strSql.Append("DOCTOR_CODE= null ,");
			}
			if (model.DOCTOR_NAME != null)
			{
				strSql.Append("DOCTOR_NAME='"+model.DOCTOR_NAME+"',");
			}
			else
			{
				strSql.Append("DOCTOR_NAME= null ,");
			}
			if (model.DEPT_CODE != null)
			{
				strSql.Append("DEPT_CODE='"+model.DEPT_CODE+"',");
			}
			else
			{
				strSql.Append("DEPT_CODE= null ,");
			}
			if (model.HISPITAL_CODE != null)
			{
				strSql.Append("HISPITAL_CODE='"+model.HISPITAL_CODE+"',");
			}
			else
			{
				strSql.Append("HISPITAL_CODE= null ,");
			}
			if (model.DOCTOR_SEX != null)
			{
				strSql.Append("DOCTOR_SEX='"+model.DOCTOR_SEX+"',");
			}
			else
			{
				strSql.Append("DOCTOR_SEX= null ,");
			}
			if (model.DOCTOR_TEL != null)
			{
				strSql.Append("DOCTOR_TEL='"+model.DOCTOR_TEL+"',");
			}
			else
			{
				strSql.Append("DOCTOR_TEL= null ,");
			}
			if (model.DOCTOR_NATION != null)
			{
				strSql.Append("DOCTOR_NATION='"+model.DOCTOR_NATION+"',");
			}
			else
			{
				strSql.Append("DOCTOR_NATION= null ,");
			}
			if (model.MERRIAGE_CODE != null)
			{
				strSql.Append("MERRIAGE_CODE='"+model.MERRIAGE_CODE+"',");
			}
			else
			{
				strSql.Append("MERRIAGE_CODE= null ,");
			}
			if (model.DOCTOR_EMAIL != null)
			{
				strSql.Append("DOCTOR_EMAIL='"+model.DOCTOR_EMAIL+"',");
			}
			else
			{
				strSql.Append("DOCTOR_EMAIL= null ,");
			}
			if (model.DOCTOR_TITLE != null)
			{
				strSql.Append("DOCTOR_TITLE='"+model.DOCTOR_TITLE+"',");
			}
			else
			{
				strSql.Append("DOCTOR_TITLE= null ,");
			}
			if (model.DOCTOR_TITLEGRADE != null)
			{
				strSql.Append("DOCTOR_TITLEGRADE='"+model.DOCTOR_TITLEGRADE+"',");
			}
			else
			{
				strSql.Append("DOCTOR_TITLEGRADE= null ,");
			}
			if (model.HELP_CODE != null)
			{
				strSql.Append("HELP_CODE='"+model.HELP_CODE+"',");
			}
			else
			{
				strSql.Append("HELP_CODE= null ,");
			}
			if (model.REMARK != null)
			{
				strSql.Append("REMARK='"+model.REMARK+"',");
			}
			else
			{
				strSql.Append("REMARK= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ");
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
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_comm_doctor ");
			strSql.Append(" where " );
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
		public HIS.Model.his_comm_doctor GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ID,DOCTOR_CODE,DOCTOR_NAME,DEPT_CODE,HISPITAL_CODE,DOCTOR_SEX,DOCTOR_TEL,DOCTOR_NATION,MERRIAGE_CODE,DOCTOR_EMAIL,DOCTOR_TITLE,DOCTOR_TITLEGRADE,HELP_CODE,REMARK ");
			strSql.Append(" from his_comm_doctor ");
			strSql.Append(" where " );
			HIS.Model.his_comm_doctor model=new HIS.Model.his_comm_doctor();
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
		public HIS.Model.his_comm_doctor DataRowToModel(DataRow row)
		{
			HIS.Model.his_comm_doctor model=new HIS.Model.his_comm_doctor();
			if (row != null)
			{
				if(row["ID"]!=null)
				{
					model.ID=row["ID"].ToString();
				}
				if(row["DOCTOR_CODE"]!=null)
				{
					model.DOCTOR_CODE=row["DOCTOR_CODE"].ToString();
				}
				if(row["DOCTOR_NAME"]!=null)
				{
					model.DOCTOR_NAME=row["DOCTOR_NAME"].ToString();
				}
				if(row["DEPT_CODE"]!=null)
				{
					model.DEPT_CODE=row["DEPT_CODE"].ToString();
				}
				if(row["HISPITAL_CODE"]!=null)
				{
					model.HISPITAL_CODE=row["HISPITAL_CODE"].ToString();
				}
				if(row["DOCTOR_SEX"]!=null)
				{
					model.DOCTOR_SEX=row["DOCTOR_SEX"].ToString();
				}
				if(row["DOCTOR_TEL"]!=null)
				{
					model.DOCTOR_TEL=row["DOCTOR_TEL"].ToString();
				}
				if(row["DOCTOR_NATION"]!=null)
				{
					model.DOCTOR_NATION=row["DOCTOR_NATION"].ToString();
				}
				if(row["MERRIAGE_CODE"]!=null)
				{
					model.MERRIAGE_CODE=row["MERRIAGE_CODE"].ToString();
				}
				if(row["DOCTOR_EMAIL"]!=null)
				{
					model.DOCTOR_EMAIL=row["DOCTOR_EMAIL"].ToString();
				}
				if(row["DOCTOR_TITLE"]!=null)
				{
					model.DOCTOR_TITLE=row["DOCTOR_TITLE"].ToString();
				}
				if(row["DOCTOR_TITLEGRADE"]!=null)
				{
					model.DOCTOR_TITLEGRADE=row["DOCTOR_TITLEGRADE"].ToString();
				}
				if(row["HELP_CODE"]!=null)
				{
					model.HELP_CODE=row["HELP_CODE"].ToString();
				}
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select ID,DOCTOR_CODE,DOCTOR_NAME,DEPT_CODE,HISPITAL_CODE,DOCTOR_SEX,DOCTOR_TEL,DOCTOR_NATION,MERRIAGE_CODE,DOCTOR_EMAIL,DOCTOR_TITLE,DOCTOR_TITLEGRADE,HELP_CODE,REMARK ");
			strSql.Append(" FROM his_comm_doctor ");
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
			strSql.Append("select count(1) FROM his_comm_doctor ");
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
			strSql.Append(")AS Row, T.*  from his_comm_doctor T ");
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

