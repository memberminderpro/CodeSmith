public string InputJS(ColumnSchema column)  
{
string strRet;
string strType = column.NativeType;
    switch (strType)
		{
			case "tinynt":	
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return numberOnly(event);\"";
				return strRet;

			case "smallint":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return numberOnly(event);\"";
				return strRet;

			case "numeric":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return numberOnly(event);\"";
				return strRet;

			case "int":		
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return numberOnly(event);\"";
				return strRet;

			case "bigint":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return numberOnly(event);\"";
				return strRet;

			case "char":
				strRet = "onkeypress=\"return noEnter();\"";
				return strRet;

			case "nvarchar":
				strRet = "onkeypress=\"return noEnter();\"";
			    return strRet;

			case "varchar":	
				strRet = "onkeypress=\"return noEnter();\"";
			    return strRet;

			case "date":
				strRet = "onblur=\"return isDateX(this);\" onkeypress=\"return noEnter();\"";
				return strRet;

			case "smalldatetime":
				strRet = "onblur=\"return isDateX(this);\" onkeypress=\"return noEnter();\"";
				return strRet;

			case "datetime":
				strRet = "onblur=\"return isDateX(this);\" onkeypress=\"return noEnter();\"";
				return strRet;

			case "decimal":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return decimalOnly(event);\"";
				return strRet;

			case "float":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return decimalOnly(event);\"";
				return strRet;

			case "money":
				strRet = "onBlur=\"return minZero(this);\" onkeypress=\"return moneyOnly(event);\"";
				return strRet;

			case "xml":	
				return "";
			case "bit":
				return "";
			default:
				return "";
        }		
	
}