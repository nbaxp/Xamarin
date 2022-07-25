import { createRouter, createWebHistory } from 'vue-router';
import routes from './routes.js';

console.log(import.meta);
const router = createRouter({ 
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: routes,
    scrollBehavior() {
        return { top: 0 };
    },
});

export default router;