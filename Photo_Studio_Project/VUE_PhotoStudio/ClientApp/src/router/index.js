import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import UsuariosTable from "@/components/Admin/UsuariosTable.vue";
import ReservasTable from "@/components/Admin/ReservasTable.vue";
import Portafolio from "@/components/Portafolio.vue";
import Reservas from "@/components/Reservas.vue";
import Admin from "@/components/Admin.vue";
import Contacto from "@/components/Contacto.vue";
import Footer from "@/components/Footer.vue";



const routes = [
    {
        path: "/Home",
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
    },
    {
        path: "/Footer",
        name: "Footer",
        component: Footer,
    }



];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;