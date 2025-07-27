<%@ Page Language="vb"  MasterPageFile="~/Site3.Master" AutoEventWireup="false" CodeBehind="Codes.aspx.vb" Inherits="GE.Codes" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
<strong><span class="style1">Enter New Code:</span><asp:DetailsView 
    ID="DetailsView1" runat="server" AutoGenerateRows="False" CssClass="style1" 
    DataKeyNames="TDWG,CODE" DataSourceID="SqlDataSource1" Height="50px" 
    Width="451px">
    <Fields>
        <asp:BoundField DataField="TDWG" HeaderText="Drawing (without REV)" ReadOnly="True" 
            SortExpression="TDWG" />
        <asp:BoundField DataField="CODE" HeaderText="CODE" ReadOnly="True" 
            SortExpression="CODE" />
        <asp:BoundField DataField="TNAME" HeaderText="TNAME" SortExpression="TNAME" />
        <asp:BoundField DataField="BCO" HeaderText="BCO" SortExpression="BCO" />
        <asp:BoundField DataField="NO" HeaderText="NO" SortExpression="NO" />
        <asp:CommandField ShowInsertButton="True" />
    </Fields>
</asp:DetailsView>
</strong>
<br />
<strong><span class="style1">All Codes:<br />
    </span>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="TDWG,CODE" DataSourceID="SqlDataSource1" 
    CssClass="style1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:TemplateField HeaderText="TDWG" SortExpression="TDWG">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("TDWG") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("TDWG") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CODE" SortExpression="CODE">
                <EditItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("CODE") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("CODE") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="TNAME" SortExpression="TNAME">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TNAME") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("TNAME") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </strong>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GEConnectionString2 %>" 
        DeleteCommand="DELETE FROM [GE_CODE] WHERE [TDWG] = @TDWG AND [CODE] = @CODE" 
        InsertCommand="INSERT INTO [GE_CODE] ([TDWG], [CODE], [TNAME], [BCO], [NO]) VALUES (@TDWG, @CODE, @TNAME, @BCO, @NO)" 
        SelectCommand="SELECT [TDWG], [CODE], [TNAME], [BCO], [NO] FROM [GE_CODE]" 
        UpdateCommand="UPDATE [GE_CODE] SET [TNAME] = @TNAME, [BCO] = @BCO, [NO] = @NO WHERE [TDWG] = @TDWG AND [CODE] = @CODE">
        <DeleteParameters>
            <asp:Parameter Name="TDWG" Type="String" />
            <asp:Parameter Name="CODE" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="TDWG" Type="String" />
            <asp:Parameter Name="CODE" Type="String" />
            <asp:Parameter Name="TNAME" Type="String" />
            <asp:Parameter Name="BCO" Type="String" />
            <asp:Parameter Name="NO" Type="Double" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TNAME" Type="String" />
            <asp:Parameter Name="BCO" Type="String" />
            <asp:Parameter Name="NO" Type="Double" />
            <asp:Parameter Name="TDWG" Type="String" />
            <asp:Parameter Name="CODE" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
 </asp:Content>