<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sp_crud.aspx.cs" Inherits="WebApplication1.sp_crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 621px; top: 269px; position: absolute" Text="update" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 104px; top: 113px; position: absolute; height: 16px" Text="Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 107px; top: 179px; position: absolute" Text="age"></asp:Label> 
        
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 198px; top: 110px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 197px; top: 174px; position: absolute"></asp:TextBox>
        
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 131px; top: 254px; position: absolute" Text="insert" OnClick="Button1_Click" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:practiceConnectionString3 %>" SelectCommand="SELECT * FROM [temp1]"></asp:SqlDataSource>
       
        
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 1116px; top: 282px; position: absolute" Text="Delete" />
       
        
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 523px; top: 191px; position: absolute" Text="new age"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 620px; top: 185px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 523px; top: 124px; position: absolute" Text="enter id"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 620px; top: 125px; position: absolute"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" style="z-index: 1; left: 86px; top: 384px; position: absolute; height: 152px; width: 232px">
        </asp:GridView>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 994px; top: 194px; position: absolute" Text="id"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 1073px; top: 192px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
