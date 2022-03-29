function listing() {
    var deferred = $.Deferred();
    var promises = [];
    var promise;
    var index = 0;
    var list = $('ul').find('li');
    list.each(function(index) {
        var that = $(this);
        console.log(that);
        var deferred = $.Deferred();
        setTimeout(function() {
            that.html(index);
            deferred.resolve();
        }, 8000);
        //push the deferred outside the timeout
        promises.push(deferred.promise());
    });

    $.when.apply($, promises).then(function() {
        setTimeout(function() {
            deferred.resolve();
        }, 2000);
    });

    return deferred.promise();
}

$.when(listing().done(function() {
    console.log('all done');
}));