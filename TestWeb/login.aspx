<%@ Page Title="تسجيل دخول" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TestWeb.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-md-12">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK" />
        </div>
    </div>
    <div class="row">
   
    <div class="col-md-8">
        <div class="row txtrow">
            <div class="col-md-3">اسم المستخدم</div>
        <div class="col-md-9">
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="اسم المسختدم مطلوب" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>

        </div>
        </div>
          <div class="row txtrow">
            <div class="col-md-3">كلمة المرور</div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="كلمة المرور مطلوبة" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>
        </div>
        </div>  
        <div class="row txtrow">
            <div class="col-md-12"> 
                <asp:CheckBox ID="chbRemember" runat="server" />
                تذكرني
                <br />
                <asp:Label ID="Label1" runat="server" Text="" style="color:red;"></asp:Label>
            </div>
       
        </div> 
          
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnLogIn" runat="server" Text="تسجيل دخول" Class="btn btn-success" ValidationGroup="OK" OnClick="btnLogIn_Click"  />
            </div>
        </div>
    </div>
    <div class="col-md-4">
        <img src="../Images/Pic.jpg" class="img-fluid" />

        &nbsp;</div>
</div>
</asp:Content>
