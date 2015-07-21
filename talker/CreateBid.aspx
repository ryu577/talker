<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreateBid.aspx.cs" Inherits="talker.CreateBid" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       
    <section>
                <div style="width:50%; margin: 0 auto;">
                    <br />
                
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    
                    <br />
                </div>
                <asp:TextBox ID="txtStartTime" runat="server" Text='<%# Bind("StartTime", "{0:t}") %>'
                                        Width="60px"></asp:TextBox>

                                    <cc1:MaskedEditExtender ID="meeStartTime" runat="server" AcceptAMPM="true" MaskType="Time"
                                        Mask="99:99" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError"
                                        ErrorTooltipEnabled="true" UserTimeFormat="None" TargetControlID="txtStartTime"
                                        InputDirection="LeftToRight" AcceptNegative="Left">
                                    </cc1:MaskedEditExtender>
                                    <asp:Label ID="lblStartTimeEdit" runat="server" Text="Press 'A' or 'P' to switch AM/PM"></asp:Label>

                                    <cc1:MaskedEditValidator ID="mevStartTime" runat="server" ControlExtender="meeStartTime"
                                        ControlToValidate="txtStartTime" IsValidEmpty="False" EmptyValueMessage="Time is required "
                                        InvalidValueMessage="Time is invalid" Display="Dynamic" EmptyValueBlurredText="Time is required "
                                        InvalidValueBlurredMessage="Invalid Time" ValidationGroup="MKE" />    

                <div style="width:50%; margin: 0 auto;">
                    <br />
                        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                    <br />
                </div>
                <asp:TextBox ID="txtEndTime" runat="server" Text='<%# Bind("StartTime", "{0:t}") %>'
                                        Width="60px"></asp:TextBox>

                                    <cc1:MaskedEditExtender ID="txtStartTime0_MaskedEditExtender" runat="server" AcceptAMPM="true" MaskType="Time"
                                        Mask="99:99" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" OnInvalidCssClass="MaskedEditError"
                                        ErrorTooltipEnabled="true" UserTimeFormat="None" TargetControlID="txtEndTime"
                                        InputDirection="LeftToRight" AcceptNegative="Left">
                                    </cc1:MaskedEditExtender>
                                    <asp:Label ID="Label3" runat="server" Text="Press 'A' or 'P' to switch AM/PM"></asp:Label>
                
                <br />
                
                <br />
                <asp:Label ID="Label2" runat="server" Text="At how much do you want to sell?"></asp:Label>
                    
                <asp:TextBox ID="TextBox1" runat="server" Height="17px"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="What do you want to talk about?"></asp:Label>
                <asp:DropDownList ID="CategoriesDropDown" runat="server" OnSelectedIndexChanged="CategoriesDropDown_SelectedIndexChanged" AutoPostBack="TRUE">

                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Advertize" OnClick="Advertize_Click" />
        </section>
    
</asp:Content>