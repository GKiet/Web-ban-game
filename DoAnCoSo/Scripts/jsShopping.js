$(document).ready(function () {
    ShowCount();
    $('body').on('click', '.add-to-cart', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var quatity = 1;
        var tQuantity = $('#quantity_value').text();
        if (tQuantity != '') {
            quatity = parseInt(tQuantity);
        }

  /*      alert(id + "" + quatity);*/
        $.ajax({
            url: '/shoppingcart/addtocart',
            type: 'POST',
            data: { id: id, quantity: quatity },
            success: function (rs) {
                if (rs.Success) {
                    $('#fa-solid fa-cart-shopping').html(rs.Count);
                    alert(rs.msg);
                }
            }
        });
    });
});

function ShowCount() {
    $.ajax({
        url: '/shoppingcart/ShowCount',
        type: 'GET',
        success: function (rs) {
            $('#fa-solid fa-cart-shopping').html(rs.Count);
        }
    });
}