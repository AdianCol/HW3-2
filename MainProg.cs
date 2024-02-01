using System;

class Prog{
    static void Main(){
        Massive[] m = new Massive[3];
        OneDemensionMassive a = new OneDemensionMassive();
        TwoDemensionMassive b = new TwoDemensionMassive();
        JaggedMassive v = new JaggedMassive();
        m[0] = a;
        m[1] =b;
        m[2] =v;
        foreach(var i in m){
            i.CreateMassive();
            i.Print();
            i.AverageValue();
        }
    }
}