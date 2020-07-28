			$(".tablesorter").tablesorter({
				debug:false,
				theme: 'custom'
			});
			$( ".tablesorter tbody tr" ).bind("mouseenter",function() {
				$(this).css("background-color","ghostwhite");
			});
			$( ".tablesorter tbody tr" ).bind("mouseleave",function() {
				$(this).css("background-color","white");
			});
			
			
Used in Grants -- if tables within tables ??

			$(".tablesorter tbody tr").mouseover(function() {
				$(this).css("background-color","ghostwhite");
				$(this).children().css("background-color","ghostwhite");
			});
			$(".tablesorter tbody tr").mouseout(function() {
				$(this).css("background-color","");
				$(this).children().css("background-color","");
			});