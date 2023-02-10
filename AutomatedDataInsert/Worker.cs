using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedDataInsert
{

    public class Worker
    {    
        
        public Worker()
        {
            AutomatedDataInsert();
        }

        void AutomatedDataInsert()
        {
            PopulateAllLevelsWithoutLevelOne();
            PupulateAllLevelsIncludingLevelOne();
        }



        private static void PopulateAllLevelsWithoutLevelOne()
        {
            int initialPressure = 950;
            int Altitude = 470;
            int initialAltitude = 470;
            int levelThreeFractionFromLevelTwo = 1000;
            int levelFourInitialAltitudeValue = 2516;
            int altitudeFraction = 43;
            int iterationIndex = 1;

            Console.WriteLine("Pressure\tAltitude\tLevel");

            while (initialPressure >= 950 && initialPressure <= 980)
            {
                for (int i = 2; i <= 4; i++)
                {
                    Console.WriteLine($"{initialPressure}\t\t{Altitude}\t\t{i}");

                    var altitudeCase = i switch
                    {
                        2 => Altitude += levelThreeFractionFromLevelTwo,
                        3 => Altitude = (levelFourInitialAltitudeValue+=36),
                        _ => Altitude += 0,
                    };
                    //if (i == 2)
                    //    Altitude += levelThreeFractionFromLevelTwo;
                    //if (i == 3)
                    //{
                    //    levelFourInitialAltitudeValue += 36;
                    //    Altitude = levelFourInitialAltitudeValue;
                    //}
                }
                initialPressure += 5;
                Altitude = initialAltitude + (altitudeFraction * iterationIndex++);
            }
        }

        private static void PupulateAllLevelsIncludingLevelOne()
        {
            int pressure = 985;
            int altitude = 0;
            int initialAltitude = 0;
            int firstAltitudeFraction = 36;
            int altitudeFraction = 43;
            int levelTwoInitialAltitudeValue = 771;
            int levelTwoFractionFromLevelOne = 778;
            int levelThreeFractionFromLevelTwo = 1000;
            int levelFourInitialAltitudeValue = 2768;
            int iterationIndex = 1;

            while (pressure <= 1080)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"{pressure}\t\t{altitude}\t\t{i}");

                    var altitudeCase = i switch
                    {
                        1 => altitude = (pressure == 985) ? levelTwoInitialAltitudeValue : (altitude + levelTwoFractionFromLevelOne),
                        2 => altitude += levelThreeFractionFromLevelTwo,
                        3 => altitude = (levelFourInitialAltitudeValue += firstAltitudeFraction),
                        _ => altitude += 0,
                    };

                    //if (i == 1 && pressure == 985)
                    //    altitude = levelTwoInitialAltitudeValue;
                    //if (i == 1 && pressure != 985)
                    //    altitude += levelTwoFractionFromLevelOne;
                    //if (i == 2)
                    //    altitude += levelThreeFractionFromLevelTwo;
                    //if (i == 3)
                    //{
                    //    levelFourInitialAltitudeValue += firstAltitudeFraction;
                    //    altitude = levelFourInitialAltitudeValue;
                    //}
                }
                altitude = (pressure == 985) ? (initialAltitude + firstAltitudeFraction) : ((initialAltitude + firstAltitudeFraction) + (altitudeFraction * iterationIndex++));
                pressure += 5;
            }
        }
    }
}
