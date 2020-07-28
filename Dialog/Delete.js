	$(".Delete").on("click", function(event) {
		var tr = $(this).closest('tr.row');
		var id = $(this).attr('id');
		tr.fadeIn(800, function() {	// turn the select row red
			tr.addClass('deleterow');
		});		

	  	if (!window.confirm("Please confirm - this will delete the selected record?")) {
			tr.fadeIn(800, function() {
				tr.removeClass('deleterow');
			});
			alert("Not deleted!");
			return false;
		}
		$.ajax({ 
			type: "POST",
			url: "Action/Delete.cfm",
			data: {
				id: id
			},
		  	success: function(data) {  
				var obj = $.parseJSON(data);
				if (!obj.SUCCESS) {
					tr.fadeIn(800, function() {
						tr.removeClass('deleterow');
					});
					alert(obj.ERROR);
					}
				else {
					tr.remove();
				}
			}
		});	
	});	