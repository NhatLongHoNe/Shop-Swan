﻿$(document).ready(function () {

    $("#btn-register").click(function () {
        Register();
    })
    $("#btn-login").click(function () {
        Login();
    })

    $("#btn-log-out").click(function () {
        LogOut();
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