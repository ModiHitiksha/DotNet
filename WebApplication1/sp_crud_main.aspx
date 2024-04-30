<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sp_crud_main.aspx.cs" Inherits="WebApplication1.sp_crud_main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 36px; top: 221px; position: absolute" Text="mobile"></asp:Label>

            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 40px; top: 161px; position: absolute; bottom: 406px" Text="email"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 42px; top: 105px; position: absolute" Text="name"></asp:Label>
       
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 141px; top: 99px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 141px; top: 156px; position: absolute"></asp:TextBox>
<%--     <p>     

     </p>  --%>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 147px; top: 312px; position: absolute" Text="Insert" />
       
        <p>
            &nbsp;</p>
     <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" style="z-index: 1; left: 129px; top: 251px; position: absolute"></asp:RequiredFieldValidator>      
  --%>
         
         <p>
             <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 622px; top: 183px; position: absolute"></asp:TextBox>
             <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 624px; top: 246px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 535px; top: 186px; position: absolute" Text="ID"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 493px; top: 242px; position: absolute" Text="updated_name"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 611px; top: 336px; position: absolute" Text="update" />
        <p>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 143px; top: 223px; position: absolute"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 1175px; top: 348px; position: absolute" Text="Delete" />
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 1077px; top: 250px; position: absolute" Text="Id"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 1179px; top: 253px; position: absolute"></asp:TextBox>
         
         </form>
</body>
</html>
