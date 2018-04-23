﻿$(document).ready(function () {
    $("form").submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: "api/reservation",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify({
                clientName: this.elements["ClientName"].value,
                location: this.elements["Location"].value
            }),
            success: function(data) {
                addTableRow(data);
            }
        })
    });
});

var addTableRow = function(reservation) {
    $("table body").append("<tr><td>" + reservation.reservationID + "</td><td>"
        + reservation.clientName + "</td><td>"
        + reservation.location + "</td><tr>");
}