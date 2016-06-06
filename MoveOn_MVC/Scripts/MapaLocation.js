function initialize() {
    var latitude = 0, longitude = 0;    
    var geocoder = new google.maps.Geocoder();
    //var address = "Estrada São Francisco, 2701 - Vila Sonia do Taboao, Taboão da Serra - SP, Brasil"                     
    var uri = "http://localhost:50154/api/av1/private/atendimentosabertos";
    
        $.getJSON(uri, function (locais) {
            var geocoder = new google.maps.Geocoder();
            $.each(locais, function (index, local) {

                var address = local.logradouro + " " + local._Endereco + ", " + local.numero + " - " + local.bairro + ", " + local.cidade + " - " + local.estado + ", " + local.pais;           

                geocoder.geocode({ 'address': address }, function (results, status) {
                    if (status == google.maps.GeocoderStatus.OK) {
                        latitude = results[0].geometry.location.lat();
                        longitude = results[0].geometry.location.lng();

                        var myLatlng = new google.maps.LatLng(latitude, longitude);

                        var infowindow = new google.maps.InfoWindow();

                        var mapOptions = {
                            disableDefaultUI: true,
                            zoom: 17,
                            center: myLatlng,
                            panControl: false,
                            mapTypeId: google.maps.MapTypeId.ROADMAP
                        }                    

                        var map = new google.maps.Map(document.getElementById("google-mapa-" + local.id), mapOptions);

                        var marker = new google.maps.Marker({
                            position: myLatlng,
                            map: map,
                            title: address
                        });

                        google.maps.event.addListener(marker, 'click', (function (marker, i) {
                            return function () {
                                infowindow.setContent("Testeeee");
                                infowindow.open(map, marker);
                            }
                        })(marker, 0));
                    }
                });
            });            
        });
}

google.maps.event.addDomListener(window, 'load', initialize);