public class Program
{
    public static void Main(string[] args)
    {
        KodeBuah obj_kodebuah = new KodeBuah();
        String kodebuah = obj_kodebuah.getKodeBuah(KodeBuah.Buah.Kurma);
        Console.WriteLine("Kode buah dari " + KodeBuah.Buah.Kurma + " adalah " + kodebuah);
    }
}