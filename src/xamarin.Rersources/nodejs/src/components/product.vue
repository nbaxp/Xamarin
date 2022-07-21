<template>
    <van-row class="product">
        <van-col :span="8" class="center">
            <van-image size="100" :src="icon" />
        </van-col>
        <van-col :span="16" class="center">
            <div style="font-size: 1.2em">{{ name ?? "name" }}</div>
            <div style="font-size: 0.8em">{{ desc ?? "desc" }}</div>
            <div style="color: #fa2c19">￥ {{ price ?? "0.00" }}</div>
            <div><van-stepper v-model="number" style="float: right" /></div>
        </van-col>
    </van-row>
</template>

<script setup>
import { ref, defineProps } from "vue";
defineProps({
    name: String,
    icon: String,
    desc: String,
    price: String,
});
const number = ref(1);
</script>

<style>
.product {
    background-color: #fff;
}
.product .center > div {
    width: 90%;
}
</style>
