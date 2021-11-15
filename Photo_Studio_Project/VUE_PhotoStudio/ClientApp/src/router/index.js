import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import UsuariosTable from "@/components/Admin/UsuariosTable.vue";
import ReservasTable from "@/components/Admin/ReservasTable.vue";
import Rastreo from "@/components/Rastreo.vue";
import Portafolio from "@/components/Portafolio.vue";
import Reservas from "@/components/Reservas.vue";
import Admin from "@/components/Admin.vue";
import Contacto from "@/components/Contacto.vue";


const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Admin/UsuariosTable",
        name: "UsuariosTable",
        component: UsuariosTable,
    },
    {
        path: "/Admin/ReservasTable",
        name: "ReservasTable",
        component: ReservasTable,
    },
    {
        path: "/Rastreo",
        name: "Rastreo",
        component: Rastreo,
    },
    {
        path: "/Portafolio",
        name: "Portafolio",
        component: Portafolio,
    },
    {
        path: "/Reservas",
        name: "Reservas",
        component: Reservas,
    },
    {
        path: "/Admin",
        name: "Admin",
        component: Admin,
    },
    {
        path: "/Contacto",
        name: "Contacto",
        component: Contacto,
    }


];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;