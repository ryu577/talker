﻿<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="talker._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>.</h1>
        <h2>Ask anyone about anything</h2>
        <p class="lead">The next leap in connecting the worlds hearts and minds.</p>
    <p class="lead">
        <asp:Button ID="Bid_Click" runat="server" OnClick="CreateBid_Click" Text="Sell My Time" />
    </p>
    
    
</asp:Content>