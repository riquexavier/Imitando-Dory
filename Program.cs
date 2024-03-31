Console.WriteLine();

Console.WriteLine("No filme 'Procurando Nemo' há uma cena clássica onde a personagem Dory tenta se comunicar com uma baleia utilizando a linguagem 'Baleês'");

Console.WriteLine();

Console.WriteLine("Era mais ou menos assim... digite um texto a ser traduzido para Baleês:");

Console.WriteLine();

String txt = Console.ReadLine()!;

Console.WriteLine("\nem baleês seria:\n");

Console.WriteLine(txt
.Replace("a" , "aaa")
.Replace("e" , "eee")
.Replace("i" , "iii")
.Replace("o" , "ooo")
.Replace("u" , "uuu")
);

Console.WriteLine();
