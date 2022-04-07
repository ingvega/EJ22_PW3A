var animaciones=[];
window.addEventListener('load',function(){
    var parpados= document.getElementsByClassName("parpado");
    
    for(var i=0;i<parpados.length;i++){
        animaciones.push(parpados[i].animate([
            {
                'marginTop':'-250px'
            },
            {
                'marginTop':'-250px'
            },
            {
                'marginTop':'-137px'
            }
        ],{
            duration:1500,
            delay:2000,
            iterations: Infinity,
            direction: 'alternate',
            easing:'linear'
        }));
    }
    

    document.getElementById("btnCambiar").addEventListener('click',
    function(){

        for(var i=0; i<animaciones.length;i++){
            animaciones[i].playbackRate=0;
        }

    });
    
});

