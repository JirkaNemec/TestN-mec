﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNěmec
{
    public class nakladak
    {
        public int nosnost { get; set; }
        public int naklad { get; set; }
        public int velikost_nadrz { get; set; }
        public int stav_nadrz { get; set; }
        public int tachometr { get; set; }
        public int spotreba { get; set; }

        public nakladak()
        {
            nosnost = 5000;
            naklad = 0;
            velikost_nadrz = 200;
            stav_nadrz = 200;
            tachometr = 0;
            spotreba = 0;
        }
        public void Nalozitnaklad()
        {

            if (naklad == 5000)
            {
                naklad = 5000;
            }
            else if (naklad < 5000)
            {
                naklad += 100;
            }
        }
        public void Vylozitnaklad()
        {

            if (naklad == 0)
            {
                naklad = 0;
            }
            else if (naklad > 0)
            {
                naklad -= 100;
            }
        }
        public void pohyb()
        {

            if (stav_nadrz == 0)
            {
                tachometr += 0;
                stav_nadrz = 0;

            }
            else if (naklad > 2500)
            {
                stav_nadrz -= 50;
                tachometr += 50;
            }
            else if (naklad < 2500)
            {
                stav_nadrz -= 40;
                tachometr += 40;
            }
        }
        public void Spotreba()
        {
            if (stav_nadrz == 0)
            {
                spotreba = 0;
            }
            else if (naklad > 2500)
            {
                spotreba = 50;
            }
            else if (naklad < 2500)
            {
                spotreba = 40;
            }
        }
        public void Natankovat()
        {
            stav_nadrz = 200;
        }



    }
}