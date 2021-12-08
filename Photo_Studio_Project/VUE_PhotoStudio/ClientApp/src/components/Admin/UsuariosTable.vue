<template>
    <div>
        <div class="">

            <button type="button"
                    class="btn btn-primary m-4 fload-end"
                    data-bs-toggle="modal"
                    data-bs-target="#pop-up"
                    @click="addClick()">
                Agregar Usuario
            </button>

            <table class="table table-striped" style="margin-left: 2%;">
                <thead>
                    <tr>
                        <th>
                            ID
                        </th>
                        <th>
                            Nombre
                        </th>
                        <th>
                            Email
                        </th>
                        <th>
                            Clave
                        </th>
                        <th>
                            Opciones
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="usu in usuarios" v-bind:key="usu.idUser">
                        <td>{{usu.idUser}}</td>
                        <td>{{usu.nombre}}</td>
                        <td>{{usu.email}}</td>
                        <td>{{usu.passcode}}</td>
                        <td>
                            <button type="button"
                                    class="btn btn-light mr-1"
                                    data-bs-toggle="modal"
                                    data-bs-target="#exampleModal"
                                    @click="editClick(usu)"> Edit                              
                            </button>
                            <button type="button" @click="deleteClick(usu.idUser)"
                                    class="btn btn-light mr-1"> Delete                              
                            </button>

                        </td>
                    </tr>
                </tbody>
            </table>

            <div class="modal fade" id="pop-up" tabindex="0"
                 aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-lg modal-dialog-centered">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">{{modalTitle}}</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal"
                                    aria-label="Close"></button>
                        </div>

                        <div class="modal-body">
                            <div class="d-flex flex-row bd-highlight mb-3">
                                <div class="p-2 w-50 bd-highlight">
                                    <div class="input-group mb-3">
                                        <span class="input-group-text">Nombre</span>
                                        <input type="text" class="form-control" v-model="nombre">
                                    </div>

                                    <div class="input-group mb-3">
                                        <span class="input-group-text">email</span>
                                        <input type="text" class="form-control" v-model="email">
                                    </div>

                                    <div class="input-group mb-3">
                                        <span class="input-group-text">passcode</span>
                                        <input type="text" class="form-control" v-model="passcode">
                                    </div>

                                </div>

                            </div>
                            <button type="button" @click="createClick()"
                                    v-if="idUser==0" class="btn btn-primary">
                                Agregar
                            </button>
                            <button type="button" @click="updateClick()"
                                    v-if="idUser!=0" class="btn btn-primary">
                                Actualizar
                            </button>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

    import axios from 'axios'

    const BaseURL = "https://localhost:44326/api/";


    export default {
        name: "UsuariosTable",
        data() {
            return {
                usuarios: [],
                modalTitle: "",
                idUser: 0,
                nombre: "",
                email: "",
                passcode: "",
            }
        },
        methods: {
            refreshData() {
                axios.get(BaseURL + "usuarios")
                    .then((response) => {
                        this.usuarios = response.data;
                        console.log(response.data);
                    });

            },
            addClick() {
                this.modalTitle = "Agregar Usuario";
                this.idUser = 0;
                this.nombre = "";
                this.email = "",
                    this.passcode = ""

            },
            editClick(usu) {
                this.modalTitle = "Editar Usuario";
                this.idUser = usu.idUser;
                this.nombre = usu.Nombre;
                this.email = usu.email,
                    this.passcode = usu.passcode

            },
            createClick() {
                axios.post(BaseURL + "usuarios", {
                    nombre: this.Nombre,
                    email: this.email,
                    passcode: this.passcode

                })
                    .then((response) => {
                        this.refreshData();
                        alert(response.data);
                    });
            },
            updateClick() {
                axios.put(BaseURL + "usuarios", {
                    idUser: this.idUser,
                    nombre: this.Nombre,
                    email: this.email,
                    passcode: this.passcode

                })
                    .then((response) => {
                        this.refreshData();
                        alert(response.data);
                    });
            },
            deleteClick(id) {
               if (!confirm("Desea borrarlo por completo?")) {
                    return;
                }
                axios.delete(BaseURL + "usuarios/" + id)
                    .then((response) => {
                        this.refreshData();
                        alert(response.data);
                    });
            },
        },
    mounted: function() {
        this.refreshData();
    }

}
</script>