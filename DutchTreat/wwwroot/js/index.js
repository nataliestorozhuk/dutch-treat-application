(function () {
    var x = 0;
    var s = "";

    console.log("Hello Nata");




    /*the syntax with jQuery library*/
    var theForm = $("#theForm");
    theForm.hide();

    /*the syntax without jQuery library*/
    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;

    var button = $("#butButton");
    button.on("click", function () {
        console.log("Buying Item");
    });


    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");


    $loginToggle.on("click", function () {
        $popupForm.slideToggle(3000);
            });


})();