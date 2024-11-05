Console.Write("Bienvenido al programa Fzz Buzz \n");

for(int i= 1; i <= 100; i++){
    if(i % 3 == 0)
        Console.WriteLine($"este es el texto FIZZ");
        if(i % 5 == 0)
         Console.WriteLine($"este es el texto FIZZBUZZ");
     else
        Console.Write($"est el numero {i}\n");
}