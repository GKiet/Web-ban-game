var indexValue = 0;
function slideShow(){
    setTimeout(slideShow, 2500);
    var x;
    const img = document.querySelectorAll(".img-ani");
    for(x = 0; x < img.length; x++){
        img[x].style.display = "none";
    }
    indexValue++;
    if(indexValue > img.length){indexValue = 1}
    img[indexValue -1].style.display = "block";
}
slideShow();

document.addEventListener('scroll',()=>{
    var scroll_postion = window.scrollY;
    if(scroll_postion > 250){
        header.style.backgroundColor = 'rgba(0, 0, 0, 0.7)';
    }
    else{
        header.style.backgroundColor = 'transparent';
    }
})

let listLink = document.querySelectorAll('.listlink');
let  subLink = document.querySelectorAll('.sublink');

for(let i = 0; i<listLink.length; i++){
    listLink[i].addEventListener('click', function(){
        for(let j=0; j<listLink.length; j++){
            listLink[j].classList.remove('active');
        }
        this.classList.add('active');

        let dataFilter = this.getAttribute('data-filter');

        for(let k=0; k<subLink.length; k++){
            subLink[k].classList.remove('active');
            subLink[k].classList.add('hide');

            if(subLink[k].getAttribute('data-item') == dataFilter || dataFilter == 'all'){
                subLink[k].classList.remove('hide');
                subLink[k].classList.add('active');
            }
        }
    })
}

var addToCartButtons = document.querySelectorAll('.add-to-cart');
addToCartButtons.forEach(function(button) {
  button.addEventListener('click', function() {
    alert('Sản phẩm đã được thêm vào giỏ hàng!');
  });
});

