window.addEventListener("load",function(){
    var config={};
    config.duration=2000;
    config.delay=500;
    config.fills='forwards';

    /*var config={
        duration:2000,
        delay:3000
    };*/

    var keyframes=[];
    var k1={},k2={};
    k1.transform='rotateX(180deg)';
    k2.transform='rotateX(0deg)';
    keyframes.push(k1);
    keyframes.push(k2);

    /*var keyframes=[
       {transform:'rotateX(180deg)'},
       {transform:'rotateX(00deg)'},
    ];*/
    var keyframes=[];
    var k1={},k2={};
    k1.transform='rotateX(180deg)';
    k2.transform='rotateX(0deg)';
    keyframes.push(k1);
    keyframes.push(k2);

    var letras=document.getElementsByClassName('letra');
    for(var i=0;i<=letras.length;i++){
        letras[i].animate(keyframes,config);
    }
});