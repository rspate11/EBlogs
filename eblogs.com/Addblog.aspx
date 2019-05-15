<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addblog.aspx.cs" Inherits="Addblog" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
   
<title>E blogs</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all"/>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href='http://fonts.googleapis.com/css?family=Open+Sans:400italic,400,800,700' rel='stylesheet' type='text/css'/>
<link href='http://fonts.googleapis.com/css?family=Pacifico' rel='stylesheet' type='text/css'/>
<script src="js/jquery.min.js"></script>	
   
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <ajaxToolkit:HtmlEditorExtender ID="HtmlEditorExtender1" runat="server" EnableSanitization="false" TargetControlID="bodytxt"></ajaxToolkit:HtmlEditorExtender>
    
        <div class="banner">
  	    <div class="container">
			<div class="logo">
				&nbsp;<img src="images/eblogs.png" /></div>
		</div> 
			<div class="header-bottom">
				<div class="container">
					<div class="head-nav">
						<span class="menu"> </span>
							<ul>
								<li class="active"><a href="Default.aspx">Home</a></li>
								<li><a href="Home.aspx">Read</a></li>
                               
								<li>
                                    
                                    <a href="Uploadblog.aspx">Upload</a></li>
                                
                                <li>
                                  
                                    <a href="profile.aspx">Profile</a></li>
                                
                                

								<div class="clearfix"> </div>
						</ul>
				</div>
				<!-- script-for-nav -->
					<script>
					    $("span.menu").click(function () {
					        $(".head-nav ul").slideToggle(300, function () {

					        });
					    });
					</script>
				<!-- script-for-nav -->		
						<div class="clearfix"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            </div>
				</div>
			</div>
	</div>
        <asp:Label ID="Titlelabel" runat="server" Text="Title"></asp:Label>
        :<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Title" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="labelblog" runat="server" Text="Blog"></asp:Label>
            :</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="bodytxt" runat="server" Columns="50" Rows="10" TextMode="MultiLine" Height="213px" Width="670px"></asp:TextBox>
            &nbsp;</p>
        <asp:Button ID="sub" runat="server" OnClick="sub_Click" Text="Submit" />
    
    </form>
</body>
</html>
