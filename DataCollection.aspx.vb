Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.SqlServer.Dts.Runtime
Public Class DataCollection
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.RadioButtonList1.SelectedIndex = -1

        Else
            If Me.RadioButtonList1.SelectedIndex = 0 Then
                Me.Label1.Text = "Before Purification"

            ElseIf Me.RadioButtonList1.SelectedIndex = 1 Then
                Me.Label1.Text = "After Purification"
            Else
                Me.Label1.Text = ""
            End If
        End If
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If Me.RadioButtonList1.SelectedIndex = 0 Then

            Me.GridView3.Visible = True
            Me.GridView2.Visible = False

        ElseIf Me.RadioButtonList1.SelectedIndex = 1 Then
            Me.GridView3.Visible = False
            Me.GridView2.Visible = True

        End If
    End Sub


    Protected Sub GridView3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView3.SelectedIndexChanged

    End Sub

    
End Class