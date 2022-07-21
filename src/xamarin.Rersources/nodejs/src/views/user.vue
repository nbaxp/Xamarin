<template>
    <van-nav-bar title="我的" left-arrow @click-left="$router.back()" />
    <van-cell title="" size="large">
        <template #title> <van-image width="40" src="/avatar.svg" /></template>
        <template #value>
            <van-button round type="primary">登录/注册</van-button></template
        >
    </van-cell>
    <van-cell title="会员中心" icon="location-o" />
</template>
