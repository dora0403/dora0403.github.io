function $g(selector){
    let nodelist = document.querySelectorAll(selector);
    return nodelist.length==1?nodelist[0]:nodelist;

}
function $c(element){
    return document.createElement(element);

}

function $cc(parent,childElement,childTxt){
    let child =document.createElement(childElement);
    child.innerText=childTxt;
    parent.appendChild(child); //直接加入不須return
}

export{$g as $got,$c,$cc};