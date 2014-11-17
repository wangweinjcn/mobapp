namespace Mobapp.localEcoSpace
{
    public partial class l_PMP
    {
        #region Component Designer generated code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        private Eco.Persistence.SyncHandler syncHandler1;

        private void InitializeComponent()
        {
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition1 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition2 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition3 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition4 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition5 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.KeyMapperDefinition keyMapperDefinition6 = new Eco.Persistence.Configuration.KeyMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition1 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition2 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition3 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition4 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition5 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition6 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition7 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition8 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition9 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition10 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition11 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition12 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition13 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition14 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition15 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition16 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition17 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition18 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition19 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition20 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition21 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition22 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition23 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition24 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition25 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition26 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition27 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition28 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition29 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition30 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition31 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition32 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition33 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            Eco.Persistence.Configuration.PersistenceMapperDefinition persistenceMapperDefinition34 = new Eco.Persistence.Configuration.PersistenceMapperDefinition();
            this.syncHandler1 = new Eco.Persistence.SyncHandler();
            this.persistenceMapperWCFClient1 = new Eco.Wcf.Client.PersistenceMapperWCFClient();
            this.persistenceMapperMySql1 = new Eco.Persistence.PersistenceMapperMySql();
            // 
            // syncHandler1
            // 
            this.syncHandler1.HistoryLength = 10000;
            // 
            // persistenceMapperWCFClient1
            // 
            this.persistenceMapperWCFClient1.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.None;
            this.persistenceMapperWCFClient1.EndpointConfigurationName = null;
            this.persistenceMapperWCFClient1.MaxReceivedMessageSize = ((long)(2147483647));
            this.persistenceMapperWCFClient1.Uri = "http://localhost:8000/PMP";
            this.persistenceMapperWCFClient1.UseWSHttp = false;
            this.persistenceMapperWCFClient1.WCFServerPassword = null;
            this.persistenceMapperWCFClient1.WCFServerUserName = null;
            // 
            // persistenceMapperMySql1
            // 
            this.persistenceMapperMySql1.CompatibilityMode = Eco.Persistence.ORMapping.EcoCompatibilityMode.EcoIII;
            this.persistenceMapperMySql1.ConnectionString = "server=localhost;database=ecotestmvc;User Id=root;password=manager; Charset=utf8";
            this.persistenceMapperMySql1.SqlDatabaseConfig.BooleanTrueLiteral = "";
            this.persistenceMapperMySql1.SqlDatabaseConfig.DefaultDateTime = new System.DateTime(((long)(0)));
            this.persistenceMapperMySql1.SqlDatabaseConfig.DefaultStringLength = 255;
            this.persistenceMapperMySql1.SqlDatabaseConfig.DropColumnTemplate = "ALTER TABLE <TableName> DROP <ColumnName>";
            this.persistenceMapperMySql1.SqlDatabaseConfig.DropIndexTemplate = "DROP INDEX <IndexName>";
            this.persistenceMapperMySql1.SqlDatabaseConfig.DropTableTemplate = "DROP TABLE <TableName>";
            this.persistenceMapperMySql1.SqlDatabaseConfig.FetchBlockSize = 250;
            keyMapperDefinition1.MapperTypeName = "Eco.Persistence.DefaultEcoIdMapper";
            keyMapperDefinition1.Name = "DefaultEcoIdMapper";
            keyMapperDefinition2.MapperTypeName = "Eco.Persistence.DefaultEcoInt64KeyMapper";
            keyMapperDefinition2.Name = "Int64";
            keyMapperDefinition3.MapperTypeName = "Eco.Persistence.AttributeKeyMapper";
            keyMapperDefinition3.Name = "Attribute";
            keyMapperDefinition4.MapperTypeName = "Eco.Persistence.AutoIncKeyMapper";
            keyMapperDefinition4.Name = "AutoInc";
            keyMapperDefinition5.MapperTypeName = "Eco.Persistence.AutoInc16KeyMapper";
            keyMapperDefinition5.Name = "AutoInc16";
            keyMapperDefinition6.MapperTypeName = "Eco.Persistence.GuidKeyMapper";
            keyMapperDefinition6.Name = "Guid";
            this.persistenceMapperMySql1.SqlDatabaseConfig.KeyMappers.AddRange(new Eco.Persistence.Configuration.KeyMapperDefinition[] {
            keyMapperDefinition1,
            keyMapperDefinition2,
            keyMapperDefinition3,
            keyMapperDefinition4,
            keyMapperDefinition5,
            keyMapperDefinition6});
            this.persistenceMapperMySql1.SqlDatabaseConfig.LengthFunctionName = "LENGTH";
            this.persistenceMapperMySql1.SqlDatabaseConfig.MaxAliasNameLength = 64;
            this.persistenceMapperMySql1.SqlDatabaseConfig.MaxDbIdentifierLength = 64;
            this.persistenceMapperMySql1.SqlDatabaseConfig.MaxIndexNameLength = 64;
            this.persistenceMapperMySql1.SqlDatabaseConfig.MaxParamsInIdList = 20;
            this.persistenceMapperMySql1.SqlDatabaseConfig.MultiTenantPrefix = "";
            persistenceMapperDefinition1.MapperTypeName = "Eco.Persistence.Default.GenericEnumAsNVarChar";
            persistenceMapperDefinition1.Name = "Eco.ObjectRepresentation.DynamicEnumString";
            persistenceMapperDefinition2.MapperTypeName = "Eco.Persistence.Default.CharAsChar";
            persistenceMapperDefinition2.Name = "System.Char";
            persistenceMapperDefinition3.MapperTypeName = "Eco.Persistence.Default.StringAsChar";
            persistenceMapperDefinition3.Name = "StringAsChar";
            persistenceMapperDefinition4.MapperTypeName = "Eco.Persistence.Default.StringAsVarChar";
            persistenceMapperDefinition4.Name = "System.String";
            persistenceMapperDefinition5.MapperTypeName = "Eco.Persistence.MySql.DateTimeAsDateTime";
            persistenceMapperDefinition5.Name = "System.DateTime";
            persistenceMapperDefinition6.MapperTypeName = "Eco.Persistence.Default.GuidAsVarChar32";
            persistenceMapperDefinition6.Name = "System.Guid";
            persistenceMapperDefinition7.MapperTypeName = "Eco.Persistence.Default.BooleanAsInteger";
            persistenceMapperDefinition7.Name = "System.Boolean";
            persistenceMapperDefinition8.MapperTypeName = "Eco.Persistence.MySql.ByteAsUnsingedTinyInt";
            persistenceMapperDefinition8.Name = "System.Byte";
            persistenceMapperDefinition9.MapperTypeName = "Eco.Persistence.Default.SByteAsSmallInt";
            persistenceMapperDefinition9.Name = "System.SByte";
            persistenceMapperDefinition10.MapperTypeName = "Eco.Persistence.Default.Int16AsSmallint";
            persistenceMapperDefinition10.Name = "System.Int16";
            persistenceMapperDefinition11.MapperTypeName = "Eco.Persistence.MySql.UInt16AsUnsignedSmallint";
            persistenceMapperDefinition11.Name = "System.UInt16";
            persistenceMapperDefinition12.MapperTypeName = "Eco.Persistence.Default.Int32AsInteger";
            persistenceMapperDefinition12.Name = "System.Int32";
            persistenceMapperDefinition13.MapperTypeName = "Eco.Persistence.Default.ColorAsInteger";
            persistenceMapperDefinition13.Name = "System.Drawing.Color";
            persistenceMapperDefinition14.MapperTypeName = "Eco.Persistence.Default.UInt32AsLongInteger";
            persistenceMapperDefinition14.Name = "System.UInt32";
            persistenceMapperDefinition15.MapperTypeName = "Eco.Persistence.MySql.MysClient.Int64AsBigInt";
            persistenceMapperDefinition15.Name = "System.Int64";
            persistenceMapperDefinition16.MapperTypeName = "Eco.Persistence.Default.UInt64AsDecimal";
            persistenceMapperDefinition16.Name = "System.UInt64";
            persistenceMapperDefinition17.MapperTypeName = "Eco.Persistence.Default.SingleAsSingle";
            persistenceMapperDefinition17.Name = "System.Single";
            persistenceMapperDefinition18.MapperTypeName = "Eco.Persistence.Default.DoubleAsDouble";
            persistenceMapperDefinition18.Name = "System.Double";
            persistenceMapperDefinition19.MapperTypeName = "Eco.Persistence.Default.DecimalAsDecimal";
            persistenceMapperDefinition19.Name = "System.Decimal";
            persistenceMapperDefinition20.MapperTypeName = "Eco.Persistence.Default.BooleanAsYNChar";
            persistenceMapperDefinition20.Name = "BooleanAsYN";
            persistenceMapperDefinition21.MapperTypeName = "Eco.Persistence.Default.BooleanAsInteger";
            persistenceMapperDefinition21.Name = "BooleanAsInteger";
            persistenceMapperDefinition22.MapperTypeName = "Eco.Persistence.Default.DateTimeAsSmallDateTime";
            persistenceMapperDefinition22.Name = "DateTimeAsSmallDateTime";
            persistenceMapperDefinition23.MapperTypeName = "Eco.Persistence.Default.DoubleAsNumeric";
            persistenceMapperDefinition23.Name = "DoubleAsNumeric";
            persistenceMapperDefinition24.MapperTypeName = "Eco.Persistence.Default.GuidAsVarChar32";
            persistenceMapperDefinition24.Name = "GuidAsVarChar32";
            persistenceMapperDefinition25.MapperTypeName = "Eco.Persistence.Default.GenericEnumAsVarChar";
            persistenceMapperDefinition25.Name = "Enum";
            persistenceMapperDefinition26.MapperTypeName = "Eco.Persistence.Default.GenericEnumAsInteger";
            persistenceMapperDefinition26.Name = "GenericEnumAsInteger";
            persistenceMapperDefinition27.MapperTypeName = "Eco.Persistence.Default.GenericAttributeMapper";
            persistenceMapperDefinition27.Name = "GenericAttributeMapper";
            persistenceMapperDefinition28.MapperTypeName = "Eco.Persistence.Default.TimeSpanAsDateTime";
            persistenceMapperDefinition28.Name = "System.TimeSpan";
            persistenceMapperDefinition29.MapperTypeName = "Eco.Persistence.MySql.Int32AsAutoInc";
            persistenceMapperDefinition29.Name = "AutoInc";
            persistenceMapperDefinition30.MapperTypeName = "Eco.Persistence.MySql.Int16AsAutoInc";
            persistenceMapperDefinition30.Name = "AutoInc16";
            persistenceMapperDefinition31.MapperTypeName = "Eco.Persistence.MySql.MysClient.ByteArrayAsBlob";
            persistenceMapperDefinition31.Name = "System.Byte[]";
            persistenceMapperDefinition32.MapperTypeName = "Eco.Persistence.MySql.MysClient.StringAsLongText";
            persistenceMapperDefinition32.Name = "StringAsText";
            persistenceMapperDefinition33.MapperTypeName = "Eco.Persistence.MySql.MysClient.StringAsUnicodeVarChar";
            persistenceMapperDefinition33.Name = "StringAsUnicode";
            persistenceMapperDefinition34.MapperTypeName = "Eco.Persistence.MySql.MysClient.StringAsUnicodeText";
            persistenceMapperDefinition34.Name = "StringAsUnicodeText";
            this.persistenceMapperMySql1.SqlDatabaseConfig.PersistenceMappers.AddRange(new Eco.Persistence.Configuration.PersistenceMapperDefinition[] {
            persistenceMapperDefinition1,
            persistenceMapperDefinition2,
            persistenceMapperDefinition3,
            persistenceMapperDefinition4,
            persistenceMapperDefinition5,
            persistenceMapperDefinition6,
            persistenceMapperDefinition7,
            persistenceMapperDefinition8,
            persistenceMapperDefinition9,
            persistenceMapperDefinition10,
            persistenceMapperDefinition11,
            persistenceMapperDefinition12,
            persistenceMapperDefinition13,
            persistenceMapperDefinition14,
            persistenceMapperDefinition15,
            persistenceMapperDefinition16,
            persistenceMapperDefinition17,
            persistenceMapperDefinition18,
            persistenceMapperDefinition19,
            persistenceMapperDefinition20,
            persistenceMapperDefinition21,
            persistenceMapperDefinition22,
            persistenceMapperDefinition23,
            persistenceMapperDefinition24,
            persistenceMapperDefinition25,
            persistenceMapperDefinition26,
            persistenceMapperDefinition27,
            persistenceMapperDefinition28,
            persistenceMapperDefinition29,
            persistenceMapperDefinition30,
            persistenceMapperDefinition31,
            persistenceMapperDefinition32,
            persistenceMapperDefinition33,
            persistenceMapperDefinition34});
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("ABSOLUTE,ACTION,ADD,ALL,ALLOCATE,ALTER,AND,ANY,ARE,AS,ASC");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("ASSERTION,AT,AUTHORIZATION,AVG,BEGIN,BETWEEN,BIT,BIT_LENGTH,BOTH");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("BY,CALL,CASCADE,CASCADED,CASE,CAST,CATALOG,CHAR,CHARACTER");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("CHARACTER_LENGTH,CHAR_LENGTH,CHECK,CLOSE,COALESCE,COLLATE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("COLLATION,COLUMN,COMMIT,CONDITION,CONNECT,CONNECTION,CONSTRAINT");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("CONSTRAINTS,CONTAINS,CONTINUE,CONVERT,CORRESPONDING,COUNT,CREATE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("CROSS,CURRENT,CURRENT_DATE,CURRENT_PATH,CURRENT_TIME");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("CURRENT_TIMESTAMP,CURRENT_USER,CURSOR,DATE,DAY,DEALLOCATE,DEC");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("DECIMAL,DECLARE,DEFAULT,DEFERRABLE,DEFERRED,DELETE,DESC,DESCRIBE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("DESCRIPTOR,DETERMINISTIC,DIAGNOSTICS,DISCONNECT,DISTINCT,DO");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("DOMAIN,DOUBLE,DROP,ELSE,ELSEIF,END,ESCAPE,EXCEPT,EXCEPTION,EXEC");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("EXECUTE,EXISTS,EXIT,EXTERNAL,EXTRACT,FALSE,FETCH,FIRST,FLOAT,FOR");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("FOREIGN,FOUND,FROM,FULL,FUNCTION,GET,GLOBAL,GO,GOTO,GRANT,GROUP");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("HANDLER,HAVING,HOUR,IDENTITY,IF,IMMEDIATE,IN,INDICATOR,INITIALLY");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("INNER,INOUT,INPUT,INSENSITIVE,INSERT,INT,INTEGER,INTERSECT");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("INTERVAL,INTO,IS,ISOLATION,JOIN,KEY,LANGUAGE,LAST,LEADING,LEAVE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("LEFT,LEVEL,LIKE,LOCAL,LOOP,LOWER,MATCH,MAX,MIN,MINUTE,MODULE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("MONTH,NAMES,NATIONAL,NATURAL,NCHAR,NEXT,NO,NOT,NULL,NULLIF");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("NUMERIC,OCTET_LENGTH,OF,ON,ONLY,OPEN,OPTION,OR,ORDER,OUT,OUTER");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("OUTPUT,OVERLAPS,PAD,PARAMETER,PARTIAL,PATH,POSITION,PRECISION");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("PREPARE,PRESERVE,PRIMARY,PRIOR,PRIVILEGES,PROCEDURE,PUBLIC,READ");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("REAL,REFERENCES,RELATIVE,REPEAT,RESIGNAL,RESTRICT,RETURN,RETURNS");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("REVOKE,RIGHT,ROLLBACK,ROUTINE,ROWS,SCHEMA,SCROLL,SECOND,SECTION");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("SELECT,SESSION,SESSION_USER,SET,SIGNAL,SIZE,SMALLINT,SOME,SPACE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("SPECIFIC,SQL,SQLCODE,SQLERROR,SQLEXCEPTION,SQLSTATE,SQLWARNING");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("SUBSTRING,SUM,SYSTEM_USER,TABLE,TEMPORARY,THEN,TIME,TIMESTAMP");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("TIMEZONE_HOUR,TIMEZONE_MINUTE,TO,TRAILING,TRANSACTION,TRANSLATE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("TRANSLATION,TRIM,TRUE,UNDO,UNION,UNIQUE,UNKNOWN,UNTIL,UPDATE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("UPPER,USAGE,USER,USING,VALUE,VALUES,VARCHAR,VARYING,VIEW,WHEN");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("WHENEVER,WHERE,WHILE,WITH,WORK,WRITE,YEAR,ZONE,ANALYZE,BEFORE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("BIGINT,BINARY,BLOB,CHANGE,COLUMNS,DATABASE,DATABASES,DAY_HOUR");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("DAY_MICROSECOND,DAY_MINUTE,DAY_SECOND,DELAYED,DISTINCTROW,DIV");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("DUAL,ENCLOSED,ESCAPED,EXPLAIN,FIELDS,FLOAT4,FLOAT8,FORCE,FULLTEXT");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("HIGH_PRIORITY,HOUR_MICROSECOND,HOUR_MINUTE,HOUR_SECOND,IGNORE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("INDEX,INFILE,INT1,INT2,INT3,INT4,INT8,KEYS,KILL,LIMIT,LINES,LOAD");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("LOCALTIME,LOCALTIMESTAMP,LOCK,LONG,LONGBLOB,LONGTEXT,LOW_PRIORITY");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("MEDIUMBLOB,MEDIUMINT,MEDIUMTEXT,MIDDLEINT,MINUTE_MICROSECOND");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("MINUTE_SECOND,MOD,NO_WRITE_TO_BINLOG,OPTIMIZE,OPTIONALLY,OUTFILE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("PURGE,RAID0,REGEXP,RENAME,REPLACE,REQUIRE,RLIKE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("SECOND_MICROSECOND,SEPARATOR,SHOW,SONAME,SPATIAL,SQL_BIG_RESULT");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("SQL_CALC_FOUND_ROWS,SQL_SMALL_RESULT,SSL,START,STARTING");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("STRAIGHT_JOIN,TABLES,TERMINATED,TINYBLOB,TINYINT,TINYTEXT,UNLOCK");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("UNSIGNED,USE,UTC_DATE,UTC_TIME,UTC_TIMESTAMP,VARBINARY");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("VARCHARACTER,X509,XOR,YEAR_MONTH,ZEROFILL,ASENSITIVE,EACH,ITERATE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.ReservedWordsList.Add("LABEL,MODIFIES,READS,RELEASE,SCHEMAS,SENSITIVE,TRIGGER,UPGRADE");
            this.persistenceMapperMySql1.SqlDatabaseConfig.SQLforNotNull = "NOT NULL";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlQuoteChar = "`";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptCommentStart = "/* ";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptCommentStop = " */";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptCommitTransaction = "COMMIT";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptRollBackTransaction = "ROLLBACK";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptSeparator = "";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptStartTransaction = "START TRANSACTION";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlScriptTerminator = ";";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlTopKeyword = "";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SqlTopQuerySuffix = "limit {0}";
            this.persistenceMapperMySql1.SqlDatabaseConfig.SupportsConstraintsInCreateTable = true;
            this.persistenceMapperMySql1.SqlDatabaseConfig.SupportsFilteredIndex = false;
            this.persistenceMapperMySql1.SqlDatabaseConfig.SystemTablePrefix = "ECO";
            this.persistenceMapperMySql1.SqlDatabaseConfig.TablesTableHasIndex = false;
            this.persistenceMapperMySql1.SqlDatabaseConfig.UseSQL92Joins = false;
            this.persistenceMapperMySql1.UseInformationSchema = false;
            this.persistenceMapperMySql1.VersionGranularity = System.TimeSpan.Parse("00:00:00");
            // 
            // l_PMP
            // 
            this.EcoSpaceTypeName = "Mobapp.localEcoSpace.l_EcoSpace";
            this.PersistenceMapper = this.persistenceMapperMySql1;

        }
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
            }

            base.Dispose(disposing);
        }
        private Eco.Wcf.Client.PersistenceMapperWCFClient persistenceMapperWCFClient1;
        private Eco.Persistence.PersistenceMapperMySql persistenceMapperMySql1;
    }
}
