Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.SqlServer.Dts.Runtime

Public Class InspData
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Session("JOB") = Me.ComboBox1.SelectedValue.ToString

    End Sub
End Class