let storage = localStorage;
function doFirst(){
    if( storage[`addItemList`]==null){
    storage[`addItemList`]=''
    }
    let list= document.querySelectorAll('.addButton')
   
for(let i=0;i<list.length;i++){
    list[i].addEventListener('click',function (e) {
        let teddyinfo=document.querySelector(`#${e.target.id} input`).value
       addItem(e.target.id,teddyinfo) 
        
    })
}

}
function addItem(itemId,itemValue) {
    //swal.fire(`${itemID}${itemValue}`)
    let image =document.createElement('img')
    image.src = '../../imgs/' + itemValue.split('|')[1]

    let title =document.createElement('span')
    title.innerText=itemValue.split('|')[0]

    let price =document.createElement('span')
    price.innerText=itemValue.split('|')[2]

    let newItem=document.getElementById('newItem')

    while(newItem.childNodes.length>=1){
     newItem.removeChild(newItem.firstChild)
    }
     
    newItem.appendChild(image)
    newItem.appendChild(title)
    newItem.appendChild(price) 
    

    if(storage[itemId]){
        swal.fire('you have checked.')
    }else{
   storage[`addItemList`]+=`${itemId}, `
    storage.setItem(itemId,itemValue)
    }
 

    let itemString= storage['addItemList']
    let items = itemString.substr(0,itemString.length - 2).split(', ')
    console.log(items)

    subtotal=0
    for(let i=0;i<items.length;i++){
    subtotal += parseInt(storage.getItem(items[i]).split('|')[2])
    }

    document.getElementById('itemCount').innerText=items.length
    document.getElementById('subtotal').innerText=subtotal
}    
window.addEventListener('load', doFirst);