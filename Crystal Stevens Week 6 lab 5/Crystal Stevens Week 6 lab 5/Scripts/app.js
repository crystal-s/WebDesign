function getInfo() {

    alert("Getting the info from the page");

    var First = document.getElementById("First").value;
    var Last = document.getElementById("Last").value;
    var Age = document.getElementById("Age").value;

    var summary = First + " " + Last + " is " + Age + " years old.";

    document.getElementById("summary").innerText = summary;

    return false;
}