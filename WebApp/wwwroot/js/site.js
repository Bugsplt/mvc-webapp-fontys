// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showCustomerDetails(json){
    let customer = JSON.parse(json)
    $("#customerdetails").text("\r\n\r\n\r\n\r\n\r\n" + customer.name + "\r\nEmail: " + customer.email + "\r\nPhone: " + customer.phone + "\r\nId: " + customer.id)
}

function openCustomer(json){
    let customer = JSON.parse(json)
    window.location.href = "/Home/CustomerView/" + customer.id
}

function deleteCustomer(id){
    window.location.href = "/Home/DeleteCustomer/" + id
}


