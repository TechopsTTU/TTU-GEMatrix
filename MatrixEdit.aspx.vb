Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
'Imports Microsoft.SqlServer.Dts.Runtime
Imports System.Threading
Imports System.IO.File
Imports System.IO


Public Class MatrixEdit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
        Else
            Dim chk1 As CheckBox
            Dim intTCheck As CheckBox
            Dim i As Integer

            chk1 = GridView1.HeaderRow.FindControl("CheckBox15") 'T01 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox1"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox1"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If

            chk1 = GridView1.HeaderRow.FindControl("CheckBox16") 'T02 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox2"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox2"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox17") 'T03 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox3"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox3"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox18") 'T04 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox4"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox4"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If

            chk1 = GridView1.HeaderRow.FindControl("CheckBox19") 'T05 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox5"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox5"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If

            chk1 = GridView1.HeaderRow.FindControl("CheckBox20") 'T06 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox6"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox6"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox21") 'T07 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox7"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox7"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox22") 'T08 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox8"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox8"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox23") 'T09 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox9"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox9"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox24") 'T10 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox10"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox10"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox25") 'T11 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox11"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox11"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox26") 'T12 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox12"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox12"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox27") 'T13 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox13"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox13"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If
            chk1 = GridView1.HeaderRow.FindControl("CheckBox28") 'T14 All

            If chk1.Checked = True Then
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox14"), CheckBox)
                    intTCheck.Checked = True

                    i = i + 1

                Next
            Else
                i = 0
                For Each oItem As GridViewRow In GridView1.Rows
                    intTCheck = DirectCast(GridView1.Rows(i).FindControl("CheckBox14"), CheckBox)
                    intTCheck.Checked = False
                    i = i + 1

                Next
            End If


            'Dim csname1 As String = "PopupScript"
            'Dim csname2 As String = "ButtonClickScript"
            'Dim cstype As Type = Me.GetType()
            'Dim strmsg As String
            'Dim strValidate As String

            'strmsg = "If changes were made you must click ReGenerate File to update the network file."
            'strValidate = "<script>"
            'strValidate = strValidate & "alert('" & strmsg & "');"
            'strValidate = strValidate & "</script>"
            'ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)
            'Exit Sub
        End If
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
        '

        'delete sn from table
        Dim strJob As String

        strJob = Session("JOB")
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand

        con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM SNx where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()

        'end delete

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

        con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con.Open()
        For Each oItem As GridViewRow In GridView1.Rows
            strJob = oItem.Cells(1).Text
            strSN = oItem.Cells(2).Text
            strBillet = oItem.Cells(17).Text
            strLot = oItem.Cells(18).Text
            strCode = oItem.Cells(19).Text
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


            strSN = Left(strCode, 3) & strSN


            'insert into SN Table
            If intT1 = -1 Then
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
                cmd.Parameters.AddWithValue("@para1", strJob)
                cmd.Parameters.AddWithValue("@para2", strCode)
                cmd.Parameters.AddWithValue("@para3", Date.Today.ToString)
                cmd.Parameters.AddWithValue("@para4", strSN & "01")
                cmd.Parameters.AddWithValue("@para5", strLot)
                cmd.Parameters.AddWithValue("@para6", strBillet)
                cmd.Parameters.AddWithValue("@para7", "1")
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            End If

            If intT2 = -1 Then


                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
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

                'Dim con As New SqlConnection
                'Dim cmd As New SqlCommand

                'con.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
                'con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO SNx (Job, CODE, date, SN, Lot, Billet, Target) Values (@para1, @para2, @para3, @para4, @para5, @para6, @para7)"
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

        'update getargetx 
        Dim strSQL As String

        strSQL = "Update GETARGETx set T01=" & intT1 & ", T02=" & intT2 & ", T03=" & intT3 & ", T04=" & intT4 & ", T05=" & intT5 & ", T06=" & intT6 & ", T07=" & intT7 & ", T08=" & intT8 & ", T09=" & intT9 & ", T10=" & intT10 & ", T11=" & intT11 & ", T12=" & intT12 & ", T13=" & intT13 & ", T14=" & intT14 & " where Job='" & strJob & "' and GECODE ='" & strCode & "';"

        cmd1.Connection = con
        cmd1.CommandText = strSQL
        cmd1.ExecuteNonQuery()
        strJob = Trim(strJob)
        'Generate file for shop floor
        Dim sw As New StreamWriter("\\10.1.1.92\reports\GE_DBase\" & strJob & ".txt")
        Dim dvSql As DataView =
        DirectCast(SqlDataSource3.Select(DataSourceSelectArguments.Empty), DataView)
        For Each drvSql As DataRowView In dvSql
            strSN = drvSql("SN").ToString
            sw.WriteLine(strSN)
        Next

        sw.Close()
        con.Close()

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
        con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM SNx where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()
        'end delete
        'delete Getarget from table
        strJob = Session("JOB")
        '  con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        'con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM Getargetx where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()
        'end delete

        'delete temp table
        strJob = Session("JOB")
        '  con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        ' con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM TempForSN where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()
        'end delete
        Response.Redirect("JobEntry.aspx")

        'delete emp sec
        strJob = Session("JOB")
        '  con1.ConnectionString = "Server=REPORTSRVR\SQL2008;Database=GE;Integrated Security=SSPI"
        ' con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "DELETE FROM GE_EMP_SEC where Job='" & strJob & "'"
        cmd1.ExecuteNonQuery()
        'end delete
        Response.Redirect("JobEntry.aspx")


    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Thread.Sleep(TimeSpan.FromSeconds(2))
        Response.Redirect("prntTargets.aspx")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Thread.Sleep(TimeSpan.FromSeconds(2))
        Response.Redirect("prntLabels.aspx")
    End Sub


    Private Sub GridView1_DataBound(sender As Object, e As System.EventArgs) Handles GridView1.DataBound
        Dim chk1 As CheckBox
        Dim intTCheck As CheckBox

            For Each oItem As GridViewRow In GridView1.Rows
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox1"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox15") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox2"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox16") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox3"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox17") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox4"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox18") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox5"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox19") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox6"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox20") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox7"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox21") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox8"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox22") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox9"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox23") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox10"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox24") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox11"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox25") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox12"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox26") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox13"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox27") 'T01 All
                chk1.Checked = True
            End If
            intTCheck = DirectCast(GridView1.Rows(0).FindControl("CheckBox14"), CheckBox)
            If intTCheck.Checked = True Then
                chk1 = GridView1.HeaderRow.FindControl("CheckBox28") 'T01 All
                chk1.Checked = True
            End If
        Next


    End Sub

    Private Sub GridView1_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
      
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As System.Web.UI.WebControls.GridViewDeletedEventArgs) Handles GridView1.RowDeleted
        Dim csname1 As String = "PopupScript"
        Dim csname2 As String = "ButtonClickScript"
        Dim cstype As Type = Me.GetType()
        Dim strmsg As String
        Dim strValidate As String

        strmsg = "You just deleted a Billet so you must click Re-Generate File to update the network file."
        strValidate = "<script>"
        strValidate = strValidate & "alert('" & strmsg & "');"
        strValidate = strValidate & "</script>"
        ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)
        Exit Sub
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As System.Web.UI.WebControls.GridViewUpdatedEventArgs) Handles GridView1.RowUpdated
        Dim csname1 As String = "PopupScript"
        Dim csname2 As String = "ButtonClickScript"
        Dim cstype As Type = Me.GetType()
        Dim strmsg As String
        Dim strValidate As String

        strmsg = "If changes were made you must click ReGenerate File to update the network file."
        strValidate = "<script>"
        strValidate = strValidate & "alert('" & strmsg & "');"
        strValidate = strValidate & "</script>"
        ClientScript.RegisterStartupScript(cstype, csname1, strValidate, False)
        Exit Sub
    End Sub


    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
       
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Thread.Sleep(TimeSpan.FromSeconds(2))
        Response.Redirect("prntJobSN.aspx")
    End Sub
End Class