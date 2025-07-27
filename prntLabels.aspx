<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="prntLabels.aspx.vb" Inherits="GE.prntLabels" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845DCD8080CC91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <div>
       
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="8pt" Height="748px" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="744px">
            <LocalReport ReportPath="Report2.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet3" />
                </DataSources>
            </LocalReport>
       
        </rsweb:ReportViewer>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:GEConnectionString2 %>" 
            
            
            
            SelectCommand="SELECT SN, Description, mmyyyy, ItemNumber, TNAME, TDWG, Job, flex FROM View_qSNForLabels WHERE (Job = @Job) ORDER BY SN" ProviderName="<%$ ConnectionStrings:GEConnectionString2.ProviderName %>">
            <SelectParameters>
                <asp:SessionParameter Name="Job" SessionField="JOB" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
   </asp:Content>
