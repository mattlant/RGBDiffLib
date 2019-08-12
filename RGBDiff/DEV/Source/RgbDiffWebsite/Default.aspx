<%@ Page Title="" Language="C#" MasterPageFile="~/RgbDiffWeb.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RgbDiffWebsite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
.mainDiv {
	text-align: center;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="mainDiv">
	<div>Please press START to begin
	</div>
<div><br />
	<asp:Button runat="server" Text="START" id="btnStart" onclick="btnStart_Click"></asp:Button><br />
	</div>
</div>
</asp:Content>
