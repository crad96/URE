<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="SistemaUre.Principal1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" runat="server">
    8<header id="top-section" class="fullbg">
<div class="jumbotron">
	<div id="carousel_intro" class="carousel slide fadeing">
		<div class="carousel-inner">
			<div class="active item" id="slide_1">
				<div class="carousel-content">					
					<div class="animated fadeInDownBig">
                        

						 <!-- <h1 style="font-family:'Cooper Black'; font-size:60px">-->
                        <h1 style="font-size:60px">
                              SISTEMA DE UNIDAD DE REGISTRO Y ESCALAFON 

						 </h1>
					</div>
					<br/>
                    
                   
                    <asp:Button ID="Inicio" runat="server"  OnClick="Inicio_Click" CssClass="buttonyellow animated fadeInLeftBig fa fa-lock" Text="Iniciar Sesion btn"/>
					
				</div>
			</div>
			<div class="item" id="slide_2">
				<div class="carousel-content">					
					<div class="animated fadeInDownBig">
						 <h1>Unidad de archivos y legajos personales del personal administrativo y docente Nombrados y Contratados  </h1>
					</div>
					<br/>
					
					<a href="#" class="buttonyellow animated fadeInLeftBig"><i class="fa fa-shopping-cart"></i>&nbsp; Iniciar Sesion</a>
				</div>
			</div>
			<div class="item" id="slide_3">
				<div class="carousel-content">					
						<br/>
						<a href="#" class="buttonyellow animated fadeInLeftBig"><i class="fa fa-shopping-cart"></i>&nbsp; Iniciar Sesion</a>
				</div>
			</div>
		</div>
	</div>
	<button class="left carousel-control" href="#carousel_intro" data-slide="prev" data-start="opacity: 0.6; left: 0%;" data-250="opacity:0; left: 5%;"><i class="fa fa-chevron-left"></i></button>
	<button class="right carousel-control" href="#carousel_intro" data-slide="next" data-start="opacity: 0.6; right: 0%;" data-250="opacity:0; right: 5%;"><i class="fa fa-chevron-right"></i></button>
</div>
<div class="inner-top-bg">
</div>
</header>
<!-- / HOMEPAGE -->
<!--  SECTION-1 -->
<!-- SECTION-3(reviews) -->
<section id="Section-3" class="fullbg color-white">
<div class="section-divider">
</div>
<div class="container">
<div class="row">
	<div class="page-header text-center col-sm-12 col-lg-12 animated fade">
		<h1>Personal de Unidad de Registro y Escalafon</h1>
		<p class="lead">
			 
		</p>
	</div>
</div>
<div class="row testimonials animated fadeInUpNow">
	<div class="col-sm-12 col-lg-12">
		<div class="arrow">
		</div>
		<div class="testimonials-slider">
			<div class="slide">
				<div class="testimonials-carousel-thumbnail">
					<img width="120" alt="" src="Bootstrap/BootstrapPrincipal/assets/img/avatar.jpg">
				</div>
				<div class="testimonials-carousel-context">
					<div class="testimonials-name">
						 Bill Robinson <span>google.com</span>
					</div>
					<div class="testimonials-carousel-content">
						<p>
							 "Our party was a great success and the marquee was perfect for the occasion and so fortunately was the weather! Thank you to you and your team for erecting it so smoothly and professionally.
						</p>
						<p>
							 Sed posuere consectetur est at lobortis. Fusce dapibus, tellus ac cursus commodo.Cras mattis consectetur purus sit amet fermentum. Sed posuere consectetur est at lobortis. Fusce dapibus, tellus ac cursus commodo."
						</p>
					</div>
				</div>
			</div>
			<div class="slide">
				<div class="testimonials-carousel-thumbnail">
					<img width="120" alt="" src="Bootstrap/BootstrapPrincipal/assets/img/avatar.jpg">
				</div>
				<div class="testimonials-carousel-context">
					<div class="testimonials-name">
						 Michael Rocks <span>yahoo.com</span>
					</div>
					<div class="testimonials-carousel-content">
						<p>
							 "Cras mattis consectetur purus sit amet fermentum. Sed posuere consectetur est at lobortis. Fusce dapibus, tellus ac cursus commodo.
						</p>
					</div>
					<p>
						 Our party was a great success and the marquee was perfect for the occasion and so fortunately was the weather! Thank you to you and your team for erecting it so smoothly and professionally."
					</p>
				</div>
			</div>
			<div class="slide">
				<div class="testimonials-carousel-thumbnail">
					<img width="120" alt="" src="Bootstrap/BootstrapPrincipal/assets/img/avatar.jpg">
				</div>
				<div class="testimonials-carousel-context">
					<div class="testimonials-name">
						 Andrew Bilson <span>wowthemes.net</span>
					</div>
					<div class="testimonials-carousel-content">
						<p>
							 "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal.
						</p>
					</div>
					<p>
						 Our party was a great success and the marquee was perfect for the occasion and so fortunately was the weather! Thank you to you and your team for erecting it so smoothly and professionally."
					</p>
				</div>
			</div>
		</div>
	</div>
</div>
</div>
</section>












<!-- SECTION-4(team) -->
<section id="Section-4" class="fullbg color-white">
<div class="section-divider">
</div>
<div class="container demo-3">
<div class="row">
	<div class="page-header text-center col-sm-12 col-lg-12 animated fade">
		<h1>Equipo de Desarrollo</h1>
		<p class="lead">
			 Diseñadores y Desarrolladores
		</p>
	</div>
</div>
<div class="row animated fadeInUpNow">
	<div class="col-md-3">
		<div class="thumbnail">
			<img src="/Bootstrap/Img/foto.jpg" alt="">
			<div class="caption">
				<h4>Angel Cordova Rosario</h4>
				<span class="primarycol">- Diseñador y Desarrollador -</span>
				<ul class="social-icons">
					<li><a href="#"><i class="fa fa-facebook"></i></a></li>
					<li><a href="#"><i class="fa fa-twitter"></i></a></li>		
					<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
				</ul>
			</div>
		</div>
	</div>
	<div class="col-md-3">
		<div class="thumbnail">
			<img src="#" alt="">
			<div class="caption">
				<h4>Katteryn Azañero Huaman </h4>
				<span class="primarycol">- Diseñador y Desarrollador -</span>

				<ul class="social-icons">
					<li><a href="#"><i class="fa fa-facebook"></i></a></li>
					<li><a href="#"><i class="fa fa-twitter"></i></a></li>		
					<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
				</ul>
			</div>
		</div>
	</div>

    	<div class="col-md-3">
		<div class="thumbnail">
			<img src="#" alt="">
			<div class="caption">
				<h4>Kocky Ravenna Rupay</h4>
				<span class="primarycol">- Diseñador y Desarrollador -</span>

				<ul class="social-icons">
					<li><a href="#"><i class="fa fa-facebook"></i></a></li>
					<li><a href="#"><i class="fa fa-twitter"></i></a></li>		
					<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
				</ul>
			</div>
		</div>
	</div>



	<div class="col-md-3">
		<div class="thumbnail">
			<img src="#" alt="">
			<div class="caption">
				<h4>Erny Garcia Reynoso </h4>
				<span class="primarycol">- Diseñador y Desarrollador -</span>
	    
                	<ul class="social-icons">
					<li><a href="#"><i class="fa fa-facebook"></i></a></li>
					<li><a href="#"><i class="fa fa-twitter"></i></a></li>		
					<li><a href="#"><i class="fa fa-google-plus"></i></a></li>
				</ul>
			</div>
		</div>
	</div>
</div>
</div>
</section>
</asp:Content>
