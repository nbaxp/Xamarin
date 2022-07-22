<template>
    <van-nav-bar
        class="search"
        safe-area-inset-top
        left-arrow
        @click-left="$router.back()"
    >
        <template #title>
            <van-search
                v-model="model.query"
                disabled
                placeholder="请输入搜索关键词"
            />
        </template>
        <template #right>
            <span>搜索</span>
        </template>
    </van-nav-bar>
    <van-button type="primary" url="http://internal.com/test?a=q1&b=q2"
        >URL 跳转</van-button
    >
</template>

<script setup>
import { reactive } from "vue";

const model = reactive({
    query: null,
});
</script>

<style>
.van-nav-bar__title {
    max-width: 70%;
    width: 70%;
}
</style>
