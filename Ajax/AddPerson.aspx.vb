Imports DataConnection.DataAccessClass
Partial Class Ajax_AddPerson
    Inherits System.Web.UI.Page

    Private Sub Ajax_AddPerson_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim name As String = Request.Form.Item("name")
        Dim lastName As String = Request.Form.Item("lastname")
        Dim flag As Boolean
        flag = AddPerson(name, lastName)
        If flag Then
            Response.Write("เพิ่มข้อมูลเรียบร้อยแล้ว!!!!")
        Else
            Response.Write("ERROR Add Person !!!")
        End If
    End Sub
End Class
