<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
    <title>E Blogs</title>
<meta charset="UTF-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-blue-grey.css"/>
<link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Open+Sans'/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
     
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<style>
html,body,h1,h2,h3,h4,h5 {font-family: "Open Sans", sans-serif}
body {
    background-size:cover;
    background-image:url("images/root-web-designs-slider-background.jpg");
}
</style>
    <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to accept request?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }
       
        function Confirm1() {
            var confirm_value1 = document.createElement("INPUT");
            confirm_value1.type = "hidden";
            confirm_value1.name = "confirm_value1";
            if (confirm("Show blogs")) {
                confirm_value1.value = "Yes";
            } else {
                confirm_value1.value = "No";
            }
            document.forms[0].appendChild(confirm_value1);
        }


    </script>
</head>
<body class="w3-theme-l5">
    <form id="form1" runat="server">
        
    <div>
     &nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="Black" BorderStyle="Solid" ForeColor="White" OnClick="Button1_Click1" Text="Home" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label1" runat="server" Text="Name" Font-Italic="True" ForeColor="Black" Font-Size="XX-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ></asp:Label>
        <br />
&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" Text="Follow request" type="button" class="btn btn-link" onclick="Button1_Click" autofocus="autofocus" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: medium; font-style: normal"></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" Text="Following" type="button" class="btn btn-link" onclick="Button2_Click" autofocus="autofocus" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: medium; font-style: normal">
            
        </asp:Button>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button runat="server" Text="Followers" type="button" class="btn btn-link" onclick="Button3_Click" autofocus="autofocus" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: medium; font-style: normal">
            
        </asp:Button>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  <asp:Button runat="server" Text="New Updates" type="button" class="btn btn-link" onclick="Button4_Click" autofocus="autofocus" style="font-family: 'Times New Roman', Times, serif; color: #FFFFFF; font-size: medium; font-style: normal"></asp:Button>

    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    
        <asp:DropDownList ID="DropDownList1" runat="server" Visible="false" Height="22px" style="margin-left: 0px" Width="124px" onchange="Confirm()" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Text="Notification" Value="0"></asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Height="23px" Width="118px" Visible="false">
            <asp:ListItem>Following</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" Visible="false" Height="21px" Width="125px">
            <asp:ListItem>Follower</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server" Visible="false"  Height="21px" Width="125px" onchange="Confirm1()" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"   >
            <asp:ListItem>Admin </asp:ListItem>
        </asp:DropDownList>
        &nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label6" runat="server" ></asp:Label>
        &nbsp;&nbsp;
        <br />
        <br />
        </div>
        <div class="container">
  
  <!-- Trigger the modal with a button -->

  <!-- Modal -->
  <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;m</button>
          <h4 class="modal-title">New updates</h4>
        </div>
        <div class="modal-body">
            <p>
            <asp:Label ID="Label5" runat="server"></asp:Label>
                </p>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        </div>
      </div>
      
    </div>
  </div>
  
</div>

         <div id="post" class="active" runat="server" style="height:auto; margin-left:65px;margin-top:20px;margin-right:15px; width:90%">
       
   </div>
    </form>
</body>
</html>
