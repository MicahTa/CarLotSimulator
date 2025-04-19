using System;

namespace CarLotSimulator
{
    class Car
    {
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            public int year;
            public int Year {
                get { return year; }
                set { year = value; }
            }
            public string make;
            public string Make {
                get { return make; }
                set { make = value; }
            }
            public string model;
            public string Model {
                get { return model; }
                set { model = value; }
            }
            public string engineNoise;
            public string EngineNoise {
                get { return engineNoise; }
                set { engineNoise = value; }
            }
            public string honkNoise;
            public string HonkNoise {
                get { return honkNoise; }
                set { honkNoise = value; }
            }
            public bool isDriveable;
            public bool IsDriveable {
                get { return isDriveable; }
                set { isDriveable = value; }
            }
            public Car() {}
            public Car(string vmake, string vmodel, int vyear, string vengineNoise, string vhonkNoise, bool visDriveable) {
                make = vmake;
                model = vmodel;
                year = vyear;
                engineNoise = vengineNoise;
                honkNoise = vhonkNoise;
                isDriveable = visDriveable;
            }

            // IDK what you wanted me to do here
            public void MakeEngineNoise() {
                Console.WriteLine(engineNoise);
            }
            public void MakeHonkNoise() {
                Console.WriteLine(honkNoise);
            }
    }
}
