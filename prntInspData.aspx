<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="prntInspData.aspx.vb" Inherits="GE.prntInspData" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="8pt" Height="640px" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="913px">
            <LocalReport ReportPath="Report4.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSetInsp" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString2 %>" 
            SelectCommand="SELECT DISTINCT SN, OD1, ID1, Height, Weight, Job FROM SNx WHERE (Job LIKE '%' + @Job + '%') AND (SN LIKE N'%01') ORDER BY SN">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
