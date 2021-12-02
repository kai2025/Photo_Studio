<template>
    <div class="container" style="position: static;">

        <div>
            <h3 style="text-align: left; ; color: #440B0B; font-weight: bold; "> Sobre nosotros</h3>
            <p class="texto" style="text-align: left; margin-top: 1%; width: 1400px;">
                AVJ Photo Studio es una plataforma web en la que los usuarios podran
                realizar reservaciones de sesiones fotograficas, visualizacion de catalogos y
                precios, informaciones sobre el negocio, contactos y terminos y condiciones
                del mismo.
            </p>
        </div>

        <div>
            <div class="img" style="margin-top: 4%;">
                <vueper-slides ref="myVueperSlides"
                               style=" height: auto; width: auto; image-rendering:auto"
                               autoplay>

                    <vueper-slide v-for="(slide, i) in slides"
                                  :key="i"
                                  :image="slide.image" />
                </vueper-slides>
            </div>
            <button class="btn" href="Portafolio.vue">Ver mas</button>
        </div>






    </div>

</template>

<script>
    import { VueperSlides, VueperSlide } from 'vueperslides'
   // import 'vueperslides/dist/vueperslides.css'

    export default {
        name: 'Home',
        components: { VueperSlides, VueperSlide },
       data: () => ({

            slides: [
                {          
                    image: require("@/assets/Portafolio/img04.jpg")
                },
                {
                    image: require("@/assets/Portafolio/img02.jpg")
                },
                {
                    image: require("@/assets/Portafolio/img03.jpg")
               },
               {
                   image: require("@/assets/Portafolio/img05.jpg")
               },
               {
                   image: require("@/assets/Portafolio/img06.jpg")
               },
            ]
        })
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
        height: 1000px;
        width: 1540px;
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
    sub-title {
        text-align: left;
        margin-left: 2%;
        color: #ffd43a;
        font-weight: bold;
    }
    .btn {
        -webkit-border-radius: 4px;
        -moz-border-radius: 4px;
        border-radius: 4px;
        color: #663A3A;
        font-size: 17px;
        background: #E8E8E8;
        padding: 10px 20px 10px 20px;
        position:relative;
    }

        .btn:hover {
            background: #848383;
            color: #FFE751;
        }
</style>
