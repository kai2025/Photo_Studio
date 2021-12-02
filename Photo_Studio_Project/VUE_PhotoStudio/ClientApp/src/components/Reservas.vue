<template>
    <div>
        <h4 style="margin-top:2%; color:black"> Reserva tu sesión de fotos</h4>

        <div>
            <div class="row">
                <div class="col-half">
                    <img src="../../src/assets/stuido_reservas.jpg" style="width: 500px; height: 600px; margin-top: 5%;" />
                </div>
                <div class="col-half">
                    <div class="container" style="margin-top:2%; margin-left:-30px;">
                        <form>
                            <div class="row">
                                <h4>Información</h4>
                                <div class="input-group input-group-icon">
                                    <input type="text" placeholder="Full Name">
                                    <div class="input-icon"><i class="fa fa-user"></i></div>
                                </div>
                                <div class="input-group input-group-icon">
                                    <input type="email" placeholder="Email Adress">
                                    <div class="input-icon"><i class="fa fa-envelope"></i></div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-half">
                                    <h4>Fecha de la reserva</h4>
                                    <div class="input-group">
                                        <div class="col-third">
                                            <input type="text" placeholder="DD">
                                        </div>
                                        <div class="col-third">
                                            <input type="text" placeholder="MM">
                                        </div>
                                        <div class="col-third">
                                            <input type="text" placeholder="YYYY">
                                        </div>
                                    </div>
                                </div>
                                <div class="col-half">
                                    <h4>Pago</h4>
                                    <div class="input-group">
                                        <input id="pago-efectivo" type="radio" name="pago" value="efectivo" checked="checked">
                                        <label for="pago-efectivo">Efectivo</label>
                                        <input id="pago-tarjeta" type="radio" name="pago" value="tarjeta">
                                        <label for="pago-tarjeta">Tarjeta</label>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <h4>Sesión fotográfica</h4>
                                <div class="input-group">
                                    <select>
                                        <option> Bebés</option>
                                        <option> Boda</option>
                                        <option> Cumpleaños</option>
                                    </select>
                                </div>
                            </div>

                            <div class="row">
                                <h4>Terms and Conditions</h4>
                                <div class="input-group">
                                    <input id="terms" type="checkbox">
                                    <label for="terms" style="font-size:12px; text-align:left">I accept the terms and conditions for signing up to this service, and hereby confirm I have read the privacy policy.</label>
                                </div>
                            </div>

                            <button class=" button select ">
                                Reservar
                            </button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>













</template>
<script>
    export default {
        name: "HelloWorld",
        props: {
            msg: String,
        },
    };
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    form-box {
        border: 10px solid #191919;
    }

    dropdown-form {
        text-align: left;
    }

    .input {
        padding: 4px;
        font-size: 21px;
        border-width: 0px;
        border-color: #ffffff;
        background-color: #f3f3f3;
        color: #3c0000;
        border-style: solid;
        border-radius: 3px;
    }

    .button {
        color: black;
        background-color: #f0a500;
        border-radius: 5px;
        font-size: 18px;
        padding: 10px 20px 10px 20px;
        border: 1px solid #f0a500;
    }

    big-text {
        color: #131313;
        text-align: left;
        font-size: 23px;
    }

    /* 64ac15 */
    *,
    *:before,
    *:after {
        box-sizing: border-box;
    }

    body {
        padding: 1em;
        font-size: 15px;
        color: #b9b9b9;
        background-color: #e3e3e3;
    }

    h4 {
        color: #f0a500;
    }

    input,
    input[type="radio"] + label,
    input[type="checkbox"] + label:before,
    select option,
    select {
        width: 100%;
        padding: 1em;
        line-height: 1.4;
        background-color: #f9f9f9;
        border: 1px solid #e5e5e5;
        border-radius: 3px;
        -webkit-transition: 0.35s ease-in-out;
        -moz-transition: 0.35s ease-in-out;
        -o-transition: 0.35s ease-in-out;
        transition: 0.35s ease-in-out;
        transition: all 0.35s ease-in-out;
    }

        input:focus {
            outline: 0;
            border-color: #bd8200;
        }

            input:focus + .input-icon i {
                color: #f0a500;
            }

            input:focus + .input-icon:after {
                border-right-color: #f0a500;
            }

        input[type="radio"] {
            display: none;
        }

            input[type="radio"] + label,
            select {
                display: inline-block;
                width: 50%;
                text-align: center;
                float: left;
                border-radius: 0;
            }

                input[type="radio"] + label:first-of-type {
                    border-top-left-radius: 3px;
                    border-bottom-left-radius: 3px;
                }

                input[type="radio"] + label:last-of-type {
                    border-top-right-radius: 3px;
                    border-bottom-right-radius: 3px;
                }

                input[type="radio"] + label i {
                    padding-right: 0.4em;
                }

                input[type="radio"]:checked + label,
                input:checked + label:before,
                select:focus,
                select:active {
                    background-color: #f0a500;
                    color: #fff;
                    border-color: #bd8200;
                }

        input[type="checkbox"] {
            display: none;
        }

            input[type="checkbox"] + label {
                position: relative;
                display: block;
                padding-left: 1.6em;
            }

                input[type="checkbox"] + label:before {
                    position: absolute;
                    top: 0.2em;
                    left: 0;
                    display: block;
                    width: 1em;
                    height: 1em;
                    padding: 0;
                    content: "";
                }

                input[type="checkbox"] + label:after {
                    position: absolute;
                    top: 0.45em;
                    left: 0.2em;
                    font-size: 0.8em;
                    color: #fff;
                    opacity: 0;
                    font-family: FontAwesome;
                    content: "\f00c";
                }

        input:checked + label:after {
            opacity: 1;
        }

    select {
        height: 3.4em;
        line-height: 2;
    }

        select:first-of-type {
            border-top-left-radius: 3px;
            border-bottom-left-radius: 3px;
        }

        select:last-of-type {
            border-top-right-radius: 3px;
            border-bottom-right-radius: 3px;
        }

        select:focus,
        select:active {
            outline: 0;
        }

        select option {
            background-color: #f0a500;
            color: #fff;
        }

    .input-group {
        margin-bottom: 1em;
        zoom: 1;
    }

        .input-group:before,
        .input-group:after {
            content: "";
            display: table;
        }

        .input-group:after {
            clear: both;
        }

    .input-group-icon {
        position: relative;
    }

        .input-group-icon input {
            padding-left: 4.4em;
        }

        .input-group-icon .input-icon {
            position: absolute;
            top: 0;
            left: 0;
            width: 3.4em;
            height: 3.4em;
            line-height: 3.4em;
            text-align: center;
            pointer-events: none;
        }

            .input-group-icon .input-icon:after {
                position: absolute;
                top: 0.6em;
                bottom: 0.6em;
                left: 3.4em;
                display: block;
                border-right: 1px solid #e5e5e5;
                content: "";
                -webkit-transition: 0.35s ease-in-out;
                -moz-transition: 0.35s ease-in-out;
                -o-transition: 0.35s ease-in-out;
                transition: 0.35s ease-in-out;
                transition: all 0.35s ease-in-out;
            }

            .input-group-icon .input-icon i {
                -webkit-transition: 0.35s ease-in-out;
                -moz-transition: 0.35s ease-in-out;
                -o-transition: 0.35s ease-in-out;
                transition: 0.35s ease-in-out;
                transition: all 0.35s ease-in-out;
            }

    .container {
        max-width: 38em;
        padding: 1em 3em 2em 3em;
        margin: 0em auto;
        background-color: #fff;
        border-radius: 4.2px;
        box-shadow: 0px 3px 10px -2px rgba(0, 0, 0, 0.2);
    }

    .row {
        zoom: 1;
    }

        .row:before,
        .row:after {
            content: "";
            display: table;
        }

        .row:after {
            clear: both;
        }

    .col-half {
        padding-right: 10px;
        float: left;
        width: 50%;
    }

        .col-half:last-of-type {
            padding-right: 0;
        }

    .col-third {
        padding-right: 10px;
        float: left;
        width: 33.33333333%;
    }

        .col-third:last-of-type {
            padding-right: 0;
        }

    @media only screen and (max-width: 540px) {
        .col-half {
            width: 100%;
            padding-right: 0;
        }
    }

</style>