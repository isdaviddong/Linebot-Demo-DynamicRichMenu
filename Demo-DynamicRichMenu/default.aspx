<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="default.aspx.cs"  Inherits="Demo_DynamicRichMenu._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        測試步驟<br />
        <br />
        <asp:Button ID="Button_DEL" runat="server" Text="1.Delete All Menu" OnClick="Button_DEL_Click" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="2.Create Rich Menu" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="3.set Default Rich Menu to users" />
    </div>
    </form>
</body>
</html>
