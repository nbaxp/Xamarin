const categories = [];
for (let i = 0; i < 30; i++) {
    let category = {
        id: i,
        name: `分类 ${i + 1}`,
        products: []
    };
    for (let j = 0; j < 4; j++) {
        category.products.push({
            id: j,
            name: `商品 ${i + 1}${j + 1}`,
            price: `${(i + 1) * (j + 1) + 10}.99`,
            vipPrice: `${(i + 1) * (j + 1)}.00`,
            desc: '商品简介',
            icon: '/images/product/1.webp',
            number: 1
        });
    }
    categories.push(category)
}
export default categories;