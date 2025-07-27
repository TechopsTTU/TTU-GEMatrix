Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
'Imports Microsoft.SqlServer.Dts.Runtime
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Me.GridView1.Visible = False
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from LOT"

            cmd.ExecuteNonQuery()
            Me.GridView2.DataBind()
            Me.Button1.Visible = False
            con.Close()

            If Session("PASS") <> Nothing Then
                Me.TextBox5.Enabled = True
                Me.Label5.Visible = False
                Me.TextBox4.Visible = False
                Button2.Visible = False

            Else
                Me.TextBox5.Enabled = False
            End If
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = False

        Else
            If TextBox5.Text <> "" Then
                Me.GridView1.DataBind()
                Me.GridView1.Visible = True
            End If

        End If


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        'find running vessel based on selection
        Dim row As GridViewRow = GridView1.SelectedRow
        Dim strLot As Label

        strLot = CType(row.Cells(0).FindControl("Label1"), Label)

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO LOT (Lot) Values (@parameter)"
        cmd.Parameters.AddWithValue("@parameter", strLot.Text)

        cmd.ExecuteNonQuery()

        Me.GridView2.EditIndex = 0
        Me.GridView2.DataBind()
        Me.GridView1.Enabled = False
        con.Close()
    End Sub





    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSN As Integer
        Dim intSNCode As String
        Dim strPreCode
        Dim sConnectionString As String
        sConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        Dim dsPubs As New DataSet("items")
        Dim dsPubs2 As New DataSet("items")
        Dim tblAuthors As DataTable
        Dim tblAuthors2 As DataTable
        If Me.GridView2.Rows.Count = 0 Then
        Else


            'get code data-------------------------------------------------------- 
            Dim strDWG As String
            strDWG = Trim(Session("DRWG"))
            Dim objConn As New SqlConnection(sConnectionString)
            Dim strCustID As String
            strCustID = Left(strDWG, 7)

            Dim daAuthors2 As _
              New SqlDataAdapter("SELECT TDWG, CODE, TNAME FROM GE_CODE WHERE TDWG Like '" & strCustID & "%'", objConn)
            daAuthors2.Fill(dsPubs2, "items")
            tblAuthors2 = dsPubs2.Tables("items")
            Dim strDrg As String
            Dim strCode As String
            Dim strTNAME As String
            Dim drCurrent As DataRow
            'get if empty
            If tblAuthors2.Rows.Count = 0 Then
                Dim csname1 As String = "PopupScript"
                Dim csname2 As String = "ButtonClickScript"
                Dim cstype As Type = Me.GetType()
                Dim strmsg As String
                Dim strValidate As String
                strmsg = "Code Not Found...Please enter a code that corresponds to CustomPartNumber"
                strValidate = "<script>"
                strValidate = strValidate & "alert('" & strmsg & "');"
                strValidate = strValidate & "</script>"
                ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)

                Exit Sub
            End If

            'end
            For Each drCurrent In tblAuthors2.Rows

                strDrg = drCurrent("TDWG").ToString
                strCode = drCurrent("CODE").ToString
                strTNAME = drCurrent("TNAME").ToString

                'do this for getting last serial number used
                If Left(strCode, 3) = "TPM" Then
                    strPreCode = "TPM"
                    Session("CODE") = strPreCode
                Else
                    Session("CODE") = strCode
                End If


            Next


            daAuthors2.Dispose()
            '------------------------------------------------------------------

            'get last sn number-------------------------------------------------------------
           
            Dim dvSql2 As DataView =
DirectCast(SqlDataSource6.Select(DataSourceSelectArguments.Empty), DataView)
            'Always get last serial number from by code 03/11/21
            'get last serial by code

            If Mid(Label4.Text, 10, 3) = "G06" Then

                For Each drvSql2 As DataRowView In dvSql2
                    intSNCode = drvSql2("LastNo")
                Next

               
            End If



            'delete temp --------------------------------------------------------------

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from TempForSN"

            cmd.ExecuteNonQuery()

            'insert data into temp----------------------------------------------


            dsPubs.Clear()
            ' Dim objConn As New SqlConnection(sConnectionString)
            Dim daAuthors3 As _
              New SqlDataAdapter("SELECT Lot, [From], [To], TargPerBillet FROM LOT", objConn)
            daAuthors3.Fill(dsPubs, "items")
            tblAuthors = dsPubs.Tables("items")
            ' Dim strCode As String
            Dim strFrom As String
            Dim strTo As String
            Dim strLot As String
            Dim strTargBillet As Integer
            ' Dim intBillet As Integer

            'Dim drCurrent As DataRow
            ' intBillet = 1

            'get Number only if G062

            If Mid(Label4.Text, 10, 4) = "G062" Then
                intSN = Mid(intSNCode, 2, 4)
                ' intSN = intSN.ToString.PadLeft(4, "0"c)
            Else
                intSN = intSNCode
            End If

            ' Exit Sub


            For Each drCurrent In tblAuthors.Rows

                strFrom = drCurrent("From").ToString
                strLot = drCurrent("Lot").ToString
                strTo = drCurrent("To").ToString
                strTargBillet = drCurrent("TargPerBillet").ToString

                'check if counter is within range if not the Letter Number needs to be changed.
                ' strCode = Session("CODE")
                Dim intDiff As Integer
                If Left(strCode, 3) <> "TPM" And Mid(Label4.Text, 10, 4) = "G062" Then
                    intDiff = strTo * strTargBillet
                    If intSN + intDiff > 9999 Then
                        Dim strSQL2 As String
                        Dim strSNPrefix As String

                        strSNPrefix = Left(intSNCode, 1)

                        Dim strSNPrefix_next As Char = strSNPrefix
                        strSNPrefix_next = UCase(Chr(Asc(strSNPrefix_next) + 1))


                        intSN = "0000" 'intSN.ToString.PadLeft(4, "0"c)
                        'strSQL2 = "Update LastSNByCode Set LastNo='" & strSNPrefix_next & intSN & " ' where GECode ='" & strCode & "';"
                        'cmd.Connection = con
                        'cmd.CommandText = strSQL2
                        'cmd.ExecuteNonQuery()



                        intSNCode = strSNPrefix_next & intSN



                        'Dim csname1 As String = "PopupScript"
                        'Dim csname2 As String = "ButtonClickScript"
                        'Dim cstype As Type = Me.GetType()
                        'Dim strmsg As String
                        'Dim strValidate As String
                        'strmsg = "This exceeds the Sequence format, change Letter."
                        'strValidate = "<script>"
                        'strValidate = strValidate & "alert('" & strmsg & "');"
                        'strValidate = strValidate & "</script>"
                        'ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)



                    End If
                End If





                Dim j As Integer
                Dim h As Integer
                For j = strFrom To strTo

                    h = 1

                    cmd.CommandText = "INSERT INTO TempForSN (Job, Lot, GECODE, BilletNo, SN, T01, T02, T03, T04, T05, T06, T07, T08, T09, T10, T11, T12, T13, T14) Values (@para1, @para2,@para3,@para4,@para5, @T01, @T02, @T03, @T04, @T05, @T06, @T07, @T08, @T09, @T10, @T11, @T12, @T13, @T14 )"
                    cmd.Parameters.AddWithValue("@para1", Me.TextBox5.Text)
                    cmd.Parameters.AddWithValue("@para2", strLot)
                    cmd.Parameters.AddWithValue("@para3", strCode)
                    cmd.Parameters.AddWithValue("@para4", j)

                    'increment SN
                    Dim strSN As String


                    intSN = intSN + 1
                    strSN = intSN.ToString.PadLeft(4, "0"c)
                    'If Mid(Label4.Text, 19, 4) = "G062" Then

                    '    cmd.Parameters.AddWithValue("@para5", Left(strCode, 4) & Left(intSNCode, 1) & intSN)
                    'Else
                    '    cmd.Parameters.AddWithValue("@para5", Left(strCode, 3) & intSN)
                    'End If

                    If Mid(Label4.Text, 10, 4) = "G062" Then

                        cmd.Parameters.AddWithValue("@para5", Left(intSNCode, 1) & strSN)
                    Else
                        cmd.Parameters.AddWithValue("@para5", intSN)
                    End If


                    Dim intT As Integer
                    intT = 0
                    'add targets
                    Dim intT1 As Integer
                    If h <= strTargBillet Then

                        intT1 = -1
                        h = h + 1
                    Else
                        intT1 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T01", intT1)
                    Dim intT2 As Integer
                    If h <= strTargBillet Then
                        intT2 = -1
                        h = h + 1
                    Else
                        intT2 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T02", intT2)
                    Dim intT3 As Integer
                    If h <= strTargBillet Then
                        intT3 = -1
                        h = h + 1
                    Else
                        intT3 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T03", intT3)
                    Dim intT4 As Integer
                    If h <= strTargBillet Then
                        intT4 = -1
                        h = h + 1
                    Else
                        intT4 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T04", intT4)
                    Dim intT5 As Integer
                    If h <= strTargBillet Then
                        intT5 = -1
                        h = h + 1
                    Else
                        intT5 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T05", intT5)
                    Dim intT6 As Integer
                    If h <= strTargBillet Then
                        intT6 = -1
                        h = h + 1
                    Else
                        intT6 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T06", intT6)
                    Dim intT7 As Integer
                    If h <= strTargBillet Then
                        intT7 = -1
                        h = h + 1
                    Else
                        intT7 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T07", intT7)
                    Dim intT8 As Integer
                    If h <= strTargBillet Then
                        intT8 = -1
                        h = h + 1
                    Else
                        intT8 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T08", intT8)
                    Dim intT9 As Integer
                    If h <= strTargBillet Then
                        intT9 = -1
                        h = h + 1
                    Else
                        intT9 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T09", intT9)
                    Dim intT10 As Integer
                    If h <= strTargBillet Then
                        intT10 = -1
                        h = h + 1
                    Else
                        intT10 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T10", intT10)
                    Dim intT11 As Integer
                    If h <= strTargBillet Then
                        intT11 = -1
                        h = h + 1
                    Else
                        intT11 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T11", intT11)
                    Dim intT12 As Integer
                    If h <= strTargBillet Then
                        intT12 = -1
                        h = h + 1
                    Else
                        intT12 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T12", intT12)
                    Dim intT13 As Integer
                    If h <= strTargBillet Then
                        intT13 = -1
                        h = h + 1
                    Else
                        intT13 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T13", intT13)
                    Dim intT14 As Integer
                    If h <= strTargBillet Then
                        intT14 = -1
                        h = h + 1
                    Else
                        intT14 = 0
                    End If

                    cmd.Parameters.AddWithValue("@T14", intT14)


                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()

                    'increment billet
                    ' intBillet = intBillet + 1
                Next

                objConn.Close()
                '  daAuthors.Dispose()
            Next


            con.Close()
            Session("LASTSN") = intSN
            Session("SNPREFIX") = Left(intSNCode, 1)

            Response.Redirect("Matrix.aspx")

        End If


    End Sub

    Protected Sub SqlDataSource4_Selecting(sender As Object, e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource4.Selecting

    End Sub

    Private Sub GridView2_RowDeleted(sender As Object, e As System.Web.UI.WebControls.GridViewDeletedEventArgs) Handles GridView2.RowDeleted
        'If Me.GridView2.Rows.Count = 0 Then
        '    Me.Button1.Visible = False
        'End If
    End Sub

    Private Sub GridView2_RowDeleting(sender As Object, e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles GridView2.RowDeleting
        If Me.GridView2.Rows.Count = 0 Then
            Me.Button1.Visible = False
        End If
        Me.GridView2.DataBind()
    End Sub

    Private Sub GridView2_RowUpdated(sender As Object, e As System.Web.UI.WebControls.GridViewUpdatedEventArgs) Handles GridView2.RowUpdated
        If Me.GridView2.Rows.Count = 0 Then
            Me.Button1.Visible = False
        Else
            Me.Button1.Visible = True
        End If
    End Sub

    Private Sub GridView2_RowUpdating(sender As Object, e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles GridView2.RowUpdating

        'Dim str1 As TextBox
        'Dim str2 As TextBox
        'Dim str3 As TextBox
        'Dim str1a As String
        'Dim str2a As String
        'Dim str3a As String

        'For Each rowItem As GridViewRow In GridView2.Rows

        '    str1 = CType(rowItem.Cells(0).FindControl("TextBox1"), TextBox)
        '    str1a = str1.Text
        '    str2 = CType(rowItem.Cells(0).FindControl("TextBox1"), TextBox)
        '    str2a = str2.Text
        '    str3 = CType(rowItem.Cells(0).FindControl("TextBox1"), TextBox)
        '    str3a = str3.Text

        'Next

        'If str1a = "" Then
        '    Dim csname1 As String = "PopupScript"
        '    Dim csname2 As String = "ButtonClickScript"
        '    Dim cstype As Type = Me.GetType()
        '    Dim strmsg As String
        '    Dim strValidate As String

        '    strmsg = "Please enter values before updating"
        '    strValidate = "<script>"
        '    strValidate = strValidate & "alert('" & strmsg & "');"
        '    strValidate = strValidate & "</script>"
        '    ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)

        '    Exit Sub

        'End If

        'If str2a = "" Then
        '    Exit Sub
        'End If

        'If str3a = "" Then
        '    Exit Sub
        'End If


    End Sub

    Public Sub helperSetSetAccess()

        Me.TextBox5.Enabled = True
        Me.Label5.Visible = False
        Me.TextBox4.Visible = False
        Button2.Visible = False

        Dim mymenu As Menu = Master.FindControl("NavigationMenu")
        Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
        mymi.Enabled = True

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox4.Text = "40361" Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True

        ElseIf Session("PASS") <> Nothing Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True

        ElseIf TextBox4.Text = "78356" Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "32472" Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "63330" Then 'leo
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "77281" Then 'Anna
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "77252" Then 'tarama
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "70661" Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True

        ElseIf TextBox4.Text = "16840" Then 'darren
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "65111" Then 'scott
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "28072" Then 'sandy
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf TextBox4.Text = "53013" Then 'cathy L.
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf Me.TextBox4.Text = "61935" Then
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf Me.TextBox4.Text = "64972" Then 'adam duran
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf Me.TextBox4.Text = "15162" Then 'Dflores
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf Me.TextBox4.Text = "5551" Then 'Natalie
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        ElseIf Me.TextBox4.Text = "55561" Then 'Janelle
            Me.TextBox5.Enabled = True
            Me.Label5.Visible = False
            Me.TextBox4.Visible = False
            Button2.Visible = False
            Session("PASS") = Me.TextBox4.Text
            Dim mymenu As Menu = Master.FindControl("NavigationMenu")
            Dim mymi As MenuItem = mymenu.FindItem("Menu Items")
            mymi.Enabled = True
        Else
            Dim csname1 As String = "PopupScript"
            Dim csname2 As String = "ButtonClickScript"
            Dim cstype As Type = Me.GetType()
            Dim strmsg As String
            Dim strValidate As String

            strmsg = "Sorry wrong password...or you do not have permission"
            strValidate = "<script>"
            strValidate = strValidate & "alert('" & strmsg & "');"
            strValidate = strValidate & "</script>"
            ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)

            Exit Sub
        End If

    End Sub


    Private Sub Button2_Load(sender As Object, e As System.EventArgs) Handles Button2.Load

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click




        'check for duplicate----------------------------------------------
        Dim sConnectionString As String
        Dim dsPubs As New DataSet("items")
        Dim dsPubs2 As New DataSet("items")
        Dim tblAuthors As DataTable

        sConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        Dim objConn As New SqlConnection(sConnectionString)

        objConn.Open()
        Session("JOB") = Me.TextBox5.Text
        Dim daAuthors As _
          New SqlDataAdapter("SELECT Job from GETARGETx where Job = '" & Me.TextBox5.Text & "'", objConn)

        daAuthors.Fill(dsPubs, "items")

        tblAuthors = dsPubs.Tables("items")
        Session("JOB") = Trim(Me.TextBox5.Text)
        Me.GridView1.Enabled = True
        If tblAuthors.Rows.Count > 0 Then
            Response.Redirect("MatrixEdit.aspx")
        Else


            Dim dvSql2 As DataView =
  DirectCast(SqlDataSource7.Select(DataSourceSelectArguments.Empty), DataView)
            For Each drvSql As DataRowView In dvSql2

                Label4.Text = drvSql("Itemkey").ToString
                Session("ITEM") = Trim(Label4.Text)
                Label2.Text = drvSql("Itemdescription1").ToString
                Session("DRWG") = Trim(Left(Label2.Text, InStr(Label2.Text, " ")))
            Next

            Label2.Text = "Drwg: " & Trim(Left(Label2.Text, InStr(Label2.Text, " ")))




            '  If Mid(Label4.Text, 10, 4) = "G062" Then


            '          'new requirement for GE
            '          'get itemkey
            Dim dvSql2a As DataView =
  DirectCast(SqlDataSource9.Select(DataSourceSelectArguments.Empty), DataView)
            If dvSql2a.Count = 0 Then

                GridView1.Visible = False
                Dim csname1 As String = "PopupScript"
                Dim csname2 As String = "ButtonClickScript"
                Dim cstype As Type = Me.GetType()
                Dim strmsg As String
                Dim strValidate As String

                strmsg = "Can not continue..An Active Customer Item Number is  not found for this Itemkey...please contact CSR to add this Number into IndustriOS. Bagging will not be able to print labels until Customer Item Number is entered in IndustriOS."
                strValidate = "<script>"
                strValidate = strValidate & "alert('" & strmsg & "');"
                strValidate = strValidate & "</script>"
                ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)

                Exit Sub
            End If
            For Each drvSqla As DataRowView In dvSql2a

                '  Label4.Text = drvSqla("ItemNumber").ToString
                '  Session("ITEM") = Trim(Label4.Text)
                Label2.Text = "Customer Part Number: " & drvSqla("CustItemNumber").ToString
                Session("DRWG") = drvSqla("CustItemNumber").ToString
            Next

            Label2.Text = Trim(Label2.Text)
            '          'end new
        End If
        'old requirement
        '          Dim dvSql2 As DataView =
        'DirectCast(SqlDataSource7.Select(DataSourceSelectArguments.Empty), DataView)
        '          For Each drvSql As DataRowView In dvSql2

        '              Label4.Text = drvSql("Itemkey").ToString
        '              Session("ITEM") = Trim(Label4.Text)
        '              Label2.Text = drvSql("Itemdescription1").ToString
        '              Session("DRWG") = Trim(Left(Label2.Text, InStr(Label2.Text, " ")))
        '          Next

        '          Label2.Text = "Drwg: " & Trim(Left(Label2.Text, InStr(Label2.Text, " ")))
        '          'end old


        Session("ITEM") = Trim(Label4.Text)


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Delete from LOT"

        cmd.ExecuteNonQuery()
        Me.GridView2.DataBind()
        con.Close()
        ' Me.Label6.Text = ComboBox1.SelectedValue.ToString
        'Me.Button1.Visible = False
        '   End If
        objConn.Close()
        Me.Button1.Visible = False


    End Sub

    Protected Sub SqlDataSource7_Selecting(sender As Object, e As System.Web.UI.WebControls.SqlDataSourceSelectingEventArgs) Handles SqlDataSource7.Selecting

    End Sub
End Class