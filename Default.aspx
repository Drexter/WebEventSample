<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblText" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtText1" runat="server"></asp:TextBox>
    
    </div>
    <asp:Button ID="btnShowText" runat="server" onclick="btnShowText_Click" 
        Text="Show Text" />
    </form>
</body>
</html>
