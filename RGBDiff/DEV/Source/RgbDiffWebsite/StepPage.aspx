<%@ Page Title="" Language="C#" MasterPageFile="~/RgbDiffWeb.Master" AutoEventWireup="true" CodeBehind="StepPage.aspx.cs" Inherits="RgbDiffWebsite.StepPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.style1
		{
			width: 600px;
			height: 600px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div align="center" >
	<div style="text-align: center;">
		Please click next or previous until you feel the colours are matching.<br />
		<br />
		Important - The point is not to get a perfect match, but an acceptable match. DO NOT over-analyze, just go with your first guess!</div>
	<div>
		<asp:Label runat="server" Text="0 % Complete" ID="lblPercentComplete"></asp:Label>
	</div>
		<table border="0" cellpadding="0" cellspacing="0" align="center">
			<tr>
				<td>
					<table class="style1">
						<tr>
							<td style="background-color: #009933; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #663300; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #00CC66; width: 200px; height: 200px;">
							</td>
						</tr>
						<tr>
							<td style="background-color: #CCFFFF; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #000; width: 200px; height: 200px;">
								<asp:Image ID="imgSource" runat="server" />
							</td>
							<td style="background-color: #336699; width: 200px; height: 200px;">
							</td>
						</tr>
						<tr>
							<td style="background-color: #660033; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #902; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #FFFF99; width: 200px; height: 200px;">
							</td>
						</tr>
					</table>
				</td>
				<td>
					<table class="style1">
						<tr>
							<td style="background-color: #009933; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #663300; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #00CC66; width: 200px; height: 200px;">
							</td>
						</tr>
						<tr>
							<td style="background-color: #CCFFFF; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #000; width: 200px; height: 200px;">
								<asp:Image ID="imgMatch" runat="server" />
							</td>
							<td style="background-color: #336699; width: 200px; height: 200px;">
							</td>
						</tr>
						<tr>
							<td style="background-color: #660033; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #902; width: 200px; height: 200px;">
							</td>
							<td style="background-color: #FFFF99; width: 200px; height: 200px;">
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	<div style="text-align: right; width: 1193px;">
		<asp:Button runat="server" style="margin:2px;" Text="<<<<<<<<<<" ID="btnBack5" OnClick="btnBackStep_Click" Enabled="True" Width="95px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text="<<<<<" ID="Button3" OnClick="btnBackStep_Click" Enabled="True" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text="<<<" ID="Button1" OnClick="btnBackStep_Click" Enabled="True" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text="<" ID="btnBack1" OnClick="btnBackStep_Click" Enabled="True" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px 2px 2px 4px;" Text=">" ID="btnForward1" OnClick="btnForwardStep_Click" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text=">>>" ID="btnForward5" OnClick="btnForwardStep_Click" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text=">>>>>" ID="Button2" OnClick="btnForwardStep_Click" Width="55px"></asp:Button>
		<asp:Button runat="server" style="margin:2px;" Text=">>>>>>>>>>" ID="Button4" OnClick="btnForwardStep_Click" Width="95px"></asp:Button>
		<asp:Button runat="server" style="margin:2px 2px 2px 6px;" Text="Accept" ID="btnAccept" OnClick="btnAccept_Click" Enabled="True" Width="55px"></asp:Button>
	</div>
	</div>
	<div style="text-align:left; font-family:Arial; font-size:10px;">
		<asp:Literal runat="server" ID="litstatus">
		</asp:Literal><br /><asp:HyperLink ID="hlreset" runat="server" NavigateUrl="~/Default.aspx">RESET</asp:HyperLink>
		</div>
</asp:Content>
