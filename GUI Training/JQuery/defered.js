function listing() {
    var deferred = $.Deferred();
    var promises = [];
    var list = $('ul').find('li');
    list.each(function(index) {
        var that = $(this);

        var deferred = $.Deferred();
        setTimeout(function() {
            that.html(index);
            deferred.resolve();
        }, 5000);
        promises.push(deferred.promise());
    });

    $.when.apply($, promises).then(function() {
        setTimeout(function() {
            deferred.resolve();
            console.log("Done...")
            alert("Done")
        }, 2000);
    });

    return deferred.promise();
}

$.when(listing().done(function() {
    console.log("All done.")
    alert('all done');
}));