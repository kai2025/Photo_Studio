
<template>
    <header class="no-repeat content-box;  background-size: cover ">
        <nav class="navbar-expand-lg navbar-light bg-light justify-content-md-center" style="margin-top:0%;">
            <div class="container-fluid">
                <div class="collapse navbar-collapse justify-content-md-center" id="navbarNav" style="color:rgb(41, 14, 14);">
                    <ul class="navbar-nav" style="margin-right:20%">
                        <b-navbar-item style="margin-right:20%">
                            <router-link class="nav-link " tag="router-link" to="/Home">Inicio</router-link>
                        </b-navbar-item>
                        <b-navbar-item style="margin-right:20%">
                            <router-link class="nav-link" tag="router-link" to="/Portafolio">Portafolio</router-link>
                        </b-navbar-item>
                        <b-navbar-item style="margin-right:20%" >
                            <router-link class="nav-link" tag="router-link" to="/Reservas">Reservas</router-link>
                        </b-navbar-item>
                        <b-navbar-item style="margin-right:20%">
                            <router-link class="nav-link" tag="router-link" to="/Rastreo">Rastreo</router-link>
                        </b-navbar-item>
                        <b-navbar-item style="margin-right:20%">
                            <router-link class="nav-link" tag="router-link" to="/Contacto">Contacto</router-link>
                        </b-navbar-item>
                        <b-navbar-item style="margin-right:20%">
                            <router-link class="nav-link" tag="router-link" to="/Admin">Admin</router-link>
                        </b-navbar-item>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
</template>

<script>
    export default {
        name: "NavMenu",
        data() {
            return {
                isExpanded: false
            }
        },
        methods: {
            collapse() {
                this.isExpanded = false;
            },

            toggle() {
                this.isExpanded = !this.isExpanded;
            }
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
    a.navbar-brand {
        white-space: normal;
        text-align: center;
        word-break: break-all;
    }

    html {
        font-size: 14px;
    }

    @media (min-width: 768px) {
        html {
            font-size: 16px;
        }
    }

    .box-shadow {
        box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
    }

</style>
