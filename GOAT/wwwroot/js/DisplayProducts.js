
$(document).ready(function () {
    $('#table').DataTable();
});


$('#modal').on('shown.bs.modal', function () {
    $('#viewBtn').trigger('focus')
})

function viewBtnClicked(element) {
    var cat = element.dataset.cat;
    var stock = element.dataset.stock;
    var colors = element.dataset.colors;
    var desc = element.dataset.desc;

    document.getElementById('catSpan').innerText = cat;
    document.getElementById('stockSpan').innerText = stock;
    document.getElementById('colorsSpan').innerText = colors;
    document.getElementById('desSpan').innerText = desc;
}