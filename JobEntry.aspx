<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
     CodeBehind="~/JobEntry.aspx.vb" Inherits ="GE._Default" %>
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
        <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="OK" />
    </h2>
    <h2 class="style1">
        Enter Job to Create new Matrix</h2>
    <asp:Panel ID="Panel1" runat="server" DefaultButton="Button3" Height="86px">
        <asp:TextBox ID="TextBox5" runat="server" CssClass="style1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="39px" Text="OK" Width="96px" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource8" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Indust2.7 %>" 
            ProviderName="<%$ ConnectionStrings:Indust2.7.ProviderName %>" 
            SelectCommand="SELECT JobNumber, ItemNumber, Itemdescription1 FROM JobItemDesc WHERE (JobNumber = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox5" Name="JobNumber" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource10">
            <Columns>
                <asp:BoundField DataField="Lotnumber" HeaderText="Lotnumber" 
                    SortExpression="Lotnumber" />
                <asp:BoundField DataField="Density" HeaderText="Density" 
                    SortExpression="Density" />
                <asp:BoundField DataField="Hardness" HeaderText="Hardness" 
                    SortExpression="Hardness" />
                <asp:BoundField DataField="Resistivity" HeaderText="Resistivity" 
                    SortExpression="Resistivity" />
                <asp:BoundField DataField="Flexural" HeaderText="Flexural" 
                    SortExpression="Flexural" />
                <asp:BoundField DataField="Compressive" HeaderText="Compressive" 
                    SortExpression="Compressive" />
                <asp:BoundField DataField="Ash" HeaderText="Ash" SortExpression="Ash" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <p>
    </p>
    <div>
        <br />
         <div id='spinner' class='spinner'></div>
 &nbsp;<asp:SqlDataSource ID="SqlDataSource9" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Indust_GE %>" 
            ProviderName="<%$ ConnectionStrings:Indust_GE.ProviderName %>" 
            SelectCommand="SELECT JobNumber, ItemNumber, Customername, CustItemNumber FROM vGE_Labels WHERE (JobNumber = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox5" DefaultValue="x" Name="JobNumber" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Label ID="Label4" runat="server"  style="font-size: large; font-weight: 700;"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" 
            style="font-size: large; font-weight: 700;"></asp:Label>
        <br />
        <br />
    </div>
       
    <div>
 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" Font-Size="X-Large" Width="532px" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <EmptyDataTemplate > 
           <asp:Label ID ="lblNorecId" runat ="server" Font-Italic="true"  Text ="No Lotnumber found for that Jobnumber..."></asp:Label>
           </EmptyDataTemplate>
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField HeaderText="LotNumber" SortExpression="LotNumber">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LotNumber") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("LotNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
       
    <p>
        <asp:Button ID="Button1" runat="server" Height="46px" Text="Generate Matrix" 
            Visible="False" Width="279px" />

    </p>
    <div style="width: 1000px">
 <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource3" Font-Size="Large" Width="994px" 
            DataKeyNames="ID" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" 
                            CommandName="Update" Font-Bold="False" Font-Size="Large" Text="Update"></asp:LinkButton>
                        &nbsp;
                    </EditItemTemplate>
                    <ItemTemplate>
                        &nbsp;
                    </ItemTemplate>
                    <ItemStyle Font-Bold="True" Font-Size="Large" ForeColor="White" 
                        VerticalAlign="Top" />
                </asp:TemplateField>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" 
                    InsertVisible="False" ReadOnly="True" Visible="False">
                </asp:BoundField>
                <asp:BoundField DataField="Lot" HeaderText="Lot" SortExpression="Lot" 
                    ReadOnly="True">
                <ControlStyle Font-Bold="True" Font-Size="Large" />
                <ItemStyle Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" 
                    Wrap="False" ForeColor="Black" VerticalAlign="Top" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="From" SortExpression="From">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("From") %>' 
                            MaxLength="2"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" 
                            Font-Size="Small" ForeColor="Red">Must enter value before updating</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("From") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Bold="True" Font-Size="Large" />
                    <ItemStyle Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="To" SortExpression="To">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("To") %>' 
                            MaxLength="2"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" 
                            Font-Size="Small" ForeColor="Red">Please enter value before updating</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("To") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Bold="True" Font-Size="Large" />
                    <ItemStyle Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TargPerBillet" SortExpression="TargPerBillet">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("TargPerBillet") %>' 
                            MaxLength="2"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" 
                            Font-Size="Small" ForeColor="Red">must enter value before updating</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("TargPerBillet") %>'></asp:Label>
                    </ItemTemplate>
                    <ControlStyle Font-Bold="True" Font-Size="Large" />
                    <ItemStyle Font-Bold="True" Font-Size="Large" HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

    </div>
    <div>
 <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConflictDetection="CompareAllValues"
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            DeleteCommand="DELETE FROM [Lot] WHERE ([Lot] = @Lot)" 
            InsertCommand="INSERT INTO [Lot] ([ID], [Lot], [From], [To], [TargPerBillet]) VALUES (@ID, @Lot, @From, @To, @TargPerBillet)" 
            SelectCommand="SELECT [ID], [Lot], [From], [To], [TargPerBillet] FROM [Lot] ORDER BY [Lot]" 
            
            UpdateCommand="UPDATE [Lot] SET [Lot] = @Lot, [From] = @From, [To] = @To, [TargPerBillet] = @TargPerBillet WHERE [Lot] = @Lot">
            <DeleteParameters>
                <asp:Parameter Name ="Lot" Type ="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="From" Type="Int32" />
                <asp:Parameter Name="To" Type="Int32" />
                <asp:Parameter Name="TargPerBillet" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="From" Type="Int32" />
                <asp:Parameter Name="To" Type="Int32" />
                <asp:Parameter Name="TargPerBillet" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" 
            ConnectionString="Data Source=10.1.1.92\SQL2008;Initial Catalog=GE;Integrated Security=True" 
            SelectCommand="SELECT [GECode], [LastNo] FROM [LastSNbyCode] WHERE ([GECode] = @GECode)" ProviderName="<%$ ConnectionStrings:GEConnectionString2.ProviderName %>">
            <SelectParameters>
                <asp:SessionParameter Name="GECode" SessionField="CODE" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
       
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
            ConnectionString="Dsn=Toyo64" 
            ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" 
            
            SelectCommand="SELECT INMAST_DBM.Itemkey,  INMAST_DBM.Itemdescription1 FROM INMAST_DBM WHERE ( INMAST_DBM.Itemkey = ?)">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="z" Name="ItemNumber" SessionField="ITEM" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
       
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT [LastNo] FROM [LastSN]"></asp:SqlDataSource>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:LotNumberConnectionString %>" 
            
            SelectCommand="SELECT DISTINCT [LotNumber] FROM [LotNumbers] WHERE ([JobNumber] = @JobNumber)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox5" Name="JobNumber" 
                    PropertyName="Text" Type="String" DefaultValue="" />
            </SelectParameters>
        </asp:SqlDataSource>



        <asp:SqlDataSource ID="SqlDataSource10" runat="server" 
            ConnectionString="<%$ ConnectionStrings:LotNumberConnectionString %>" 
            SelectCommand="SELECT DISTINCT [Lotnumber], [Density], [Hardness], [Resistivity], [Flexural], [Compressive], [Ash], [Grade] FROM [View_LotNumberForReport] WHERE ([JobNumber] = @JobNumber)">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox5" Name="JobNumber" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>



        <asp:SqlDataSource ID="SqlDataSource7" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Indust_GE %>" 
            
            SelectCommand="SELECT Itemkey, Itemdescription1 FROM TTUACCESS.SNDATAJOBS WHERE (JobNumber = ?)" 
            ProviderName="<%$ ConnectionStrings:Indust_GE.ProviderName %>">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox5" Name="JobNumber" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>



        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            
            
            
            
            SelectCommand="SELECT DISTINCT [Job], ItemNumber FROM [View_Union_jobs] ORDER BY [Job]">
        </asp:SqlDataSource>



    </div>
       
               
    </asp:Content>
