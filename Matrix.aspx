<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site2.Master" CodeBehind="Matrix.aspx.vb" Inherits="GE.Matrix" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <div style="width: 971px">
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            DeleteCommand="DELETE FROM [TempForSN] WHERE [SN] = @SN" 
            InsertCommand="INSERT INTO [TempForSN] ([Job], [SN], [T01], [T02], [T03], [T04], [T05], [T06], [T07], [T08], [T09], [T10], [T11], [T12], [T13], [T14], [BilletNo], [Lot], [GECode]) VALUES (@Job, @SN, @T01, @T02, @T03, @T04, @T05, @T06, @T07, @T08, @T09, @T10, @T11, @T12, @T13, @T14, @BilletNo, @Lot, @GECode)" 
            SelectCommand="SELECT [Job], [SN], [T01], [T02], [T03], [T04], [T05], [T06], [T07], [T08], [T09], [T10], [T11], [T12], [T13], [T14], [BilletNo], [Lot], [GECode] FROM [TempForSN] WHERE ([Job] = @Job)" 
            
            
            UpdateCommand="UPDATE [TempForSN] SET [Job] = @Job, [T01] = @T01, [T02] = @T02, [T03] = @T03, [T04] = @T04, [T05] = @T05, [T06] = @T06, [T07] = @T07, [T08] = @T08, [T09] = @T09, [T10] = @T10, [T11] = @T11, [T12] = @T12, [T13] = @T13, [T14] = @T14, [BilletNo] = @BilletNo, [Lot] = @Lot, [GECode] = @GECode WHERE [SN] = @SN">
            <DeleteParameters>
                <asp:Parameter Name="SN" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Job" Type="String" />
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
                <asp:Parameter Name="BilletNo" Type="String" />
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="GECode" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Job" Type="String" />
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
                <asp:Parameter Name="BilletNo" Type="String" />
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="GECode" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT [SN] FROM [SNx] WHERE ([Job] = @Job) ORDER BY [SN]">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true" UpdateMode="Always">
    <ContentTemplate>
        <p>
        <asp:Button ID="Button1" runat="server" Height="45px" 
            Text="Generate Matrix and Network File" Width="277px" />
              </p>
        <p>
            <asp:Button ID="Button2" runat="server" Height="40px" OnClientClick="return confirm('Are you sure?');" 
                Text="Delete and Start Over" Width="274px" />
        </p>
    </ContentTemplate>
</asp:UpdatePanel>
       
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="SN" DataSourceID="SqlDataSource1" 
            ForeColor="#333333" GridLines="None" Width="924px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Job" HeaderText="Job" 
                    SortExpression="Job" />
                <asp:BoundField DataField="SN" HeaderText="SN" SortExpression="SN" 
                    ReadOnly="True" />
                <asp:TemplateField HeaderText="T01" SortExpression="T01">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("T01") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("T01") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T02" SortExpression="T02">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("T02") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("T02") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T03" SortExpression="T03">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("T03") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("T03") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T04" SortExpression="T04">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("T04") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" Checked='<%# Bind("T04") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T05" SortExpression="T05">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox5" runat="server" Checked='<%# Bind("T05") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox5" runat="server" Checked='<%# Bind("T05") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T06" SortExpression="T06">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox6" runat="server" Checked='<%# Bind("T06") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox6" runat="server" Checked='<%# Bind("T06") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T07" SortExpression="T07">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox7" runat="server" Checked='<%# Bind("T07") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox7" runat="server" Checked='<%# Bind("T07") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T08" SortExpression="T08">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox8" runat="server" Checked='<%# Bind("T08") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox8" runat="server" Checked='<%# Bind("T08") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T09" SortExpression="T09">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox9" runat="server" Checked='<%# Bind("T09") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox9" runat="server" Checked='<%# Bind("T09") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T10" SortExpression="T10">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox10" runat="server" Checked='<%# Bind("T10") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox10" runat="server" Checked='<%# Bind("T10") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T11" SortExpression="T11">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox11" runat="server" Checked='<%# Bind("T11") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox11" runat="server" Checked='<%# Bind("T11") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T12" SortExpression="T12">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox12" runat="server" Checked='<%# Bind("T12") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox12" runat="server" Checked='<%# Bind("T12") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T13" SortExpression="T13">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox13" runat="server" Checked='<%# Bind("T13") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox13" runat="server" Checked='<%# Bind("T13") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="T14" SortExpression="T14">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox14" runat="server" Checked='<%# Bind("T14") %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox14" runat="server" Checked='<%# Bind("T14") %>' 
                            Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="BilletNo" HeaderText="BilletNo" 
                    SortExpression="BilletNo" />
                <asp:BoundField DataField="Lot" HeaderText="Lot" SortExpression="Lot" />
                <asp:BoundField DataField="GECode" HeaderText="GECode" 
                    SortExpression="GECode" />
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
      </asp:Content>
