<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ThemHoa.aspx.cs" Inherits="WebHoa.ThemHoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="form-group">
        Danh mục: <asp:DropDownList ID="ddlLoai" runat="server" CssClass="form-control" DataTextField="TenLoai" DataValueField="TenLoai"></asp:DropDownList>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HoaTuoiDBConnectionString %>" SelectCommand="SELECT [TenLoai] FROM [Loai]"></asp:SqlDataSource>
    </div>
    <div class="form-group">
        Tên hoa: <asp:TextBox ID="txttenhoa" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
      <div class="form-group">
        Giá: <asp:TextBox ID="txtgia" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        Ngày cập nhật: <asp:Calendar ID="clngaycapnhat" runat="server"> </asp:Calendar>
    </div>
    <div class="form-group">
        Hình: <asp:FileUpload ID="Fhinh" runat="server" CssClass="form-control"></asp:FileUpload>
        </div>
        <div class="form-group">
        <asp:Button ID="btxuly" runat="server" CssClass="bt btn-info" OnClick="btxuly_Click" Text="Thêm"></asp:Button>
    </div>
    <asp:Label ID="lbThongBao" runat="server"></asp:Label>
  
</asp:Content>
