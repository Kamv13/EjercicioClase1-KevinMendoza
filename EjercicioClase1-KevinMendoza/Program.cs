using EjercicioClase1_KevinMendoza;

SuperHeroe Heroe1 = new SuperHeroe();
SuperHeroe Heroe2 = new SuperHeroe();
SuperHeroe Heroe3 = new SuperHeroe();


Heroe1.NombreH = "Flash";
Heroe1.IdentidadSecreta = "Barry Allen";
Heroe1.Ciudad = "Central City";
Heroe1.PuedeVolar = false;
Heroe1.poder.NombreP = "Super Velocidad";
Heroe1.poder.descripcion = "Con el poder de la supervelocidad puede generar fuerzas destructivas, pensar y reaccionar" +
    "de forma sobrehumana.";
Heroe1.poder.nivel = 0;

Heroe1.imprimir();
Console.WriteLine("");
Console.WriteLine("");

Heroe2.NombreH = "Magneto";
Heroe2.IdentidadSecreta = "Max Eisenhart (Erik Lehnsherr)";
Heroe2.Ciudad = "desconocida actualmente";
Heroe2.PuedeVolar = true;
Heroe2.poder.NombreP = "Manipulacion de Campos Electromagneticos";
Heroe2.poder.descripcion = "Controlar cualquier campo electromagnetico/metales magneticos incluso el de la tierra misma";
Heroe2.poder.nivel = 0;

Heroe2.imprimir();
Console.WriteLine("");
Console.WriteLine("");

Heroe3.NombreH = "Iron Man";
Heroe3.IdentidadSecreta = "Anthony Stark (Tony Stark)";
Heroe3.Ciudad = "New York";
Heroe3.PuedeVolar = true;
Heroe3.poder.NombreP = "Super Inteligencia y traje adaptable a disposicion de Tony";
Heroe3.poder.descripcion = "Creacion de trajes superhumanos con diferentes habilidades";
Heroe3.poder.nivel = 1;

Heroe3.imprimir();