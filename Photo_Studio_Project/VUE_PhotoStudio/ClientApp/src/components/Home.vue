<template>
    <div>

        <h1>Inicio</h1>

        <div>
            <h3> Sobre nosotros</h3>
            <p class="texto">
                AVJ Photo Studio es una plataforma web en la que los usuarios podrán
                realizar reservaciones de sesiones fotográficas, visualización de catálogos y
                precios, informaciones sobre el negocio, contactos y términos y condiciones
                del mismo.
            </p>
        </div>


        <!--<div id="carruselHome" class="carousel slide">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img01.jpg" />
                </div>
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img02.jpg" />
                </div>
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img03.jpg" />
                </div>
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img04.jpg" />
                </div>
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img05.jpg" />
                </div>
                <div class="carousel-item active">
                    <img src="../assets/Portafolio/img06.jpg" />
                </div>
            </div>
        </div>-->

        <ul>
            <li><a href="https://github.com/vuejs/vue-cli/tree/dev/packages/%40vue/cli-plugin-babel" target="_blank" rel="noopener"></a></li>
            <li><a href="https://github.com/vuejs/vue-cli/tree/dev/packages/%40vue/cli-plugin-eslint" target="_blank" rel="noopener"></a></li>
        </ul>
        <ul>
            <li><a href="https://vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://forum.vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://chat.vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://twitter.com/vuejs" target="_blank" rel="noopener"></a></li>
            <li><a href="https://news.vuejs.org" target="_blank" rel="noopener"></a></li>
        </ul>
        <ul>
            <li><a href="https://router.vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://vuex.vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://github.com/vuejs/vue-devtools#vue-devtools" target="_blank" rel="noopener"></a></li>
            <li><a href="https://vue-loader.vuejs.org" target="_blank" rel="noopener"></a></li>
            <li><a href="https://github.com/vuejs/awesome-vue" target="_blank" rel="noopener"></a></li>
        </ul>

    </div>

</template>

<script>
    export default {
        name: 'Home',
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    h3 {
        margin: 40px 0 0;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }
    .img {
        height: 500px;
        width: 400px;
        image-rendering: auto;
    }
    texto {
        margin-top: 10px;
        color: #ffd43a;
        overflow-wrap: break-word;
        font-size: 50px;
        text-align: left;
        white-space: pre-wrap;
        word-spacing: 2px;
    }

</style>
