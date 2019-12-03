function narbar() {
    var x = document.getElementById("myTopnav");
    if (x.className === "navbar-fixed-top") {
        x.className += " responsive";
    } else {
        x.className = "navbar-fixed-top";
    }
}