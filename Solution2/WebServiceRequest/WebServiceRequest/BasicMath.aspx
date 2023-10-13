<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BasicMath.aspx.cs" Inherits="WebServiceRequest.BasicMath" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <style>
        .container-fluid label {
            background-color: rgba(109, 39, 245, 0.8);
            color: white;
            padding: 4px 8px;
            margin: 0px 10px;
            border-radius: 0.5rem;
            font-size: 19px;
        }

            .container-fluid label:hover {
                cursor: pointer;
                background-color: rgba(83, 43, 160, 0.8);
                font-weight: 600 !important;
            }
        #heading h2{
            display:none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid border bg-success bg-gradient py-2 d-flex justify-content-center rounded">
            <label>Addition</label>
            <label>Subtraction</label>
            <label>Multiplication</label>
            <label>Division</label>
            <label>Square</label>
            <label>Cube</label>
        </div>
        <div class="container mt-5 p-5 border border-dark border-4 rounded">
            <div class="row">
                <div id="heading" class="col-12 text-center mb-4">
                    <h2>Adding Two Numbers</h2>
                    <h2>Subtracting Two Numbers</h2>
                    <h2>Multiplying Two Numbers</h2>
                    <h2>Dividing Two Numbers</h2>
                    <h2>Square of a Number</h2>
                    <h2>Cube of a Number</h2>
                </div>
            </div>

            <div id="fields" class="row justify-content-center mb-4">
                <div class="col-4">
                    <div id="errorMess" class="col-12 bg-danger text-white bg-gradient text-center py-1 d-none">
                    </div>
                    <asp:Label Text="Enter First Number" CssClass="h5" runat="server"></asp:Label>
                    <asp:TextBox ID="firstNumberTxt" CssClass="form-control mb-3" runat="server"></asp:TextBox>
                    <div id="number2">
                        <asp:Label Text="Enter Second Number" CssClass="h5" runat="server"></asp:Label>
                        <asp:TextBox ID="secondNumberTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row justify-content-center">
                <div class="col-4 d-flex">
                    <div class="col-7">
                        <asp:TextBox ID="answerTxt" CssClass="form-control col-5" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                    <div class="col-5">
                        <asp:HiddenField ID="hiddenTxt" runat="server" />
                        <asp:Button ID="SubmitBtn" CssClass="btn btn-success float-end fw-bold" OnClientClick="return Validation()" OnClick="SubmitBtn_Click" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js"></script>
    <script>
    //const { cookies } = require("modernizr");

        function Validation() {
            var num1 = parseFloat($("#firstNumberTxt").val());
            var num2 = parseFloat($("#secondNumberTxt").val());
            var btnTxt = $("#SubmitBtn").val();
            $("#hiddenTxt").val(btnTxt);
            $("#answerTxt").val("");
            if ($("#SubmitBtn").val() == "Square" || $("#SubmitBtn").val() == "Cube") {
                if ($("#firstNumberTxt").val() == '') {
                    $("#errorMess").removeClass("d-none");
                    $("#errorMess").text("Enter Valid Numbers");
                    return false;
                }
                else if (isNaN(num1)) {
                    $("#errorMess").removeClass("d-none");
                    $("#errorMess").text("Fields Cannot Be Empty");
                    return false;
                }
                else {
                    $("#errorMess").addClass("d-none");
                    $("#errorMess").text("");
                    return true;
                }
            }
            else {
                if ($("#firstNumberTxt").val() == '' || $("#secondNumberTxt").val() == '') {
                    $("#errorMess").removeClass("d-none");
                    $("#errorMess").text("Enter Valid Numbers");
                    return false;
                }
                else if (isNaN(num1) || isNaN(num2)) {
                    $("#errorMess").removeClass("d-none");
                    $("#errorMess").text("Fields Cannot Be Empty");
                    return false;
                }
                else {
                    if (btnTxt == "Divide" && num2 == 0) {
                        $("#errorMess").removeClass("d-none");
                        $("#errorMess").text("Second Number Cannot Be Zero");
                        return false;
                    }
                    else {
                        $("#errorMess").addClass("d-none");
                        $("#errorMess").text("");
                        return true;
                    }
                    
                }
            }
            
        }
        function setCookie(cname, cvalue) {
            const d = new Date();
            d.setTime(d.getTime() + (1 * 24 * 60 * 60 * 1000));
            let expires = "expires=" + d.toUTCString();
            document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
        }

        function getCookie(cname) {
            let name = cname + "=";
            let decodedCookie = decodeURIComponent(document.cookie);
            let ca = decodedCookie.split(';');
            for (let i = 0; i < ca.length; i++) {
                let c = ca[i];
                while (c.charAt(0) == ' ') {
                    c = c.substring(1);
                }
                if (c.indexOf(name) == 0) {
                    return c.substring(name.length, c.length);
                }
            }
            return "";
        }
        function NavClick(nav) {
            debugger;
            $("#heading").find("h2").hide();
            //$("#answerTxt").val("");
            //$("#firstNumberTxt").val("");
            //$("#secondNumberTxt").val("");
            //var nav = $(this).text();
            setCookie("selectedNav", nav);
            if (nav == "Addition") {
                $("#SubmitBtn").val("Add");
                $("#heading").find("h2:first").show();
                $("#number2").removeClass("d-none");
            }
            else if (nav == "Subtraction") {
                $("#SubmitBtn").val("Subtract");
                $("#heading").find("h2:nth-child(2)").show();
                $("#number2").removeClass("d-none");
            }
            else if (nav == "Multiplication") {
                $("#SubmitBtn").val("Multiply");
                $("#heading").find("h2:nth-child(3)").show();
                $("#number2").removeClass("d-none");
            }
            else if (nav == "Division") {
                $("#SubmitBtn").val("Divide");
                $("#heading").find("h2:nth-child(4)").show();
                $("#number2").removeClass("d-none");
            }
            else if (nav == "Square") {
                $("#SubmitBtn").val("Square");
                $("#heading").find("h2:nth-child(5)").show();
                $("#number2").addClass("d-none");
            }
            if (nav == "Cube") {
                $("#SubmitBtn").val("Cube");
                $("#heading").find("h2:last").show();
                $("#number2").addClass("d-none");
            }
        }

        $(function () {
            var selectNav = getCookie("selectedNav");
            if (selectNav != null) {
                NavClick(selectNav);
            }
            else {
                $("#heading").find("h2:first").show();
                $("#SubmitBtn").val("Add");
            }
            
            $(".container-fluid").find("label").click(function () {
                debugger;
                $("#answerTxt").val("");
                $("#firstNumberTxt").val("");
                $("#secondNumberTxt").val("");
                NavClick($(this).text());
            });
        });
    </script>
</body>
</html>
