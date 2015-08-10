using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
//Please add references
namespace HisClient.DAL
{
	/// <summary>
	/// 数据访问类:his_hos_medical_record
	/// </summary>
	public partial class his_hos_medical_record
	{
		public his_hos_medical_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string HIS_HOS_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from his_hos_medical_record");
			strSql.Append(" where HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HIS_HOS_CODE;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HisClient.Model.his_hos_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into his_hos_medical_record(");
			strSql.Append("IP,HIS_HOS_CODE,Case_Code,Patient_Name,MD_Dept_ID,MD_SickRoom_ID,ME_Bed_ID,In_Date,Out_Date,Status,In_Hospital_Order,Create_by,Update_date,Update_by,is_removed,Help_Code,Create_date,Charge_Doctor_Name,Charge_Nurse_ID,Charge_Nurse_Name,Patient_Pay_Type,NURSING_CLASS,PATIENT_CONDITION,ACCL_ACCT_ID,TYPE,CHANGE_DEPT_HELP,IN_WAY,IN_WAY_Doctor,IS_INFECTION,INTRODUCER,ATTENDING_DOCTOR_ID,IN_HOS_AGE,MD_DEPT_NAME,MD_BED_CODE,MD_SICKROOM_NAME,DOC_EDIT_IS,DOC_EDIT_Account,Nurse_EDIT_IS,Nurse_EDITAccount)");
			strSql.Append(" values (");
			strSql.Append("@IP,@HIS_HOS_CODE,@Case_Code,@Patient_Name,@MD_Dept_ID,@MD_SickRoom_ID,@ME_Bed_ID,@In_Date,@Out_Date,@Status,@In_Hospital_Order,@Create_by,@Update_date,@Update_by,@is_removed,@Help_Code,@Create_date,@Charge_Doctor_Name,@Charge_Nurse_ID,@Charge_Nurse_Name,@Patient_Pay_Type,@NURSING_CLASS,@PATIENT_CONDITION,@ACCL_ACCT_ID,@TYPE,@CHANGE_DEPT_HELP,@IN_WAY,@IN_WAY_Doctor,@IS_INFECTION,@INTRODUCER,@ATTENDING_DOCTOR_ID,@IN_HOS_AGE,@MD_DEPT_NAME,@MD_BED_CODE,@MD_SICKROOM_NAME,@DOC_EDIT_IS,@DOC_EDIT_Account,@Nurse_EDIT_IS,@Nurse_EDITAccount)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IP", MySqlDbType.VarChar,18),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18),
					new MySqlParameter("@Case_Code", MySqlDbType.VarChar,18),
					new MySqlParameter("@Patient_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@MD_Dept_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MD_SickRoom_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@ME_Bed_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@In_Date", MySqlDbType.Date),
					new MySqlParameter("@Out_Date", MySqlDbType.Date),
					new MySqlParameter("@Status", MySqlDbType.VarChar,1),
					new MySqlParameter("@In_Hospital_Order", MySqlDbType.Int32,2),
					new MySqlParameter("@Create_by", MySqlDbType.VarChar,18),
					new MySqlParameter("@Update_date", MySqlDbType.Date),
					new MySqlParameter("@Update_by", MySqlDbType.VarChar,18),
					new MySqlParameter("@is_removed", MySqlDbType.VarChar,1),
					new MySqlParameter("@Help_Code", MySqlDbType.VarChar,18),
					new MySqlParameter("@Create_date", MySqlDbType.Date),
					new MySqlParameter("@Charge_Doctor_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@Charge_Nurse_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@Charge_Nurse_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@Patient_Pay_Type", MySqlDbType.VarChar,18),
					new MySqlParameter("@NURSING_CLASS", MySqlDbType.VarChar,128),
					new MySqlParameter("@PATIENT_CONDITION", MySqlDbType.VarChar,128),
					new MySqlParameter("@ACCL_ACCT_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@TYPE", MySqlDbType.VarChar,10),
					new MySqlParameter("@CHANGE_DEPT_HELP", MySqlDbType.VarChar,512),
					new MySqlParameter("@IN_WAY", MySqlDbType.VarChar,64),
					new MySqlParameter("@IN_WAY_Doctor", MySqlDbType.VarChar,64),
					new MySqlParameter("@IS_INFECTION", MySqlDbType.VarChar,1),
					new MySqlParameter("@INTRODUCER", MySqlDbType.VarChar,64),
					new MySqlParameter("@ATTENDING_DOCTOR_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@IN_HOS_AGE", MySqlDbType.VarChar,32),
					new MySqlParameter("@MD_DEPT_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MD_BED_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@MD_SICKROOM_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOC_EDIT_IS", MySqlDbType.Int32,11),
					new MySqlParameter("@DOC_EDIT_Account", MySqlDbType.VarChar,128),
					new MySqlParameter("@Nurse_EDIT_IS", MySqlDbType.Int32,11),
					new MySqlParameter("@Nurse_EDITAccount", MySqlDbType.VarChar,128)};
			parameters[0].Value = model.IP;
			parameters[1].Value = model.HIS_HOS_CODE;
			parameters[2].Value = model.Case_Code;
			parameters[3].Value = model.Patient_Name;
			parameters[4].Value = model.MD_Dept_ID;
			parameters[5].Value = model.MD_SickRoom_ID;
			parameters[6].Value = model.ME_Bed_ID;
			parameters[7].Value = model.In_Date;
			parameters[8].Value = model.Out_Date;
			parameters[9].Value = model.Status;
			parameters[10].Value = model.In_Hospital_Order;
			parameters[11].Value = model.Create_by;
			parameters[12].Value = model.Update_date;
			parameters[13].Value = model.Update_by;
			parameters[14].Value = model.is_removed;
			parameters[15].Value = model.Help_Code;
			parameters[16].Value = model.Create_date;
			parameters[17].Value = model.Charge_Doctor_Name;
			parameters[18].Value = model.Charge_Nurse_ID;
			parameters[19].Value = model.Charge_Nurse_Name;
			parameters[20].Value = model.Patient_Pay_Type;
			parameters[21].Value = model.NURSING_CLASS;
			parameters[22].Value = model.PATIENT_CONDITION;
			parameters[23].Value = model.ACCL_ACCT_ID;
			parameters[24].Value = model.TYPE;
			parameters[25].Value = model.CHANGE_DEPT_HELP;
			parameters[26].Value = model.IN_WAY;
			parameters[27].Value = model.IN_WAY_Doctor;
			parameters[28].Value = model.IS_INFECTION;
			parameters[29].Value = model.INTRODUCER;
			parameters[30].Value = model.ATTENDING_DOCTOR_ID;
			parameters[31].Value = model.IN_HOS_AGE;
			parameters[32].Value = model.MD_DEPT_NAME;
			parameters[33].Value = model.MD_BED_CODE;
			parameters[34].Value = model.MD_SICKROOM_NAME;
			parameters[35].Value = model.DOC_EDIT_IS;
			parameters[36].Value = model.DOC_EDIT_Account;
			parameters[37].Value = model.Nurse_EDIT_IS;
			parameters[38].Value = model.Nurse_EDITAccount;

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
		public bool Update(HisClient.Model.his_hos_medical_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update his_hos_medical_record set ");
			strSql.Append("IP=@IP,");
			strSql.Append("Case_Code=@Case_Code,");
			strSql.Append("Patient_Name=@Patient_Name,");
			strSql.Append("MD_Dept_ID=@MD_Dept_ID,");
			strSql.Append("MD_SickRoom_ID=@MD_SickRoom_ID,");
			strSql.Append("ME_Bed_ID=@ME_Bed_ID,");
			strSql.Append("In_Date=@In_Date,");
			strSql.Append("Out_Date=@Out_Date,");
			strSql.Append("Status=@Status,");
			strSql.Append("In_Hospital_Order=@In_Hospital_Order,");
			strSql.Append("Create_by=@Create_by,");
			strSql.Append("Update_date=@Update_date,");
			strSql.Append("Update_by=@Update_by,");
			strSql.Append("is_removed=@is_removed,");
			strSql.Append("Help_Code=@Help_Code,");
			strSql.Append("Create_date=@Create_date,");
			strSql.Append("Charge_Doctor_Name=@Charge_Doctor_Name,");
			strSql.Append("Charge_Nurse_ID=@Charge_Nurse_ID,");
			strSql.Append("Charge_Nurse_Name=@Charge_Nurse_Name,");
			strSql.Append("Patient_Pay_Type=@Patient_Pay_Type,");
			strSql.Append("NURSING_CLASS=@NURSING_CLASS,");
			strSql.Append("PATIENT_CONDITION=@PATIENT_CONDITION,");
			strSql.Append("ACCL_ACCT_ID=@ACCL_ACCT_ID,");
			strSql.Append("TYPE=@TYPE,");
			strSql.Append("CHANGE_DEPT_HELP=@CHANGE_DEPT_HELP,");
			strSql.Append("IN_WAY=@IN_WAY,");
			strSql.Append("IN_WAY_Doctor=@IN_WAY_Doctor,");
			strSql.Append("IS_INFECTION=@IS_INFECTION,");
			strSql.Append("INTRODUCER=@INTRODUCER,");
			strSql.Append("ATTENDING_DOCTOR_ID=@ATTENDING_DOCTOR_ID,");
			strSql.Append("IN_HOS_AGE=@IN_HOS_AGE,");
			strSql.Append("MD_DEPT_NAME=@MD_DEPT_NAME,");
			strSql.Append("MD_BED_CODE=@MD_BED_CODE,");
			strSql.Append("MD_SICKROOM_NAME=@MD_SICKROOM_NAME,");
			strSql.Append("DOC_EDIT_IS=@DOC_EDIT_IS,");
			strSql.Append("DOC_EDIT_Account=@DOC_EDIT_Account,");
			strSql.Append("Nurse_EDIT_IS=@Nurse_EDIT_IS,");
			strSql.Append("Nurse_EDITAccount=@Nurse_EDITAccount");
			strSql.Append(" where HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@IP", MySqlDbType.VarChar,18),
					new MySqlParameter("@Case_Code", MySqlDbType.VarChar,18),
					new MySqlParameter("@Patient_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@MD_Dept_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@MD_SickRoom_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@ME_Bed_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@In_Date", MySqlDbType.Date),
					new MySqlParameter("@Out_Date", MySqlDbType.Date),
					new MySqlParameter("@Status", MySqlDbType.VarChar,1),
					new MySqlParameter("@In_Hospital_Order", MySqlDbType.Int32,2),
					new MySqlParameter("@Create_by", MySqlDbType.VarChar,18),
					new MySqlParameter("@Update_date", MySqlDbType.Date),
					new MySqlParameter("@Update_by", MySqlDbType.VarChar,18),
					new MySqlParameter("@is_removed", MySqlDbType.VarChar,1),
					new MySqlParameter("@Help_Code", MySqlDbType.VarChar,18),
					new MySqlParameter("@Create_date", MySqlDbType.Date),
					new MySqlParameter("@Charge_Doctor_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@Charge_Nurse_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@Charge_Nurse_Name", MySqlDbType.VarChar,18),
					new MySqlParameter("@Patient_Pay_Type", MySqlDbType.VarChar,18),
					new MySqlParameter("@NURSING_CLASS", MySqlDbType.VarChar,128),
					new MySqlParameter("@PATIENT_CONDITION", MySqlDbType.VarChar,128),
					new MySqlParameter("@ACCL_ACCT_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@TYPE", MySqlDbType.VarChar,10),
					new MySqlParameter("@CHANGE_DEPT_HELP", MySqlDbType.VarChar,512),
					new MySqlParameter("@IN_WAY", MySqlDbType.VarChar,64),
					new MySqlParameter("@IN_WAY_Doctor", MySqlDbType.VarChar,64),
					new MySqlParameter("@IS_INFECTION", MySqlDbType.VarChar,1),
					new MySqlParameter("@INTRODUCER", MySqlDbType.VarChar,64),
					new MySqlParameter("@ATTENDING_DOCTOR_ID", MySqlDbType.VarChar,18),
					new MySqlParameter("@IN_HOS_AGE", MySqlDbType.VarChar,32),
					new MySqlParameter("@MD_DEPT_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@MD_BED_CODE", MySqlDbType.VarChar,128),
					new MySqlParameter("@MD_SICKROOM_NAME", MySqlDbType.VarChar,128),
					new MySqlParameter("@DOC_EDIT_IS", MySqlDbType.Int32,11),
					new MySqlParameter("@DOC_EDIT_Account", MySqlDbType.VarChar,128),
					new MySqlParameter("@Nurse_EDIT_IS", MySqlDbType.Int32,11),
					new MySqlParameter("@Nurse_EDITAccount", MySqlDbType.VarChar,128),
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)};
			parameters[0].Value = model.IP;
			parameters[1].Value = model.Case_Code;
			parameters[2].Value = model.Patient_Name;
			parameters[3].Value = model.MD_Dept_ID;
			parameters[4].Value = model.MD_SickRoom_ID;
			parameters[5].Value = model.ME_Bed_ID;
			parameters[6].Value = model.In_Date;
			parameters[7].Value = model.Out_Date;
			parameters[8].Value = model.Status;
			parameters[9].Value = model.In_Hospital_Order;
			parameters[10].Value = model.Create_by;
			parameters[11].Value = model.Update_date;
			parameters[12].Value = model.Update_by;
			parameters[13].Value = model.is_removed;
			parameters[14].Value = model.Help_Code;
			parameters[15].Value = model.Create_date;
			parameters[16].Value = model.Charge_Doctor_Name;
			parameters[17].Value = model.Charge_Nurse_ID;
			parameters[18].Value = model.Charge_Nurse_Name;
			parameters[19].Value = model.Patient_Pay_Type;
			parameters[20].Value = model.NURSING_CLASS;
			parameters[21].Value = model.PATIENT_CONDITION;
			parameters[22].Value = model.ACCL_ACCT_ID;
			parameters[23].Value = model.TYPE;
			parameters[24].Value = model.CHANGE_DEPT_HELP;
			parameters[25].Value = model.IN_WAY;
			parameters[26].Value = model.IN_WAY_Doctor;
			parameters[27].Value = model.IS_INFECTION;
			parameters[28].Value = model.INTRODUCER;
			parameters[29].Value = model.ATTENDING_DOCTOR_ID;
			parameters[30].Value = model.IN_HOS_AGE;
			parameters[31].Value = model.MD_DEPT_NAME;
			parameters[32].Value = model.MD_BED_CODE;
			parameters[33].Value = model.MD_SICKROOM_NAME;
			parameters[34].Value = model.DOC_EDIT_IS;
			parameters[35].Value = model.DOC_EDIT_Account;
			parameters[36].Value = model.Nurse_EDIT_IS;
			parameters[37].Value = model.Nurse_EDITAccount;
			parameters[38].Value = model.HIS_HOS_CODE;

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
		public bool Delete(string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HIS_HOS_CODE;

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
		public bool DeleteList(string HIS_HOS_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE in ("+HIS_HOS_CODElist + ")  ");
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
		public HisClient.Model.his_hos_medical_record GetModel(string HIS_HOS_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select IP,HIS_HOS_CODE,Case_Code,Patient_Name,MD_Dept_ID,MD_SickRoom_ID,ME_Bed_ID,In_Date,Out_Date,Status,In_Hospital_Order,Create_by,Update_date,Update_by,is_removed,Help_Code,Create_date,Charge_Doctor_Name,Charge_Nurse_ID,Charge_Nurse_Name,Patient_Pay_Type,NURSING_CLASS,PATIENT_CONDITION,ACCL_ACCT_ID,TYPE,CHANGE_DEPT_HELP,IN_WAY,IN_WAY_Doctor,IS_INFECTION,INTRODUCER,ATTENDING_DOCTOR_ID,IN_HOS_AGE,MD_DEPT_NAME,MD_BED_CODE,MD_SICKROOM_NAME,DOC_EDIT_IS,DOC_EDIT_Account,Nurse_EDIT_IS,Nurse_EDITAccount from his_hos_medical_record ");
			strSql.Append(" where HIS_HOS_CODE=@HIS_HOS_CODE ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@HIS_HOS_CODE", MySqlDbType.VarChar,18)			};
			parameters[0].Value = HIS_HOS_CODE;

			HisClient.Model.his_hos_medical_record model=new HisClient.Model.his_hos_medical_record();
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
		public HisClient.Model.his_hos_medical_record DataRowToModel(DataRow row)
		{
			HisClient.Model.his_hos_medical_record model=new HisClient.Model.his_hos_medical_record();
			if (row != null)
			{
				if(row["IP"]!=null)
				{
					model.IP=row["IP"].ToString();
				}
				if(row["HIS_HOS_CODE"]!=null)
				{
					model.HIS_HOS_CODE=row["HIS_HOS_CODE"].ToString();
				}
				if(row["Case_Code"]!=null)
				{
					model.Case_Code=row["Case_Code"].ToString();
				}
				if(row["Patient_Name"]!=null)
				{
					model.Patient_Name=row["Patient_Name"].ToString();
				}
				if(row["MD_Dept_ID"]!=null)
				{
					model.MD_Dept_ID=row["MD_Dept_ID"].ToString();
				}
				if(row["MD_SickRoom_ID"]!=null)
				{
					model.MD_SickRoom_ID=row["MD_SickRoom_ID"].ToString();
				}
				if(row["ME_Bed_ID"]!=null)
				{
					model.ME_Bed_ID=row["ME_Bed_ID"].ToString();
				}
				if(row["In_Date"]!=null && row["In_Date"].ToString()!="")
				{
					model.In_Date=DateTime.Parse(row["In_Date"].ToString());
				}
				if(row["Out_Date"]!=null && row["Out_Date"].ToString()!="")
				{
					model.Out_Date=DateTime.Parse(row["Out_Date"].ToString());
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["In_Hospital_Order"]!=null && row["In_Hospital_Order"].ToString()!="")
				{
					model.In_Hospital_Order=int.Parse(row["In_Hospital_Order"].ToString());
				}
				if(row["Create_by"]!=null)
				{
					model.Create_by=row["Create_by"].ToString();
				}
				if(row["Update_date"]!=null && row["Update_date"].ToString()!="")
				{
					model.Update_date=DateTime.Parse(row["Update_date"].ToString());
				}
				if(row["Update_by"]!=null)
				{
					model.Update_by=row["Update_by"].ToString();
				}
				if(row["is_removed"]!=null)
				{
					model.is_removed=row["is_removed"].ToString();
				}
				if(row["Help_Code"]!=null)
				{
					model.Help_Code=row["Help_Code"].ToString();
				}
				if(row["Create_date"]!=null && row["Create_date"].ToString()!="")
				{
					model.Create_date=DateTime.Parse(row["Create_date"].ToString());
				}
				if(row["Charge_Doctor_Name"]!=null)
				{
					model.Charge_Doctor_Name=row["Charge_Doctor_Name"].ToString();
				}
				if(row["Charge_Nurse_ID"]!=null)
				{
					model.Charge_Nurse_ID=row["Charge_Nurse_ID"].ToString();
				}
				if(row["Charge_Nurse_Name"]!=null)
				{
					model.Charge_Nurse_Name=row["Charge_Nurse_Name"].ToString();
				}
				if(row["Patient_Pay_Type"]!=null)
				{
					model.Patient_Pay_Type=row["Patient_Pay_Type"].ToString();
				}
				if(row["NURSING_CLASS"]!=null)
				{
					model.NURSING_CLASS=row["NURSING_CLASS"].ToString();
				}
				if(row["PATIENT_CONDITION"]!=null)
				{
					model.PATIENT_CONDITION=row["PATIENT_CONDITION"].ToString();
				}
				if(row["ACCL_ACCT_ID"]!=null)
				{
					model.ACCL_ACCT_ID=row["ACCL_ACCT_ID"].ToString();
				}
				if(row["TYPE"]!=null)
				{
					model.TYPE=row["TYPE"].ToString();
				}
				if(row["CHANGE_DEPT_HELP"]!=null)
				{
					model.CHANGE_DEPT_HELP=row["CHANGE_DEPT_HELP"].ToString();
				}
				if(row["IN_WAY"]!=null)
				{
					model.IN_WAY=row["IN_WAY"].ToString();
				}
				if(row["IN_WAY_Doctor"]!=null)
				{
					model.IN_WAY_Doctor=row["IN_WAY_Doctor"].ToString();
				}
				if(row["IS_INFECTION"]!=null)
				{
					model.IS_INFECTION=row["IS_INFECTION"].ToString();
				}
				if(row["INTRODUCER"]!=null)
				{
					model.INTRODUCER=row["INTRODUCER"].ToString();
				}
				if(row["ATTENDING_DOCTOR_ID"]!=null)
				{
					model.ATTENDING_DOCTOR_ID=row["ATTENDING_DOCTOR_ID"].ToString();
				}
				if(row["IN_HOS_AGE"]!=null)
				{
					model.IN_HOS_AGE=row["IN_HOS_AGE"].ToString();
				}
				if(row["MD_DEPT_NAME"]!=null)
				{
					model.MD_DEPT_NAME=row["MD_DEPT_NAME"].ToString();
				}
				if(row["MD_BED_CODE"]!=null)
				{
					model.MD_BED_CODE=row["MD_BED_CODE"].ToString();
				}
				if(row["MD_SICKROOM_NAME"]!=null)
				{
					model.MD_SICKROOM_NAME=row["MD_SICKROOM_NAME"].ToString();
				}
				if(row["DOC_EDIT_IS"]!=null && row["DOC_EDIT_IS"].ToString()!="")
				{
					model.DOC_EDIT_IS=int.Parse(row["DOC_EDIT_IS"].ToString());
				}
				if(row["DOC_EDIT_Account"]!=null)
				{
					model.DOC_EDIT_Account=row["DOC_EDIT_Account"].ToString();
				}
				if(row["Nurse_EDIT_IS"]!=null && row["Nurse_EDIT_IS"].ToString()!="")
				{
					model.Nurse_EDIT_IS=int.Parse(row["Nurse_EDIT_IS"].ToString());
				}
				if(row["Nurse_EDITAccount"]!=null)
				{
					model.Nurse_EDITAccount=row["Nurse_EDITAccount"].ToString();
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
			strSql.Append("select IP,HIS_HOS_CODE,Case_Code,Patient_Name,MD_Dept_ID,MD_SickRoom_ID,ME_Bed_ID,In_Date,Out_Date,Status,In_Hospital_Order,Create_by,Update_date,Update_by,is_removed,Help_Code,Create_date,Charge_Doctor_Name,Charge_Nurse_ID,Charge_Nurse_Name,Patient_Pay_Type,NURSING_CLASS,PATIENT_CONDITION,ACCL_ACCT_ID,TYPE,CHANGE_DEPT_HELP,IN_WAY,IN_WAY_Doctor,IS_INFECTION,INTRODUCER,ATTENDING_DOCTOR_ID,IN_HOS_AGE,MD_DEPT_NAME,MD_BED_CODE,MD_SICKROOM_NAME,DOC_EDIT_IS,DOC_EDIT_Account,Nurse_EDIT_IS,Nurse_EDITAccount ");
			strSql.Append(" FROM his_hos_medical_record ");
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
			strSql.Append("select count(1) FROM his_hos_medical_record ");
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
			strSql.Append(")AS Row, T.*  from his_hos_medical_record T ");
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
			parameters[0].Value = "his_hos_medical_record";
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

