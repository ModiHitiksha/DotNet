<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 268px; width: 1498px; z-index: 1; left: 24px; top: 3px; position: absolute">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 797px; top: 94px; position: absolute; height: 57px; width: 184px" Text="hitiksha"></asp:Label>
        <p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1;left: 612px; top: 94px; position: absolute" Text="click me" OnClick="Visibility"/>
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource1" OnClick="Visibility">
            <Columns>
                <asp:BoundField DataField="order_id" HeaderText="order_id" ReadOnly="True" SortExpression="order_id" />
                <asp:BoundField DataField="purch_amt" HeaderText="purch_amt" SortExpression="purch_amt" />
                <asp:BoundField DataField="order_date" HeaderText="order_date" SortExpression="order_date" />
                <asp:BoundField DataField="customer_id" HeaderText="customer_id" SortExpression="customer_id" />
                <asp:BoundField DataField="salesman_id" HeaderText="salesman_id" SortExpression="salesman_id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:practiceConnectionString2 %>" ProviderName="<%$ ConnectionStrings:practiceConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [order]"></asp:SqlDataSource>
    </form>
</body>
</html>
