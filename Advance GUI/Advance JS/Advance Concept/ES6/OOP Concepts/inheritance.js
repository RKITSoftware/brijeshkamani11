import Person from "./Person.js";


class Student extends Person {
    constructor(firstname, lastname, department, semster) {
        super(firstname, lastname);
        this.department = department;
        this.semster = semster;
    }

    introducesSelf() {
        return "Hii I am Student. My name is " + this.fullName + " and My Age is " + this.Age + "and I belong to " + this.department + ".";
    }

    callbaseIntro() {
        return super.introducesSelf();
    }
}



let txt = document.getElementById("txt");
let message = txt.innerHTML;

message += "creating new object of Student<br /><br />"
const student = new Student("Brijesh", "Kamani");

message += "Accessing private member.<br />";
message += student.firstName + "<br /><br />";

message += "getting full name of student using getter and parent property.<br />";
message += student.fullName + "<br /><br />";

message += "Adding Birthdate using setter of parent class.<br />";
student.birthDate = '2001-03-30';

message += "Printing birthdate.<br />";
message += student.birthDate + "<br /><br />";

message += "getting age from Birthdate using getter of parent class.<br />";
message += student.Age + "<br /><br />";

message += "calling override method using object : " + student.introducesSelf() + "<br /><br />";

message += "calling base class intro method : " + student.callbaseIntro() + "<br /><br />";


txt.innerHTML = message;