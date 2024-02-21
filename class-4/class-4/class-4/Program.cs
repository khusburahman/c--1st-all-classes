
//int[] number = new int[10];
//number[1] = 80;
//number[2] = 20;
//number[3] = 62;
//number[4] = 40;

//for (int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}





//int[] number = new int[70];
//number[1] = 90;
//number[2] = 50;
//number[3] = 30;
//number[4] = 76;
//for (int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine(number[i]);
//}




//int[]arr=new int[500];
//Console.Write("Enter your product: ");
//int n=Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Enter your product number:",i) ;
//        arr[i] = Convert.ToInt32(Console.ReadLine());
//    sum = sum + arr[i];
//}
//Console.WriteLine("sum product price:" +sum);






//Console.WriteLine("Enter your product: ");
//int num=Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= num; i++)
//{
//    Console.Write("Enter your product quantity: ");
//    int productQuantity=Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Enter the product price: ");
//    int oneproduct=Convert.ToInt32(Console.ReadLine());
//    int totalProduct=productQuantity*oneproduct;
//    sum = sum + totalProduct;
//}
//Console.WriteLine("\n your product price is: " + sum);
//Console.ReadKey(true);








//var array1 = new[] {
//    "Ravi",
//    "Rahul",
//    "Nitin",
//    "Welcomes",
//    "You"
//};
//var array2 = new string[10];
//array2[0] = "Narveer";
//// cloning arr and storing it in new array
//array1.CopyTo(array2, 1);
//// Printing array using loop
//foreach (var element in array2)
//{
//    System.Console.WriteLine(element);
//}


//var arr1 = new[]
//{
//    "khus",
//    "mij",
//    "taj",
//    "Welcome",
//    "you",
//};
//var arr2 = new string[10];
//arr2[0] = "Ayesha";
//arr1.CopyTo(arr2, 1);
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}
//Console.ReadKey(true);



//var arr1 = new[] {
//    "khus",
//    "mij",
//    "tas",
//};
//var arr2 = new string[10];
//arr1[0] = "suha";
//arr1[1] = "tani";
//arr1.CopyTo(arr2, 1);
//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}






//    int[] originalArray = { 1, 2, 3, 4, 5 };

//    // create a new array using the Clone method
//    int[] clonedArray = (int[])originalArray.Clone();

//    // print the original array
//    Console.WriteLine("Original array:");
//    PrintArray(originalArray);

//    // print the cloned array
//    Console.WriteLine("Cloned array:");
//    PrintArray(clonedArray);

//    // modify an element in the original array
//    originalArray[0] = 100;

//    // print the original array again
//    Console.WriteLine("Modified original array:");
//    PrintArray(originalArray);

//    // print the cloned array again
//    Console.WriteLine("Cloned array after modifying original array:");
//    PrintArray(clonedArray);

//    Console.ReadLine();


//// helper method to print an array
//static void PrintArray(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}








//int[] n = new int[10]; /* n is an array of 10 integers */
//int[] m = new int[5]; /* m is an array of 5 integers */
//for (int i = 0; i < 10; i++)
//{
//    n[i] = i + 200;
//}
//Console.WriteLine("Original Array...");
//foreach (int j in n)
//{
//    int i = j - 200;
//    Console.WriteLine("Element[{0}] = {1}", i, j);
//}
//Array.Copy(n, 0, m, 0, 5);
//Console.WriteLine("New Array...");
//foreach (int res in m)
//{
//    Console.WriteLine(res);
//}
//Console.ReadKey();









class Employ
{

    public int id;
    public string name;
    public string email;
    public int number;
    public double selary;
    public void Selary()
    {

    }
    public void employInfo()
    {


        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Enter your Id : ");
            id = Convert.ToInt32(Console.ReadLine());


            if (id == 1010)
            {


                Console.WriteLine("Enter your Name : ");
                name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your Address : ");
                email = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your email : ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your Selary : ");
                selary = Convert.ToDouble(Console.ReadLine());

                double ht = selary * 50 / 100;
                double ta = selary * 5 / 100;
                double pt = selary * 5 / 100;

                double total = selary + ht + ta + pt;

                if (selary <= 15000)
                {

                    Console.WriteLine($"\n ID No : {id}\n Name : {name}\n Email : {email}\n Phone Number : {number} \n Position : Devloper \n total Selary : {total} \n");


                }
                else if (selary > 15000 || selary <= 25000)
                {
                    Console.WriteLine($" ID No : {id}\n Name : {name}\n Email : {email}\n Phone Number : {number} \n  Position : Senior Devloper \n total Selary : {total} \n");


                }

            }

            else
            {
                Console.WriteLine("Enter your valid Id \n ");
            }


        }







    }
}