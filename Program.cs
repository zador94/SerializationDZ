using System.Xml;
using System.Xml.Serialization;
using DZNaFile;

AccountForPayment accountForPayment = new AccountForPayment (false)
{
    PayPerDay = 15.5,
    AmountOfDays = 3,
    OneDayPenalty = 12,
    NumberOfPenaltyDays = 2
};


if (accountForPayment.Xz == false)
{
    System.Xml.Serialization.XmlSerializer writer = new XmlSerializer(typeof(AccountForPayment));
}

if (accountForPayment.Xz)
{
    int a = Int32.Parse(Console.ReadLine());
    switch (a)
    {
        case 1:
            SerializedAndDeserialized.Serialized(accountForPayment);
            break;
        case 2:
            SerializedAndDeserialized.Deserialized(accountForPayment);
            break;
    }
}
