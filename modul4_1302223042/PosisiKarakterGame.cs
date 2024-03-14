public enum Posisi { TENGKURAP, JONGKOK, BERDIRI, TERBANG };
public enum Trigger { TOMBOL_W, TOMBOL_S, TOMBOL_X };

public class PosisiKarakterGame
{
    public class Transition
    {
        public Posisi stateAwal;
        public Posisi stateAkhir;
        public Trigger trigger;

        public Transition(Posisi stateAwal, Posisi stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.trigger = trigger;
        }
    }

    Transition[] transisi =
    {
        new Transition(Posisi.TENGKURAP, Posisi.JONGKOK, Trigger.TOMBOL_W),
        new Transition(Posisi.JONGKOK, Posisi.BERDIRI, Trigger.TOMBOL_W),
        new Transition(Posisi.BERDIRI, Posisi.TERBANG, Trigger.TOMBOL_W),
        new Transition(Posisi.TERBANG, Posisi.BERDIRI, Trigger.TOMBOL_S),
        new Transition(Posisi.TERBANG, Posisi.JONGKOK, Trigger.TOMBOL_X),
        new Transition(Posisi.BERDIRI, Posisi.JONGKOK, Trigger.TOMBOL_S),
        new Transition(Posisi.JONGKOK, Posisi.TENGKURAP, Trigger.TOMBOL_S)

    };

    public Posisi currentState = Posisi.BERDIRI;

    public Posisi GetNextState(Posisi stateAwal, Trigger trigger)
    {
        Posisi stateAkhir = stateAwal;

        for (int i = 0; i < transisi.Length; i++)
        {
            Transition difference = transisi[i];
            if (stateAwal == difference.stateAwal && trigger == difference.trigger)
            {
                stateAkhir = difference.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTrigger(Trigger trigger)
    {
        currentState = GetNextState(currentState, trigger);

        if (currentState == Posisi.BERDIRI)
        {
            Console.WriteLine("Posisi Stanby");
        }
        else if (currentState == Posisi.TENGKURAP)
        {
            Console.WriteLine("Posisi Istirahat");
        } 
        else
        {
            Console.WriteLine("Posisi sekarang sedang " + currentState);
        }
    }
}