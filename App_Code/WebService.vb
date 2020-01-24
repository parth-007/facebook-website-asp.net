Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.Script.Services
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
   <ScriptMethod(ResponseFormat:=ResponseFormat.Json)> _
    Public Function GetCustomers(ByVal prefix As String) As String()
        Dim users As New List(Of String)()
        Using conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ADMIN\Documents\Face123.mdf;Integrated Security=True;Connect Timeout=30")

            Using cmd As New SqlCommand()
                cmd.CommandText = "select fname, userid from Users where " & "fname like @SearchText + '%'"
                cmd.Parameters.AddWithValue("@SearchText", prefix)
                cmd.Connection = conn
                conn.Open()
                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    While sdr.Read()
                        users.Add(String.Format("{0}-{1}", sdr("fname"), sdr("userid")))
                    End While
                End Using
                conn.Close()
            End Using
            Return users.ToArray()
        End Using
    End Function
End Class