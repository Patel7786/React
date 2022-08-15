function enrollStudents() {
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var website = document.getElementById("website").value;
    var image = document.getElementById("image").value;

    var letters = /^[A-Za-z]+$/;
    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

    if (name == '') {
        alert('Please enter your name');
    } else if (!letters.test(name)) {
        alert('Name field required only alphabet characters');
    } else if (email == '') {
        alert('Please enter your user email id');
    } else if (!filter.test(email)) {
        alert('Invalid email');
    } else if (website == '') {
        alert('Please enter website');
    } else if (image == '') {
        alert('Please enter image link');
    } else {

        var gender = document.querySelector('input[name="gender"]:checked').value;
        var checkboxes = document.getElementsByName('skills');
        var skills = "";
        for (var i = 0, n = checkboxes.length; i < n; i++) {
            if (checkboxes[i].checked) {
                skills += "," + checkboxes[i].value;
            }
        }
        if (skills)
            skills = skills.substring(1);

        var table = document.getElementById("studentDetails");
        var row = table.insertRow(-1);
        var description = row.insertCell(-1);
        var images = row.insertCell(1);
        description.innerHTML = name + "</br>" + gender + "</br>" + email + "</br>" + '<a href="' + website + '" target="_blank">' + website + '</a>' + "</br>" + skills;

        images.innerHTML = "<img src='" + image + "' style='height: 200px;width: 70%'>";
    }


}