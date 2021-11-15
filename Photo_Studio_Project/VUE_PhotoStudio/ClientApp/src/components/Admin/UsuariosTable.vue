<template>
    <h1 ID="tableLabel">Usuarios</h1>

    <p v-if="!usuarios"><em>Loading...</em></p>
    <table class='table table-striped' aria-labelledby="tableLabel">
        <thead>
            <tr>
                <th>ID</th>
                <th> Nombre Completo</th>
                <th>Email</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="usuario in usuarios" v-bind:key="usuario.ID">
                <td>{{usuario.idUser}}</td>
                <td>{{usuario.nombre}}</td>
                <td>{{usuario.email}}</td>
                <td>
                    <button>Edit</button>
                    <button>Delete</button>
                </td>
            </tr>
        </tbody>
    </table>
</template>


<script>
    import axios from 'axios'

    const BaseURL = "https://localhost:44326/api/";
    const controller = "usuarios";

    export default {
        name: "UsuariosTable",
        data() {
            return {
                usuarios: []
            }
        },
        methods: {
            getUsers() {
                //console.log(BaseURL + controller);
                axios.get(BaseURL + controller)
                    .then((response) => {
                      //  console.log("Punto 01");
                        this.usuarios = response.data;
                        console.log(this.usuarios);
                        console.log(response.data);
                    })
                    .catch(function (error) {
                        error = "Ha ocurrido un problema, favor intente de nuevo"
                        alert(error);
                    });
            }
        },
        mounted() {
            this.getUsers();
        }
    }
</script>