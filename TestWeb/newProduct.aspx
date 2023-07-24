<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="newProduct.aspx.cs" Inherits="TestWeb.newProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            width: 258px;
        }
        .auto-style4 {
            height: 29px;
            width: 258px;
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
                <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductID" ErrorMessage="الكود مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="كود الصنف مستخدم من قبل" ControlToValidate="txtProductID" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="Save">*</asp:CustomValidator>
            </td>
        </tr>
    
        <tr>
            <td>الاسم</td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProductName" ErrorMessage="اسم الصنف مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="اسم الصنف مستخدم من قبل" ControlToValidate="txtProductName" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" ValidationGroup="Save">*</asp:CustomValidator>
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
