var model = {
    reservations: ko.observableArray()
};

function sendAjaxRequest(httpMethod, callback, url) {
    $.ajax("/api/web" + (url ? "/" + url : ""), {
        type: httpMethod, success, callback
    });
}

function getAllItems() {
    sendAjaxRequest("GET", function (data) {
        model.reservations.removeAll();
        for (vari = 0; i < data.length; i++) {
            model.reservations.push(data[i]);
        }
    });
}

    function removeItem(item) {
        sendAjaxRequest("DELETE", function () { getAllItems(); }, item.ReservationId);
    }


    $(document).ready(
        function () {
            getAllItems();
            ko.applyBindings(model);
        }
    );


