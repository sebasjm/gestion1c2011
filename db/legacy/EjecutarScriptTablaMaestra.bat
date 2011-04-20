sqlcmd -S localhost\SQLSERVER2005 -U gd -P gd2011 -i gd_esquema.Schema.sql,gd_esquema.Maestra.Table.sql  -a 32767 -o resultado_output.txt
