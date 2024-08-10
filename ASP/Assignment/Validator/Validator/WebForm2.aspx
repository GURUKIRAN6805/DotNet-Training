<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Validator.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Result</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Entered Details</h2>
            <p>Name: <asp:Label ID="lblName" runat="server"></asp:Label></p>
            <p>Family Name: <asp:Label ID="lblFamilyName" runat="server"></asp:Label></p>
            <p>Address: <asp:Label ID="lblAddress" runat="server"></asp:Label></p>
            <p>City: <asp:Label ID="lblCity" runat="server"></asp:Label></p>
            <p>Zip Code: <asp:Label ID="lblZipCode" runat="server"></asp:Label></p>
            <p>Phone: <asp:Label ID="lblPhone" runat="server"></asp:Label></p>
            <p>Email: <asp:Label ID="lblEmail" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>