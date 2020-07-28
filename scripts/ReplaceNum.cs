public string ReplaceNum(ColumnSchema column) 
{
string strType = column.NativeType;
switch (strType)
	{
	case "tinynt":	
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\-]+', '', 'ALL')>";
	case "smallint":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\-]+', '', 'ALL')>";
	case "numeric":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\-]+', '', 'ALL')>";
	case "int":		
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\-]+', '', 'ALL')>";
	case "bigint":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\-]+', '', 'ALL')>";

	case "decimal":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\.\\-]+', '', 'ALL')>";
	case "float":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\.\\-]+', '', 'ALL')>";
	case "money":
		return "<cfset FORM."+column.Name+"	= REReplace(FORM."+column.Name+",	'[^0-9\\.\\-]+', '', 'ALL')>";
	default:
		return "";
	}
}