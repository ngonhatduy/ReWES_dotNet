//Set map and maker
var map;
function initMap() {
    // set position map
	var latlng = new google.maps.LatLng(10.762639, 106.682027); 
	var myOptions = {
		zoom: 17,
		center: latlng,
		mapTypeId: google.maps.MapTypeId.ROADMAP
	};
	map = new google.maps.Map(document.getElementById("map"), myOptions);
	
	//Set maker for position
	var marker = new google.maps.Marker({ 
		position: latlng,
		map: map,
	});
	
	// Display data
    new TxtOverlay(latlng, "", "markerTextBox", "customBox", map);
}

google.maps.event.addDomListener(window, 'load', initMap);