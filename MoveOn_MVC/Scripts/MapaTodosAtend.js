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
                zoom: 10,
                center: myLatlng,
                panControl: false,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            }

            // Exibir o mapa na div #mapa;
            var map = new google.maps.Map(document.getElementById("google-mapa-todo"), mapOptions);

            carregarPontos(map);

            var infowindow = new google.maps.InfoWindow();            

        }
    });

}

    
function carregarPontos(map) {
    $.getJSON('/Scripts/AtendimentosAbertos.json', function (locais) {
        var geocoder = new google.maps.Geocoder();
        $.each(locais, function (index, local) {
            var address = local.Endereco;
            
            geocoder.geocode({ 'address': address }, function (results, status) {              
                if (status == google.maps.GeocoderStatus.OK) {
                    latitude = results[0].geometry.location.lat();
                    longitude = results[0].geometry.location.lng();

                    var marker = new google.maps.Marker({
                        position: new google.maps.LatLng(latitude, longitude),
                        title: "Meu ponto personalizado! :-D",
                        map: map
                    });
                }
            });
        });
    });
}

google.maps.event.addDomListener(window, 'load', initialize);