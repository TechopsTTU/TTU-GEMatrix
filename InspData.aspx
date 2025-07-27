<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site4.Master" CodeBehind="InspData.aspx.vb" Inherits="GE.InspData" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <style type="text/css">
        .ajax__combobox_itemlist
        {
            margin: 0px;
            padding: 0px;
            cursor: default;
            list-style-type: none;
            text-align: left;
            border: solid 1px ButtonShadow;
            background-color: Window;
            font-size: x-large;
            font-family: Verdana;
            width: 100%;
        }
    .style1
    {
        font-size: large;
    }
    </style>
    <h2>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h2>
    <h2 class="style1">
        &nbsp;</h2>
    <h2 class="style1">
        Enter Inspection Data for PArts</h2>
    <div>
        <br />
        Job Number:<br />
        <asp:ComboBox ID="ComboBox1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource2" DataTextField="Job" DataValueField="Job" 
            MaxLength="0" style="display: inline;" Font-Size="Large">
        </asp:ComboBox>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT DISTINCT [Job] FROM [SNx] ORDER BY [Job]">
        </asp:SqlDataSource>
        <br />
        Serial Number:<br />
        <asp:ComboBox ID="ComboBox2" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="SN" DataValueField="SN" 
            MaxLength="0" style="display: inline;" Font-Size="Large">
        </asp:ComboBox>
        <br />
    
    </div>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" DataSourceID="SqlDataSource3" Font-Size="Large" Height="50px" 
        Width="259px">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
        DeleteCommand="DELETE FROM [SNx] WHERE [Job] = @Job AND [SN] = @SN" 
        InsertCommand="INSERT INTO [SNx] ([Job], [SN], [OD1], [ID1], [Height], [Weight]) VALUES (@Job, @SN, @OD1, @ID1, @Height, @Weight)" 
        SelectCommand="SELECT [Job], [SN], [OD1], [ID1], [Height], [Weight] FROM [SNx] WHERE (([Job] = @Job) AND ([SN] = @SN))" 
        
        UpdateCommand="UPDATE [SNx] SET [OD1] = @OD1, [ID1] = @ID1, [Height] = @Height, [Weight] = @Weight WHERE [Job] = @Job AND [SN] = @SN">
        <DeleteParameters>
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="SN" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="SN" Type="String" />
            <asp:Parameter Name="OD1" Type="Double" />
            <asp:Parameter Name="ID1" Type="Double" />
            <asp:Parameter Name="Height" Type="Double" />
            <asp:Parameter Name="Weight" Type="Double" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="ComboBox1" Name="Job" 
                PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="ComboBox2" Name="SN" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="OD1" Type="Double" />
            <asp:Parameter Name="ID1" Type="Double" />
            <asp:Parameter Name="Height" Type="Double" />
            <asp:Parameter Name="Weight" Type="Double" />
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="SN" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
        
        SelectCommand="SELECT SN FROM SNx WHERE (Job = @Job2) AND (SUBSTRING(SN, 9, 2) = '01')">
        <SelectParameters>
            <asp:ControlParameter ControlID="ComboBox1" Name="Job2" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

     </asp:Content>
