<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Search.aspx.vb" Inherits="GE.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enter Serial Number:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Find" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="SN" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="Job" HeaderText="Job" SortExpression="Job" />
                        <asp:BoundField DataField="SN" HeaderText="Serial Number" ReadOnly="True" 
                            SortExpression="SN" />
                        <asp:BoundField DataField="code" HeaderText="Code" SortExpression="code" />
                        <asp:BoundField DataField="Lot" HeaderText="Lot" SortExpression="Lot" />
                        <asp:BoundField DataField="Billet" HeaderText="Billet" 
                            SortExpression="Billet" />
                        <asp:BoundField DataField="Target" HeaderText="Target" 
                            SortExpression="Target" />
                        <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
                    SelectCommand="SELECT [SN], [code], [Description], [mmyyyy], [Job], [date], [Billet], [Lot], [Target] FROM [SNx] WHERE ([SN] = @SN)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" Name="SN" PropertyName="Text" 
                            Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
