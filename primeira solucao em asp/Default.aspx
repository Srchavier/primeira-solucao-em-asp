<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="primeira_solucao_em_asp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <br />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Inserir" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Listar" />
        <asp:Button ID="Button3" runat="server" Text="Adicionar" />
        <asp:Button ID="Button4" runat="server" Text="Deletar" />

        <br />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

</asp:Content>
