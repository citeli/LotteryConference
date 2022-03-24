function markElementAsSelectedById(id) {        
    var element = document.getElementById(id);
    element.classList.add("number-checked");
}

function removeElementAsSelectedById(id) {    
    var element = document.getElementById(id);
    element.classList.remove("number-checked");
}

function verifyIfElementIsChecked(id) {    
    var element = document.getElementById(id);
    return element.classList.contains("number-checked");
}