Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Microsoft.SqlServer.Dts.Runtime
Imports System.Threading

Public Class prntLabels
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim newPageSettings As New System.Drawing.Printing.PageSettings
        'newPageSettings.Margins = New System.Drawing.Printing.Margins(0.28, 0.3, 0.37, 0.5)
        'ReportViewer1.SetPageSettings(newPageSettings)
    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub
End Class