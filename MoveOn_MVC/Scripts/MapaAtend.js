function initialize() {
    var latitude = 0, longitude = 0;

    var geocoder = new google.maps.Geocoder();
    var address = "Estrada São Francisco, 2701 - Vila Sonia do Taboao, Taboão da Serra - SP, Brasil";
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status == google.maps.GeocoderStatus.OK) {

            latitude = results[0].geometry.location.lat();
            longitude = results[0].geometry.location.lng();

            var myLatlng = new google.maps.LatLng(latitude, longitude);

            var mapOptions = {
                disableDefaultUI: true,
                zoom: 17,
                center: myLatlng,
                panControl: false,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }

            // Exibir o mapa na div #mapa;
            var map = new google.maps.Map(document.getElementById("google-mapa"), mapOptions);

            var infowindow = new google.maps.InfoWindow();


            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: 'Hello World!'
            });

            google.maps.event.addListener(marker, 'click', (function (marker, i) {
                return function () {
                    infowindow.setContent("Testeeee");
                    infowindow.open(map, marker);
                }
            })(marker, 0));

        }
    });

}
google.maps.event.addDomListener(window, 'load', initialize);