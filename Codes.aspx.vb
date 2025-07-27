Public Class Codes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
        Else
            Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
        End If
    End Sub

    Private Sub DetailsView1_ItemInserted(sender As Object, e As System.Web.UI.WebControls.DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
        Me.DetailsView1.DataBind()
    End Sub

    Private Sub DetailsView1_ItemInserting(sender As Object, e As System.Web.UI.WebControls.DetailsViewInsertEventArgs) Handles DetailsView1.ItemInserting
        Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
    End Sub

    Private Sub DetailsView1_ModeChanged(sender As Object, e As System.EventArgs) Handles DetailsView1.ModeChanged
        Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
    End Sub

    Protected Sub DetailsView1_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.DetailsViewPageEventArgs) Handles DetailsView1.PageIndexChanging

        Me.GridView1.DataBind()
        Me.DetailsView1.ChangeMode(DetailsViewMode.Insert)
    End Sub
End Class