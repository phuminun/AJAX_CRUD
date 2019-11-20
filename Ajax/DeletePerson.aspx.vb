Imports DataConnection.DataAccessClass

Partial Class Ajax_DeletePerson
    Inherits System.Web.UI.Page

    Private Sub Ajax_DeletePerson_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim id As String = Request.Form.Item("id")
        Dim flag As Boolean
        flag = DeletePerson(id)

        If flag Then
            Response.Write("success")
        Else
            Response.Write("Error!!!")
        End If
    End Sub
End Class
