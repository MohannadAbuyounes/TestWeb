<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="sendData.aspx.cs" Inherits="TestWeb.sendData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:TextBox ID="txtSend" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send Session" />
        <asp:Button ID="btnSendQuery" runat="server" OnClick="btnSendQuery_Click" Text="Send Query" />
        <asp:Button ID="btnSendCookie" runat="server" OnClick="btnSendCookie_Click" Text="Send Cookie" />
    </p>
</asp:Content>
