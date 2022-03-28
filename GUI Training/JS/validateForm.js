const form = document.getElementById('form');
const First_Name = document.getElementById('First_Name');
const Last_Name = document.getElementById('Last_Name');
const Gender = document.querySelectorAll('input[name="Gender"]');
const Mobile = document.getElementById('Mobile');
const Email = document.getElementById('Email');
const Password = document.getElementById('Password');
const ConfirmPassword = document.getElementById('ConfirmPassword');
const Address = document.getElementById('Address');
const Birthdate = document.getElementById('Birthdate');
const City = document.getElementById('City');
const Pincode = document.getElementById('Pincode');
const Course = document.querySelectorAll('input[name="Course"]');
const IAgree = document.getElementById('IAgree');
const Submit = document.getElementById('Submit');

var isValidForm = false;

const setError = (element, message) => {

    const inputControl = element.parentElement.parentElement;
    const errorDisplay = inputControl.querySelector('.error');
    errorDisplay.innerText = message;
    inputControl.classList.add('error');
    inputControl.classList.remove('success')
    isValidForm = false;
    return false;

}

const setSuccess = element => {
    const inputControl = element.parentElement.parentElement;
    const errorDisplay = inputControl.querySelector('.error');

    errorDisplay.innerText = '';
    inputControl.classList.add('success');
    inputControl.classList.remove('error');
    isValidForm = true;
    return true;

};

const isValidEmail = email => {
    const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(String(email).toLowerCase());
}


const isValidPincode = pincode => {
    return !isNaN(pincode) && pincode.length == 6;
}

const checkAndSetErrorForRequiredElement = (element) => {
    const elementValue = element.value;
    if (elementValue === undefined || elementValue.trim() === '') {
        return setError(element, element.placeholder + ' is required');

    } else {
        return setSuccess(element);

    }
};

const checkAndSetErrorForMaxLengthElement = (element, length) => {

    const elementValue = element.value;
    if (elementValue !== undefined && elementValue.length > length) {
        return setError(element, element.placeholder + ' should be less than or equal to' + length);
    } else {
        return setSuccess(element);
    }
};

const checkRequiredAndMax = (element, length) => {
    if (checkAndSetErrorForRequiredElement(element)) {
        return checkAndSetErrorForMaxLengthElement(element, length);
    }
}

const checkAndSetErrorForRadioButtons = (name) => {
    const radioButton = document.querySelector('input[name="' + name + '"]:checked');

    if (radioButton === null) {
        return setError(document.querySelector('input[name="' + name + '"]'), "Please Select " + name + "");
    } else {
        return setSuccess(document.querySelector('input[name="' + name + '"]'));
    }
};



First_Name.addEventListener('focusout', e => checkRequiredAndMax(e.target, 50));
Last_Name.addEventListener('focusout', e => checkRequiredAndMax(e.target, 50));
Gender.forEach((element) => {
    element.addEventListener('click', e => {
        setSuccess(element);
    })
});
Mobile.addEventListener('focusout', e => {
    if (checkRequiredAndMax(e.target, 10)) {
        if (isNaN(e.target.value) || e.target.value.length != 10) {
            setError(e.target, "Enter Valid Mobile Number");
        } else {
            setSuccess(e.target);
        }
    }
});
Email.addEventListener('focusout', e => {
    if (checkRequiredAndMax(e.target, 250)) {
        if (isValidEmail(e.target.value)) {
            setSuccess(e.target);
        } else {
            setError(e.target, "Please Enter Valid Email Address");
        }
    }
});

Password.addEventListener('focusout', e => {
    if (checkRequiredAndMax(e.target, 250)) {
        console.log(ConfirmPassword.value !== e.target.value);
        if (ConfirmPassword.value !== e.target.value) {
            setError(ConfirmPassword, "Password is not matched");
        } else {
            setSuccess(ConfirmPassword);
        }
    }
});
ConfirmPassword.addEventListener('focusout', e => {
    if (checkRequiredAndMax(e.target, 250)) {
        if (Password.value !== e.target.value) {
            setError(e.target, "Password is not matched");
        }
    }
});
Address.addEventListener('focusout', e => {
    checkRequiredAndMax(e.target, 500);
});

Birthdate.addEventListener('focusout', e => {
    if (checkAndSetErrorForRequiredElement(e.target)) {
        console.log(Date(e.target.value) + new Date())
        if (Date.parse(e.target.value) > new Date()) {
            setError.apply(e.target, "Birthdate should not be greater than todays date");
        }
    }

});

Pincode.addEventListener('focusout', e => {
    if (checkRequiredAndMax(e.target, 6)) {
        if (isValidPincode(e.target.value)) {
            setSuccess(e.target);
        } else {
            setError(e.target, "Enter valid pincode");
        }
    }
});
Course.forEach((element) => {
    element.addEventListener('click', e => {
        setSuccess(element);
    })
});
IAgree.addEventListener('click', element => {
    if (!element.target.checked) {
        setError(IAgree, "You Must have to Agree.");
    } else {
        setSuccess(IAgree);
    }
})

form.addEventListener('submit', e => {
    e.preventDefault();
    // console.log(validateForm());
    if (validateForm()) {
        console.log((new FormData(form)));
    }
    console.log(document.querySelector('form'));
})


const validateForm = () => {
    const inputText = document.querySelectorAll('input[type=text], input[type=password], textarea, select');
    inputText.forEach((element) => { if (!checkAndSetErrorForRequiredElement(element)) { return false; } });
    if (!checkAndSetErrorForRadioButtons("Gender")) return false;
    if (!checkAndSetErrorForRadioButtons("Course")) return false;
    if (!IAgree.checked) {
        return setError(IAgree, "You Must have to Agree.");
    } else {
        return setSuccess(IAgree);
    }

}