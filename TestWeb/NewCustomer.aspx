<%@ Page Title="عميل جديد" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="TestWeb.NewCustomer" %>
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
            <td class="auto-style1" colspan="3"><strong>عميل جديد</strong></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Save" />
            </td>
        </tr>
        <tr>
            <td>الكود</td>
            <td>
                <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="الكود مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="كود العميل مستخدم من قبل" ControlToValidate="txtCustomerID" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="Save">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">الشركة</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCompanyName" ErrorMessage="اسم الشركة مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>الاسم</td>
            <td>
                <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContactName" ErrorMessage="اسم العميل مطلوب" ForeColor="Red" ValidationGroup="Save">*</asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="اسم العميل مستخدم من قبل" ControlToValidate="txtContactName" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate" ValidationGroup="Save">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>اللقب</td>
            <td>
                <asp:TextBox ID="txtContactTitle" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>العنوان</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>المدينة </td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>الاقليم</td>
            <td>
                <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>الرمز البريدي</td>
            <td>
                <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>الدولة</td>
            <td>
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>الهاتف</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td>الفاكس</td>
            <td>
                <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnAddCustomer" runat="server" Text="اضافة" class="btn btn-primary" OnClick="btnAddCustomer_Click" ValidationGroup="Save"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelAddCustomer" runat="server" Text="العاء" class="btn btn-danger" OnClick="btnCancelAddCustomer_Click"/>
            </td>
        </tr>
    </table>

</asp:Content>
