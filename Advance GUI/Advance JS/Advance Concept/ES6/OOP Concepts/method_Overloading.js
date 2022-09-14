class AddItems {
    add(a) {
        console.log("add method with one argument is called...");
        return a;

    }

    add(a, b) {
        console.log("add method with two argument is called...");
        return a + b;
    }

    add(a, b, c) {
        console.log("add method with three argument is called...");
        return a + b + c;
    }

    add(...arg) {
        console.log("add method with infinite argument is called...");
        let sum = 0;
        arg.forEach((value) => {
            sum += value;
        })
        return sum;
    }
}


var txt = document.getElementById("txt");
var message = txt.textContent;
message += "creating object of class...<br/>";
const addItems = new AddItems();

message += "calling add method with one argument<br/><br/>";
message += "Addition of 5 and 6 is : " + addItems.add(5, 6) + " <br/><br/>";

message += "Addition of 5, 6 and 7 is : " + addItems.add(5, 6, 7) + " <br/><br/>";

message += "Addition of 5, 6, 7 and 8 is : " + addItems.add(5, 6, 7, 8) + " <br/><br/>";

message += "As You can see in console window only last add method with infinite argument is called everytime thats mean js does not support method overloading."

txt.innerHTML = message;