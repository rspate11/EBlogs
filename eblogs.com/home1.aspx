<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="home1.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="w3-container" style="background:#ffdd99">
  <h2 style="align-content:center;text-align:center; font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;"> Categories</h2>
  <p></p>
</div>
        <div class="w3-content" style="width:100%">
  <img  class="mySlides" src="images/breakfast.jpg" style="width:100%"/>
  <img  class="mySlides" src="images/travel.jpg" style="width:100%"/>
  
</div>
        <div class="w3-center">
  <div class="w3-section">
    <button class="w3-button w3-light-grey" onclick="plusDivs(-1)"> ❮ Prev</button>
    
   
    <button class="w3-button w3-light-grey" onclick="plusDivs(1)">Next ❯ </button>
  </div>
 
  <button class="w3-button demo" onclick="currentDiv(4)">Food</button>
  <button class="w3-button demo" onclick="window.open('travelling.aspx')">Travelling</button>

</div>

<script>
    var slideIndex = 1;
    showDivs(slideIndex);

    function plusDivs(n) {
        showDivs(slideIndex += n);
    }

    function currentDiv(n) {
        showDivs(slideIndex = n);
    }

    function showDivs(n) {
        var i;
        var x = document.getElementsByClassName("mySlides");
        var dots = document.getElementsByClassName("demo");
        if (n > x.length) { slideIndex = 1 }
        if (n < 1) { slideIndex = x.length }
        for (i = 0; i < x.length; i++) {
            x[i].style.display = "none";
        }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" w3-red", "");
        }
        x[slideIndex - 1].style.display = "block";
        dots[slideIndex - 1].className += " w3-red";
    }
</script>
        

	<div class="container">
		<div class="content" style="background:#ffdd99">
			<div>
			   <div class="container">
		

            <div   style=" margin-right: 0px;  margin-top:auto ;height:96px; width:100%;">
			    <img src="images/FISHING RODS.jpg" style="height:auto;width:100%;" /><br />
               
                </div>

        <br />
        <br />
        <br />
       
        
        
        
        
        
        
        <div style="height: 96px; width: 100%; margin-right: auto; margin-top: 50px">
                 <img src="images/ad.png" style="height:auto;width:100%;" /><br />
               
			   
&nbsp;</div>
            </div>





<!-- content -->
<!-- footer -->
	<div class="footer">
		<div class="container">
			<p> &nbsp;</p>
            <p> &nbsp;</p>
            <div class="footer">
		<div class="container">
			<p> &nbsp;</p>
            <p> &nbsp;2017  ©
                E Blogs
		</p>
		</div>
	</div>
				
			</div>
		</div>
	</div>
<!-- footer -->
&nbsp;</div>
            </div>
        
	





</asp:Content>

