//String userNameInDb = "defneSa";
//String passwordInDb = "asd421";
//Console.Write("Enter your username: ");
//string userName = Console.ReadLine();
//Console.Write("Enter your password: ");
//string password = Console.ReadLine();
//string resultDb = $"In db information is: {userNameInDb} {passwordInDb}";
//string result = $"Your information is: {userName} {password}";

//bool equals = userName.ToLower() == userNameInDb.ToLower();
//Console.WriteLine(equals);

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine(resultDb);
//Console.WriteLine(result);

//string hello = "Hello World, Defne";

//int index = hello.IndexOf(' ');
//Console.WriteLine(index);   
//string result = hello.Substring(index + 1);
//index = result.IndexOf("Def");
//result = result.Substring(index + 1);
//Console.WriteLine(result);

//string hello = "Hello World, Defne";

//int index = hello.IndexOf("Def");
//Console.WriteLine(index);
//string result = hello.Substring(6, 5);
//Console.WriteLine(result);

String userNameInDb = "defneSa";
String passwordInDb = "asd421";
Console.Write("Enter your username: ");
string userName = Console.ReadLine();
Console.Write("Enter your password: ");
userName = Console.ReadLine();
Console.Write("Enter your password: ");
string password = Console.ReadLine();

bool equals = userName.ToLower().Equals(userNameInDb.ToLower());
if (equals)
{
    Console.WriteLine("Girdiğin username doğru.");
    Console.WriteLine("Sisteme giriş yaptın");
}
Console.WriteLine("İşlemin sonucu 400");

// Ekrana ilk sayıyı gir yazacak. İkinci sayıyı gir yazacak.
// Yapmak istediğin işlemi gir yazacaksın.
// O seçilen işleme göre matematik işlemini yapıp ekrana yazdır.
