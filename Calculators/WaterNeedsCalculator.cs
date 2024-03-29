﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Calculators {
    public class WaterNeedsCalculator {
        public static double Calculate(int age, double weight) {
            double weightPound = (weight * 2.20462) / 2.2;
            
            if (age < 30) {
                weightPound = weightPound * 40;
            }
            else if (age > 29 && age < 56 ) {
                weightPound = weightPound * 35;
            }
            else if (age > 55) {
                weightPound = weightPound * 30;
            }
            
            weightPound = (weightPound / 28.3) * 0.0295735;
            weightPound = Math.Round(weightPound, 1);

            return weightPound;
        }

        public static int GetAge(DateTime dob) {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            return age;
        }
    }
}
