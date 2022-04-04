var parpados=
document.getElementsByClassName("parpado");



parpados[0].animate([
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
});