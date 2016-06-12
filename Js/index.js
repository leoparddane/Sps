/**
 * Created by Administrator on 2016/4/20.
 */
window.onload = function () {
    var onld = document.getElementById("onld");
    lod(120);
    var times = null;
    function lod(top) {
        clearInterval(times);
        var onld = document.getElementById("onld");
        times = setInterval(function () {
            var speen = (top - onld.offsetTop) / 20;
            speen = speen > 0 ? Math.ceil(speen) : Math.floor(speen);
            if (onld.offsetTop == top) {
                clearInterval(times);
            } else {
                onld.style.top = onld.offsetTop + speen + 'px';
            }
        }, 50)
    }
};