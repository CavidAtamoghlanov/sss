var connection = new signalR.HubConnectionBuilder()
    .withUrl("http://localhost:27001/chathub").build();

document.getElementById("sendButton").addEventListener("click", function (event) {
    var userName = document.getElementById("usernameInput").value;
    var name = document.getElementById("nameInput").value;
    var surname = document.getElementById("surnameInput").value;

    connection.invoke("AddUserToHub", userName, name, surname).catch(function (err) {
        return console.error(err.toString() + "   Bizim Error");
    });

 
});

connection.start().catch(err => console.error(err.toString() + "   Start Error"));