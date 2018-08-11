var map;
function initMap() {
    var mapOptions = {
        zoom: 8,
        center: new google.maps.LatLng(-34.397, 150.644)
    };
    map = new google.maps.Map(document.getElementById('map'), mapOptions);
}
google.maps.event.addDomListener(window, 'load', initMap);

function LoadMarker(lat,long) {
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(lat, long),
        map: map,
        title: 'Hello World!'
    });

    var contentString = '<div id="content" style="width: 200px; height: 200px;"><h1>Overlay</h1></div>';
    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    google.maps.event.addListener(marker, 'click', function () {
        infowindow.open(map, marker);
    });

    // To add the marker to the map, call setMap();
    marker.setMap(map);
}
