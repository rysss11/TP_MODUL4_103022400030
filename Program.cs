using System;
public enum Kelurahan
{
    Batununggal, Kujangsari, Mengger, Wates, Cijaura, 
    Jatisari, Margasari, Sekejati, Kebonwaru, Maleer
}

public class KodePos
{
    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] tableKodePos = {40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274};

        return tableKodePos[(int)kelurahan]; 
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan\tKode Pos");
        Console.WriteLine("======================");
        Kelurahan kel1 = Kelurahan.Batununggal;
        Console.WriteLine(kel1+"\t"+KodePos.getKodePos(kel1));
        Kelurahan kel2 = Kelurahan.Kujangsari;
        Console.WriteLine(kel2 +"\t"+ KodePos.getKodePos(kel2));
        Kelurahan kel3 = Kelurahan.Mengger;
        Console.WriteLine(kel3 +"\t\t"+ KodePos.getKodePos(kel3));
        Kelurahan kel4 = Kelurahan.Wates;
        Console.WriteLine(kel4 +"\t\t"+ KodePos.getKodePos(kel4));
        Kelurahan kel5 = Kelurahan.Cijaura;
        Console.WriteLine(kel5+"\t\t"+ KodePos.getKodePos(kel5));
        Kelurahan kel6 = Kelurahan.Jatisari;
        Console.WriteLine(kel6 +"\t"+ KodePos.getKodePos(kel6));
        Kelurahan kel7 = Kelurahan.Margasari;
        Console.WriteLine(kel7 +"\t"+ KodePos.getKodePos(kel7));
        Kelurahan kel8 = Kelurahan.Sekejati;
        Console.WriteLine(kel8 +"\t"+ KodePos.getKodePos(kel8));
        Kelurahan kel9 = Kelurahan.Kebonwaru;
        Console.WriteLine(kel9 +"\t"+ KodePos.getKodePos(kel9));
        Kelurahan kel10 = Kelurahan.Maleer;
        Console.WriteLine(kel10 +"\t\t"+ KodePos.getKodePos(kel10));
    }
}