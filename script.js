
function oboji_f(){
  var i;
  var redovi = document.getElementsByTagName('tr');

  for(i=1;i<redovi.length;i++)
  {
    if(i%2==1)
    {
     redovi[i].className="neparan";
    }
  }
}

function sort_f(){
  var redovi = document.getElementsByTagName('tr');
  var tabela = document.getElementById('Tabela');
  var a,b;
  for(j=0;j<redovi.length;j++)
  {
    for(i=1;i<(redovi.length-1);i++)
    {
    a=redovi[i].getElementsByTagName('td')[4];
    b=redovi[i+1].getElementsByTagName('td')[4];

    if (parseInt(a.innerHTML) < parseInt(b.innerHTML)) {
            redovi[i].parentNode.insertBefore(redovi[i + 1], redovi[i]);
            break;
          }
    }
  }

}

function markpol_f(){
  var a;
  var redovi = document.getElementsByTagName('tr');

  for(i=1;i<redovi.length;i++)
  {
    a=redovi[i].getElementsByTagName('td')[4];
    if(parseInt(a.innerHTML)>50)
      redovi[i].style.color='green';
  }
}

function markNpol_f(){
  var a;
  var redovi = document.getElementsByTagName('tr');

  for(i=1;i<redovi.length;i++)
  {
    a=redovi[i].getElementsByTagName('td')[4];
    if(parseInt(a.innerHTML)<50)
      redovi[i].style.color='red';
  }
}

function izdvoji_f(){
  var a;
  var redovi = document.getElementsByTagName('tr');
  var tabela = document.getElementById('Tabela');


  for(j=0;j<redovi.length;j++){
  for(i=1;i<redovi.length;i++)
  {
    a=redovi[i].getElementsByTagName('td')[4];
    if(parseInt(a.innerHTML)<50)
        tabela.deleteRow(i);
  }
}
  sort_f();
}
