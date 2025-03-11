window.showToaster = function (type, message)
{
    if (type == "success")
    {
        toastr.success(message)
    }
    if (type == "error")
    {
        toastr.error(message)
    }
};

window.showSweetAlert = function()
{
    Swal.fire({
        title: "Good job!",
        text: "You clicked the button!",
        icon: "success"
    });
};