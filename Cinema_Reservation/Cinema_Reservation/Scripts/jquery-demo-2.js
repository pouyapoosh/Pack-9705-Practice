(function () { 

    //$(document).on('ready', function () { 
    //$(document).ready(function () {
    $(function () { //Document Ready
        let $wrapper = $('#wrapper');
        $wrapper.css('text-align', 'center');
        let $location = $('#location');
        let locations = [
                { "text": "سالن ۱" , "seats" : [25, 25, 25, 30, 20, 20, 15, 10] },
                { "text": "سالن ۲", "seats": [25, 25, 25, 30, 20, 20, 15, 10] },
                { "text": "سالن ۳", "seats": [25, 25, 25, 30, 30, 5] },
        ];

        let selected_seats = [];

        for (let ix in locations) {
            $('<option>')
                .val(ix)
                .html(locations[ix].text)
                .appendTo($location);
        }

        $location.on('change', function () {
            let selectedIndex = $location.val(); //$(this).val();
            //alert(selectedIndex);

            if (selectedIndex !== -1) {
                $wrapper.html('');
                //$('#Save').append(
                //    ('<button>').addClass('btn-block btn-success').text('ذخیره اطلاعات  &nbsp;')
                //        .append(
                //            ('<span>').addClass('fa fa-save')
                //        )
                //);
                let seats = locations[selectedIndex].seats;
                for (let ix in seats) {

                    let seat_buttons = $('<div>').addClass('col-md-11');
                    for (var i = 0; i < seats[ix]; i++) {
                        seat_buttons.append(
                            $('<button>')
                                .addClass('btn btn-success btn-xs')
                                .html(i + 1)
                                .on('click', function () {
                                    //alert($(this).html());
                                    selected_seats.push(+$(this).html());
                                    var sandaliha = [];
                                    let x = 0;
                                    if (x <= 9) {
                                        sandaliha = $(this).html();
                                        x++;
                                    }
                                    sandaliha.toString();
                                    $(this).toggleClass('btn-success').toggleClass('btn-warning');
                                })
                        );
                    }
                    $('<div>')
                        .addClass('row')
                        .append($('<div>').addClass('col-md-1').html(+ix + 1))
                        .append(seat_buttons).appendTo($wrapper);
                }
            }

        });
        $('#Send').on('click', function SendData() {
            let firstname = $('#name').val();
            let lastname = $('#family').val();
           
            $.ajax({
                method: "GET",
                URL: "/AjaxSavingData.aspx",
                data: { name: firstname, family: lastname, seats: sandaliha }
            })

        })

    });

})();