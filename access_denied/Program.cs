using access_denied;

ClassAccess classAccess = new ClassAccess();

Console.WriteLine("sto provando ad accedere alle proprietà della classe:");

Console.WriteLine(classAccess.number1);
Console.WriteLine(classAccess.getNumber2);
Console.WriteLine(classAccess.getNumber3);
Console.WriteLine(classAccess.number4);


//usando i modificatori d'accesso (private, protected), non sono riuscito ad accedere alla variabile, dunque si deve usare 
//l'incapsulamento usando il "get" (getter) per poter accedere alla variabile 

















