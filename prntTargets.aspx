<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="prntTargets.aspx.vb" Inherits="GE.prntTargets" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <div style="width: 980px">
   
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="Medium" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="924px" 
            Height="771px">
            <LocalReport ReportPath="Report1.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString %>" 
            SelectCommand="SELECT [GECode], [SN], [T01], [T02], [T03], [T04], [T05], [T06], [T07], [T08], [T09], [T10], [T11], [T12], [T13], [T14], [Lot], [BilletNo], [Job] FROM [GETARGETx] WHERE ([Job] = @Job)">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
      
    </div>
   </asp:Content>
