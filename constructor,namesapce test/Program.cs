// See https://aka.ms/new-console-template for more information
using System;
namespace Myfirstprogram
{

}


class Porgram
{
    static void Main(string[] args)
    {
        Card myCard = new Card("4169-7388-9856-0934", 980, "03/26", "Manafli Abdullah", "Kapital Bank", 230);
        myCard.Information();
    }
}

class Card
{
    public string CardNumber { get; set; }
    public int CVV { get; set; }
    public string ExpDate { get; set; }
    public string OwnerFullname { get; set; }
    public string BankName { get; set; }
    public double Balance { get; set; }
    public Card(string CardNumber, int CVV, string ExpDate, string OwnerFullname, string BankName, double Balance)
    {
        this.CardNumber = CardNumber;
        this.CVV = CVV;
        this.ExpDate = ExpDate;
        this.OwnerFullname = OwnerFullname;
        this.BankName = BankName;
        this.Balance = Balance;
    }
    public void Information()
    {
        Console.WriteLine( "CardNumber:" + CardNumber );
        Console.WriteLine( "CVV:" + CVV);
        Console.WriteLine( "ExpDate:" + ExpDate);
        Console.WriteLine( "OwnerFullname:" + OwnerFullname);
        Console.WriteLine( "BankName:" + BankName);
        Console.WriteLine( "Balance:" + Balance);


    }
    
}











