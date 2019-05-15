<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login1.aspx.cs" Inherits="login1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
       <style type="text/css">
       
        .auto-style2 {
            width: 100%;
        }
        #Button12 {
            width: 56px;
            height: 22px;
            margin-left: 0px;
        }
           #Button2 {
               height: 25px;
               margin-top: 4px;
           }
           #Button1 {
               width: 92px;
               color: #FFFFFF;
               font-weight: 700;
               font-size: medium;
               margin-left: 40px;
               margin-top: 7px;
               background-color: #009900;
           }
           .auto-style8 {
               width: 189px;
           }
           .auto-style9 {
               width: 300px;
           }
    </style>
</head>
<body style="font-size: xx-large">
    <form id="form1" runat="server" style="background-image: url('images/root-web-designs-slider-background.jpg'); height: 1793px;">
   
    
        <strong style="color: #FFFFFF">
        <input id="ButtonReturn" onclick="window.open('Default.aspx')" type="button"  value="Home" style="border-style: none; color: #FFFFFF; background-color: #FF0000; font-weight: 700; margin-left: 0px;" />&nbsp&nbsp&nbsp; Login Page</strong><table class="auto-style2">

            <tr>
                <td  style="font-size: large; text-align: right" class="auto-style9">UserName:</td>
                <td class="auto-style8" >
                    <asp:TextBox ID="TextBoxUsername" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="*Enter Username" ForeColor="Red" style="font-size: medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td  style="font-size: large; text-align: right" class="auto-style9">Password:</td>
                <td class="auto-style8" >
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="*Enter password" ForeColor="Red" style="font-size: medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            
        </table>
       
          <input id="Button1" onclick="window.open('registration.aspx')" style="border-style: none; margin-left: 307px;" type="button" value="Register" /><asp:Button ID="Button_login" runat="server" OnClick="Button_login_Click" Text="Login" BackColor="Red" BorderColor="Red" BorderStyle="None" ForeColor="White" style="font-size: medium; font-weight: 700; margin-left: 36px;" />
           <br />
        <br />
        <br />
        <br />
    </form>
</body>

 
</html>
