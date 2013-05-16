<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head>
	<meta charset='utf-8'> 
	<meta name="viewport" content="width=device-width, user-scalable=no">
	<meta name="apple-mobile-web-app-capable" content="yes">
        
	
	<title>g-Patient</title>
    

	<link rel="stylesheet" media="(max-width: 767px)" type="text/css" href="../Content/Visit/css/mobileStyle.css" />
	<link rel="stylesheet" media="(min-width: 768px)" type="text/css" href="../Content/Visit/css/style.css">
	<script type="text/javascript" src="../Content/Visit/js/jquery-1.9.1.min.js"></script>
	<script type="text/javascript" src="../Content/Visit/js/gpatient.js"></script>

    <!--<link href='http://fonts.googleapis.com/css?family=Ubuntu+Condensed' rel='stylesheet' type='text/css'>-->

	<script type="text/javascript">
	    //document.ontouchmove = function(e){ e.preventDefault(); }
	    setTimeout(function () {
	        // Hide the address bar!
	        window.scrollTo(0, 1);

	    });

	</script>
	

	<script type="text/javascript">
	    function blockMove() {
	        event.preventDefault();
	    }


	    function touchMove(event) {
	        event.preventDefault();
	        curX = event.targetTouches[0].pageX - startX;
	        curY = event.targetTouches[0].pageY - startY;
	        event.targetTouches[0].target.style.webkitTransform =
		        'translate(' + curX + 'px, ' + curY + 'px)';
	        alert("move");
	    }


	</script>


</head>
<body>

<div id="sidebar">
	<div id="sidebarWrapper">
	<div id="notificationsButton" class="round orange">
		<div>
			<div>
				 <span class="notifIcon">!</span>
				 <span id="notifText">Notificações</span>
				 <div id="notifCounter"class="deeper round">5</div>
			</div>
		</div>
	</div>
	<div id="upperBtnBar"></div>
	<div id="selectedDay">
		<div id="daySelected" class="boldFont">30</div>
		<div id="monthSelected" class="boldFont">Abril</div>

	</div>
	<div id="calendar">
		<div id="calendarMonthBar">
			<button id="prevMonth"><</button>
			<span id="monthCalendar">Abril 2013</span>
			<button id="nextMonth">></button>
		</div>
		<div id="calendarTab">
			<div id="weekTitle" class="week">
				<span>seg</span>
				<span>ter</span>
				<span>qua</span>
				<span>qui</span>
				<span>sex</span>
				<span>sáb</span>
				<span>dom</span>
			</div>
			<div id="week1" class="week">
				<span>01</span>
				<span>02</span>
				<span>03</span>
				<span>04</span>
				<span>05</span>
				<span>06</span>
				<span>07</span>
			</div>
			<div id="week2" class="week">
				<span>08</span>
				<span>09</span>
				<span>10</span>
				<span>11</span>
				<span class="clicable">12</span>
				<span>13</span>
				<span>14</span>
			</div>
			<div id="week3" class="week">
				<span>15</span>
				<span>16</span>
				<span class="clicable">17</span>
				<span>18</span>
				<span>19</span>
				<span>20</span>
				<span>21</span>
			</div>
			<div id="week4" class="week">
				<span>22</span>
				<span>23</span>
				<span>24</span>
				<span>25</span>
				<span>26</span>
				<span>27</span>
				<span>28</span>
			</div>
			<div id="week5" class="week">
				<span>29</span>
				<span class="selected">30</span>
				<span class="disabled">01</span>
				<span class="disabled">02</span>
				<span class="disabled">03</span>
				<span class="disabled">04</span>
				<span class="disabled">05</span>
			</div>
		</div>
	</div>
	<div id="bottomBtnBar">
		<button>Hoje</button>
		<button>Todas as Consultas</button>

	</div>
	</div>
</div>
<div id="content" >

	<span id="topmargin"></span>
	<div id="eventList" class="white_bg">
		<div class="event_item white_solid_bg" >
			
			<div class="item_content">
				<div class="item_date_time">
					<div class="item_date">
						03 abr
					</div>
					<div class="item_time">
						12h00
					</div>
				</div>
				<div class="item_data" >
					<div class="item_data_title">Dermatologia</div>
					<div class="item_data_subtitle">Consultório 2 - Dr. Guedes</div>
				</div>
				<div class="item_goto_details"><span>></span></div>
			</div>
		</div>

		<div class="event_item white_solid_bg" >
					<div class="item_content">
						<div class="item_date_time">
							<div class="item_date">
								03 abr
							</div>
							<div class="item_time">
								12h00
							</div>
						</div>
						<div class="item_data" >
							<div class="item_data_title">Dermatologia</div>
							<div class="item_data_subtitle">Consultório 2 - Dr. Guedes</div>
						</div>
						<div class="item_goto_details"><span>></span></div>
					</div>
		</div>

	</div>
	<div id="detailZone"></div>

</div>


<div id="calendarScroller" >

	<span id="Span1"></span>
	<div id="dTab">
		<div id="daysScroller">
			<div class="dayScrl">
				<div class="dayScrlDtl">25</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
			<div class="dayScrl">
				<div class="dayScrlDtl">26</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
			<div class="dayScrl">
				<div class="dayScrlDtl">27</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
			<div class="dayScrl">
				<div class="dayScrlDtl">28</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
			<div class="dayScrl">
				<div class="dayScrlDtl">29</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
			<div class="dayScrl">
				<div class="dayScrlDtl">30</div>
				<div class="monthScrlDtl">Abril</div>
			</div>
		</div>
	</div>
</div>
<div id="plusBtn"></div>
</body>
</html>
