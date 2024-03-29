(function () {
    var nameOfBrowser = navigator.appName;
    var addScroll = false;
    var pX = 0;
    var pY = 0;
    var theLayer;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;
    if (nameOfBrowser == "Netscape") {
        document.captureEvents(Event.MOUSEMOVE)
    }

    function mouseMove(event) {
        if (nameOfBrowser == "Netscape") {
            pX = event.pageX - 5;
            pY = event.pageY;
        } 
        else {
            pX = event.x - 5;
            pY = event.y;
        }

        if (nameOfBrowser == "Netscape") {
            if (document.layers.ToolTip.visibility == 'show') {
                popTip();
            }
        } 
        else {
            if (document.all['ToolTip'].style.visibility == 'visible') {
                popTip();
            }
        }
    }
    function popTip() {
        if (nameOfBrowser == "Netscape") {
            theLayer = document.layers.ToolTip;

            if ((pX + 120) > window.innerWidth) {
                pX = window.innerWidth - 150;
            }

            theLayer.left = pX + 10;
            theLayer.top = pY + 15;
            theLayer.visibility = 'show';
        } 
        else {
            theLayer = eval('document.all[\'ToolTip\']');
            if (theLayer) {
                pX = event.x - 5;
                pY = event.y;

                if (addScroll) {
                    pX = pX + document.body.scrollLeft;
                    pY = pY + document.body.scrollTop;
                }

                if ((pX + 120) > document.body.clientWidth) {
                    pX = pX - 150;
                }

                theLayer.style.pixelLeft = pX + 10;
                theLayer.style.pixelTop = pY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }
    function HideTip() {
        args = HideTip.arguments;
        if (nameOfBrowser == "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        } else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }
    function HideMenu1() {
        if (nameOfBrowser == "Netscape") {
            document.layers.menu1.visibility = 'hide';
        } 
        else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (nameOfBrowser == "Netscape") {
            theLayer = eval('document.layers[\'menu1\']');
            theLayer.visibility = 'show';
        } 
        else {
            theLayer = eval('document.all[\'menu1\']');
            theLayer.style.visibility = 'visible';
        }
    } 

    function HideMenu2() {
        if (nameOfBrowser == "Netscape") {
            document.layers['menu2'].visibility = 'hide';
        } 
        else {
            document.all['menu2'].style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (nameOfBrowser == "Netscape") {
            theLayer = eval('document.layers[\'menu2\']');
            theLayer.visibility = 'show';
        } else {
            theLayer = eval('document.all[\'menu2\']');
            theLayer.style.visibility = 'visible';
        }
    }
})();
