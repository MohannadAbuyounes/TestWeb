<%@ Page Title="الفئات" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="categoies.aspx.cs" Inherits="TestWeb.categoies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <div class="row" >
                <a href ="NewCategory.aspx" class="btn btn-primary" id="adminAdd" runat="server">جديد</a>     


            </div>
                <asp:GridView ID="grd" runat="server" class ="table table-striped table-hover" OnRowDataBound="grd_RowDataBound"  OnRowDeleting="grd_RowDeleting" OnSelectedIndexChanged="grd_SelectedIndexChanged"  >
                    <Columns>
                        <asp:HyperLinkField HeaderText="تعديل" NavigateUrl="editCategory.aspx" Text="تعديل" DataNavigateUrlFields="CategoryID" DataNavigateUrlFormatString="updateCategory.aspx?id={0}" />
                        <asp:ButtonField CommandName="Delete" HeaderText="حذف" ShowHeader="True" Text="حذف"/>
                    </Columns>
            </asp:GridView>
   
        </asp:View>
        <asp:View ID="View2" runat="server">
            <h3>هل تريد حذف الفئة <asp:Label ID="lblName" runat="server" Text=""></asp:Label>؟</h3>
            <p>
                <asp:Button ID="btnDelete" runat="server" Text="حذف" class="btn btn-success" OnClick="btnDelete_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="العاء" class="btn btn-danger" OnClick="btnCancel_Click"/>
            </p>
            <p>
                <asp:HiddenField ID="hf" runat="server" />
            </p>
        </asp:View>
    </asp:MultiView>
</asp:Content>
