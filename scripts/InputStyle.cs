public string InputStyle(ColumnSchema column)  
{
string strColType = column.NativeType;
    switch (strColType)
		{
			case "tinynt":			return "TxtInC";
			case "smallint":		return "TxtInC";
			case "int":				return "TxtInC";
			case "bigint":			return "TxtInC";
			case "numeric":			return "TxtInC";

			case "char":			return "TxtIn";

			case "nvarchar":		return "TxtIn";
			case "varchar":			return "TxtIn";

			case "date":			return "TxtInC";
			case "smalldatetime":	return "TxtInC";
			case "datetime":		return "TxtInC";

			case "decimal":			return "TxtInR";
			case "float":			return "TxtInR";
			case "money":			return "TxtInR";

			case "xml":				return "TxtIn";
			case "bit":				return "TxtIn";

			default:				return "TxtIn";
        }		
	
}