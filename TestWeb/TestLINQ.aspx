<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TestLINQ.aspx.cs" Inherits="TestWeb.TestLINQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    بحث
    <asp:TextBox ID="txtContrySarech" runat="server" OnTextChanged="txtContrySarech_TextChanged"></asp:TextBox>
    <asp:Button ID="btnContrySarech" runat="server" OnClick="btnContrySarech_Click" Text="بحث بالدولة" />
    <asp:Button ID="btnAll" runat="server" OnClick="btnAll_Click" Text="عرض الجميع" />
    <asp:Button ID="btnShowColums" runat="server" OnClick="btnShowColums_Click" Text="عرض اهم الحقول" />
    <asp:Button ID="btnNameSarech" runat="server" OnClick="btnNameSarech_Click" Text="بحث بالاسم" />
    <asp:Button ID="btnSort" runat="server" OnClick="btnSort_Click" Text="ترتيب" />
    <br />
    <br />
    <asp:GridView ID="grd" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Height="222px">
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
</asp:Content>
