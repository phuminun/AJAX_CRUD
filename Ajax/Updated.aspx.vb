Imports Newtonsoft
Imports DataConnection.DataAccessClass
Partial Class Ajax_Updated
    Inherits System.Web.UI.Page

    Private Sub Ajax_Updated_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim id As String = Request.Form.Item("id")
        Dim name As String = Request.Form.Item("name")
        Dim lastName As String = Request.Form.Item("lastName")
        Dim flag As Boolean
        flag = UpdatePerson(name, lastName, id)

        If flag Then
            Response.Write("success")
        Else
            Response.Write("Error!!!")
        End If
    End Sub
End Class
