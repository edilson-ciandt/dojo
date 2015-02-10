<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarCliente.aspx.cs" Inherits="Banco.Portal.CadastrarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div>
       <h3>Cadastrar</h3>
        <asp:Label ID="lblConfirmacao" runat="server" Text=""></asp:Label>
        <div>
            <h4>Nome:</h4>
            <asp:TextBox ID="txtNome" runat="server" Text="" ></asp:TextBox> 
        </div>   
        <div>
            <h4>Cpf:</h4>
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        </div>     
        <div>
            <h4>Endereço:</h4>
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        </div>
        <div>
            <h4>Data Nasc.:</h4>
            <asp:Calendar ID="cldData" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar!" OnClick="btnSalvar_Click" />

        </div>
    </div>
    
    
</asp:Content>
