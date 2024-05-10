function SearchProduct() {
    var input = $("#searchInput").val();
    var url = "https://localhost:44308/Products/Search/" + input;

    $.get(url, function (response) {
        if (response !== null) {
            try {
                console.log(response)
                var parsedData = response;
                var imagePath = "/Data/Products/" + parsedData.ImagePath;
                $("#prodID").val(parsedData.Id);
                $("#prodName").val(parsedData.Name);
                $("#prodDes").val(parsedData.Description);
                $("#prodPrice").val(parsedData.Price);
                $("#prodSize").val(parsedData.Size);
                $("#prodColors").val(parsedData.Colors);
                $("#prodStock").val(parsedData.Stock);
                $("#prodImg").attr("src", imagePath);
                $("#prodImgPath").attr("value", parsedData.ImagePath)
                $("#main").removeClass("d-none");
            } catch (error) {
                console.error('Error parsing JSON:', error);
            }
        }
    });
}


function ShowToast() {
    $("#liveToast").toast('show');
    $("#main").addClass("d-none");
}