<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="TraCuu.aspx.cs" Inherits="WebHoa.TraCuu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-inline">
        Giá từ
        <asp:TextBox ID="txtGiaTu" runat="server" CssClass="form-control"></asp:TextBox>
        Giá đến
        <asp:TextBox ID="txtGiaDen" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btTraCuu" runat="server" Text="Tra Cứu" CssClas="btn btn-info" OnClick="btTraCuu_Click" />
    </div>
    <div class="row">
        <asp:Repeater ID="rptHoa" runat="server">
            <ItemTemplate>
                <div class="col-md-3 col-sm-6 item">
                    <div class="i">
                        <a href="#">
                            <img src='<%# Eval("Hinh","Uploads/hinh_san_pham/{0}") %>' />
                        </a>
                    </div>
                    <div class="t">
                        <asp:Label ID="lbTenHoa" runat="server" Text='<%# Eval("TenHoa") %>'></asp:Label><br />
                        Giá bán:
                        <asp:Label ID="lbGia" CssClass="vn" runat="server" Text='<%# Eval("Gia","{0: #,##0} Đồng") %>'></asp:Label>
                        <asp:Button ID="btAddToCart" runat="server" Text="Add To Cart" CssClass="btn btn-success" />
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
