<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="MatrixEdit.aspx.vb" Inherits="GE.MatrixEdit" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script type="text/javascript">
 //<![CDATA[
    function CheckAll(oCheckbox) {
        alert('Any changes and you must click Re-Generate file button');
        }
  
//]]>
 </script>


    <div style="width: 1250px">
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT [Job] FROM [GETARGETx]">
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
          <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true" UpdateMode="Always">
    <ContentTemplate>
        <asp:Button ID="Button3" runat="server" Text="Print Matrix Only" Height="49px" 
            Width="284px" />
        <br />
        
        <br />
        <asp:Button ID="Button4" runat="server" Height="48px" Text="Print Labels" 
            Width="284px" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Height="48px" 
            Text="Print Job and Serial#'s" Width="284px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="52px" 
            Text="Re-Generate Matrix and Network File" 
            ToolTip="This will re-create using same serialnumbers from the matrix below including changes." 
            Width="285px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="52px"  OnClientClick="return confirm('Are you sure?');" 
            Text="Delete and Start Over" 
            ToolTip="This will complete delete the history and generate new serial numbers" 
            Width="282px" />
             <br />
             </ContentTemplate>
    </asp:UpdatePanel>
        <asp:Label ID="Label1" runat="server" ForeColor="Red" 
            Text="That JobNumber already has had Serial Numbers generated...See Below."></asp:Label>
    
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="SN,Job,GECode" DataSourceID="SqlDataSource2" 
        ForeColor="#333333" GridLines="None" Width="1194px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="Job" HeaderText="Job" ReadOnly="True" 
                SortExpression="Job" />
            <asp:BoundField DataField="SN" HeaderText="SN" ReadOnly="True" 
                SortExpression="SN" />
            <asp:TemplateField HeaderText="T01" SortExpression="T01">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("T01") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T01&nbsp;&nbsp;
                    <br />
                    <asp:CheckBox ID="CheckBox15" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)"/>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("T01") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T02" SortExpression="T02">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("T02") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T02<br />
                    <asp:CheckBox ID="CheckBox16" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("T02") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T03" SortExpression="T03">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("T03") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T03<br />
                    <asp:CheckBox ID="CheckBox17" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("T03") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T04" SortExpression="T04">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("T04") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T04<br />
                    <asp:CheckBox ID="CheckBox18" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("T04") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T05" SortExpression="T05">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox5" runat="server" Checked='<%# Bind("T05") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T05<br />
                    <asp:CheckBox ID="CheckBox19" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox5" runat="server" Checked='<%# Bind("T05") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T06" SortExpression="T06">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox6" runat="server" Checked='<%# Bind("T06") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T06<br />
                    <asp:CheckBox ID="CheckBox20" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox6" runat="server" Checked='<%# Bind("T06") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T07" SortExpression="T07">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox7" runat="server" Checked='<%# Bind("T07") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T07<br />
                    <asp:CheckBox ID="CheckBox21" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox7" runat="server" Checked='<%# Bind("T07") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T08" SortExpression="T08">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox8" runat="server" Checked='<%# Bind("T08") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T08<br />
                    <asp:CheckBox ID="CheckBox22" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox8" runat="server" Checked='<%# Bind("T08") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T09" SortExpression="T09">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox9" runat="server" Checked='<%# Bind("T09") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T09<br />
                    <asp:CheckBox ID="CheckBox23" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox9" runat="server" Checked='<%# Bind("T09") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T10" SortExpression="T10">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox10" runat="server" Checked='<%# Bind("T10") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T10<br />
                    <asp:CheckBox ID="CheckBox24" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox10" runat="server" Checked='<%# Bind("T10") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T11" SortExpression="T11">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox11" runat="server" Checked='<%# Bind("T11") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T11<br />
                    <asp:CheckBox ID="CheckBox25" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox11" runat="server" Checked='<%# Bind("T11") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T12" SortExpression="T12">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox12" runat="server" Checked='<%# Bind("T12") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T12<br />
                    <asp:CheckBox ID="CheckBox26" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox12" runat="server" Checked='<%# Bind("T12") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T13" SortExpression="T13">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox13" runat="server" Checked='<%# Bind("T13") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T13<br />
                    <asp:CheckBox ID="CheckBox27" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox13" runat="server" Checked='<%# Bind("T13") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="T14" SortExpression="T14">
                <EditItemTemplate>
                    <asp:CheckBox ID="CheckBox14" runat="server" Checked='<%# Bind("T14") %>' />
                </EditItemTemplate>
                <HeaderTemplate>
                    T14<br />
                    <asp:CheckBox ID="CheckBox28" runat="server" Text="All" AutoPostBack="True" type="checkbox" onclick="CheckAll(this)" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox14" runat="server" Checked='<%# Bind("T14") %>' 
                        Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="BilletNo" HeaderText="BilletNo" 
                SortExpression="BilletNo" />
            <asp:BoundField DataField="Lot" HeaderText="Lot" SortExpression="Lot" />
            <asp:BoundField DataField="GECode" HeaderText="GECode" ReadOnly="True" 
                SortExpression="GECode" />
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
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
        DeleteCommand="DELETE FROM [GETARGETx] WHERE [SN] = @SN AND [Job] = @Job AND [GECode] = @GECode" 
        InsertCommand="INSERT INTO [GETARGETx] ([SN], [T01], [T02], [T03], [T04], [T05], [T06], [T07], [T08], [T09], [T10], [T11], [T12], [T13], [T14], [Lot], [BilletNo], [Job], [GECode]) VALUES (@SN, @T01, @T02, @T03, @T04, @T05, @T06, @T07, @T08, @T09, @T10, @T11, @T12, @T13, @T14, @Lot, @BilletNo, @Job, @GECode)" 
        SelectCommand="SELECT SN, T01, T02, T03, T04, T05, T06, T07, T08, T09, T10, T11, T12, T13, T14, Lot, BilletNo, Job, GECode FROM GETARGETx WHERE (Job = @Job) ORDER BY SN" 
        
        
            UpdateCommand="UPDATE [GETARGETx] SET [T01] = @T01, [T02] = @T02, [T03] = @T03, [T04] = @T04, [T05] = @T05, [T06] = @T06, [T07] = @T07, [T08] = @T08, [T09] = @T09, [T10] = @T10, [T11] = @T11, [T12] = @T12, [T13] = @T13, [T14] = @T14, [Lot] = @Lot, [BilletNo] = @BilletNo WHERE [SN] = @SN AND [Job] = @Job AND [GECode] = @GECode">
        <DeleteParameters>
            <asp:Parameter Name="SN" Type="String" />
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="GECode" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="SN" Type="String" />
            <asp:Parameter Name="T01" Type="Boolean" />
            <asp:Parameter Name="T02" Type="Boolean" />
            <asp:Parameter Name="T03" Type="Boolean" />
            <asp:Parameter Name="T04" Type="Boolean" />
            <asp:Parameter Name="T05" Type="Boolean" />
            <asp:Parameter Name="T06" Type="Boolean" />
            <asp:Parameter Name="T07" Type="Boolean" />
            <asp:Parameter Name="T08" Type="Boolean" />
            <asp:Parameter Name="T09" Type="Boolean" />
            <asp:Parameter Name="T10" Type="Boolean" />
            <asp:Parameter Name="T11" Type="Boolean" />
            <asp:Parameter Name="T12" Type="Boolean" />
            <asp:Parameter Name="T13" Type="Boolean" />
            <asp:Parameter Name="T14" Type="Boolean" />
            <asp:Parameter Name="Lot" Type="String" />
            <asp:Parameter Name="BilletNo" Type="String" />
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="GECode" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="T01" Type="Boolean" />
            <asp:Parameter Name="T02" Type="Boolean" />
            <asp:Parameter Name="T03" Type="Boolean" />
            <asp:Parameter Name="T04" Type="Boolean" />
            <asp:Parameter Name="T05" Type="Boolean" />
            <asp:Parameter Name="T06" Type="Boolean" />
            <asp:Parameter Name="T07" Type="Boolean" />
            <asp:Parameter Name="T08" Type="Boolean" />
            <asp:Parameter Name="T09" Type="Boolean" />
            <asp:Parameter Name="T10" Type="Boolean" />
            <asp:Parameter Name="T11" Type="Boolean" />
            <asp:Parameter Name="T12" Type="Boolean" />
            <asp:Parameter Name="T13" Type="Boolean" />
            <asp:Parameter Name="T14" Type="Boolean" />
            <asp:Parameter Name="Lot" Type="String" />
            <asp:Parameter Name="BilletNo" Type="String" />
            <asp:Parameter Name="SN" Type="String" />
            <asp:Parameter Name="Job" Type="String" />
            <asp:Parameter Name="GECode" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
   
        <br />
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT * FROM [SNx] WHERE ([Job] = @Job) ORDER BY [SN]">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
   
     </div>
    
    </asp:Content>
