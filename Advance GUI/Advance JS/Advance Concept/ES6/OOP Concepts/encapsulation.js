import Person from "./Person.js";

let txt = document.getElementById("txt");
let message = txt.innerHTML;

message += "creating new object of Person class<br/><br/>"
const person = new Person("Brijesh", "Kamani");

message += "Accessing private member.<br/>";
message += person.firstName + "<br/><br/>";

message += "getting full name of person using getter.<br/>";
message += person.fullName + "<br/><br/>";

message += "Adding Birthdate using setter.<br/>";
person.birthDate = '2001-03-30';

message += "Printing birthdate.<br/>";
message += person.birthDate + "<br/><br/>";

message += "getting age from Birthdate using getter.<br/>";
message += person.Age + "<br/><br/>";

message += "calling method using object : " + person.introducesSelf() + "<br/><br/>";

let person1 = new Person();
let person2 = new Person();
message += "Extra two object created.<br/><br/>"

message += "accessing private Static field Count total number of object: " + Person.countTotalPerson + "<br/>";
message += "accessing private static Field using public Static method : " + Person.totalNumberOfObjects() + " <br/>"

txt.innerHTML = message;