<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="updateProduct.aspx.cs" Inherits="TestWeb.updateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .auto-style1 {
            width: 41px;
        }
        .auto-style2 {
            width: 69px;
        }
        .auto-style3 {
            width: 70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table >
        <tr>
            <td class="auto-style1" colspan="3"><strong>صنف جديد</strong></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Save" />
            </td>
        </tr>
        <tr>
            <td>الكود</td>
            <td>
                <asp:TextBox ID="txtProductID" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductID" ErrorMessage="الكود مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </td>
        </tr>
    
        <tr>
            <td>الاسم</td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProductName" ErrorMessage="اسم الصنف مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>الفئة</td>
            <td>
                <asp:DropDownList ID="ddlCategories" runat="server"></asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
       <tr>
            <td>المورد</td>
            <td>
                <asp:DropDownList ID="ddlSupplier" runat="server"></asp:DropDownList>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>السعر </td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
   
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="btnAddProduct" runat="server" Text="اضافة" class="btn btn-primary" OnClick="btnAddProduct_Click" ValidationGroup="Save"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelAddProduct" runat="server" Text="العاء" class="btn btn-danger" OnClick="btnCancelAddProduct_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
