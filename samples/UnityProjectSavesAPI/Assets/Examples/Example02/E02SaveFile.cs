﻿using SavesAPI;
using System;

namespace Examples.E02
{
    [Serializable]
    public class E02SaveFile : ISaveableObject
    {
        public string textContent;

        public SavingMethod SavingMethod => SavingMethod.Encrypted;
        public string Name => "menuTextContent";
        public DateTime LastUsage { get; set; }

        public E02SaveFile(string textContent)
        {
            this.textContent = textContent;
        }
    }
}
