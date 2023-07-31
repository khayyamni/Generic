


// boxing-unboxin

//int num = 5;

//object t = num;

//num = 100;

//Console.WriteLine(t);


//int num = 5;

//object t = num;

//int j = (int)t;

//upcasting-downcasting

//using Casting_Generics;

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();

//Animal animal3 = fish1;

//Animal animal2 = new Fish();

//Fish fish3 = (Fish)animal2;

//Book book1 = new Book();



//object[] animals = { animal1, fish1, animal3, animal2, fish3 };

//foreach (var item in animals)
//{
//    ((Animal)item).Name = "Tulku";
//    Console.WriteLine(((Animal)item).Name);
//}






//object[] animals = { 1, "Salam", animal1, fish1, animal3, animal2, fish3 };

//foreach (var item in animals)
//{
//    if(item is Animal)
//    {
//        ((Animal)item).Name = "Tulku";
//        Console.WriteLine(((Animal)item).Name);
//    }

//}




//object[] animals = { book1, 1, "Salam", animal1, fish1, animal3, animal2, fish3 };

//foreach (var item in animals)
//{

//    Animal animal  = item as Animal;

//    if(animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }

//    //if (item is Animal a) 
//    //{
//    //    a.Name = "Tulku";
//    //    Console.WriteLine(a.Name);
//    //}

//}


//int num1 = 200;
//byte num2 = (byte)num1;
//Console.WriteLine(num2);


//static void Test(int? a)
//{
//    Test2((int)a);
//}

//static void Test2(int a)
//{

//}

//using Casting_Generics;

//IntList intList = new IntList();

//intList.Add(3);
//intList.Add(5);
//intList.Add(3);
//intList.Add(5);
//intList.Add(3);
//intList.Add(5);
//intList.Add(3);
//intList.Add(5);

//var result = intList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//StringList stringList = new StringList();
//stringList.Add("Salam");
//stringList.Add("Salamlar");

//var res = stringList.GetAll();


//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

//using Casting_Generics;
//using System.Xml.Linq;

//DataList<int> datas = new DataList<int>();


//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//DataList<string> words = new DataList<string>();

//words.Add("salam");
//words.Add("salam1");
//words.Add("salam2");
//words.Add("salam3");

//var list = words.GetAll();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//DataList<bool> statuses = new DataList<bool>();

//statuses.Add(true);
//statuses.Add(false);

//var listBool = statuses.GetAll();

//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}


//DataList<Book1> books = new DataList<Book1>();

//books.Add(new Book1{ Id = 1, Name = "Xosrov ve Shirin" });
//books.Add(new Book1 { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}


//Repository<string> data1 = new Repository<string>();
//Repository<Book1> data2 = new Repository<Book1>();
//Repository<bool> data3 = new Repository<bool>();


//Repository<Bird,Animal> animal = new Repository<Bird,Animal>();


//Datalist<Book> books = new();


//books.Add(new Book{ Id = 1, Name = "Xowsrov ve Shirin"});
//books.Add(new Book{ Id = 2, Name = "Isgendername" });