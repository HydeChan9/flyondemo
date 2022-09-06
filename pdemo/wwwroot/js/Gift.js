function doFirst() {
    //sec2特價四樣商品圖
    const sec2 = document.querySelector(".sec2");
    let html = '';
    let disPro = {
        proBrand: ["AMADANA", "BEATS", "DIOR", "DYSON"],
        proName: ["廚餘處理機", "EP 頭戴式耳罩", "SAUVAGE曠野之心香氛", "SUPERSONIC 吹風機"],
        originalPrice: ["20000", "12000", "15000", "25000"],
        specialPrice: ["18000", "10000", "12000", "22000"]
    };

    for (let i = 0; i < 4; i++) {
        html += `<div class="discountProduct">
        <div class="discountFake">
        <a href="#">
            <div class="productImg">
                <img src="../images/Products/Discount/${disPro.proBrand[i]} ${disPro.proName[i]}.png" alt="" class="productPic">
            </div>
            <div class="overlay2">
                <span class="overlay4">Special Offer</span>
                <span class="overlay3">${disPro.specialPrice[i]}</span>
            </div>

            <div class="discountProductA1">
                <h4 class="picBrand">${disPro.proBrand[i]}</h4>
                <h2 class="picName">${disPro.proName[i]}</h2>
                <h4 class="picDes1">Point：${disPro.originalPrice[i]}</h4>
            </div>
        </a>
    </div>
    </div>`;
    }

    sec2.innerHTML = html;

    //積分兌換全部商品圖
    const contentAll = document.querySelector("#contentAll");
    fetch('http://127.0.0.1:5500/normalProducts.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {
            let html = '';
            
            html = `<div id="contentProduct" class="contentProAll">`;
            myJson.forEach(element => {
                html += `<div class="contentProduct">
                          <a href="#">
                            <div class="myCard">
                               <div class="img-wrap">
                                  <img src="${element.img}" alt="${element.product_name}">
                               </div> 
                                    <span class="productBrand">${element.product_brand}</span>
                                    <span class="productName">${element.product_name}</span>
                                    <span class="productDes">${element.product_description}</span>
                                    <span class="productPoint">Point：${element.point}</span>
                            <div class="overlay">
                               <span class="overlay1">加入購物車
                               <br>
                               <img src="../images/icons-shopping-bag-white.png" class="shoppingCartWhite"></span>
                            </div>  
                            </div> 
                          </a>
                        </div>`;
            });
            html += `</div>`;
            contentAll.innerHTML = html;
        });
}

window.addEventListener("load", doFirst)