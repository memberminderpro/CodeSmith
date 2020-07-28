public string CFPropertyType(ColumnSchema column)
{
string strColType = (string) column.NativeType;
switch (strColType)
	{
		case "bigint":			return "numeric";
		case "bit":				return "boolean";
		case "char":			return "string";
		case "date":			return "date";
		case "datetime":		return "date";
		case "decimal":			return "numeric";
		case "float":			return "numeric";
		case "int":				return "numeric";
		case "money":			return "numeric";
		case "numeric":			return "numeric";
		case "nvarchar":		return "string";
		case "smalldatetime":	return "date";
		case "smallint":		return "numeric";
		case "tinyint":			return "numeric";
		case "varchar":			return "string";
		case "xml":				return "string";
		default:				return "string";
	}
}