$(document).ready(function () {
    $("#errMsg").hide();
});

$("#btnsearchlatlang").click(function () {
    var mnc = $("#MNC").val();
    var mcc = $("#MCC").val();
    var lac = $("#LAC").val();
    var cid = $("#CID").val();

    var mapreq =
        {
            MNC: mnc,
            MCC: mcc,
            LAC: lac,
            CID: cid
        };

    $.ajax({
        type: 'POST',
        url: '/api/map',
        data: JSON.stringify(mapreq),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (d) {
            console.log(d);
            if (d != undefined && d.Latitude != null && d.Latitude > 0) {
                $("#errMsg").hide();
                $("#searched_lat").html(d.Latitude);
                $("#searched_long").html(d.Longitude);
            }
            else {
                $("#errMsg").show();
                $("#errMsg").html("Please enter valid data");
            }
        }
    });
});