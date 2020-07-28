public string CFRequired(ColumnSchema column)
{
if ( column.AllowDBNull )
	return "Yes";
else
	return "No";
}