const tblProduct = "Products";
let productId = null;
$(#btnSave).click(function () {
    const product = $('txtProduct').val();
    const description = $('txtDescription').val();
    const price = $('txtPrice').val();

    createProduct(product, description, price);
}
);

function createProduct(product, description, price) {
    let lst = getProducts();
    const requestModel = {
        id: uuidv4(),
        product: product,
        description: description,
        price: price
    };
    lst.push(requestModel);
    const jsonProduct = JSON.stringify(lst);
    localStorage.setItem(tblProduct,jsonProduct);
    successMessage("Saving Successful");

}

function uuidv4() {
    return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, c =>
        (+c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> +c / 4).toString(16)
    );
}

function getProducts() {
    const products = localStorage.getItem(tblProduct);
    let lst = [];
    if (products !== null) {
        lst = JSON.parse(products);
    }
    return lst;
}