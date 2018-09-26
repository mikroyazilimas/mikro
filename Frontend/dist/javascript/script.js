function ShowLoading() {
    $(".loading-bar").fadeIn();
}

function HideLoading() {
    $(".loading-bar").fadeOut();
}

$(document).ready(function () {
    $("body").on("submit", "form", function () {
        ShowLoading();
    });
});