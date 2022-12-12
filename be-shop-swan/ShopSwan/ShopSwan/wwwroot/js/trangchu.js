$(document).ready(function () {

    $("#btn-register").click(function () {
        Register();
    })
    $("#btn-login").click(function () {
        Login();
    })

    $("#btn-log-out").click(function () {
        LogOut();
    })

    $("#btn-register-cart").click(function () {
        Register1();
    })
    $("#btn-login-cart").click(function () {
        Login1();
    })

    $("#add-to-cart").click(function () {
        toastr["success"]("Đã thêm vào giỏ hàng thành công");
    })

    $(".btn-color").click(function () {
        $(".btn-color").removeClass("active")
        $(this).addClass("active");
    });
    $(".btn-size").click(function () {
        $(".btn-size").removeClass("active")
        $(this).addClass("active");
    });

    $(".input-amount-right").click(function () {
        var x = eval($('#txtAmount').val()) + 1;
        $('#txtAmount').val(x)
    });
    $(".input-amount-left").click(function () {
        var x = eval($('#txtAmount').val()) - 1;
        if (x > 0) {
            $('#txtAmount').val(x);
        }
    });
    $('.btn-pay').click(function () {
        if ($(this).val() == 1) {
            $('#modal-1').addClass('n-d-none');
            $('#modal-2').removeClass('n-d-none');
        } else {
            $('#modal-2').addClass('n-d-none');
            $('#modal-1').removeClass('n-d-none');
        }
    })
    $('#btn-hide-login').click(function () {
        $('#cart-login').addClass("n-d-none");
        $('#cart-register').removeClass("n-d-none");
        $('#btn-dangnhap-cart').removeClass("n-d-none");
    })

    $('#btn-hide-register').click(function () {
        $('#cart-register').addClass("n-d-none");
        $('#cart-login').removeClass("n-d-none");
        $('#btn-dangnhap-cart').addClass("n-d-none");

    })
    function Register() {
        //debugger;

        var submitData = {
            Name: "",
            Phone: "",
            Email: "",
            Password :""
        }
        if (!$('#password').val()
            || !$('#rePassword').val()
            || !$('#name').val()
            || !$('#phone').val()
            || !$('#email').val()
        ) {
            toastr["warning"]("bạn cần nhập đầy đủ thông tin");
            return 0;
        } else if ($('#password').val() != $('#rePassword').val()) {
            toastr["warning"]("mật khẩu khác nhau");
            return 0;
        } else {
            submitData.Name = $('#name').val();
            submitData.Phone = $('#phone').val();
            submitData.Email = $('#email').val();
            submitData.Password = $('#password').val();

            $.ajax({
                url: '/home/Register',
                type: 'post',
                dataType: 'json',
                data: {
                    user: submitData
                },
                success: function (res) {
                    toastr["success"]("Đăng ký thành công");
                    location.href = "/";
                },
                error: function (error) {
                    console.log(error)
                }
            })

        }

       
    }
    function LogOut() {
        $.ajax({
            url: '/home/LogOut',
            type: 'post',
            success: function (res) {
                toastr["success"]("Đăng xuất thành công");
                location.href = "/";
            },
            error: function (error) {
                console.log(error)
            }
        })
    }
    function Register1() {
        //debugger;

        var submitData = {
            Name: "",
            Phone: "",
            Email: "",
            Password: ""
        }
        if (!$('#password1').val()
            || !$('#rePassword').val()
            || !$('#name').val()
            || !$('#phone').val()
            || !$('#email1').val()
        ) {
            toastr["warning"]("bạn cần nhập đầy đủ thông tin");
            return 0;
        } else if ($('#password1').val() != $('#rePassword').val()) {
            toastr["warning"]("mật khẩu khác nhau");
            return 0;
        } else {
            submitData.Name = $('#name').val();
            submitData.Phone = $('#phone').val();
            submitData.Email = $('#email1').val();
            submitData.Password = $('#password1').val();

            $.ajax({
                url: '/home/Register',
                type: 'post',
                dataType: 'json',
                data: {
                    user: submitData
                },
                success: function (res) {
                    toastr["success"]("Đăng ký thành công");
                    location.href = "/home/cart";
                },
                error: function (error) {
                    console.log(error)
                }
            })

        }


    }

    function Login1() {
        var submitData = {
            Email: "",
            Password: ""
        }
        if (!$('#password').val()
            || !$('#email').val()
        ) {
            toastr["warning"]("bạn cần nhập đầy đủ thông tin");
            return 0;
        } else {
            submitData.Email = $('#email').val();
            submitData.Password = $('#password').val();

            $.ajax({
                url: '/home/Login',
                type: 'post',
                dataType: 'json',
                data: {
                    user: submitData
                },
                success: function (res) {
                    console.log(res);
                    if (res) {
                        toastr["success"]("Đăng nhập thành công");
                        location.href = "/home/cart";
                    } else {
                        toastr["warning"]("Đăng nhập thất bại");
                    }

                },
                error: function (error) {
                    console.log(error)
                }
            })

        }

    }


    function LogOut() {
        $.ajax({
            url: '/home/LogOut',
            type: 'post',
            success: function (res) {
                toastr["success"]("Đăng xuất thành công");
                location.href = "/";
            },
            error: function (error) {
                console.log(error)
            }
        })
    }

    function Login() {
        var submitData = {
            Email: "",
            Password: ""
        }
        if (!$('#password').val()
            || !$('#email').val()
        ) {
            toastr["warning"]("bạn cần nhập đầy đủ thông tin");
            return 0;
        }  else {
            submitData.Email = $('#email').val();
            submitData.Password = $('#password').val();

            $.ajax({
                url: '/home/Login',
                type: 'post',
                dataType: 'json',
                data: {
                    user: submitData
                },
                success: function (res) {
                    console.log(res);
                    if (res) {
                        toastr["success"]("Đăng nhập thành công");
                        location.href = "/";
                    } else {
                        toastr["warning"]("Đăng nhập thất bại");
                    }
                    
                },
                error: function (error) {
                    console.log(error)
                }
            })

        }

    }


})