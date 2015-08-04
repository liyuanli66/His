
CREATE TABLE COMM_ICD10
(
	ID                   VARCHAR(18) NOT NULL,
	ICD_CODE             VARCHAR(18) NULL,
	ICD_NAME             VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	TYPE_CODE            VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKCOMM_ICD10 ON COMM_ICD10
(
	ID
);



ALTER TABLE COMM_ICD10
ADD PRIMARY KEY (ID);



CREATE TABLE COMM_ICD10_TYPE
(
	TYPE_CODE            VARCHAR(18) NULL,
	ID                   VARCHAR(18) NOT NULL,
	TYPE_NAME            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKCOMM_ICD10_TYPE ON COMM_ICD10_TYPE
(
	ID
);



ALTER TABLE COMM_ICD10_TYPE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_ACCOUNT
(
	ID                   VARCHAR(18) NOT NULL,
	ACCOUNT              VARCHAR(128) NULL,
	PASSWORD             VARCHAR(128) NULL,
	ROLE_CODE            VARCHAR(18) NULL,
	USER_CODE            VARCHAR(18) NULL,
	ADMIN_TYPE           VARCHAR(2) NULL,
	IS_USE               VARCHAR(2) NULL,
	AUTHORITY_XML        VARCHAR(4000) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL,
	LAST_LOGINTIME       DATE NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_ ON HIS_COMM_ACCOUNT
(
	ID
);



ALTER TABLE HIS_COMM_ACCOUNT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_DEPT
(
	ID                   VARCHAR(18) NOT NULL,
	DEPT_CODE            VARCHAR(18) NULL,
	DEPT_NAME            VARCHAR(20) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	DEPT_TYPE            VARCHAR(18) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_DEPT ON HIS_COMM_DEPT
(
	ID
);



ALTER TABLE HIS_COMM_DEPT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_DICT_INFO
(
	ID                   VARCHAR(18) NOT NULL,
	TYPE_CODE            VARCHAR(18) NULL,
	DICT_CODE            VARCHAR(18) NULL,
	DICT_NAME            VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_DICT_ ON HIS_COMM_DICT_INFO
(
	ID
);



ALTER TABLE HIS_COMM_DICT_INFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_DICT_TYPE
(
	ID                   VARCHAR(18) NOT NULL,
	TYPE_CODE            VARCHAR(18) NULL,
	TYPE_NAME            VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_DICT_TYPE ON HIS_COMM_DICT_TYPE
(
	ID
);



ALTER TABLE HIS_COMM_DICT_TYPE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_DOCTOR
(
	ID                   VARCHAR(18) NULL,
	DOCTOR_CODE          VARCHAR(18) NULL,
	DOCTOR_NAME          VARCHAR(128) NULL,
	DEPT_CODE            VARCHAR(18) NULL,
	HISPITAL_CODE        VARCHAR(18) NULL,
	DOCTOR_SEX           VARCHAR(18) NULL,
	DOCTOR_TEL           VARCHAR(128) NULL,
	DOCTOR_NATION        VARCHAR(18) NULL,
	MERRIAGE_CODE        VARCHAR(18) NULL,
	DOCTOR_EMAIL         VARCHAR(128) NULL,
	DOCTOR_TITLE         VARCHAR(18) NULL,
	DOCTOR_TITLEGRADE    VARCHAR(18) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	REMARK               VARCHAR(128) NULL
);



CREATE TABLE HIS_COMM_DOSAGE
(
	ID                   VARCHAR(18) NOT NULL,
	DOSAGE_CODE          VARCHAR(18) NULL,
	DOSAGE_NAME          VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_ ON HIS_COMM_DOSAGE
(
	ID
);



ALTER TABLE HIS_COMM_DOSAGE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_EFFICACY
(
	ID                   VARCHAR(18) NOT NULL,
	EFFICACY_CODE        VARCHAR(18) NULL,
	EFFICACY_NAME        VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_ ON HIS_COMM_EFFICACY
(
	ID
);



ALTER TABLE HIS_COMM_EFFICACY
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_FEEITEM
(
	ID                   VARCHAR(18) NOT NULL,
	FEEITEM_CODE         VARCHAR(18) NULL,
	FEEITEM_NAME         VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	FEEITEM_TYPE         VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_ ON HIS_COMM_FEEITEM
(
	ID
);



ALTER TABLE HIS_COMM_FEEITEM
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_FUNCTION
(
	ID                   VARCHAR(18) NOT NULL,
	MODULE_CODE          VARCHAR(18) NULL,
	FUNCTION_CODE        VARCHAR(18) NULL,
	FUNCTION_NAME        VARCHAR(128) NULL,
	IS_USE               VARCHAR(2) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	REMARKS              VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_FUNCTION ON HIS_COMM_FUNCTION
(
	ID
);



ALTER TABLE HIS_COMM_FUNCTION
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_HOSPITAL
(
	ID                   VARCHAR(18) NOT NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	HOSPITAL_NAME        VARCHAR(128) NULL,
	HOSPITAL_LEVEL       VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_HOSPITAL ON HIS_COMM_HOSPITAL
(
	ID
);



ALTER TABLE HIS_COMM_HOSPITAL
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_MANUFACTURE
(
	ID                   VARCHAR(18) NOT NULL,
	MANUFACTURE_CODE     VARCHAR(18) NOT NULL,
	MANUFACTURE_NAME     VARCHAR(128) NULL,
	LOCALITY_TYPE        VARCHAR(2) NULL,
	CREDIT_CODE          INTEGER NULL,
	MANUFACTURE_ADDRESS  VARCHAR(128) NULL,
	LINK_MAN             VARCHAR(128) NULL,
	LINK_TEL             VARCHAR(128) NULL,
	LINK_EMAIL           VARCHAR(128) NULL,
	FAX                  VARCHAR(128) NULL,
	APTITUDE             VARCHAR(128) NULL,
	APTITUDE_DATE        DATE NULL,
	HELP_CODE            VARCHAR(18) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_ ON HIS_COMM_MANUFACTURE
(
	ID
);



ALTER TABLE HIS_COMM_MANUFACTURE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_MEDINFO
(
	ID                   VARCHAR(18) NOT NULL,
	MED_CODE             VARCHAR(18) NULL,
	MED_NAME             VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	MENUFACTURE_CODE     VARCHAR(18) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_UNIT             VARCHAR(128) NULL,
	DOSAGE_CODE          VARCHAR(18) NULL,
	APPROVAL_NUMBER      VARCHAR(128) NULL,
	EFFICACY_CODE        VARCHAR(18) NULL,
	ORIGIN               VARCHAR(128) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	PAKAGE_UNIT          VARCHAR(20) NULL,
	PAKAGE_PM_NUMBER     INTEGER NULL,
	DEFAULT_DOSAGE_AMOUNT DECIMAL(12,4) NULL,
	_default___561       CHAR(18) NULL,
	_default___751       CHAR(18) NULL,
	_default_            CHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_MEDINFO ON HIS_COMM_MEDINFO
(
	ID
);



ALTER TABLE HIS_COMM_MEDINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_MEDNAME
(
	ID                   VARCHAR(18) NOT NULL,
	MED_CODE             VARCHAR(18) NULL,
	MED_NAME             VARCHAR(128) NULL,
	TYPE_CODE            VARCHAR(18) NULL,
	HELP_CODE            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL,
	_default___528       CHAR(18) NULL,
	_default_            CHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_MEDNAME ON HIS_COMM_MEDNAME
(
	ID
);



ALTER TABLE HIS_COMM_MEDNAME
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_MEDTYPE
(
	ID                   VARCHAR(18) NOT NULL,
	TYPE_CODE            VARCHAR(18) NULL,
	TYPE_NAME            VARCHAR(128) NULL,
	HELP_CODE            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_MEDTYPE ON HIS_COMM_MEDTYPE
(
	ID
);



ALTER TABLE HIS_COMM_MEDTYPE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_MODULE
(
	ID                   VARCHAR(18) NOT NULL,
	MODULE_NAME          VARCHAR(128) NULL,
	MODULE_CODE          VARCHAR(18) NULL,
	SYSTEM_CODE          VARCHAR(18) NULL,
	IS_USE               VARCHAR(2) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	REMARK               CHAR(128) NULL,
	_default_            CHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_MODLE ON HIS_COMM_MODULE
(
	ID
);



ALTER TABLE HIS_COMM_MODULE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_ROLE
(
	ID                   VARCHAR(18) NOT NULL,
	ROLE_CODE            VARCHAR(18) NULL,
	ROLE_NAME            VARCHAR(128) NULL,
	ROLE_XML             VARCHAR(4000) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	IS_USE               VARCHAR(2) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKCOMM_DICT ON HIS_COMM_ROLE
(
	ID
);



ALTER TABLE HIS_COMM_ROLE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_COMM_SYSTEM
(
	ID                   VARCHAR(18) NOT NULL,
	SYSTEM_CODE          VARCHAR(18) NULL,
	SYSTEM_NAME          VARCHAR(128) NULL,
	IS_USER              VARCHAR(2) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_COMM_SYSTEM ON HIS_COMM_SYSTEM
(
	ID
);



ALTER TABLE HIS_COMM_SYSTEM
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_CHANGEPRICE
(
	ID                   VARCHAR(18) NOT NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL,
	MEMO                 VARCHAR(128) NULL,
	CHANGE_CODE          VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_CHANGEPRICE ON HIS_DS_CHANGEPRICE
(
	ID
);



ALTER TABLE HIS_DS_CHANGEPRICE
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_CHANGEPRICEINFO
(
	ID                   VARCHAR(18) NOT NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_NAME             VARCHAR(128) NULL,
	MED_SPC              VARCHAR(20) NULL,
	VALIDITY_DATE        DATE NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(20) NULL,
	PAKAGE_UNIT          VARCHAR(128) NULL,
	MED_MADETIME         DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	NEW_PRICE            NUMERIC(12,4) NULL,
	CHANGE_CODE          VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_CHANGEPRICEINFO ON HIS_DS_CHANGEPRICEINFO
(
	ID
);



ALTER TABLE HIS_DS_CHANGEPRICEINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_EXPORT
(
	ID                   VARCHAR(18) NOT NULL,
	EXPORT_CODE          VARCHAR(18) NULL,
	MANUFACTURE_NAME     VARCHAR(128) NULL,
	MANUFACTURE_CODE     VARCHAR(18) NULL,
	EXPORT_TYPE          VARCHAR(2) NULL,
	EXPORT_DEPT          VARCHAR(18) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	COST                 NUMERIC(12,4) NULL,
	OPERATOR_NAME        VARCHAR(128) NULL,
	OPERATOR_DATE        DATE NULL,
	CANCEL_OPERATOR      VARCHAR(20) NULL,
	CANCEL_DATE          DATE NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_EXPORT ON HIS_DS_EXPORT
(
	ID
);



ALTER TABLE HIS_DS_EXPORT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_EXPORTINFO
(
	ID                   VARCHAR(18) NOT NULL,
	EXPORT_CODE          VARCHAR(18) NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_CODE             VARCHAR(18) NULL,
	MED_NAME             VARCHAR(20) NULL,
	PAKAGE_UNIT          VARCHAR(20) NULL,
	PAKAGE_AMOUNT        NUMERIC(12,4) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	MED_MADETIME         DATE NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_EXPORTINFO ON HIS_DS_EXPORTINFO
(
	ID
);



ALTER TABLE HIS_DS_EXPORTINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_IMPORT
(
	ID                   VARCHAR(18) NOT NULL,
	IMPORT_CODE          VARCHAR(18) NULL,
	IMPORT_TYPE          VARCHAR(2) NULL,
	MANUFACTURE_CODE     VARCHAR(18) NULL,
	MANUFACTURE_NAME     VARCHAR(128) NULL,
	INVOICE_NO           VARCHAR(128) NULL,
	ACCOUNT_FLAG         VARCHAR(2) NULL,
	ACCOUNT_DATE         DATE NULL,
	ISPAY_FLAG           VARCHAR(2) NULL,
	PAY_TIME             DATE NULL,
	CONTRACT_NO          VARCHAR(128) NULL,
	IMPORT_FLAG          VARCHAR(20) NULL,
	COST                 NUMERIC(12,4) NULL,
	CREATE_BY            VARCHAR(20) NULL,
	CREATE_DATE          DATE NULL,
	PURCHASER            VARCHAR(128) NULL,
	PURCHASE_DATE        DATE NULL,
	CANCEL_OPRATOR       VARCHAR(20) NULL,
	CANCEL_DATE          DATE NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_IMPORT ON HIS_DS_IMPORT
(
	ID
);



ALTER TABLE HIS_DS_IMPORT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_IMPORTINFO
(
	ID                   VARCHAR(18) NOT NULL,
	IMPORT_CODE          VARCHAR(18) NULL,
	MED_CODE             VARCHAR(18) NULL,
	MED_NAME             VARCHAR(128) NULL,
	PAKAGE_UNIT          VARCHAR(128) NULL,
	PAKAGE_AMOUNT        INTEGER NULL,
	MENUFACTURE_CODE     VARCHAR(20) NULL,
	MEDINFO_CODE         VARCHAR(20) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	BATCHNO              VARCHAR(20) NULL,
	MED_MADETIME         DATE NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_IMPORTINFO ON HIS_DS_IMPORTINFO
(
	ID
);



ALTER TABLE HIS_DS_IMPORTINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_DS_STOCK
(
	ID                   VARCHAR(18) NOT NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_NAME             VARCHAR(128) NULL,
	MED_SPC              VARCHAR(20) NULL,
	VALIDITY_DATE        DATE NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(20) NULL,
	PAKAGE_UNIT          VARCHAR(128) NULL,
	MED_MADETIME         DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	PAKAGE_AMOUNT        NUMERIC(12,4) NULL
);



CREATE UNIQUE INDEX XPKHIS_DS_STOCK ON HIS_DS_STOCK
(
	ID
);



ALTER TABLE HIS_DS_STOCK
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_CHECK
(
	ID                   VARCHAR(18) NOT NULL,
	CHECK_CODE           VARCHAR(18) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	DEPT_CODE            VARCHAR(18) NULL,
	DEPT_NAME            VARCHAR(128) NULL,
	MEMO                 VARCHAR(128) NULL,
	LOSE_COST            NUMERIC(12,4) NULL,
	PROFIT_COST          NUMERIC(12,4) NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_CHECK ON HIS_PM_CHECK
(
	ID
);



ALTER TABLE HIS_PM_CHECK
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_CHECKINFO
(
	ID                   VARCHAR(18) NOT NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_UNIT             VARCHAR(128) NULL,
	MED_AMOUNT           NUMERIC(12,4) NULL,
	REAL_AMOUNT          NUMERIC(12,4) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	MED_MADETIME         DATE NULL,
	BACHNO               VARCHAR(128) NULL,
	DEPT_CODE            VARCHAR(18) NULL,
	CREATE_DATE          DATE NULL,
	CREATE_BY            VARCHAR(128) NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_CHECKINFO ON HIS_PM_CHECKINFO
(
	ID
);



ALTER TABLE HIS_PM_CHECKINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_EXPORT
(
	ID                   VARCHAR(18) NOT NULL,
	EXPORT_CODE          VARCHAR(18) NULL,
	RECEIVE_DEPT_CODE    VARCHAR(20) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	SEND_DEPT_CODE       VARCHAR(18) NULL,
	HOSPITAL_CODE        VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_EXPORT ON HIS_PM_EXPORT
(
	ID
);



ALTER TABLE HIS_PM_EXPORT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_EXPORTINFO
(
	ID                   VARCHAR(18) NOT NULL,
	EXPORT_CODE          VARCHAR(18) NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_UNIT             VARCHAR(128) NULL,
	MED_AMOUNT           NUMERIC(12,4) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	MED_MADETIME         DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_EXPORTINFO ON HIS_PM_EXPORTINFO
(
	ID
);



ALTER TABLE HIS_PM_EXPORTINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_IMPORT
(
	ID                   VARCHAR(18) NOT NULL,
	SEND_DEPT_CODE       VARCHAR(18) NULL,
	RECEIVE_DEPT_CODE    VARCHAR(18) NULL,
	PAKAGE_OUT_CODE      VARCHAR(18) NULL,
	CREATE_BY            VARCHAR(128) NULL,
	CREATE_DATE          DATE NULL,
	IMPORT_CODE          VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_IMPORT ON HIS_PM_IMPORT
(
	ID
);



ALTER TABLE HIS_PM_IMPORT
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_IMPORTINFO
(
	IMPORT_CODE          VARCHAR(18) NULL,
	ID                   VARCHAR(18) NOT NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_UNIT             VARCHAR(128) NULL,
	MED_AMOUNT           NUMERIC(12,4) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	MED_MADETIME         DATE NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_IMPORTINFO ON HIS_PM_IMPORTINFO
(
	ID
);



ALTER TABLE HIS_PM_IMPORTINFO
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_PM_STOCK
(
	ID                   VARCHAR(18) NOT NULL,
	MEDINFO_CODE         VARCHAR(18) NULL,
	MED_SPC              VARCHAR(128) NULL,
	MED_UNIT             VARCHAR(128) NULL,
	MED_AMOUNT           NUMERIC(12,4) NULL,
	MED_PRICE            NUMERIC(12,4) NULL,
	PURCHASE_PRICE       NUMERIC(12,4) NULL,
	WHOLESALE_PRICE      NUMERIC(12,4) NULL,
	VALIDITY_DATE        DATE NULL,
	MED_MADETIME         DATE NULL,
	BATCHNO              VARCHAR(128) NULL,
	DEPT_CODE            VARCHAR(18) NULL
);



CREATE UNIQUE INDEX XPKHIS_PM_STOCK ON HIS_PM_STOCK
(
	ID
);



ALTER TABLE HIS_PM_STOCK
ADD PRIMARY KEY (ID);



CREATE TABLE HIS_BIL_CL_RECEIPT
(
	CL_RECEIPT_CODE      NVARCHAR(18) NOT NULL ,
	CL_CODE              NVARCHAR(18) NOT NULL ,
	CASHIER              NVARCHAR(18) NOT NULL ,
	RECEICPT_CODE        NVARCHAR(128) NOT NULL ,
	RECIVER_TIME         DATE NOT NULL ,
	CASH_AMT             FLOAT(10,2) NOT NULL ,
	CARD_AMT             FLOAT(10,2) NOT NULL ,
	INSURANCE_AMT        FLOAT(10,2) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	REFUND_RECP_CODE     NVARCHAR(128) NULL ,
	REFUND_DATE          DATE NULL ,
	REFUND_OPT           NVARCHAR(18) NULL ,
	REDUCE_AMT           INTEGER NULL ,
	REDUCE_DATE          DATE NULL ,
	REDUCE_OPT           NVARCHAR(18) NULL ,
	REDUCE_REASON        NVARCHAR(128) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_BIL_CL_RECEIPT ON HIS_BIL_CL_RECEIPT
(CL_RECEIPT_CODE   ASC,CL_CODE   ASC);



ALTER TABLE HIS_BIL_CL_RECEIPT
	ADD CONSTRAINT  XPKHIS_BIL_CL_RECEIPT PRIMARY KEY (CL_RECEIPT_CODE,CL_CODE);



CREATE TABLE HIS_BIL_CL_RECP_DETAIL
(
	ID                   NVARCHAR(18) NOT NULL ,
	CL_RECEIPT_CODE      NVARCHAR(18) NOT NULL ,
	CL_CODE              NVARCHAR(18) NOT NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL ,
	FEEITEM_CODE         NVARCHAR(18) NOT NULL ,
	FEEITEM_NAME         NVARCHAR(18) NOT NULL ,
	PRICE                FLOAT(10,4) NOT NULL ,
	COUNT                FLOAT(10,2) NULL ,
	UNIT                 NVARCHAR(128) NULL ,
	AMT                  FLOAT(10,2) NULL 
);



CREATE UNIQUE INDEX XPKHIS_BIL_CL_RECP_DETAIL ON HIS_BIL_CL_RECP_DETAIL
(ID   ASC,CL_RECEIPT_CODE   ASC,CL_CODE   ASC);



ALTER TABLE HIS_BIL_CL_RECP_DETAIL
	ADD CONSTRAINT  XPKHIS_BIL_CL_RECP_DETAIL PRIMARY KEY (ID,CL_RECEIPT_CODE,CL_CODE);



CREATE TABLE HIS_BIL_COUNTER
(
	ID                   NVARCHAR(18) NOT NULL ,
	CASHIER              NVARCHAR(128) NOT NULL ,
	START_IVNNO          NVARCHAR(20) NOT NULL ,
	END_IVNNO            NVARCHAR(20) NOT NULL ,
	RECP_TYPE            NVARCHAR(20) NULL ,
	USE_TYPE             NVARCHAR(2) NOT NULL ,
	RECP_COUNT           FLOAT(5,0) NOT NULL ,
	PRE_CODE             NVARCHAR(20) NULL ,
	REFOUNDED_COUNT      FLOAT(5,0) NOT NULL ,
	INVALID_COUNT        FLOAT(5,0) NOT NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_BIL_COUNTER ON HIS_BIL_COUNTER
(ID   ASC);



ALTER TABLE HIS_BIL_COUNTER
	ADD CONSTRAINT  XPKHIS_BIL_COUNTER PRIMARY KEY (ID);



CREATE TABLE HIS_CL_DAILY_STATEMENT
(
	ID                   NVARCHAR(18) NOT NULL ,
	OPERATOR             NVARCHAR(18) NULL ,
	OPERATE_TIME         DATE NULL ,
	RECIVER              NVARCHAR(18) NULL ,
	START_TIME           DATE NULL ,
	END_TIME             DATE NULL ,
	START_RECEIPT_CODE   NVARCHAR(18) NULL ,
	END_RECEIPT_CODE     NVARCHAR(18) NULL ,
	RECEIPT__NUM         NVARCHAR(18) NULL ,
	RETUEN_RECEIPT_NUM   NVARCHAR(18) NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_DAILY_STATEMENT ON HIS_CL_DAILY_STATEMENT
(ID   ASC);



ALTER TABLE HIS_CL_DAILY_STATEMENT
	ADD CONSTRAINT  XPKHIS_CL_DAILY_STATEMENT PRIMARY KEY (ID);



CREATE TABLE HIS_CL_DAILY_STATEMENT_ITEMTYP
(
	ID                   NVARCHAR(18) NOT NULL ,
	DAILY_CODE           NVARCHAR(18) NOT NULL ,
	ITEM_TYPE            NVARCHAR(20) NULL ,
	ITEM_SUM_PAY         INTEGER NULL ,
	ITEM_CASH_PAY        INTEGER NULL ,
	ITEM_CARD_PAY        INTEGER NULL ,
	ITEM_INSURANCE_PAY   INTEGER NULL ,
	STATUS               NVARCHAR(20) NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_DAILY_STATEMENT_ITEM ON HIS_CL_DAILY_STATEMENT_ITEMTYP
(ID   ASC,DAILY_CODE   ASC);



ALTER TABLE HIS_CL_DAILY_STATEMENT_ITEMTYP
	ADD CONSTRAINT  XPKHIS_CL_DAILY_STATEMENT_ITEM PRIMARY KEY (ID,DAILY_CODE);



CREATE TABLE HIS_CL_MEDICAL_RECORD
(
	CL_CODE              NVARCHAR(18) NOT NULL ,
	PHA_CODE             NVARCHAR(18) NOT NULL ,
	DOCTOR_CODE          NVARCHAR(18) NULL ,
	CL_DATE              DATE NULL ,
	IP                   NVARCHAR(18) NULL ,
	ICD_CODE             NVARCHAR(128) NULL ,
	ICD_NAME             NVARCHAR(128) NULL ,
	MEMO                 NVARCHAR(128) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_MEDICAL_RECORD ON HIS_CL_MEDICAL_RECORD
(CL_CODE   ASC);



ALTER TABLE HIS_CL_MEDICAL_RECORD
	ADD CONSTRAINT  XPKHIS_CL_MEDICAL_RECORD PRIMARY KEY (CL_CODE);



CREATE TABLE HIS_CL_ORDER_ITEM
(
	ID                   NVARCHAR(18) NOT NULL ,
	CL_PRES_CODE         NVARCHAR(18) NOT NULL ,
	CL_CODE              NVARCHAR(18) NOT NULL ,
	ITEM_CODE            NVARCHAR(18) NULL ,
	ITEM_NAME            NVARCHAR(128) NULL ,
	COUNT                FLOAT(10,4) NULL ,
	PRICE                FLOAT(10,4) NULL ,
	ITEM_TYPE            NVARCHAR(1) NULL ,
	SPEC                 NVARCHAR(128) NULL ,
	UNIT                 NVARCHAR(128) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	STATUS               NVARCHAR(1) NULL ,
	HERB_NUM             FLOAT(10,4) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_ORDER_ITEM ON HIS_CL_ORDER_ITEM
(ID   ASC,CL_PRES_CODE   ASC,CL_CODE   ASC);



ALTER TABLE HIS_CL_ORDER_ITEM
	ADD CONSTRAINT  XPKHIS_CL_ORDER_ITEM PRIMARY KEY (ID,CL_PRES_CODE,CL_CODE);



CREATE TABLE HIS_CL_PRES_DETAIL_CANCLE
(
	ID                   NVARCHAR(18) NOT NULL ,
	CL_PRES_CODE         NVARCHAR(18) NOT NULL ,
	CL_CODE              NVARCHAR(18) NOT NULL ,
	STATUS               NVARCHAR(2) NULL ,
	APPLY_DEPT_CODE      NVARCHAR(18) NULL ,
	DOCTOR_CODE          NVARCHAR(18) NULL ,
	OPERATE_DEPT_CODE    NVARCHAR(18) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_PRES_DETAIL_CANCLE ON HIS_CL_PRES_DETAIL_CANCLE
(ID   ASC,CL_PRES_CODE   ASC,CL_CODE   ASC);



ALTER TABLE HIS_CL_PRES_DETAIL_CANCLE
	ADD CONSTRAINT  XPKHIS_CL_PRES_DETAIL_CANCLE PRIMARY KEY (ID,CL_PRES_CODE,CL_CODE);



CREATE TABLE HIS_CL_PRESCRIPTION
(
	CL_PRES_CODE         NVARCHAR(18) NOT NULL ,
	CL_CODE              NVARCHAR(18) NOT NULL ,
	STATUS               NVARCHAR(1) NULL ,
	APPLY_DEPT_CODE      NVARCHAR(18) NULL ,
	DOCTOR_CODE          NVARCHAR(18) NULL ,
	OPERATE_DEPT_CODE    NVARCHAR(18) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_CL_PRESCRIPTION ON HIS_CL_PRESCRIPTION
(CL_PRES_CODE   ASC,CL_CODE   ASC);



ALTER TABLE HIS_CL_PRESCRIPTION
	ADD CONSTRAINT  XPKHIS_CL_PRESCRIPTION PRIMARY KEY (CL_PRES_CODE,CL_CODE);



CREATE TABLE HIS_HOS_ACCOUNT
(
	HOS_ACC_CODE         NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	IP                   NVARCHAR(18) NOT NULL ,
	SUM_IN               FLOAT(10,2) NOT NULL ,
	SUM_OUT              FLOAT(10,2) NOT NULL ,
	ACCOUNT_BALANCE      FLOAT(10,2) NULL ,
	LOWER_LIMIT          FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_ACCOUNT ON HIS_HOS_ACCOUNT
(HOS_ACC_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_ACCOUNT
	ADD CONSTRAINT  XPKHIS_HOS_ACCOUNT PRIMARY KEY (HOS_ACC_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_ACCOUNT_LOG
(
	ID                   NVARCHAR(18) NOT NULL ,
	HOS_ACC_CODE         NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	AMT                  FLOAT(12,2) NULL ,
	PAY_TYPE             NVARCHAR(1) NULL ,
	IS_REFUND            NVARCHAR(1) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_ACCOUNT_LOG ON HIS_HOS_ACCOUNT_LOG
(ID   ASC,HOS_ACC_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_ACCOUNT_LOG
	ADD CONSTRAINT  XPKHIS_HOS_ACCOUNT_LOG PRIMARY KEY (ID,HOS_ACC_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_DAILY_STATEMENT
(
	OPERATOR             NVARCHAR(18) NULL ,
	OPERATE_TIME         DATE NULL ,
	RECIVER              NVARCHAR(18) NULL ,
	START_TIME           DATE NULL ,
	END_TIME             DATE NULL ,
	START_RECEIPT_CODE   NVARCHAR(18) NULL ,
	END_RECEIPT_CODE     NVARCHAR(18) NULL ,
	RECEIPT__NUM         NVARCHAR(18) NULL ,
	RETUEN_RECEIPT_NUM   NVARCHAR(18) NULL ,
	ID                   NVARCHAR(18) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_DAILY_STATEMENT ON HIS_HOS_DAILY_STATEMENT
(ID   ASC);



ALTER TABLE HIS_HOS_DAILY_STATEMENT
	ADD CONSTRAINT  XPKHIS_HOS_DAILY_STATEMENT PRIMARY KEY (ID);



CREATE TABLE HIS_HOS_DAILY_STATEMENT_ITEMTY
(
	ID                   NVARCHAR(18) NOT NULL ,
	ITEM_TYPE            NVARCHAR(20) NULL ,
	ITEM_SUM_PAY         INTEGER NULL ,
	ITEM_CASH_PAY        INTEGER NULL ,
	ITEM_CARD_PAY        INTEGER NULL ,
	ITEM_INSURANCE_PAY   INTEGER NULL ,
	STATUS               NVARCHAR(20) NULL ,
	DAILY_CODE           NVARCHAR(18) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_DAILY_STATEMENT_ITE ON HIS_HOS_DAILY_STATEMENT_ITEMTY
(ID   ASC,DAILY_CODE   ASC);



ALTER TABLE HIS_HOS_DAILY_STATEMENT_ITEMTY
	ADD CONSTRAINT  XPKHIS_HOS_DAILY_STATEMENT_ITE PRIMARY KEY (ID,DAILY_CODE);



CREATE TABLE HIS_HOS_MEDICAL_RECORD
(
	IP                   NVARCHAR(18) NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	Case_Code            NVARCHAR(18) NULL ,
	Patient_Name         NVARCHAR(18) NULL ,
	MD_Dept_ID           FLOAT(18) NULL ,
	MD_SickRoom_ID       FLOAT(18) NULL ,
	ME_Bed_ID            FLOAT(1) NULL ,
	In_Date              DATE NULL ,
	Out_Date             DATE NULL ,
	Status               FLOAT(1) NULL ,
	In_Hospital_Order    FLOAT(2) NULL ,
	Create_by            NVARCHAR(18) NULL ,
	Update_date          DATE NULL ,
	Update_by            NVARCHAR(18) NULL ,
	is_removed           FLOAT(1) NULL ,
	Help_Code            NVARCHAR(18) NULL ,
	Create_date          DATE NULL ,
	Charge_Doctor_Name   NVARCHAR(18) NULL ,
	Charge_Nurse_ID      FLOAT(18) NULL ,
	Charge_Nurse_Name    NVARCHAR(18) NULL ,
	Patient_Pay_Type     NVARCHAR(18) NULL ,
	NURSING_CLASS        NVARCHAR(128) NULL ,
	PATIENT_CONDITION    NVARCHAR(128) NULL ,
	ACCL_ACCT_ID         INTEGER NULL ,
	TYPE                 NVARCHAR(10) NULL ,
	CHANGE_DEPT_HELP     NVARCHAR(512) NULL ,
	IN_WAY               NVARCHAR(64) NULL ,
	IN_WAY_Doctor        NVARCHAR(64) NULL ,
	IS_INFECTION         FLOAT(2) NULL ,
	INTRODUCER           NVARCHAR(64) NULL ,
	ATTENDING_DOCTOR_ID  INTEGER NULL ,
	IN_HOS_AGE           NVARCHAR(32) NULL ,
	MD_DEPT_NAME         NVARCHAR(128) NULL ,
	MD_BED_CODE          NVARCHAR(128) NULL ,
	MD_SICKROOM_NAME     NVARCHAR(128) NULL ,
	DOC_EDIT_IS          INTEGER NULL ,
	DOC_EDIT_Account     NVARCHAR(128) NULL ,
	Nurse_EDIT_IS        INTEGER NULL ,
	Nurse_EDITAccount    NVARCHAR(128) NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_MEDICAL_RECORD ON HIS_HOS_MEDICAL_RECORD
(HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_MEDICAL_RECORD
	ADD CONSTRAINT  XPKHIS_HOS_MEDICAL_RECORD PRIMARY KEY (HIS_HOS_CODE);



CREATE TABLE HIS_HOS_MONTHLY_STATEMENT
(
	OPERATOR             NVARCHAR(18) NULL ,
	OPERATE_TIME         DATE NULL ,
	RECIVER              NVARCHAR(18) NULL ,
	START_TIME           DATE NULL ,
	END_TIME             DATE NULL ,
	START_RECEIPT_CODE   NVARCHAR(18) NULL ,
	END_RECEIPT_CODE     NVARCHAR(18) NULL ,
	RECEIPT__NUM         NVARCHAR(18) NULL ,
	RETUEN_RECEIPT_NUM   NVARCHAR(18) NULL ,
	ID                   NVARCHAR(18) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_MONTHLY_STATEMENT ON HIS_HOS_MONTHLY_STATEMENT
(ID   ASC);



ALTER TABLE HIS_HOS_MONTHLY_STATEMENT
	ADD CONSTRAINT  XPKHIS_HOS_MONTHLY_STATEMENT PRIMARY KEY (ID);



CREATE TABLE HIS_HOS_MONTHLY_STATEMENT_ITEM
(
	ITEM_TYPE            NVARCHAR(20) NULL ,
	ITEM_SUM_PAY         INTEGER NULL ,
	ITEM_CASH_PAY        INTEGER NULL ,
	ITEM_CARD_PAY        INTEGER NULL ,
	ITEM_INSURANCE_PAY   INTEGER NULL ,
	STATUS               NVARCHAR(20) NULL ,
	ID                   NVARCHAR(18) NOT NULL ,
	MONTHLY_CODE         NVARCHAR(18) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_MONTHLY_STATEMENT_I ON HIS_HOS_MONTHLY_STATEMENT_ITEM
(ID   ASC,MONTHLY_CODE   ASC);



ALTER TABLE HIS_HOS_MONTHLY_STATEMENT_ITEM
	ADD CONSTRAINT  XPKHIS_HOS_MONTHLY_STATEMENT_I PRIMARY KEY (ID,MONTHLY_CODE);



CREATE TABLE HIS_HOS_ORDER_ITEM
(
	ID                   NVARCHAR(18) NOT NULL ,
	HOS_PRES_CODE        NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	ITEM_CODE            NVARCHAR(18) NULL ,
	ITEM_NAME            NVARCHAR(128) NULL ,
	COUNT                FLOAT(10,4) NULL ,
	PRICE                FLOAT(10,4) NULL ,
	ITEM_TYPE            NVARCHAR(1) NULL ,
	SPEC                 NVARCHAR(128) NULL ,
	UNIT                 NVARCHAR(128) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	STATUS               NVARCHAR(1) NULL ,
	HERB_NUM             FLOAT(10,4) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_ORDER_ITEM ON HIS_HOS_ORDER_ITEM
(ID   ASC,HOS_PRES_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_ORDER_ITEM
	ADD CONSTRAINT  XPKHIS_HOS_ORDER_ITEM PRIMARY KEY (ID,HOS_PRES_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_PRES_DETAIL_CANCLE
(
	ID                   NVARCHAR(18) NOT NULL ,
	STATUS               NVARCHAR(2) NULL ,
	APPLY_DEPT_CODE      NVARCHAR(18) NULL ,
	DOCTOR_CODE          NVARCHAR(18) NULL ,
	OPERATE_DEPT_CODE    NVARCHAR(18) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL ,
	HOS_PRES_CODE        NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_PRES_DETAIL_CANCLE ON HIS_HOS_PRES_DETAIL_CANCLE
(ID   ASC,HOS_PRES_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_PRES_DETAIL_CANCLE
	ADD CONSTRAINT  XPKHIS_HOS_PRES_DETAIL_CANCLE PRIMARY KEY (ID,HOS_PRES_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_PRESCRIPTION
(
	HOS_PRES_CODE        NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	STATUS               NVARCHAR(1) NULL ,
	APPLY_DEPT_CODE      NVARCHAR(18) NULL ,
	DOCTOR_CODE          NVARCHAR(18) NULL ,
	OPERATE_DEPT_CODE    NVARCHAR(18) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_PRESCRIPTION ON HIS_HOS_PRESCRIPTION
(HOS_PRES_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_PRESCRIPTION
	ADD CONSTRAINT  XPKHIS_HOS_PRESCRIPTION PRIMARY KEY (HOS_PRES_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_RECEIPT
(
	HOS_RECEIPT_CODE     NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	CASHIER              NVARCHAR(18) NOT NULL ,
	RECEICPT_CODE        NVARCHAR(128) NOT NULL ,
	RECIVER_TIME         DATE NOT NULL ,
	CASH_AMT             FLOAT(10,2) NOT NULL ,
	CARD_AMT             FLOAT(10,2) NOT NULL ,
	INSURANCE_AMT        FLOAT(10,2) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	REDUCE_AMT           INTEGER NULL ,
	REDUCE_DATE          DATE NULL ,
	REDUCE_OPT           NVARCHAR(18) NULL ,
	REDUCE_REASON        NVARCHAR(128) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_RECEIPT ON HIS_HOS_RECEIPT
(HOS_RECEIPT_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_RECEIPT
	ADD CONSTRAINT  XPKHIS_HOS_RECEIPT PRIMARY KEY (HOS_RECEIPT_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_RECEIPT_CANCLE
(
	HOS_RECEIPT_CODE     NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	CASHIER              NVARCHAR(18) NOT NULL ,
	RECEICPT_CODE        NVARCHAR(128) NOT NULL ,
	RECIVER_TIME         DATE NOT NULL ,
	CASH_AMT             FLOAT(10,2) NOT NULL ,
	CARD_AMT             FLOAT(10,2) NOT NULL ,
	INSURANCE_AMT        FLOAT(10,2) NULL ,
	SUM_AMT              FLOAT(10,2) NULL ,
	REDUCE_AMT           INTEGER NULL ,
	REDUCE_DATE          DATE NULL ,
	REDUCE_OPT           NVARCHAR(18) NULL ,
	REDUCE_REASON        NVARCHAR(128) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_RECEIPT_CANCLE ON HIS_HOS_RECEIPT_CANCLE
(HOS_RECEIPT_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_RECEIPT_CANCLE
	ADD CONSTRAINT  XPKHIS_HOS_RECEIPT_CANCLE PRIMARY KEY (HOS_RECEIPT_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_RECEIPT_DETAIL
(
	ID                   NVARCHAR(18) NOT NULL ,
	HOS_RECEIPT_CODE     NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	FEEITEM_CODE         NVARCHAR(18) NOT NULL ,
	FEEITEM_NAME         NVARCHAR(18) NOT NULL ,
	PRICE                FLOAT(10,4) NOT NULL ,
	COUNT                FLOAT(10,2) NULL ,
	UNIT                 NVARCHAR(128) NULL ,
	AMT                  FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_RECEIPT_DETAIL ON HIS_HOS_RECEIPT_DETAIL
(ID   ASC,HOS_RECEIPT_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_RECEIPT_DETAIL
	ADD CONSTRAINT  XPKHIS_HOS_RECEIPT_DETAIL PRIMARY KEY (ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);



CREATE TABLE HIS_HOS_RECEIPT_DETAIL_CANCLE
(
	ID                   NVARCHAR(18) NOT NULL ,
	HOS_RECEIPT_CODE     NVARCHAR(18) NOT NULL ,
	HIS_HOS_CODE         NVARCHAR(18) NOT NULL ,
	FEEITEM_CODE         NVARCHAR(18) NOT NULL ,
	FEEITEM_NAME         NVARCHAR(18) NOT NULL ,
	PRICE                FLOAT(10,4) NOT NULL ,
	COUNT                FLOAT(10,2) NULL ,
	UNIT                 NVARCHAR(128) NULL ,
	AMT                  FLOAT(10,2) NULL ,
	OPT_USER             NVARCHAR(128) NOT NULL ,
	OPT_DATE             DATE NOT NULL ,
	OPT_TERM             NVARCHAR(128) NOT NULL ,
	OPT_ORGA             NVARCHAR(128) NOT NULL 
);



CREATE UNIQUE INDEX XPKHIS_HOS_RECEIPT_DETAIL_CANC ON HIS_HOS_RECEIPT_DETAIL_CANCLE
(ID   ASC,HOS_RECEIPT_CODE   ASC,HIS_HOS_CODE   ASC);



ALTER TABLE HIS_HOS_RECEIPT_DETAIL_CANCLE
	ADD CONSTRAINT  XPKHIS_HOS_RECEIPT_DETAIL_CANC PRIMARY KEY (ID,HOS_RECEIPT_CODE,HIS_HOS_CODE);

commit;
