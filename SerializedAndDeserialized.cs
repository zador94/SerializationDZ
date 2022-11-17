using System.Xml.Serialization;

namespace DZNaFile;

public class SerializedAndDeserialized
{
    public static void Serialized(AccountForPayment accountForPayment)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(AccountForPayment));
        try
        {
            using (Stream fileStram = File.Create("test.xml"))
            {
                xmlSerializer.Serialize(fileStram, accountForPayment);
            }

            Console.WriteLine("Success");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void Deserialized(AccountForPayment accountForPayment)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(AccountForPayment));
        try
        {
            AccountForPayment p = null;
            using (Stream fStream = File.OpenRead("test.xml"))
            {
                p = (AccountForPayment)xmlSerializer.Deserialize(fStream);
            }

            Console.WriteLine(p);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void SerializedNonСomputable(AccountForPayment accountForPayment)
    {

        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AccountForPayment));
            try
            {
                using (Stream fileStram = File.Create("test.xml"))
                {
                    xmlSerializer.Serialize(fileStram, accountForPayment.PayPerDay);
                }

                Console.WriteLine("Success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
    
