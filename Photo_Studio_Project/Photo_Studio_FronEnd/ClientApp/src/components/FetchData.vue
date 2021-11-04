<template>
    <h1 id="tableLabel">Usuarios</h1>

    <p>This component demonstrates fetching data from the server.</p>

    <p v-if="!usuarios"><em>Loading...</em></p>

    <table class='table table-striped' aria-labelledby="tableLabel" v-if="usuarios">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nombre Completo</th>
                <th>Correo Electronico</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="user of usuarios" v-bind:key="user">
                <td>{{ user.ID_User }}</td>
                <td>{{ user.Nombre }}</td>
                <td>{{ user.Email }}</td>
            </tr>
        </tbody>
    </table>
</template>


<script>
    const variables = {
        BaseUrl: "https://localhost:44346/api/"
    }

    import axios from 'axios'
    export default {
        name: "FetchData",
        data() {
            return {
                usuarios: []
            }
        },
        methods: {
            getData() {
                axios.get(variables.BaseUrl+ 'api/usuarios')
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
