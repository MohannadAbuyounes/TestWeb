<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSignUp.ascx.cs" Inherits="TestWeb.ucSignUp" %>
 <div class="row">
        <div class="col-md-12" >
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK" />
        </div>
    </div>
<div class="row">
   
    <div class="col-md-9">
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
            <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="كلمة المرور مطلوبة" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>
        </div>
        </div>  

                <div class="row txtrow">
            <div class="col-md-3">تأكيد كلمة المرور</div>
        <div class="col-md-9">
              <asp:TextBox ID="txtConfirmePassword" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>

              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmePassword" ErrorMessage="كلمة المرور فير متطابقة" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:CompareValidator>

              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmePassword" ErrorMessage="تأكيد كلمة المرور مطلوبة" Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>

        </div>
        </div>
          <div class="row txtrow">
            <div class="col-md-3">العنوان</div>
        <div class="col-md-9">
           <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </div>
        </div>  

                <div class="row txtrow">
            <div class="col-md-3">الهاتف</div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPhone" runat="server" ></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhone" ErrorMessage="رقم الهاتف مطلوب " Font-Bold="False" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>

        </div>
        </div>
          <div class="row txtrow">
            <div class="col-md-3">الايميل</div>
        <div class="col-md-9" style="direction: ltr">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="صيفة الايميل فير صحيحة" Font-Bold="True" Font-Italic="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="OK">*</asp:RegularExpressionValidator>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="الايميل مطلوب" Font-Italic="True" ForeColor="Red" ValidationGroup="OK">*</asp:RequiredFieldValidator>

        </div>
        </div>  

        <br />
        <div class="row">
            <div class="col-md-12">
                <asp:Button ID="btnSignUp" runat="server" Text="اشتراك" Class="btn btn-success" ValidationGroup="OK" OnClick="btnSignUp_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="الغاء"  Class="btn btn-danger" OnClick="btnCancel_Click" />
            </div>
        </div>
    </div>
    <div class="col-md-3">
        <img src="../Images/Pic.jpg" class="img-fluid" />

        &nbsp;</div>
</div>

