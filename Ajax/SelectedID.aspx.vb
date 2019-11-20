Imports DataConnection.DataAccessClass
Imports Newtonsoft.Json
Imports System.Data
Partial Class Ajax_SelectedID
    Inherits System.Web.UI.Page

    Private Sub Ajax_SelectedID_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim id As String = Request.Form.Item("id")
        Dim dt As New DataTable
        dt = SelectPerson(id)
        Dim json As Object = JsonConvert.SerializeObject(dt, Formatting.Indented)
        Response.Write(json)
    End Sub
End Class
