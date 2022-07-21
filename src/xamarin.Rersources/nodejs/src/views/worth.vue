<template>
    <van-nav-bar title="推荐" left-arrow @click-left="$router.back()" />
    <van-row class="center">
        <div v-for="item in topProducts" style="width: 46%; border-radius: 5px">
            <img :alt="item.name" :src="item.icon" />
            <div class="ellipsis">
                {{ item.name }}
            </div>
            <div class="price">￥ {{ item.price }}</div>
        </div>
    </van-row>
</template>

<script setup>
import topProducts from "~/mock/product.js";
</script>
