<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testDataView.aspx.cs" Inherits="FrontClient_testDataView" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:BulletedList ID="BulletedList1" runat="server">
            <asp:ListItem>输入1</asp:ListItem>
            <asp:ListItem>阿斯蒂芬</asp:ListItem>
            <asp:ListItem>阿道夫</asp:ListItem>
            <asp:ListItem>个阿坝</asp:ListItem>
            <asp:ListItem>爱迪生</asp:ListItem>
        </asp:BulletedList>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <asp:Image ID="Image1" runat="server" ImageUrl="../App_Data/images/wp8.jpg" />
        <asp:Wizard ID="Wizard1" runat="server" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
            <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1"></asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2"></asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1" YValuesPerPoint="2"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </div>
    </form>
</body>
</html>
