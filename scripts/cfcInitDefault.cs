public string cfcInitDefault(ColumnSchema column)
{
	
string strColType = column.NativeType;
	
if (column.ExtendedProperties.Contains("CS_IsIdentity") && column.ExtendedProperties["CS_IsIdentity"].Value.ToString().ToLower() == "true") {
	return "0";
}
if (column.Name.ToLower() == "created_by" || column.Name.ToLower() == "modified_by" ) {
	return "#SESSION.UserID#";
}
if (column.Name.ToLower() == "created_tmstmp" || column.Name.ToLower() == "modified_tmstmp" ) {
	return "#now()#";
}
if (column.Name.ToLower() == "clubid") {
	return "#SESSION.ClubID#";
}
if (column.Name.ToLower() == "accountid") {
	return "#SESSION.AccountID#";
}
string strDefault = (string)column.ExtendedProperties["CS_Default"].Value;
	switch (strColType)
		{
			case "int":	
				if (strDefault.Length == 0) {
					return "0";
					break;
				}
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "bigint":
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "bit":	
				return "0";
				break;
			case "decimal":	
				if ( strDefault == "((0.0))" || strDefault == "((0.00))")
					return strDefault = "0.00";
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
			case "real":
			case "float":
			case "money":
				if ( strDefault == "((0.0))" || strDefault == "((0.00))")
					return strDefault = "0.00";
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "numeric":
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "smallint":
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "tinyint":
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "((" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "))" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "char":
				if ( strDefault == "('')" )
					return "";
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "('" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "')" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "nvarchar":
			case "varchar":
				if ( strDefault == "('')" )
					return "";
				if ( strDefault == "((0.0))" || strDefault == "((0.00))")
					return strDefault = "0.00";
				if (strDefault.Length > 4) {
					if (strDefault.Substring(0, 2) == "('" )
						strDefault = strDefault.Substring(2);
					if (strDefault.Substring(strDefault.Length-2, 2) == "')" )
						strDefault = strDefault.Substring(0, strDefault.Length-2);
				}
				return strDefault;
				break;
			case "xml":	
				return strDefault;
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