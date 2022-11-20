using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;
using DZNaFile;

AccountForPayment accountForPayment = new AccountForPayment(15.5, 3, 12, 2)
{
    Xz = false
};

Console.WriteLine("Введите число для действия");
Console.WriteLine("1 - сериализовать");
Console.WriteLine("2 - десериализовать");

int a;
while (!Int32.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2))
{
    Console.WriteLine("Введите 1 или 2");
}
switch (a)
    {
        case 1:
            SerializedAndDeserialized.Serialized(accountForPayment);
            break;
        case 2:
            SerializedAndDeserialized.Deserialized(accountForPayment);
            break;
    }




