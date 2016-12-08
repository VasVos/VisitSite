$("div#images").sequencer({
    // the amount of images
    count: 15,

    // path to your images
    path: "Content/Images/main",

    // extension of your images
    ext: "jpeg"
},
    function () {
        $("div#preload").hide();
    });
