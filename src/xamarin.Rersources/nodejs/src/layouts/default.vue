<template>
    <div class="container">
        <router-view />
    </div>
    <van-tabbar
        v-model="model.current"
        active-color="#ee0a24"
        inactive-color="#000"
        route
    >
        <van-tabbar-item
            v-for="item in model.items"
            :name="item.name"
            :to="item.to"
            :icon="item.icon"
        >
            {{ item.label }}
        </van-tabbar-item>
    </van-tabbar>
</template>

<script setup>
import { reactive } from "vue";

const model = reactive({
    current: "home",
    items: [
        { name: "home", to: "/home", icon: "wap-home-o", label: "首页" },
        { name: "category", to: "/category", icon: "apps-o", label: "分类" },
        { name: "worth", to: "/worth", icon: "bag-o", label: "值得买" },
        { name: "cart", to: "/cart", icon: "shopping-cart-o", label: "购物车" },
        { name: "user", to: "/user", icon: "user-o", label: "我的" },
    ],
});
</script>

<style scoped>
.container {
    height: calc(100vh - var(--van-tabbar-height));
    box-sizing: border-box;
    overflow-x: hidden;
    overflow-y: auto;
    position: relative;
}
</style>
