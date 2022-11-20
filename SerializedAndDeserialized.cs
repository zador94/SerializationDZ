using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace DZNaFile;

public class SerializedAndDeserialized
{
    public static void Serialized(AccountForPayment accountForPayment)
    {
        SoapFormatter soapFormatter = new SoapFormatter();
        try
        {
            using (Stream fStream = File.Create("test.soap"))
            {
                soapFormatter.Serialize(fStream, accountForPayment);
            }

            Console.WriteLine("Success");
            AccountForPayment p = null;
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void Deserialized(AccountForPayment accountForPayment)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            try
            {
                AccountForPayment p = null;
                using (Stream fStream = File.OpenRead("test.soap"))
                {
                    p = (AccountForPayment)soapFormatter.Deserialize(fStream);
                }

                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }


    
