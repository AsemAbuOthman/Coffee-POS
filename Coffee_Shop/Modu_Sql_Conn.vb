Imports System.Data.SqlClient

Module Modu_Sql_Conn

    Public WhichForm As String
    Public strUsername As String
    Public strPassword As String

    '"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CoffeShopDB;Data Source=Leon"
    '"Data Source=SQL8010.site4now.net;Initial Catalog=db_aa9156_coffeshopdb;User Id=db_aa9156_coffeshopdb_admin;Password=Asim@7320"

    Public Conn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CoffeShopDB;Data Source=Leon")
    Public Cmd As New SqlCommand
    Public Reader As SqlDataReader
    'Public Adapt As SqlDataAdapter

End Module
