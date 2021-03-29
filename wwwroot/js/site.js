// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Scroll bar
var progress = document.getElementById('scroll');
var totalHeight = document.body.offsetHeight;

window.onscroll = function(){
    var winScroll = document.body.scrollTop || document.documentElement.scrollTop;
    var height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
    var scrolled = (winScroll / height) * 100;
    progress.style.height = scrolled + "%";
};

// Human-readable Date and Time for Case.cshtml to convert epoch to datetime, by saving the value as a Date type instead of long and converting to a string with built-in js methods
function convertEpoch(postDate)
{
    result = new Date(postDate);
    return result.toLocaleString();
};

// Time Elapsed function for Active.cshtml to see when a case was posted
function timeElapsed(postDate) {
    var seconds = Math.floor((Date.now() - postDate) / 1000); // div 1000 to go from ms to s for epoch
    var intervalType;

    var interval = Math.floor(seconds / 31536000); // 31536000 is the number of seconds in a year
    if (interval >= 1) { //if our interval is greater than 1 it means that there are more seconds than one year, so we round down to the nearest year.
        intervalType = 'year';
    } else {
        interval = Math.floor(seconds / 2592000); // seconds per 30-day month 
        if (interval >= 1) { //if our interval is greater than 1 it means that there are more seconds than one month, so we round down to the nearest month... etc.
            intervalType = 'month';
        } else {
            interval = Math.floor(seconds / 86400); // seconds per day
            if (interval >= 1) {
                intervalType = 'day';
            } else {
                interval = Math.floor(seconds / 3600); // seconds per hour
                if (interval >= 1) {
                    intervalType = "hour";
                } else {
                    interval = Math.floor(seconds / 60); // seconds per minute
                    if (interval >= 1) {
                        intervalType = "minute";
                    } else {
                        interval = seconds; // if we haven't been less than 1 for our interval, it means that our date is less than 1 minute from now. We use the seconds value.
                        intervalType = "second";
                    }
                }
            }
        }
    }

    if (interval > 1 || interval === 0) { // if our interval is more than 1 (eg 2 years), or it's 0, we add the "s" at the end of "year"
        intervalType += 's';
    }
    
    return interval + ' ' + intervalType;
};


// Hover effects on homepage buttons (the text specifically). Replaces CSS implementation for text color change.
function hoverText(buttonID) {
    var y = document.getElementById(buttonID);
    y.style.color = '#ffffff';
    y.style.backgroundColor = '#4D4D4C';
};

function unhoverText(buttonID) {
    var x = document.getElementById(buttonID);
    x.style.color = 'black';
    x.style.backgroundColor = 'white';
};


// input validation for Submit.cshtml and _Layout.cshtml
function bountyIsValid(bounty) {
    return /^\d*\.?\d*$/.test(bounty); //regex check for numeric bounty values
};

function nameIsValid(name) {
    return /^[a-zA-Z ]*$/.test(name); //regex check for alphabet-only name
};

function emailIsValid(email) { //regex check for email-allowable characters
    return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
};

function validateCaseSubmission() {
    var company = document.getElementById("company");
    var title = document.getElementById("title");
    var bounty = document.getElementById("bounty");
    var description = document.getElementById("description");
    if (company.value === "") {
        alert("Please enter your company name.");
        company.focus();
    } else if (title.value === "") {
        alert("Please enter a title for your problem.");
        title.focus();
    } else if (title.value.length > 150) {
        alert("Please enter a more concise title");
        bProblem.focus();
    } else if (!bountyIsValid(bounty.value) || bounty.value === "") {
        alert("Please enter a valid bounty (Positive number)");
        bounty.focus();
    } else if (description.value === "") {
        alert("Please enter a description to your problem.");
        description.focus();
    } else {
        return true; //only goes to the next page/submits if no errors on page
    }
    return false;
};

function validateResponseSubmission() { // required to prevent null value from being passed to c# append response service
    var content = document.getElementById("response_content")
    if (content.value ==="") {
        alert("Please enter a response");
        content.focus();
        return false
    }
    return true
};

function validateContactForm() {
    var emailContact = document.getElementById("emailContact");
    var message = document.getElementById("messageContact");
    if (emailContact.value === "") {
        alert("Please enter your email address.");
        emailContact.focus();
    } else if (message.value === "") {
        alert("Please enter a message");
        message.focus();
    } else if (!emailIsValid(emailContact.value)) {
        alert("Please enter a valid email address.");
        emailContact.focus();
    } else {
        return true; //only goes to the next page/submits if no errors on page
    }
    return false;
};

function validateSignUp() {
    var emailSignUp = document.getElementById("emailSignUp");
    var name = document.getElementById("nameSignUp");
    var location = document.getElementById("locationSignUp");
    var phone = document.getElementById("phoneSignUp");
    var picture = document.getElementById("pictureSignUp");
    var company = document.getElementById("companySignUp");
    var password = document.getElementById("phoneSignUp");

    if (emailSignUp.value === "") {
        alert("Please enter your email address.");
        emailSignUp.focus();
    } else if (name.value === "") {
        alert("Please enter your name");
        name.focus();
    } else if (location.value === "") {
        alert("Please enter your location");
        location.focus();
    } else if (phone.value === "") {
        alert("Please enter your phone number");
        phone.focus();
    } else if (!emailIsValid(emailSignUp.value)) {
        alert("Please enter a valid email address.");
        emailSignUp.focus();
    } else if (company.value === "") {
        alert("Please enter your company name");
        company.focus();
    } else if (password.value === "") {
        alert("Please enter a password");
        password.focus();
    } else {
        return true; //only goes to the next page/submits if no errors on page
    }
    return false;
};

function validateLogIn() {
    const emailLogIn = document.getElementById("emailLogIn");
    const password = document.getElementById("passwordLogIn");
    if (emailLogIn.value === "") {
        alert("Please enter your email address.");
        emailLogIn.focus();
    } else if (password.value === "") {
        alert("Please enter your password");
        password.focus();
    } else if (!emailIsValid(emailLogIn.value)) {
        alert("Please enter a valid email address.");
        emailLogIn.focus();
    } else {
        return true; //only goes to the next page/submits if no errors on page
    }
    return false;
};

//below functions show/hide log in or signup sections depending on which which button is clicked on the page
function toSignUp() {
    var logInDiv = document.getElementById("logInDiv");
    var signUpDiv = document.getElementById("signUpDiv");
    logInDiv.style.display = "none";
    signUpDiv.style.display = "block";
};

function toLogIn() {
    var logInDiv = document.getElementById("logInDiv");
    var signUpDiv = document.getElementById("signUpDiv");
    logInDiv.style.display = "block";
    signUpDiv.style.display = "none";
};