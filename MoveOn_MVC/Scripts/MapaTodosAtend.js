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

    var uri = "http://localhost:50154/api/av1/private/atendimentosabertos";

    $.getJSON(uri, function (locais) {
        var geocoder = new google.maps.Geocoder();
        $.each(locais, function (index, local) {

            //var address = "Estrada São Francisco, 2701 - Vila Sonia do Taboao, Taboão da Serra - SP, Brasil";
            //"localizacao": {
            //    "id": 1,
            //    "logradouro": "Rua",
            //    "_Endereco": "Maria da Penha",
            //    "numero": "321",
            //    "complemento": null,
            //    "cep": "03232567",
            //    "cidade": "São Paulo",
            //    "estado": "SP",
            //    "pais": "Brasil",
            //    "coordenadaX": 12345,
            //    "coordenadaY": 42322

            var address = local.logradouro + " " + local._Endereco + ", " + local.numero + " - " + local.bairro + ", " + local.cidade + " - " + local.estado + ", " + local.pais;
                       

            geocoder.geocode({ 'address': address }, function (results, status) {              
                if (status == google.maps.GeocoderStatus.OK) {
                    latitude = results[0].geometry.location.lat();
                    longitude = results[0].geometry.location.lng();

                    console.log(address);

                    var marker = new google.maps.Marker({
                        position: new google.maps.LatLng(latitude, longitude),
                        title: address,
                        map: map
                    });
                }
            });
        });
    });
}

google.maps.event.addDomListener(window, 'load', initialize);