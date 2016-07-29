var uri = 'api/categories';

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of categories.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<tr><td></td></tr>', { text: item.Name }).appendTo($('#categories'));
            });
        });
});

function formatItem(item) {
    return item.Name + ': $' + item.Price;
}