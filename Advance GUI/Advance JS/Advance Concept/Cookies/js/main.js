function saveTheCookie(value, number_of_days = 0) {
    var cookie_name = "sessionID";
    var today = new Date();
    var expire = new Date();
    expire.setTime(today.getTime() + 60 * 60 * 1000 * 24 * number_of_days);
    if(number_of_days != 0)
        document.cookie = cookie_name + "=" + value + "; expires=" + expire.toGMTString() + "; secure; samesite=strict;";
        else{
            document.cookie = cookie_name + "=" + value + "; secure; samesite=strict;";
        }
}

function getTheCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return false;
}