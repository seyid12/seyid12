function btnAc() {
    document.getElementById("cnslp").innerHTML=""
}
function btnSeven() {
    if (document.getElementById("cnslp").innerHTML == "0") {
        document.getElementById("cnslp").innerHTML = "7"
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerText+"7"
    }

}

function btnEight() {
    if (document.getElementById("cnslp").innerHTML == "0") {
        document.getElementById("cnslp").innerHTML = "8"
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerText+"8"
    }
}

function btnNine() {
    if (document.getElementById("cnslp").innerHTML == "0") {
        document.getElementById("cnslp").innerHTML = "9"
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+"9"
    }
}
function btnFour() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="4"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"4"
    }
}
function btnFive() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="5"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"5"
    }
}
function btnSix() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="6"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"6"
    }
}
function btnOne() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="1"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"1"
    }
}
function btnTwo() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="2"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"2"
    }
}
function btnThree() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="3"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"3"
    }
}
function btnZero() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML="0"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"0"
    }
}
function btnOneoverx() {
    if (document.getElementById("cnslp").innerHTML=="0"|| document.getElementById("cnslp").innerHTML=="error") {
        document.getElementById("cnslp").innerHTML="error"
    }
    else {
        document.getElementById("cnslp").innerHTML="1"+"/"+"("+document.getElementById("cnslp").innerHTML+")"
    }
}
function btnComma() {
    document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+","
}
function btnPrntop() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML= "("
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+"("
    }
}
function btnPrntcls() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML= ")"
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+")"
    }
}
function btnArti() {
    if (document.getElementById("cnslp").innerHTML!="0") {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+"+"
    }
    else {
        document.getElementById("cnslp").innerHTML="0"
    }
}
function btnEksi() {
    if (document.getElementById("cnslp").innerHTML!="0") {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+"-"
    }
    else {
        document.getElementById("cnslp").innerHTML="0"
    }
}
function btnCarpi() {
    if (document.getElementById("cnslp").innerHTML!="0") {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+"*"
    }
    else {
        document.getElementById("cnslp").innerHTML="0"
    }
}
function btnBolme() {
    if (document.getElementById("cnslp").innerHTML!="0") {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+"<span>/</span>"
    }
    else {
        document.getElementById("cnslp").innerHTML="0"
    }
}
function btnPi() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML= math.pi
    }
    else {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+math.pi
    }
}
function btnE() {
    if (document.getElementById("cnslp").innerHTML=="0") {
        let num= math.e
        document.getElementById("cnslp").innerHTML= num.toString()
    }
    else {
        let num= math.e
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+num.toString()
    }
}
function btnYuzde() {
        var deger = prompt("% yüzde giriniz")
        var yuzde = (deger/100)
        document.getElementById("cnslp").innerHTML ="("+document.getElementById("cnslp").innerHTML+")"+"*"+yuzde.toString()
    }
function btnUstel() {
    var x = prompt("xʸ'nin x değerini giriniz")
    var y = prompt("xʸ'nin y değerini giriniz")
    var f = x
    var zyuv = (y-1)
    var z = math.ceil(zyuv)
    for (var i = 1; i <=z; i++) {
        x=x*f
    }
    if (document.getElementById("cnslp").innerHTML=="0") {
        document.getElementById("cnslp").innerHTML= x.toString()
    }
    else {
        document.getElementById("cnslp").innerHTML=document.getElementById("cnslp").innerHTML+x.toString()
    }
}
function btnSquare() {
    var getnum = prompt("karekökünü alacagınız sayıyı giriniz")
    var square = math.sqrt(getnum);
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = square
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+square
    }
}
function btnAscuare() {
    var getnum1 = prompt("kaçıncı derceden kök almak istersiniz")
    var getnum2 = prompt(getnum1+" derecen kökünü alacağınız sayıyı giriniz")
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = math.pow(getnum2,1/getnum1);
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+math.pow(getnum2,1/getnum1);
    } 
}
function btnLog() {
    var getnumlog = prompt("sayı giriniz")
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = math.log10(getnumlog);
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+math.log10(getnumlog);
    } 
}
function btnLn() {
    var getnumln = prompt("sayı giriniz")
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = math.log(getnumln);
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+math.log(getnumln);
    } 
}
function btnSin() {
    var angleindegrees = prompt("açı giriniz")
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = Math.sin(angleindegrees*Math.PI/180);
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+Math.sin(angleindegrees*Math.PI/180);
    } 
}
function btnCos() {
    var angleindegrees1 = prompt("açı giriniz")
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = Math.cos(angleindegrees1*Math.PI/180);
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+Math.cos(angleindegrees1*Math.PI/180);
    } 
}
function btnTan() {
    var angleindegrees2 = prompt("açı giriniz")
    var sintan = (Math.sin(angleindegrees2*Math.PI/180)/Math.cos(angleindegrees2*Math.PI/180));
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = sintan;
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+sintan;
    }
}
function btnCot() {
    var angleindegrees3 = prompt("açı giriniz")
    var coscot = (Math.cos(angleindegrees3*Math.PI/180)/Math.sin(angleindegrees3*Math.PI/180));
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = coscot;
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+coscot;
    }
}
function btnLogab() {
    var abcds = prompt("a değerini giriniz")
    var bbcds = prompt("b değerini giriniz")
    var blg = Math.log(bbcds);
    var alg = Math.log(abcds);
    var ablb = blg/alg
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = ablb;
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+ablb;
    }
}
function btnArcsin() {
    var hdg = prompt("sayı giriniz")
    var hdgg = Math.asin(hdg);
    var hdggr = hdgg*180/Math.PI
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML = hdggr;
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+hdggr;
    }
}
function btnArccos() {
    var efg = prompt("sayı giriniz")
    var efgg = Math.acos(efg);
    var efggr = efgg*180/Math.PI
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML=efggr;
    }
    else {
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+efggr;
    }
}
function btnArctan() {
    var ffg = prompt("sayı giriniz")
    var ffgg = Math.atan(ffg);
    var ffggr = ffgg*180/Math.PI
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML= ffggr;
    }
    else {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+ffggr;
    }
}
function btnArccot() {
    var kfg = prompt("sayı giriniz")
    var kfgg = Math.atan(kfg);
    var kfggr = (kfgg*180/Math.PI)
    if (document.getElementById("cnslp").innerHTML==0) {
        document.getElementById("cnslp").innerHTML=kfggr;
    }
    else {
        document.getElementById("cnslp").innerHTML= document.getElementById("cnslp").innerHTML+kfggr;
    }
}
function btnX() {
    var sayii= prompt("sayı giriniz");
    let sayiii = parseFloat(sayii);
    factorial = 1;
    if (document.getElementById("cnslp").innerHTML < 0) {
        alert("Lütfen pozitif bir tamsayı giriniz")
    }
    else {
    for(let i = 1; i <= sayiii; i++) {
            factorial=factorial*i;
        
        }
        document.getElementById("cnslp").innerHTML = document.getElementById("cnslp").innerHTML+factorial;
    }
}

function btnSonuc() {
    var a = document.getElementById("cnslp").innerHTML
    b =math.evaluate(a);
    alert(b);
}
