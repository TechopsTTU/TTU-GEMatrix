Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
'Imports Microsoft.SqlServer.Dts.Runtime
Imports System.Threading
Imports System.IO.File
Imports System.IO


Public Class Matrix
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Thread.Sleep(TimeSpan.FromSeconds(2))
        ''Check to see if SN exists
        'strSQL = "SELECT [SN].[Job#] FROM SN WHERE ((SN.[Job#])= '" & strJob & "');"
        'rs = db.OpenRecordset(strSQL, dbOpenDynaset)
        'If rs.BOF = True And rs.EOF = True Then
        '    'Create SN since none exist
        '    fPopulateSN()
        'Else
        '    'SN exist
        '    MsgBox("Serial numbers were already generated", vbOKOnly, "Proceding to Output Form")
        '    DoCmd.OpenForm("SelectOutput", , , stLinkCriteria)
        'End If

        'get flex

        Dim sConnectionString As String
        sConnectionString = "Server=REPORTSRVR\SQL2008;Database=LotNumber;Integrated Security=SSPI"
        Dim objConn As New SqlConnection(sConnectionString)
        Dim dsFlex As New DataSet("items")

        Dim tblFlex As DataTable
        Dim strJob As String
        strJob = Session("JOB")

        Dim daFlex As _
          New SqlDataAdapter("SELECT Flexural FROM View_LotNumberForReport1 WHERE JobNumber Like '" & strJob & "%'", objConn)
        daFlex.Fill(dsFlex, "items")
        tblFlex = dsFlex.Tables("items")
        Dim dblFlex As Double
        Dim drCurrent As DataRow
        'get if empty
        If tblFlex.Rows.Count = 0 Then
            Dim csname1 As String = "PopupScript"
            Dim csname2 As String = "ButtonClickScript"
            Dim cstype As Type = Me.GetType()
            Dim strmsg As String
            Dim strValidate As String
            strmsg = "Flexural Not Found...Lot Data missing flex data"
            strValidate = "<script>"
            strValidate = strValidate & "alert('" & strmsg & "');"
            strValidate = strValidate & "</script>"
            ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)

            Exit Sub
        End If

        'end
        For Each drCurrent In tblFlex.Rows

            dblFlex = drCurrent("Flexural").ToString
            Exit For

        Next


        daFlex.Dispose()
        'end flex



        Dim intSN As String
        Dim strSNPrefix As String

        intSN = Session("LASTSN")
        strSNPrefix = Session("SNPREFIX")
        'Create Text file for ShopFloor
        ' Dim strJob As String = ""
        Dim strSN As String
        Dim intT1 As String
        Dim intT2 As String
        Dim intT3 As String
        Dim intT4 As String
        Dim intT5 As String
        Dim intT6 As String
        Dim intT7 As String
        Dim intT8 As String
        Dim intT9 As String
        Dim intT10 As String
        Dim intT11 As String
        Dim intT12 As String
        Dim intT13 As String
        Dim intT14 As String
        Dim intTCheck As CheckBox
        Dim strBillet As Integer
        Dim strLot As String
        Dim strCode As String
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim strPreFix As String


        'insert into SN Table
        ' con.Close()

        con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con.Open()
        cmd.Connection = con

        For Each oItem As GridViewRow In GridView1.Rows
            strJob = Trim(oItem.Cells(1).Text)

            strSN = Trim(oItem.Cells(2).Text)
            strBillet = Trim(oItem.Cells(17).Text)
            strLot = Trim(oItem.Cells(18).Text)
            strCode = Trim(oItem.Cells(19).Text)

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox1"), CheckBox)
            If intTCheck.Checked = True Then
                intT1 = -1
            Else
                intT1 = 0
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox2"), CheckBox)
            If intTCheck.Checked = True Then
                intT2 = -1
            Else
                intT2 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox3"), CheckBox)
            If intTCheck.Checked = True Then
                intT3 = -1
            Else
                intT3 = 0
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox4"), CheckBox)
            If intTCheck.Checked = True Then
                intT4 = -1
            Else
                intT4 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox5"), CheckBox)
            If intTCheck.Checked = True Then
                intT5 = -1
            Else
                intT5 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox6"), CheckBox)
            If intTCheck.Checked = True Then
                intT6 = -1
            Else
                intT6 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox7"), CheckBox)
            If intTCheck.Checked = True Then
                intT7 = -1
            Else
                intT7 = 0
            End If


            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox8"), CheckBox)
            If intTCheck.Checked = True Then
                intT8 = -1
            Else
                intT8 = 0
            End If


            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox9"), CheckBox)
            If intTCheck.Checked = True Then
                intT9 = -1
            Else
                intT9 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox10"), CheckBox)
            If intTCheck.Checked = True Then
                intT10 = -1
            Else
                intT10 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox11"), CheckBox)
            If intTCheck.Checked = True Then
                intT11 = -1
            Else
                intT11 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox12"), CheckBox)
            If intTCheck.Checked = True Then
                intT12 = -1
            Else
                intT12 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox13"), CheckBox)
            If intTCheck.Checked = True Then
                intT13 = -1
            Else
                intT13 = 0
            End If

            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox14"), CheckBox)
            If intTCheck.Checked = True Then
                intT14 = -1
            Else
                intT14 = 0
            End If
            'Dim con As New SqlConnection
            'Dim cmd As New SqlCommand


            strSN = Left(strCode, 3) & strSN

            ''insert into SN Table
            'con.Close()


            'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
            'con.Open()
            'cmd.Connection = con

            If intT1 = -1 Then

                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target, flex) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7,@para8)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "01")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "1")
                cmd.Parameters.AddWithValue("@para8", dblFlex)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            '  Dim con As New SqlConnection
            '  Dim cmd As New SqlCommand
            If intT2 = -1 Then

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con

                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "02")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "2")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()

            End If
            If intT3 = -1 Then

                ' Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "03")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "3")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT4 = -1 Then

                '   Dim con As New SqlConnection
                '   Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "04")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "4")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT5 = -1 Then

                ' Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "05")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "5")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If

            If intT6 = -1 Then

                '   Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "06")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "6")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If

            If intT7 = -1 Then

                '  Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "07")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "7")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If


            If intT8 = -1 Then

                ' Dim con As New SqlConnection
                ' Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "08")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "8")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT9 = -1 Then

                ' Dim con As New SqlConnection
                ' Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "09")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "9")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT10 = -1 Then

                '  Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "10")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "10")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If

            If intT11 = -1 Then

                '  Dim con As New SqlConnection
                ' Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "11")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "11")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT12 = -1 Then

                '  Dim con As New SqlConnection
                ' Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "12")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "12")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
            If intT13 = -1 Then

                '  Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "13")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "13")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If

            If intT14 = -1 Then

                '  Dim con As New SqlConnection
                '  Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                'cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target, mmyyyy) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "14")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "14")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If
        Next


        con.Close()


        'Append Temp table data to GETARGET
        Dim strSQL As String
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con1.Open()

        strSQL = " INSERT INTO GETARGETx ( GECode, SN, T01, T02, T03, T04, T05, T06, T07, T08, T09, T10, T11, T12, T13, T14, Lot, BilletNo, Job ) " & _
"SELECT TempForSN.GECode, TempForSN.SN, TempForSN.T01, TempForSN.T02, TempForSN.T03,TempForSN.T04, TempForSN.T05, TempForSN.T06, TempForSN.T07, TempForSN.T08, TempForSN.T09, TempForSN.T10, TempForSN.T11, TempForSN.T12, TempForSN.T13, TempForSN.T14, TempForSN.Lot, TempForSN.BilletNo, TempForSN.Job " & _
"FROM TempForSN;"

        cmd1.Connection = con1
        cmd1.CommandText = strSQL
        cmd1.ExecuteNonQuery()

        ''Update LastSN 
        'Dim con2 As New SqlConnection
        'Dim cmd2 As New SqlCommand

        'con2.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        'con2.Open()
        strPreFix = Left(strCode, 3)


        'Check if code has specific serial number
        Dim dsCodeItems As New DataSet("items")

        Dim tblCodes As DataTable
        If Left(strCode, 3) <> "TPM" Then
            Dim daCode As _
         New SqlDataAdapter("SELECT * from LastSNbyCode WHERE GECode Like '" & strCode & "'", con1)
            daCode.Fill(dsCodeItems, "items")
            tblCodes = dsCodeItems.Tables("items")
        Else
            Dim daCode As _
         New SqlDataAdapter("SELECT * from LastSNbyCode WHERE GECode Like '" & strPreFix & "'", con1)
            daCode.Fill(dsCodeItems, "items")
            tblCodes = dsCodeItems.Tables("items")
        End If
     


        Dim strSQL2 As String



        'get if empty
        If tblCodes.Rows.Count > 0 Then
            If strPreFix <> "TPM" Then

                intSN = intSN.ToString.PadLeft(4, "0"c)
                strSQL2 = "Update LastSNByCode Set LastNo='" & strSNPrefix & intSN & " ' where GECode ='" & strPreFix & "';"
                ' strSQL2 = "Update LastSNByCode Set LastNo='" & intSN & " ' where GECode ='" & strCode & "';"

            Else
                intSN = Trim(intSN)
                strSQL2 = "Update LastSNByCode Set LastNo='" & intSN & " ' where GECode ='" & strPreFix & "';"

            End If
            
            cmd1.Connection = con1
            cmd1.CommandText = strSQL2
            cmd1.ExecuteNonQuery()

        End If





            

            con1.Close()
        'open sn table for serial to file

        'Generate file for shop floor
        Dim sw As New StreamWriter("\\10.1.1.92\reports\GE_DBase\" & strJob & ".txt")
        Dim dvSql As DataView =
            DirectCast(SqlDataSource2.Select(DataSourceSelectArguments.Empty), DataView)
            For Each drvSql As DataRowView In dvSql
                strSN = drvSql("SN").ToString
                sw.WriteLine(strSN)
            Next

            sw.Close()



            'update who did it.
            Dim strEMP As String
            strEMP = Session("PASS")

            Dim conEmp As New SqlConnection
            Dim cmdEmp As New SqlCommand

            conEmp.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
            conEmp.Open()
            cmdEmp.Connection = conEmp
            cmdEmp.CommandText = "INSERT INTO GE_EMP_SEC (Emp, Job) Values (@para1, @para2)"
            cmdEmp.Parameters.AddWithValue("@para1", strEMP)
            cmdEmp.Parameters.AddWithValue("@para2", strJob)
            cmdEmp.ExecuteNonQuery()
            cmdEmp.Parameters.Clear()
            conEmp.Close()
            Session("JOB") = strJob
            'Labels
            Response.Redirect("prntEmptyTargets.aspx")


    End Sub


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Thread.Sleep(TimeSpan.FromSeconds(2))
        'delete sn from table
        Dim strJob As String
        strJob = Session("JOB")
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        'delete temp table

        con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM TempForSN where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()
        'end delete
        Response.Redirect("JobEntry.aspx")
    End Sub
End Class