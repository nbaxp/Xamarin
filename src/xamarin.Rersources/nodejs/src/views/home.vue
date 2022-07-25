<template>
    <router-link to="/search">
        <van-search disabled placeholder="请输入搜索关键词" />
    </router-link>
    <van-swipe :autoplay="3000" lazy-render>
        <van-swipe-item v-for="item in images" :key="item">
            <img :src="item" />
        </van-swipe-item>
    </van-swipe>
    <h2>热门分类</h2>
    <van-grid square :gutter="5" :column-num="5">
        <van-grid-item
            v-for="item in topCategories"
            :key="item"
            :icon="item.icon"
            :text="item.name"
        />
    </van-grid>
    <h2>推荐商品</h2>
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
// swipe
const images = [];
for (let i = 0; i < 6; i++) {
    images.push(`./images/swipe/${i + 1}.jpg`);
}
// category
const getCategoryImage = (name) => `./images/category/${name}.webp`;
const topCategories = [
    { name: "少儿童书", icon: getCategoryImage("1"), to: "" },
    { name: "学习用书", icon: getCategoryImage("2"), to: "" },
    { name: "文学小说", icon: getCategoryImage("3"), to: "" },
    { name: "人文社科", icon: getCategoryImage("4"), to: "" },
    { name: "经营投资", icon: getCategoryImage("5"), to: "" },
    { name: "热门考试", icon: getCategoryImage("6"), to: "" },
    { name: "IT科技", icon: getCategoryImage("7"), to: "" },
    { name: "进口原版", icon: getCategoryImage("8"), to: "" },
    { name: "教育培训", icon: getCategoryImage("9"), to: "" },
    { name: "电子书", icon: getCategoryImage("10"), to: "" },
];
</script>

<style>
.van-swipe-item img {
    width: 100%;
}
</style>
