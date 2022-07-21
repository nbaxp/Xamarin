import { defineStore } from 'pinia';
export default defineStore('cart', {
    states: () => {
        return {
            total: 0,
            items: []
        };
    }
});