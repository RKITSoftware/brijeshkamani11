


class Person {

    static #countTotalPerson = 0;
    #firstName;
    #secondName;
    #birthDay;
    constructor(firstName = "", secondName = "") {
        this.#firstName = firstName,
            this.#secondName = secondName;
        ++Person.#countTotalPerson;

    }
    get fullName() {
        return this.#firstName + " " + this.#secondName;
    }


    set birthDate(value) {
        this.#birthDay = new Date(value);
    }

    get birthDate() {
        return this.#birthDay.toDateString();
    }
    get Age() {
        if (this.#birthDay != undefined) {
            return Math.abs(new Date(Date.now() - this.#birthDay.getTime()).getUTCFullYear() - 1970);
        }
        return undefined;
    }

    introducesSelf() {
        return "Hii My name is " + this.fullName + " and My Age is " + this.Age + ".";
    }

    static totalNumberOfObjects() {
        return "Total number of object created is " + Person.#countTotalPerson;
    }



};

export { Person as default};


