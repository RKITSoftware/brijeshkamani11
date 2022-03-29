jQuery.validator.addMethod("noSpace", function(value, element) {
    return value == '' || value.trim().length != 0;
}, "No space please and don't leave it empty");
jQuery.validator.addMethod("customEmail", function(value, element) {
    return this.optional(element) || /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/.test(value);
}, "Please enter valid email address!");
$.validator.addMethod("alphanumeric", function(value, element) {
    return this.optional(element) || /^\w+$/i.test(value);
}, "Only Alphabets, Numbers and Undercore Allowed");
var $stdform = $('#stdform');
if ($stdform.length) {
    $stdform.validate({
        rules: {
            //username is the name of the textbox
            username: {
                required: true,
                //alphanumeric is the custom method, we defined in the above
                alphanumeric: true,
                maxlength: 50
            },
            email: {
                required: true,
                customEmail: true,
                maxlength: 250
            },
            password: {
                required: true,
                maxlength: 250
            },
            confirm: {
                required: true,
                equalTo: '#password'
            },
            fname: {
                required: true,
                noSpace: true,
                maxlength: 50
            },
            lname: {
                required: true,
                noSpace: true,
                maxlength: 50
            },
            gender: {
                required: true
            },
            hobbies: {
                required: true
            },
            country: {
                required: true
            },
            address: {
                required: true,
                maxlength: 500
            }
        },
        messages: {
            username: {
                //error message for the required field
                required: 'Please enter username!',
                maxlength: "Only 50 characters allowed in username"
            },
            email: {
                required: 'Please enter email!',
                //error message for the email field
                email: 'Please enter valid email!',
                maxlength: "Only 250 characters allowed in email address"
            },
            password: {
                required: 'Please enter password!',
                maxlength: "Only 250 characters allowed in password"
            },
            confirm: {
                required: 'Please enter confirm password!',
                equalTo: 'Please enter same password!'
            },
            fname: {
                required: 'Please enter first name!',
                maxlength: "Only 50 characters allowed in First Name"
            },
            lname: {
                required: 'Please enter last name!',
                maxlength: "Only 50 characters allowed in Last name"
            },
            country: {
                required: 'Please select country!'
            },
            address: {
                required: 'Please enter address!',
                maxlength: "Only 500 characters allowed in address"
            }
        },
        errorPlacement: function(error, element) {
            if (element.is(":radio")) {
                error.insertAfter($('#radioError'));
            } else if (element.is(":checkbox")) {
                error.insertAfter($('#checkboxError'));
            } else {
                error.insertAfter(element);
            }

        }
    });

    function convertFormToJSON(form) {
        return $(form)
            .serializeArray()
            .reduce(function(json, { name, value }) {
                json[name] = value;
                return json;
            }, {});
    }

    $("#stdform").on("submit", function(e) {
        e.preventDefault();
        const form = $("#stdform");
        if (form.valid()) {
            const json = JSON.stringify(convertFormToJSON(form));
            alert(json);
            // $("#formData").text(json);
        }

    });
};