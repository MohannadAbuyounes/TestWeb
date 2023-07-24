<%@ Page Title="فئة جديدة" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="newCategory.aspx.cs" Inherits="TestWeb.newCategory" %>
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
            <td class="auto-style1" colspan="3"><strong>فئة جديدة</strong></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Save" />
            </td>
        </tr>
  
       
        <tr>
            <td> اسم الفئة</td>
            <td>
                <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="اسم الفئة مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="اسم الفئة مستخدم من قبل" ControlToValidate="txtCategoryName" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" ValidationGroup="Save">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>الوصف</td>
            <td>
                <asp:TextBox ID="txtDescraption" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
       
       
        <tr>
            <td colspan="3">
                <asp:Button ID="btnAddCategory" runat="server" Text="اضافة" class="btn btn-primary" OnClick="btnAddCategory_Click" ValidationGroup="Save"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelAddCategory" runat="server" Text="العاء" class="btn btn-danger" OnClick="btnCancelAddCategory_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>
