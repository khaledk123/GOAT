document.onreadystatechange = function () {
    if (document.readyState === "complete") {
        // Remove the preloader when the page is fully loaded
        document.getElementById("preloader").style.display = "none";
    }
};

function ShowToast() {
    $("#liveToast").toast('show');
}