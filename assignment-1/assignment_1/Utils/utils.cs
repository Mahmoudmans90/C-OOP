using MyLibrary;
namespace Assignment_1
{
    public static class Utils
    {
        public static void ClassVsStruct(){
            //Class → Reference Type
            // Struct → Value Type
            // Class: أي نسخة جديدة تشير لنفس المكان في الذاكرة → تعديل نسخة واحدة يغير التانية.
            // Struct: أي نسخة جديدة مستقلة → تعديل نسخة لا يغير النسخ الأخرى.
            Console.WriteLine("=== Class vs Struct ===");

            PersonClass p1 = new PersonClass("mahmoud");
            PersonClass p2 = p1;
            p2.Name = "Omar";

            Console.WriteLine($"Class p1.Name: {p1.Name}");

            PersonStruct s1 = new PersonStruct("mahmoud");
            PersonStruct s2 = s1;
            s2.Name = "Omar";

            Console.WriteLine($"Struct s1.Name: {s1.Name}");
        }
        public static void publicVSprivate()
        {
            // private → متاح داخل نفس الكلاس فقط
            // public → متاح من أي مكان
            Console.WriteLine("\n=== Public vs Private ===");

            Car car = new Car("bmw" , 1000000);

            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Price: {car.GetPrice()}");
            // Console.WriteLine($"Price: {car.price}"); ===>Error
        }

        public static void CreateAndUseLIP()
        {   
        // CMD=> dotnet new classlib
        // Write My Code
        // CMD=> dotnet add reference ..\MyLibrary\MyLibrary.csproj
        // that add  To assignment_1\assignment-1.csproj
        //<ItemGroup>
        //<ProjectReference Include="..\ClassLip\C-OOP.csproj" />
        //</ItemGroup>
        /// Now I can use My Lip py using its namespace
        PersonClassLip personBylip = new PersonClassLip("mahmoud");
        Console.WriteLine($"person class lip => {personBylip}");
        
        }
    }
}