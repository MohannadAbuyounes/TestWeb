<%@ Page Title="تعديل" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="updateCategory.aspx.cs" Inherits="TestWeb.updateCategory" %>
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
            <td class="auto-style1" colspan="3"><strong>تعديل بيانات فئة </strong></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Save" />
            </td>
        </tr>
      

                 <tr>
            <td>الكود</td>
            <td>
                <asp:TextBox ID="txtCategoryID" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCategoryID" ErrorMessage="الكود مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td class="auto-style2">اسم الفئة</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="اسم الفئة مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>الوصف</td>
            <td>
                <asp:TextBox ID="txtDescrption" runat="server" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
     
        <tr>
            <td colspan="3">
                <asp:Button ID="btnAddCategory" runat="server" Text="تعديل" class="btn btn-primary" OnClick="btnAddCategory_Click" ValidationGroup="Save"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelAddCategory" runat="server" Text="العاء" class="btn btn-danger" OnClick="btnCancelAddCategory_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
