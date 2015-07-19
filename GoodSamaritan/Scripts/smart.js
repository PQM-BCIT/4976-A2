$(document).ready(function () {
    if (document.getElementById("ProgramId") == 3) {
        showSmart();
    }
    else {
        hideSmart();
    }

    $('#ProgramId').change(function () {
        if (this.value == 3) {
            showSmart();
        }
        else {
            hideSmart();
        }
    });
});

function showSmart() {
    document.getElementById("smart-group").style.display = "inline";
}

function hideSmart() {
    document.getElementById("smart-group").style.display = "none";
};
