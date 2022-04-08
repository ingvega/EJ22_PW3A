window.addEventListener("load",function(){
    var config={};
    config.duration=2000;
    config.delay=500;
    config.fill='forwards';

    

    var keyframes=[];
    var k1={},k2={};
    k1.transform='rotateX(180deg)';
    k2.transform='rotateX(0deg)';
    keyframes.push(k1);
    keyframes.push(k2);

    var keyframes2=[
        {transform:'rotateY(0deg)'},
        {transform:'rotateY(360deg)'},
     ];

     var config2={
        duration:2000,
        delay:500,
        iterations:Infinity
    };
    
    var keyframes=[];
    var k1={},k2={};
    k1.transform='rotateX(180deg)';
    k2.transform= 'rotateX(0deg)';
    keyframes.push(k1);
    keyframes.push(k2);

    var letras=document.getElementsByClassName('letra');
    var retardo=500;
    for(var i=0;i<letras.length;i++){
        config.delay=retardo;
        config2.delay=retardo;
        //letras[i].animate(keyframes,config);
        //letras[i].animate(keyframes2,config2);
        retardo+=2000;
    }
});

