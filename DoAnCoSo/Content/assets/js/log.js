const navper = document.querySelector('.navper');
const loginLink = document.querySelector('.login-link');
const registerLink = document.querySelector('.register-link');
const forgotpwLink = document.querySelector('.forgotpw-link');
const logingLink = document.querySelector('.loging-link');
const resetpwLink = document.querySelector('.resetpw-link');

registerLink.addEventListener('click', ()=>{
    navper.classList.add('active');
});

loginLink.addEventListener('click', ()=>{
    navper.classList.remove('active');
});

forgotpwLink.addEventListener('click', ()=>{
    navper.classList.add('actived');
});

logingLink.addEventListener('click', ()=>{
    navper.classList.remove('actived');
});

resetpwLink.addEventListener('click', ()=>{
    navper.classList.add('active-reset');
});