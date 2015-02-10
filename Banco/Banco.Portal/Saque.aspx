<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Saque.aspx.cs" Inherits="Banco.Portal.Saque" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Saque:</h2>
    <h3>Numero:</h3>
    <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
    <h3>Senha:</h3>
    <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"></asp:TextBox>
    <h3>Valor:</h3>
    <asp:TextBox ID="txtValor" TextMode="Number" runat="server"></asp:TextBox>

    <asp:Button ID="btnSacar" runat="server" Text="Sacar" OnClick="btnSacar_Click" />
    <asp:Label ID="lblResultadoDoSaque" runat="server" Text=""></asp:Label>
</asp:Content>
