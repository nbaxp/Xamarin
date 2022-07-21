import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue';
import Icons from 'unplugin-icons/vite'
import Components from 'unplugin-vue-components/vite';
import { VantResolver } from 'unplugin-vue-components/resolvers';
import WindiCSS from 'vite-plugin-windicss';
import path from 'path';

const pathSrc = path.resolve(__dirname, 'src');

export default defineConfig({
    resolve: {
        alias: {
            '~/': `${pathSrc}/`,
        },
    },
    plugins: [
        vue(),
        Icons(),
        WindiCSS(),
        Components({
            resolvers: [VantResolver()],
        }),
    ]
})