<template>
    <div>
        <img src="../src/assets/op1.jpg" style="width: 1600px"/>
        <h3></h3>
        <nav-menu></nav-menu>
        <router-view />

    </div>

</template>

<script>
    import NavMenu from './components/NavMenu.vue'

    export default {
        name: 'App',
        components: {
            NavMenu,
        }
    }
</script>

<style>
    #app {
        font-family: "Merriweather", serif;
        font-size: larger;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #313131;
    }

    @font-face {
        font-family: "Merriwether", serif;
        src: url('https://fonts.googleapis.com/css2?family=Merriweather:ital,wght@1,700&display=swap') format("truetype");
    }

    img {
        max-width:1300px;
        max-height:400px
    }
</style>