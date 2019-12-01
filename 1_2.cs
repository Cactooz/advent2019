using System;

namespace Advent_of_Code_2019_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFuel = 0;
            double roundFuelTemp, roundExtraFuelTemp, extraFuelTemp;
            double fuelTemp = 0;
            int[] mass =
             {
                66626,
                95053,
                84365,
                111504,
                97412,
                124986,
                133224,
                60267,
                68096,
                120910,
                105547,
                138575,
                112841,
                113102,
                92387,
                83511,
                62646,
                98974,
                138093,
                59417,
                137854,
                78318,
                143846,
                81514,
                86217,
                98493,
                82056,
                129376,
                61322,
                51045,
                115467,
                106540,
                149439,
                141253,
                65608,
                130480,
                79444,
                80032,
                101908,
                105695,
                145502,
                87538,
                68817,
                128768,
                148784,
                115464,
                147306,
                148666,
                118258,
                82755,
                68422,
                98333,
                105334,
                120963,
                89349,
                78675,
                99151,
                61383,
                81549,
                106544,
                72880,
                88152,
                110879,
                91277,
                123584,
                78430,
                51658,
                126045,
                93833,
                52535,
                130831,
                130920,
                80069,
                140263,
                50943,
                63503,
                116135,
                112686,
                67582,
                83515,
                128736,
                136447,
                69998,
                72472,
                61009,
                136054,
                124675,
                134813,
                149765,
                132135,
                127787,
                148333,
                78020,
                94212,
                81407,
                58994,
                146820,
                66603,
                62761,
                86955,
            };
            for (int i = 0; i < mass.Length; i++)
            {
                fuelTemp += mass[i];
                fuelTemp = fuelTemp / 3;
                roundFuelTemp = Math.Floor(fuelTemp);
                roundFuelTemp -= 2;
                totalFuel += Convert.ToInt32(roundFuelTemp);
                while (roundFuelTemp > 0)
                {
                    extraFuelTemp = roundFuelTemp / 3;
                    roundExtraFuelTemp = Math.Floor(extraFuelTemp);
                    roundExtraFuelTemp -= 2;
                    if (roundExtraFuelTemp <= 0) {
                        roundFuelTemp = 0;
                    }
                    else {
                        totalFuel += Convert.ToInt32(roundExtraFuelTemp);
                        roundFuelTemp = roundExtraFuelTemp;
                    }
                }
                fuelTemp = 0;
            }
            Console.WriteLine($"Total: {totalFuel}");
        }
    }
}
