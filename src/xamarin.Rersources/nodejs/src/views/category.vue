<template>
    <van-nav-bar title="分类" left-arrow @click-left="$router.back()" />
    <div id="category">
        <div class="column left" ref="leftRef">
            <div
                class="item"
                v-for="(category, index) in categories"
                :ref="setLeftRef"
                @click="onLeftClick($event, index)"
            >
                {{ category.name }}
            </div>
        </div>
        <div
            class="column right"
            ref="rightRef"
            @scroll="onRightScroll($event)"
        >
            <div class="item" v-for="category in categories" :ref="setRightRef">
                <h2>{{ category.name }}</h2>
                <Product
                    v-for="product in category.products"
                    :icon="product.icon"
                    :name="product.name"
                    :price="product.price"
                    :desc="product.desc"
                    :number="number"
                />
            </div>
        </div>
    </div>
</template>
<script setup>
import { ref, onBeforeUpdate } from "vue";
import categories from "~/mock/category.js";
import Product from "~/components/product.vue";

const number = ref(0);
const leftRef = ref(null);
const rightRef = ref(null);
let leftRefs = [];
let rightRefs = [];

const setLeftRef = (el) => {
    if (el) {
        leftRefs.push(el);
    }
};

const setRightRef = (el) => {
    if (el) {
        rightRefs.push(el);
    }
};

onBeforeUpdate(() => {
    leftRefs = [];
    rightRefs = [];
});

const onLeftClick = (e, i) => {
    leftRef.value.scrollHeight;
    rightRef.value.scrollTo(0, rightRefs[i - 1].offsetTop);
    setTimeout(() => {
        if (!e.target.classList.contains("active")) {
            document
                .querySelectorAll(".left .item.active")
                .forEach((o) => o.classList.remove("active"));
            e.target.classList.add("active");
        }
    }, 50);
};
const onRightScroll = (e) => {
    for (let i = 0; i < rightRefs.length; i++) {
        const item = rightRefs[i];
        if (
            rightRef.value.scrollTop >= item.offsetTop &&
            rightRef.value.scrollTop < item.offsetTop + item.clientHeight
        ) {
            if (!leftRefs[i].classList.contains("active")) {
                setTimeout(() => {
                    document
                        .querySelectorAll(".left .item.active")
                        .forEach((o) => o.classList.remove("active"));
                    leftRefs[i].classList.add("active");
                }, 50);
            }
            //
            if (leftRef.value.scrollTop - leftRefs[i].offsetTop >= 0) {
                leftRef.value.scrollTop = leftRefs[i].offsetTop;
            } else if (
                leftRefs[i].offsetTop -
                    leftRef.value.scrollTop +
                    leftRefs[i].clientHeight >
                leftRef.value.clientHeight
            ) {
                leftRef.value.scrollTop =
                    leftRefs[i].offsetTop -
                    leftRef.value.clientHeight +
                    leftRefs[i].clientHeight;
            }
        }
        //break;
    }
};
</script>

<style>
#category {
    height: calc(100% - var(--van-nav-bar-height));
    background-color: #fff;
    overflow: hidden;
    position: relative;
}
#category .column {
    position: relative;
    height: 100%;
    overflow: auto;
}
#category .left {
    width: 25%;
    float: left;
}
#category .right {
    width: 75%;
    float: right;
    overflow: auto;
}
#category .item {
    box-sizing: border-box;
}
#category .left .item {
    height: 3em;
    line-height: 3em;
    padding: 0 1em;
    color: #000;
    background-color: #f6f6f6;
    overflow: hidden;
}
#category .left .item.active {
    color: #ee0a24;
    background-color: #fff;
}
#category .right .item {
    border-bottom: 1px solid #fff;
}
</style>
