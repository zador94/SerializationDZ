using System.Runtime.Serialization;
using System.Xml;

namespace DZNaFile;

[Serializable]
public class AccountForPayment : ISerializable
{
    public double PayPerDay { get; set; }   // оплата за день
    public int AmountOfDays { get; set; }   // количество дней
    public double OneDayPenalty { get; set; } // штраф за один день задержки оплаты;
    public int NumberOfPenaltyDays { get; set; }  // количество дней задержи оплаты
    public double SumNoPenalty { get; set; } // сумма к оплате без штрафа
    public double Penalty { get; set; }  // штраф
    public double Sum { get; set; } // общая сумма к оплате 
    public bool Xz { get; set; }  
    

    public AccountForPayment()
    {
        
    }


    public AccountForPayment(double payPerDay, int amountOfDays, double oneDayPenalty, int numberOfPenaltyDays)
    {
        PayPerDay = payPerDay;
        AmountOfDays = amountOfDays;
        OneDayPenalty = oneDayPenalty;
        NumberOfPenaltyDays = numberOfPenaltyDays;
        SumNoPenalty = PayPerDay * AmountOfDays;
        Penalty = OneDayPenalty * NumberOfPenaltyDays;
        Sum = SumNoPenalty - Penalty;
    }

    

    private AccountForPayment(SerializationInfo info, StreamingContext context)
    {
        if (Xz == false)
        {
            PayPerDay = info.GetDouble("PayPerDay");
            AmountOfDays = info.GetInt32("AmountOfDays");
            OneDayPenalty = info.GetDouble("OneDayPenalty");
            NumberOfPenaltyDays = info.GetInt32("NumberOfPenaltyDays");
        }
        else
        {
            PayPerDay = info.GetDouble("PayPerDay");
            AmountOfDays = info.GetInt32("AmountOfDays");
            OneDayPenalty = info.GetDouble("OneDayPenalty");
            NumberOfPenaltyDays = info.GetInt32("NumberOfPenaltyDays");
            SumNoPenalty = info.GetDouble("SumNoPenalty");
            Penalty = info.GetDouble("Penalty");
            Sum = info.GetDouble("Sum");
        }
    }
    

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (Xz == false)
        {
            info.AddValue("PayPerDay", PayPerDay);
            info.AddValue("AmountOfDays", AmountOfDays);
            info.AddValue("OneDayPenalty", OneDayPenalty);
            info.AddValue("NumberOfPenaltyDays", NumberOfPenaltyDays);
        }
        else if(Xz == true)
        {
            info.AddValue("PayPerDay", PayPerDay);
            info.AddValue("AmountOfDays", AmountOfDays);
            info.AddValue("OneDayPenalty", OneDayPenalty);
            info.AddValue("NumberOfPenaltyDays", NumberOfPenaltyDays);
            info.AddValue("SumNoPenalty", PayPerDay * AmountOfDays);
            info.AddValue("Penalty", OneDayPenalty * NumberOfPenaltyDays);
            info.AddValue("Sum", SumNoPenalty - Penalty);
            
        }
    }
}