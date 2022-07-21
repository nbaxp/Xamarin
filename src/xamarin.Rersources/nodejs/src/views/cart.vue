<template>
    <van-nav-bar title="购物车" left-arrow @click-left="$router.back()" />
    <template v-for="category in categories">
        <Product
            v-for="product in category.products"
            :icon="product.icon"
            :name="product.name"
            :price="product.price"
            :desc="product.desc"
            :number="product.number"
        />
    </template>
</template>

<script setup>
import Product from "~/components/product.vue";
import categories from "~/mock/category.js";
</script>
