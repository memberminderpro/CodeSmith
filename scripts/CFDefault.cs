public string CFDefault(ColumnSchema column)
{
string strColType = column.NativeType;
string pattern = "[a-zA-Z0-9]+";
Regex regex = new Regex(pattern);
string strDefault = (string)column.ExtendedProperties["CS_Default"].Value;
	switch (strColType)
		{
			case "bigint":
			case "bit":	
			case "decimal":	
			case "float":
			case "int":	
			case "money":
			case "numeric":
			case "smallint":
			case "tinyint":
				return strDefault;
				break;
			case "char":
			case "nvarchar":
			case "varchar":
			case "xml":	
				return Regex.Match(strDefault, pattern).Value;
				break;
			case "date":
			case "datetime":
			case "smalldatetime":
				return strDefault;
				break;

			default:
				return strDefault;
				break;
		}
}