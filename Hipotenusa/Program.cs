double cat1=0, cat2=0, hipotenusa=0;

Console.WriteLine("Digite o valor do cateto1: ");
cat1=double.Parse(Console.ReadLine());

Console.WriteLine("Digite o cateto 2: ");
cat2= double.Parse(Console.ReadLine());

hipotenusa=Math.Sqrt(cat1*cat1+cat2*cat2);

Console.WriteLine("A hipotenusa é: " + hipotenusa);




