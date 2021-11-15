<template>
        <nav-menu></nav-menu>
        <router-view />
</template>

<script>
    import NavMenu from './components/NavMenu.vue'

export default {
  name: 'App',
  components: {
      NavMenu
  }
}
</script>

<style >
    #app {
        font-family: "Merriweather", serif;
        font-size: larger;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #313131;
        margin-top: 60px;
    }

    @font-face {
        font-family: "Merriweather", serif;
        src: url('https://fonts.googleapis.com/css2?family=Merriweather:ital,wght@1,700&display=swap') format("truetype");
    }

    img {
        max-width: auto;
        height: auto;
    }


</style>
