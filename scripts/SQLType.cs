public string SQLType(ColumnSchema column)
{
string strColType = column.NativeType;
	switch (strColType)
		{
			case "bigint":			return "CF_SQL_INTEGER";
			case "bit":				return "CF_SQL_BIT";
			case "char":			return "CF_SQL_CHAR";
			case "date":			return "CF_SQL_DATE";
			case "datetime":		return "CF_SQL_TIMESTAMP";
			case "decimal":			return "CF_SQL_DECIMAL\"  Scale=\"2";
			case "float":			return "CF_SQL_REAL";
			case "int":				return "CF_SQL_INTEGER";
			case "money":			return "CF_SQL_MONEY";
			case "numeric":			return "CF_SQL_INTEGER";
			case "nvarchar":		return "CF_SQL_VARCHAR";
			case "smalldatetime":	return "CF_SQL_TIMESTAMP";
			case "smallint":		return "CF_SQL_INTEGER";
			case "tinyint":			return "CF_SQL_INTEGER";
			case "varchar":			return "CF_SQL_VARCHAR";
			case "xml":				return "CF_SQL_VARCHAR";
			default:				return "CF_SQL_VARCHAR";
	}
}