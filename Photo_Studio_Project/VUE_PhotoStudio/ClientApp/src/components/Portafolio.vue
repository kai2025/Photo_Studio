<template>
    <div>
        <h2> Portafolio</h2>

        <div class="img" style="margin-top: 4%;">
            <vueper-slides ref="myVueperSlides"
                           style=" height: 1000px; width: 1540px; image-rendering: auto;"
                           autoplay>

                <vueper-slide v-for="(slide, i) in slides_bebes"
                              :key="i"
                              :image="slide.image" />
            </vueper-slides>
        </div>
        <div class="img" style="margin-top: 4%;">
            <vueper-slides ref="myVueperSlides"
                           style="height: 1000px; width: 1540px; image-rendering: auto;"
                           autoplay>

                <vueper-slide v-for="(slid, i) in slides_alimentos"
                              :key="i"
                              :image="slid.image" />
            </vueper-slides>
        </div>
        <div class="img" style="margin-top: 4%;">
            <vueper-slides ref="myVueperSlides"
                           style=" height: 1000px; width: 1540px; image-rendering: auto;"
                           autoplay>

                <vueper-slide v-for="(sli, i) in slides_bodas"
                              :key="i"
                              :image="sli.image" />
            </vueper-slides>
        </div>


    </div>

        
</template>

<script>
    import { VueperSlides, VueperSlide } from 'vueperslides'
    import 'vueperslides/dist/vueperslides.css'

    export default {
        name: 'Portafolio',
        components: { VueperSlides, VueperSlide },
        data: () => ({

            slides_bebes: [
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes01.jpeg")
                },
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes05.jpeg")
                },
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes02.jpeg")
                },
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes03.jpeg")
                }, 
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes04.jpeg")
                }, 
                {
                    image: require("@/assets/Bebes_Carrusel/Bebes06.jpeg")
                },
            ],
            slides_alimentos: [
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos01.jpeg")
                },
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos02.jpeg")
                },
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos03.jpeg")
                },
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos04.jpeg")
                },
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos05.jpeg")
                },
                {
                    image: require("@/assets/Alimentos_Carrusel/Alimentos06.jpeg")
                },
            ],
            slides_bodas: [
                {
                    image: require("@/assets/Bodas_Carrusel/Boda01.jpeg")
                },
                {
                    image: require("@/assets/Bodas_Carrusel/Boda02.jpeg")
                },
                {
                    image: require("@/assets/Bodas_Carrusel/Boda03.jpeg")
                },
                {
                    image: require("@/assets/Bodas_Carrusel/Boda04.jpeg")
                },
                {
                    image: require("@/assets/Bodas_Carrusel/Boda05.jpeg")
                },
                {
                    image: require("@/assets/Bodas_Carrusel/Boda06.jpeg")
                },
            ]
        })
    }

</script>

<style scoped>

</style>
