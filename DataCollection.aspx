<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DataCollection.aspx.vb" Inherits="GE.DataCollection" MaintainScrollPositionOnPostback="true" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hercules amd Gemini Data Collection</title>
    <style type="text/css">
        .style1
        {
            font-size: medium;
        }
    </style>
</head>
<body>
<h1  />

    &nbsp;<h1  />

    Hercules and Gemini Data Collection<form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <span class="style1">Select JobNumber</span><br />
        <asp:ComboBox ID="ComboBox1" runat="server">
        </asp:ComboBox>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT [Job] FROM [SNx]"></asp:SqlDataSource>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            Font-Size="Large" Height="85px" Width="207px">
            <asp:ListItem>Before Purification</asp:ListItem>
            <asp:ListItem>After Purification</asp:ListItem>
        </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Size="Large"></asp:Label>
        <br />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" DataKeyNames="Job,SN" 
            DataSourceID="SqlDataSource2" Font-Size="Medium" Visible="False" 
            Width="1135px">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="SN" HeaderText="Serial Number" ReadOnly="True" 
                    SortExpression="SN" />
                <asp:BoundField DataField="Lot" HeaderText="Lot Number" ReadOnly="True" 
                    SortExpression="Lot" />
                <asp:BoundField DataField="Billet" HeaderText="Billet" 
                    SortExpression="Billet" ReadOnly="True" />
                <asp:BoundField DataField="Target" HeaderText="Target" 
                    SortExpression="Target" ReadOnly="True" />
                <asp:TemplateField HeaderText="&lt;=.012 (pinhole)" SortExpression="BeforePin1">
                    
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("BeforePin1") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                     <ItemTemplate>
                          <%# IIf(Eval("BeforePin1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.012 - .020 (pinhole)" 
                    SortExpression="BeforePin2">
                    
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("BeforePin2") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                          <%# IIf(Eval("BeforePin2") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.020 (pinhole)" SortExpression="BeforePin3">
                 
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("BeforePin3") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                          <%# IIf(Eval("BeforePin3") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Flow Marks, Striations, Discoloration" 
                    SortExpression="BeforeDefect1">
                
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" 
                            Checked='<%# Bind("BeforeDefect1") %>' Text="YES" />
                    </EditItemTemplate>
                     <ItemTemplate>
                          <%# IIf(Eval("BeforeDefect1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&lt;=.039 (silverspots)" 
                    SortExpression="BeforeSilver1">
                 
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox5" runat="server" 
                            Checked='<%# Bind("BeforeSilver1") %>' Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                          <%# IIf(Eval("BeforeSilver1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.039 (silverspots)" 
                    SortExpression="BeforeSilver2">
                    
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox6" runat="server" 
                            Checked='<%# Bind("BeforeSilver2") %>' Text="YES" />
                    </EditItemTemplate>
                     <ItemTemplate>
                          <%# IIf(Eval("BeforeSilver2") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Porous Material" SortExpression="BeforePorous">
                   
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox7" runat="server" 
                            Checked='<%# Bind("BeforePorous") %>' Text="YES" />
                    </EditItemTemplate>
                     <ItemTemplate>
                          <%# IIf(Eval("BeforePorous") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            DeleteCommand="DELETE FROM [SNx] WHERE [Job] = @Job AND [SN] = @SN" 
            InsertCommand="INSERT INTO [SNx] ([Job], [SN], [Lot], [Billet], [Target], [BeforePin1], [BeforePin2], [BeforePin3], [BeforeDefect1], [BeforeSilver1], [BeforeSilver2], [BeforePorous]) VALUES (@Job, @SN, @Lot, @Billet, @Target, @BeforePin1, @BeforePin2, @BeforePin3, @BeforeDefect1, @BeforeSilver1, @BeforeSilver2, @BeforePorous)" 
            SelectCommand="SELECT SNx.Job, SNx.SN, GETARGETx.Lot, GETARGETx.BilletNo as Billet, SNx.BeforePin1, SNx.BeforePin2, SNx.BeforePin3, SNx.BeforeDefect1, SNx.BeforeSilver1, SNx.BeforeSilver2, SNx.BeforePorous, RIGHT (SNx.SN, 2) AS Target FROM SNx INNER JOIN View_GE_Datax ON SNx.SN = View_GE_Datax.SN INNER JOIN GETARGETx ON View_GE_Datax.SN1 = GETARGETx.SN AND View_GE_Datax.Job = GETARGETx.Job WHERE (SNx.Job = @Job)" 
            
            
            
            UpdateCommand="UPDATE [SN] SET [Lot] = @Lot, [Billet] = @Billet, [Target] = @Target, [BeforePin1] = @BeforePin1, [BeforePin2] = @BeforePin2, [BeforePin3] = @BeforePin3, [BeforeDefect1] = @BeforeDefect1, [BeforeSilver1] = @BeforeSilver1, [BeforeSilver2] = @BeforeSilver2, [BeforePorous] = @BeforePorous WHERE [Job] = @Job AND [SN] = @SN">
            <DeleteParameters>
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="Billet" Type="String" />
                <asp:Parameter Name="Target" Type="String" />
                <asp:Parameter Name="BeforePin1" Type="Boolean" />
                <asp:Parameter Name="BeforePin2" Type="Boolean" />
                <asp:Parameter Name="BeforePin3" Type="Boolean" />
                <asp:Parameter Name="BeforeDefect1" Type="Boolean" />
                <asp:Parameter Name="BeforeSilver1" Type="Boolean" />
                <asp:Parameter Name="BeforeSilver2" Type="Boolean" />
                <asp:Parameter Name="BeforePorous" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="ComboBox1" Name="Job" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="Billet" Type="String" />
                <asp:Parameter Name="Target" Type="String" />
                <asp:Parameter Name="BeforePin1" Type="Boolean" />
                <asp:Parameter Name="BeforePin2" Type="Boolean" />
                <asp:Parameter Name="BeforePin3" Type="Boolean" />
                <asp:Parameter Name="BeforeDefect1" Type="Boolean" />
                <asp:Parameter Name="BeforeSilver1" Type="Boolean" />
                <asp:Parameter Name="BeforeSilver2" Type="Boolean" />
                <asp:Parameter Name="BeforePorous" Type="Boolean" />
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" DataKeyNames="Job,SN" 
            DataSourceID="SqlDataSource3" Width="960px" Font-Size="Medium" 
            Visible="False">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="SN" HeaderText="Serial Number" ReadOnly="True" 
                    SortExpression="SN" />
                <asp:BoundField DataField="Lot" HeaderText="Lot Number" SortExpression="Lot" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Billet" HeaderText="Billet" 
                    SortExpression="Billet" ReadOnly="True" />
                <asp:BoundField DataField="Target" HeaderText="Target" 
                    SortExpression="Target" ReadOnly="True" />
                <asp:TemplateField HeaderText="&lt;=.012 (pinhole)" SortExpression="AfterPin1">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("AfterPin1") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                         <%# IIf(Eval("AfterPin1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.012 - .020 (pinhole)" 
                    SortExpression="AfterPin2">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("AfterPin2") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# IIf(Eval("AfterPin2") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.020 (pinhole)" SortExpression="AftrePin3">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%# Bind("AfterPin3") %>' 
                            Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                       <%# IIf(Eval("AfterPin3") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Flow Marks, Striations, Discoloration" 
                    SortExpression="AfterDefect1">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox4" runat="server" 
                            Checked='<%# Bind("AfterDefect1") %>' Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <%# IIf(Eval("AfterDefect1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&lt;=.039 (silverspots)" 
                    SortExpression="AfterSilver1">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox5" runat="server" 
                            Checked='<%# Bind("AfterSilver1") %>' Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                          <%# IIf(Eval("AfterSilver1") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="&gt;.039 (silverspots)" 
                    SortExpression="AfterSilver2">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox6" runat="server" 
                            Checked='<%# Bind("AfterSilver2") %>' Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                            <%# IIf(Eval("AfterSilver2") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Porous Material" SortExpression="AfterPorous">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox7" runat="server" 
                            Checked='<%# Bind("AfterPorous") %>' Text="YES" />
                    </EditItemTemplate>
                    <ItemTemplate>
                          <%# IIf(Eval("AfterPorous") = False, "No", "Yes")%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            DeleteCommand="DELETE FROM [SNx] WHERE [Job] = @Job AND [SN] = @SN" 
            InsertCommand="INSERT INTO [SNx] ([Job], [SN], [Lot], [Billet], [Target], [AfterPin1], [AfterPin2], [AftrePin3], [AfterDefect1], [AfterSilver1], [AfterSilver2], [AfterPorous]) VALUES (@Job, @SN, @Lot, @Billet, @Target, @AfterPin1, @AfterPin2, @AfterPin3, @AfterDefect1, @AfterSilver1, @AfterSilver2, @AfterPorous)" 
            SelectCommand="SELECT SNx.Job, SNx.SN, GETARGETx.Lot, GETARGETx.BilletNo AS Billet, SNx.Target, SNx.AfterPin1, SNx.AfterPin2, SNx.AfterPin3, SNx.AfterDefect1, SNx.AfterSilver1, SNx.AfterSilver2, SNx.AfterPorous FROM SNx INNER JOIN View_GE_Datax ON SNx.SN = View_GE_Datax.SN INNER JOIN GETARGETx ON View_GE_Datax.SN1 = GETARGETx.SN AND View_GE_Datax.Job = GETARGETx.Job WHERE (SNx.Job = @Job)" 
            
            
            
            UpdateCommand="UPDATE [SNx] SET [Lot] = @Lot, [Billet] = @Billet, [Target] = @Target, [AfterPin1] = @AfterPin1, [AfterPin2] = @AfterPin2, [AfterPin3] = @AfterPin3, [AfterDefect1] = @AfterDefect1, [AfterSilver1] = @AfterSilver1, [AfterSilver2] = @AfterSilver2, [AfterPorous] = @AfterPorous WHERE [Job] = @Job AND [SN] = @SN">
            <DeleteParameters>
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="Billet" Type="String" />
                <asp:Parameter Name="Target" Type="String" />
                <asp:Parameter Name="AfterPin1" Type="Boolean" />
                <asp:Parameter Name="AfterPin2" Type="Boolean" />
                <asp:Parameter Name="AfterPin3" Type="Boolean" />
                <asp:Parameter Name="AfterDefect1" Type="Boolean" />
                <asp:Parameter Name="AfterSilver1" Type="Boolean" />
                <asp:Parameter Name="AfterSilver2" Type="Boolean" />
                <asp:Parameter Name="AfterPorous" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="ComboBox1" Name="Job" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Lot" Type="String" />
                <asp:Parameter Name="Billet" Type="String" />
                <asp:Parameter Name="Target" Type="String" />
                <asp:Parameter Name="AfterPin1" Type="Boolean" />
                <asp:Parameter Name="AfterPin2" Type="Boolean" />
                <asp:Parameter Name="AfterPin3" Type="Boolean" />
                <asp:Parameter Name="AfterDefect1" Type="Boolean" />
                <asp:Parameter Name="AfterSilver1" Type="Boolean" />
                <asp:Parameter Name="AfterSilver2" Type="Boolean" />
                <asp:Parameter Name="AfterPorous" Type="Boolean" />
                <asp:Parameter Name="Job" Type="String" />
                <asp:Parameter Name="SN" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
