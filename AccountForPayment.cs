using System.Runtime.Serialization;
using System.Xml;

namespace DZNaFile;

[Serializable]
public class AccountForPayment
{
    public double PayPerDay { get; set; }   // оплата за день
    public int AmountOfDays { get; set; }   // количество дней
    public double OneDayPenalty { get; set; } // штраф за один день задержки оплаты;
    public int NumberOfPenaltyDays { get; set; }  // количество дней задержи оплаты
    public double SumNoPenalty { get; set; }    // сумма к оплате без штрафа
    public double Penalty { get; set; }  // штраф
    public double Sum { get; set; } // общая сумма к оплате 
    public bool Xz { get; set; }
    
    public AccountForPayment()
    {
        
    }
    
    public AccountForPayment(bool xz)
    {
        Xz = xz;
        SumNoPenalty = PayPerDay * AmountOfDays;
        Penalty = OneDayPenalty * NumberOfPenaltyDays;
        Sum = SumNoPenalty - Penalty;
    }

    
    public override string ToString()
    {
        return $"Сумма без штрафа:{SumNoPenalty}, Штраф:{Penalty}, Общая сумма:{Sum}";
    }
}