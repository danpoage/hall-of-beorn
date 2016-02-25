function getLocal(key) {
    if (typeof (Storage) !== "undefined") {
        return localStorage.getItem(key);
    }
}

function setLocal(key, data) {
    if (typeof (Storage) !== "undefined") {
        localStorage.setItem(key, data);
    }
}

function clearLocal(key) {
    if (typeof (Storage) !== "undefined") {
        localStorage.removeItem(key);
    }
}

function removeUrlParameter(url, parameter) {
    //prefer to use l.search if you have a location/link object
    var urlparts = url.split('?');
    if (urlparts.length >= 2) {

        var prefix = encodeURIComponent(parameter) + '=';
        var pars = urlparts[1].split(/[&;]/g);

        //reverse iteration as may be destructive
        for (var i = pars.length; i-- > 0;) {
            //idiom for string.startsWith
            if (pars[i].lastIndexOf(prefix, 0) !== -1) {
                pars.splice(i, 1);
            }
        }

        url = urlparts[0] + '?' + pars.join('&');
        return url;
    } else {
        return url;
    }
}