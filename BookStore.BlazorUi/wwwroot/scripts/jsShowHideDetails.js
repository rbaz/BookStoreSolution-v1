// Assign Click event to Plus Image.
$(document).on("click", "img[src*='plus.png']", function () {
    /*debugger; // pause execution here    */
    var nextElem = $(this).next();
    /*if (nextElem.length) {*/
        /*$(this).closest("tr").after("<tr><td></td><td colspan='999'>" + nextElem.html() + "</td></tr>");*/
        $(this).attr("src", "/images/minus.png");
    //}
});

// Assign Click event to Minus Image.
$(document).on("click", "img[src*='minus.png']", function () {
    $(this).attr("src", "/images/plus.png");
    $(this).closest("tr").next().remove();
});

function toggleElementVisibility(elementId) {
    let element = document.getElementById(elementId);
    if (element.style.display === "none") {
        element.style.display = "block";
    } else {
        element.style.display = "none";
    }
}