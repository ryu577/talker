<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpcomingDiscussions.aspx.cs" Inherits="talker.UpcomingDiscussions" MasterPageFile="~/Site.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Upcoming Discussions</h1></div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="talker.Models.Discussion" SelectMethod="GetUpcomingDiscussions" 
        CssClass="table table-striped table-bordered" >
        <Columns>
        <asp:BoundField DataField="ReceivingUserName" HeaderText="Receiving User" />
        <asp:BoundField DataField="DiscussionStartTime" HeaderText="Starts At" />
        <asp:BoundField DataField="DiscussionEndTime" HeaderText="Ends At" />            
        </Columns>
    </asp:GridView>
</asp:Content>
