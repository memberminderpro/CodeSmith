public string InputValue(ColumnSchema column)  
{
string strRet;
string strType = column.NativeType;
int  nSize = column.Size;
    switch (strType)
		{
			case "tinynt":	
				strRet = "size=\"3\" maxlength=\"3\"";
				return strRet;
			case "smallint":
				strRet = "size=\"3\" maxlength=\"3\"";
				return strRet;
			case "numeric":
				strRet = "size=\"5\" maxlength=\"8\"";
				return strRet;
			case "int":		
				strRet = "size=\"5\" maxlength=\"8\"";
				return strRet;
			case "bigint":
				strRet = "size=\"8\" maxlength=\"8\"";
				return strRet;

			case "char":
				strRet = "size="+nSize+" maxlength="+nSize;
				return strRet;

			case "nvarchar":
                if (nSize < 0) {
				    strRet = "cols=\"30\" rows=\"3\"";
				    return strRet;
                } else {
    				strRet = "size="+nSize+" maxlength="+nSize;
				    return strRet;
                }
			case "varchar":	
                if (nSize < 0) {
				    strRet = "cols=\"30\" rows=\"3\"";
				    return strRet;
                } else {
    				strRet = "size="+nSize+" maxlength="+nSize;
				    return strRet;
                }
			case "date":
				strRet = "size=\"10\" maxlength=\"10\"";
				return strRet;
			case "smalldatetime":
				strRet = "size=\"10\" maxlength=\"10\"";
				return strRet;
			case "datetime":
				strRet = "size=\"10\" maxlength=\"10\"";
				return strRet;

			case "decimal":
				strRet = "size=\"8\" maxlength=\"8\"";
				return strRet;
			case "float":
				strRet = "size=\"8\" maxlength=\"8\"";
				return strRet;
			case "money":
				strRet = "size=\"8\" maxlength=\"8\"";
				return strRet;

			case "xml":	
				return "";
			case "bit":
				return "";
			default:
				return "";
        }		
	
}