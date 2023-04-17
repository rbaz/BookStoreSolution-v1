// Assign Click event to Plus Image.
$(document).on("click", "img[src*='plus.png']", function () {
    var detailRow = $(this).closest("tr").next(".details-row");
    detailRow.toggle();
    $(this).attr("src", "/images/minus.png");
});

// Assign Click event to Minus Image.
$(document).on("click", "img[src*='minus.png']", function () {
    $(this).attr("src", "/images/plus.png");
    var detailRow = $(this).closest("tr").next(".details-row");
    detailRow.hide();  // hide the detail row instead of removing it
});


function toggleElementVisibility(elementId) {
    let element = document.getElementById(elementId);
    if (element.style.display === "none") {
        element.style.display = "block";
    } else {
        element.style.display = "none";
    }
}
