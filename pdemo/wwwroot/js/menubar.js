const contentAll = document.querySelector("#contentAll");
//積分兌換
const pointChange = document.getElementsByName("pointChange");
let contentAllhtml = "";
pointChange[0].onclick = function () {
    RuleBar.style.display = "none";
    personalInfo.style.display="none";
    contentAll.style.display = "";
    fetch('http://127.0.0.1:5500/normalProducts.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {

            contentAllhtml = `<div id="contentProduct" class="contentProAll">`;
            myJson.forEach(element => {

                contentAllhtml += `<div class="contentProduct">
                          <a href="#">
                            <div class="myCard">
                               <div class="img-wrap">
                                  <img src="../../${element.img}" alt="${element.product_name}">
                               </div> 
                                    <span class="productBrand">${element.product_brand}</span>
                                    <span class="productName">${element.product_name}</span>
                                    <span class="productDes">${element.product_description}</span>
                                    <span class="productPoint">Point：${element.point}</span>
                            <div class="overlay">
                               <span class="overlay1">加入購物車
                               <br>
                               <img src="../../images/icons-shopping-bag-white.png" class="shoppingCartWhite"></span>
                            </div>  
                            </div> 
                          </a>
                        </div>`;
            });
            contentAllhtml += "</div>";
            contentAll.innerHTML = contentAllhtml;
        });
};

//個人資料
const personalInfor = document.getElementsByName("personalInfor");
const personalInfo = document.querySelector(".personalInfo");
personalInfor[0].onclick = function () {
    RuleBar.style.display = "none";
    personalInfo.style.display="";
    contentAll.style.display = "none";
};

// 兌換規則
const pointRule = document.getElementsByName("pointRule");
const RuleBar = document.querySelector(".RuleBar");
let pointRulehtml = "";
pointRule[0].onclick = function () {
    RuleBar.style.display = "";
    personalInfo.style.display="none";
   
    fetch('http://127.0.0.1:5500/Rule.json')
            .then(function (response) {
                return response.json();
            })
            .then(function (myJson) {
                pointRulehtml = `<div class="RuleContent">
                                     <div class="RuleContent1">
                                     ${myJson[0].Rule}
                                     </div>
                                 </div>`;
                contentAll.innerHTML = pointRulehtml;
            });
    RuleClick();
};


// 過去兌換
const pointRecord = document.getElementsByName("pointRecord");
pointRecord[0].onclick = function () {
    RuleBar.style.display = "none";
    personalInfo.style.display="none";
    contentAll.style.display = "";
    let html = "";
    html = `過去兌換放這裡`;
    contentAll.innerHTML = html;
};

// 優惠商品
const discountProduct = document.getElementsByName("discountProduct");
discountProduct[0].onclick = function () {
    RuleBar.style.display = "none";
    personalInfo.style.display="none";
    contentAll.style.display = "";
    fetch('http://127.0.0.1:5500/discountProducts.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {

            contentAllhtml = `<div id="contentProduct" class="contentProAll">`;
            myJson.forEach(element => {

                contentAllhtml += `<div class="contentProduct">
                          <a href="#">
                            <div class="myCard">
                               <div class="img-wrap">
                                  <img src="../../${element.img}" alt="${element.product_name}">
                               </div> 
                                    <span class="productBrand">${element.product_brand}</span>
                                    <span class="productName">${element.product_name}</span>
                                    <span class="productDes">${element.product_description}</span>
                                    <span class="productPoint">Point：${element.point}</span>
                            <div class="overlay">
                               <span class="overlay1">加入購物車
                               <br>
                               <img src="../../images/icons-shopping-bag-white.png" class="shoppingCartWhite"></span>
                            </div>  
                            </div> 
                          </a>
                        </div>`;
            });
            contentAllhtml += "</div>";
            contentAll.innerHTML = contentAllhtml;
        });
};

//兌換規則裡的每個一小按鈕會出現的資料
function RuleClick() {
    const Rule = document.getElementsByName("Rule");
    const Point = document.getElementsByName("Point");
    const Personal = document.getElementsByName("Personal");
    const App = document.getElementsByName("App");


    Rule[0].onclick = function () {
        contentAll.style.display = "";
        fetch('http://127.0.0.1:5500/Rule.json')
            .then(function (response) {
                return response.json();
            })
            .then(function (myJson) {
                pointRulehtml = `<div class="RuleContent">
                                     <div class="RuleContent1">
                                     ${myJson[0].Rule}
                                     </div>
                                 </div>`;
                contentAll.innerHTML = pointRulehtml;
            });
    };
    Point[0].onclick = function () {
        contentAll.style.display = "";
        fetch('http://127.0.0.1:5500/Rule.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {
            pointRulehtml = `<div class="RuleContent">
                                 <div class="RuleContent1">
                                 ${myJson[1].Point}
                                 </div>
                             </div>`;
            contentAll.innerHTML = pointRulehtml;
        });

    };

    Personal[0].onclick = function () {
        contentAll.style.display = "";
        fetch('http://127.0.0.1:5500/Rule.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {
            pointRulehtml = `<div class="RuleContent">
                                 <div class="RuleContent1">
                                 ${myJson[2].Personal}
                                 </div>
                             </div>`;
            contentAll.innerHTML = pointRulehtml;
        });
    };
    App[0].onclick = function () {
        contentAll.style.display = "";
        fetch('http://127.0.0.1:5500/Rule.json')
        .then(function (response) {
            return response.json();
        })
        .then(function (myJson) {
            pointRulehtml = `<div class="RuleContent">
                                 <div class="RuleContent1">
                                 ${myJson[3].App}
                                 </div>
                             </div>`;
            contentAll.innerHTML = pointRulehtml;
        });
    };
};
