<template>
    <div>

        <div class="btn-group" role="group">
            <router-link class="nav-link" tag="router-link" to="/Admin/UsuariosTable">
                <button class="btn"> Usuarios</button>
            </router-link>
            <router-link class="nav-link" tag="router-link" to="/Admin/ReservasTable">
                <button class="btn"> Reservas</button>
            </router-link>
        </div>
    </div>
</template>

<script>

</script>

<style scoped>
    btn {
        background: #4f4f4f;
        border-radius: 5px;
        color: #ffd43a;
        font-size: 25px;
        padding: 15px 25px 15px 25px;
    }
        .btn:hover {
            background: #f5f5f5;
            text-decoration: none;
            color: #990303;
        }
</style>