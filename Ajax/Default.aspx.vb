Imports System.Data
Imports Newtonsoft.Json
Imports System.IO
Imports System.Collections.Generic
Imports System.Exception
Imports DataConnection.DataAccessClass

Partial Class Ajax_Default
    Inherits System.Web.UI.Page

    Private Sub Ajax_Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As New DataTable
        dt = getAll()
        Dim json As Object = JsonConvert.SerializeObject(dt, Formatting.Indented)
        Response.Write(json)
    End Sub
End Class
