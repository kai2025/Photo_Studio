<template>
    <h1 id="tableLabel">Usuarios</h1>

    <p>This component demonstrates fetching data from the server.</p>

    <p v-if="!usuarios"><em>Loading...</em></p>

    <table class='table table-striped' aria-labelledby="tableLabel" v-if="usuarios">
        <thead>
            <tr>
                <th>IdUser</th>
                <th>Nombre</th>
                <th>Email</th>
                <th>Passcode</th>

            </tr>
        </thead>
        <tbody>
            <tr v-for="usuario of usuarios" v-bind:key="usuario">
                <td>{{ usuario.IdUser }}</td>
                <td>{{ usuario.Nombre }}</td>
                <td>{{ usuario.Email }}</td>
                <td>{{ usuario.Passcode }}</td>

            </tr>
        </tbody>
    </table>
</template>


<script>
    import axios from 'axios';

    const BaseUrl = "https://localhost:44326/api";

    export default {
        name: "FetchData",
        data() {
            return {
                usuarios: []
            }
        },
        methods: {
            getData() {
                axios.get(BaseUrl + 'usuarios')
                    .then((response) => {
                        this.usuarios =  response.data;
                    })
                    .catch(function (error) {
                        alert(error);
                    });
            }
        },
        mounted() {
            this.getData();
        }
    }
</script>