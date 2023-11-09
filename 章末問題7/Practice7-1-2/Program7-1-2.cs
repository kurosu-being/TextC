﻿using System;
using System.Collections.Generic;

namespace Practice7_1_2 {
    //Practice7-1-2 Practice7-1-1のプログラムを、SortedDictionary<TKey,TValue>を使って書き換えてください
    class Program {
        static void Main(string[] args) {
            string wInputString = "Cozy lummox gives smart squid who asks for job pen";

            wInputString = wInputString.ToUpper();
            var wCharCount = new SortedDictionary<char, int>();
            foreach (char wCharacter in wInputString) {
                if (char.IsLetter(wCharacter)) {
                    wCharCount[wCharacter] = wCharCount.ContainsKey(wCharacter) ? wCharCount[wCharacter] + 1 : wCharCount[wCharacter] = 1;
                }
            }
            foreach (var wKeyValuePair in wCharCount) {
                Console.WriteLine($"'{wKeyValuePair.Key}': {wKeyValuePair.Value}");
            }
        }
    }
}