<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="WebServiceExam1.MainForm" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Panel ID="contentArea" runat="server">
            <asp:TextBox ID="countdown" runat="server" Width = "3%"></asp:TextBox>
            <asp:RegularExpressionValidator ID="validator"  ControlToValidate="countdown" runat="server" ErrorMessage="Only Numbers Allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Timer  ID="timer" runat="server" OnTick="tick" Interval="1000" Enabled="false"></asp:Timer>
            <asp:Button ID="start" runat="server" Width="3%" Text="Restart" />
            <asp:Label ID="Label1" runat="server" Width="3%"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
