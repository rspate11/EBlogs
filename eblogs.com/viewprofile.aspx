<%@ Page Title="E Blogs" Language="C#" AutoEventWireup="true" CodeFile="viewprofile.aspx.cs" Inherits="viewprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title></title>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-blue-grey.css"/>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Open+Sans'/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
<style>
html,body,h1,h2,h3,h4,h5 {font-family: "Open Sans", sans-serif}
body {
    background-size:cover;
    background-image:url("images/root-web-designs-slider-background.jpg");
}
</style>
        </head>
<body class="w3-theme-l5">

    <form id="form1" runat="server">

        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="Black" BorderStyle="Solid" ForeColor="White" OnClick="Button2_Click" Text="Home" />
            <br />
&nbsp;&nbsp;
        </p>

        <asp:Label ID="Label1" runat="server" Text="Username:" Font-Bold="True" ForeColor="White" style="font-size: x-large"></asp:Label> &nbsp; <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="White" style="font-size: x-large" ></asp:Label>

<!-- Navbar -->


<!-- Navbar on small screens -->


<!-- Page Container -->


             <div id="post" class="active" runat="server" style="height:auto; margin-left:65px;margin-top:20px;margin-right:65px; width:90%; background-image: inherit;">
       
   </div>
            

    <br />
        <br />

       
    
       
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Visible="true" OnClick="Button1_Click1" Text="Follow" Height="35px" Width="100px" BackColor="Black" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
               
 
<script>
    // Accordion
    function myFunction(id) {
        var x = document.getElementById(id);
        if (x.className.indexOf("w3-show") == -1) {
            x.className += " w3-show";
            x.previousElementSibling.className += " w3-theme-d1";
        } else {
            x.className = x.className.replace("w3-show", "");
            x.previousElementSibling.className =
                x.previousElementSibling.className.replace(" w3-theme-d1", "");
        }
    }

    // Used to toggle the menu on smaller screens when clicking on the menu button
    function openNav() {
        var x = document.getElementById("navDemo");
        if (x.className.indexOf("w3-show") == -1) {
            x.className += " w3-show";
        } else {
            x.className = x.className.replace(" w3-show", "");
        }
    }
</script>

    </form>

</body>


</html>
