const form = document.getElementById('form');
const First_Name = document.getElementById('First_Name');
const Last_Name = document.getElementById('Last_Name');
const Address = document.getElementById('Address');
const Birthdate = document.getElementById('Birthdate');
const Submit = document.getElementById('Submit');
const Update = document.getElementById('update');

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



form.addEventListener('submit', e => {
    e.preventDefault();

    if (validateForm()) {
        save_data();

    }

})



const validateForm = () => {
    const inputText = document.querySelectorAll('input[type=text], textarea');
    inputText.forEach((element) => { if (!checkAndSetErrorForRequiredElement(element)) { return false; } });
    return true;
}

const save_data = () => {
    let data = {

    };
    for (const element of form.elements) {
        if (element.id.length > 0) {
            data[element.id] = element.value;
        }
    }
    localStorage.clear();
    localStorage.setItem("Form-data", JSON.stringify(data));
    alert("Data saved in local storage.");
    form.reset();
};

Update.onclick = () => {
    const savedData = JSON.parse(localStorage.getItem("Form-data"));
    if (savedData != null) {
        for (const element of form.elements) {
            if (element.id in savedData) {
                element.value = savedData[element.id];

            }
        }
    } else {
        alert("There is not any data to display");
    }


};