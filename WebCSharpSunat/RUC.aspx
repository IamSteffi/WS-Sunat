<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RUC.aspx.cs" Inherits="WebCSharpSunat.RUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <center>
         <p>



         </p>
         <p>



         </p>
    <p>
        Buscar RUC: <asp:TextBox runat="server" Id="Buscartxt" OnTextChanged="Buscartxt_TextChanged"/>

    </p>
    <p> 
        <asp:GridView runat="server" ID="gvRUC"></asp:GridView>
    </p>
         </center>
</asp:Content>
