export default [
    {
        path: '/login',
        component: () => import('~/views/login.vue'),
    },
    {
        path: '/',
        redirect: '/home',
        component: () => import('~/layouts/default.vue'),
        children: [
            {
                path: '/home',
                component: () => import('~/views/home.vue')
            },
            {
                path: '/category',
                component: () => import('../views/category.vue')
            },
            {
                path: '/worth',
                component: () => import('../views/worth.vue')
            },
            {
                path: '/cart',
                component: () => import('../views/cart.vue')
            },
            {
                path: '/user',
                component: () => import('~/views/user.vue')
            },
        ]
    },
    {
        path: '/search',
        component: () => import('~/views/search.vue'),
    },
    {
        path: '/:pathMatch(.*)*',
        name: 'notFound',
        component: () => import('~/views/404.vue'),
    },
]