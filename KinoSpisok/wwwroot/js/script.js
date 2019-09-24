document.getElementById('knopka').onclick = sliderLeft;

var left = 0;

function sliderLeft() {
    var polosa = document.getElementById('polosa');
    left = left - 350;
    if (left < -2450) {
        left = 0;
    }
    polosa.style.left = left + 'px';
}

window.onload = function () {

    document.querySelector('#menu').onmouseover = menuShow;
    document.querySelector('#menu').onmouseout = menuHide;
    //document.querySelector('#search1').onmousedown = searchShow;

    function menuShow() {
        var show = document.querySelector('#menu');
        show.style.left = 0;
    }

    function menuHide() {
        var hide = document.querySelector('#menu');
        hide.style.left = '-135px';
    }

    //function searchShow() {
    //    var show = document.querySelector('#search');
    //    show.style.top = '7px'
    //}
}

