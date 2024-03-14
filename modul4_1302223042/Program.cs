public class Program
{
    public static void Main(string[] args)
    {
        KodeBuah obj_kodebuah = new KodeBuah();
        String kodebuah = obj_kodebuah.getKodeBuah(KodeBuah.Buah.Kurma);
        Console.WriteLine("Kode buah dari " + KodeBuah.Buah.Kurma + " adalah " + kodebuah);

        PosisiKarakterGame posisikarakter = new PosisiKarakterGame();
        Console.WriteLine("State Awal : " + posisikarakter.currentState);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_S);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_S);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_W);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_W);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_W);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_S);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_W);
        posisikarakter.ActivateTrigger(Trigger.TOMBOL_X);
    }
}