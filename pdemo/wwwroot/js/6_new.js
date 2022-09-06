let storage = localStorage;
function doFirst(){
	let itemString = storage['addItemList'] 
    let items = itemString.substr(0,itemString.length - 2).split(', ')
    // console.log(items);  // ['A1001', 'A1005', 'A1006', 'A1002']

    newDiv = document.createElement('div')
    newTable = document.createElement('table')

    // 將 table 放進 div，再將 div 放進 cartList
    newDiv.appendChild(newTable)
    cartList.appendChild(newDiv)

    total = 0
    for(let i = 0; i < items.length; i++){
        let itemInfo = storage.getItem(items[i])

        createCartList(items[i],itemInfo)

        let itemPrice = parseInt(itemInfo.split('|')[2])
        total += itemPrice
    }
    document.getElementById('total').innerText = total
}
function createCartList(itemId,itemValue){
    // alert(`${itemId}: ${itemValue}`)
    let itemTitle = itemValue.split('|')[0]
    let itemImage = '../../imgs/' + itemValue.split('|')[1]
    let itemPrice = parseInt(itemValue.split('|')[2])

    // 建立每個品項的清單區域 -- tr
    let trItemList = document.createElement('tr')
    trItemList.className = 'item'

    newTable.appendChild(trItemList)

    // 建立商品圖片 -- 第一個 td
    let tdImage = document.createElement('td')
    tdImage.style.width = '200px'

    let image = document.createElement('img')
    image.src = itemImage
    image.width = 80

    tdImage.appendChild(image)
    trItemList.appendChild(tdImage)

    // 建立商品名稱和刪除按鈕 -- 第二個 td
    let tdTitle = document.createElement('td')
    tdTitle.style.width = '280px'
    tdTitle.id = itemId

    let pTitle = document.createElement('p')
    pTitle.innerText = itemTitle

    let delButton = document.createElement('button')
    delButton.innerText = 'Delete'
    delButton.addEventListener('click',deleteItem)    

    tdTitle.appendChild(pTitle)
    tdTitle.appendChild(delButton)
    trItemList.appendChild(tdTitle)

    // 建立商品價格 -- 第三個 td
    let tdPrice = document.createElement('td')
    tdPrice.style.width = '170px'

    let pPrice = document.createElement('p')
    pPrice.innerText = itemPrice

    tdPrice.appendChild(pPrice)
    trItemList.appendChild(tdPrice)

    // 建立商品數量 -- 第四個 td
    let tdItemCount = document.createElement('td')
    tdItemCount.style.width = '60px'

    let pItemCount = document.createElement('p')
    
    let inputItemCount = document.createElement('input')
    inputItemCount.type = 'number'
    inputItemCount.value = 1
    inputItemCount.min = 1
    inputItemCount.addEventListener('input',changeItemCount)

    pItemCount.appendChild(inputItemCount)
    tdItemCount.appendChild(pItemCount)
    trItemList.appendChild(tdItemCount)
}
function deleteItem(e){
    let itemId = e.target.parentNode.id

    // 1. 刪除總金額 -- 要完成作業也要修改此處
    let itemValue = storage.getItem(itemId)
    let delitemCount=e.target.parentNode.parentNode.childNodes[3].childNodes
    let delitemValue=document.querySelector('input').value
    
    total -= parseInt(itemValue.split('|')[2])*delitemValue

    document.getElementById('total').innerText = total

    // 2. 清除 storage
    storage.removeItem(itemId)

    // 字串.replace(子字串,欲取代的字串)
    storage['addItemList'] = storage['addItemList'].replace(`${itemId}, `,``)

    // 3. 刪除該筆 <tr>
    // e.target.parentNode.parentNode.parentNode.removeChild(e.target.parentNode.parentNode)
    newTable.removeChild(e.target.parentNode.parentNode)
}
function changeItemCount(e){
    let itemId=e.target.parentNode.parentNode.parentNode.childNodes[1].id
    let itemValue=storage.getItem(itemId)
    total+=parseInt((itemValue).split('|')[2])
    document.getElementById('total').innerText=total

    swal.fire(total.toString())
    //swal.fire(itemId)
}
window.addEventListener('load', doFirst);