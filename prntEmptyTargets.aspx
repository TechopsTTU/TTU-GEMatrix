<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="prntEmptyTargets.aspx.vb" Inherits="GE.prntEmptyTargets" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <div>
    
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="Medium" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="962px" 
            Height="771px">
            <LocalReport ReportPath="Report1.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            
            SelectCommand="SELECT [GECode], [SN], '' as [T01], '' as [T02], '' as [T03],'' as [T04], '' as [T05],'' as [T06], '' as [T07], '' as [T08], '' as [T09], '' as [T10], '' as [T11],'' as  [T12], '' as [T13], '' as [T14], [Lot], [BilletNo], [Job] FROM [GETARGETx] WHERE ([Job] = @Job)">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
    
    </div>
    </asp:Content>
