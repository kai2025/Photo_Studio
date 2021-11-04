import { createWebHistory, createRouter } from "vue-router";
import Home from "@/components/Home.vue";
import FetchData from "@/components/FetchData.vue";
import UsuariosPage from "@/components/UsuariosPage.vue";


const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
    {
        path: "/UsuariosPage",
        name: "UsuariosPage",
        component: UsuariosPage,
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;