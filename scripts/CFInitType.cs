public string CFInitType(ColumnSchema column)
{

if (column.Name.ToLower() == "created_by") {
	return "string";
}
if (column.Name.ToLower() == "modified_by") {
	return "string";
}
if (column.Name.ToLower() == "created_tmstmp") {
	return "string";
}
if (column.Name.ToLower() == "modified_tmstmp") {
	return "string";
}

string strColType = (string) column.NativeType;
switch (strColType)
	{
		case "bigint":			return "numeric";
		case "bit":				return "boolean";
		case "char":			return "string";
		case "date":			return "string";
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