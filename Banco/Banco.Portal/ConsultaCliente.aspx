<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaCliente.aspx.cs" Inherits="Banco.Portal.ConsultaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de Clientes</h1>
    <asp:GridView ID="grvClientes" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="grvClientes_PageIndexChanging"></asp:GridView>
</asp:Content>
