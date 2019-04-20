using System;
using System.Collections.Generic;
using System.IO;

namespace MyHashTable
{
    class HashTable
    {
        public enum hashFunctionType { Standart, WithParameters}

        public hashFunctionType HashType { get; set; }

        public int A { get; set; } = 1;
        public int B { get; set; } = 1;
        public int C { get; set; } = 1;

        public List<Subscriber>[] Table { get; } = new List<Subscriber>[256];

        public HashTable()
        {
            for (int i = 0; i < 256; i++)
            {
                Table[i] = new List<Subscriber>();
            }
        }

        private byte Hash(int key)
        {
            switch (HashType)
            {
                case hashFunctionType.Standart:
                    return Convert.ToByte(key % 256);

                case hashFunctionType.WithParameters:

                    if (A == 0) A = 1;
                    if (B == 0) B = 1;
                    if (C == 0) C = 1;

                    return Convert.ToByte((key * A * B * C) % 256);
            }

            throw new InvalidOperationException();
        }

        public void LoadFromFile()
        {
            using (StreamReader streamReader = new StreamReader("astra.txt"))
            {
                string newLine = streamReader.ReadLine();

                while (newLine != null)
                {
                    if (newLine[6] != ' ')
                    {
                        string key = string.Empty;

                        for (int i = 0; i < 5; i++)
                        {
                            key += newLine[i];
                        }

                        string name = string.Empty;

                        for (int i = 6; i < 27; i++)
                        {
                            name += newLine[i];
                        }

                        string adress = string.Empty;

                        for (int i = 28; i < newLine.Length; i++)
                        {
                            adress += newLine[i];
                        }

                        Subscriber newSub = new Subscriber();

                        newSub.Key = Convert.ToInt32(key);
                        newSub.Name = name;
                        newSub.Adress = adress;

                        Table[Hash(newSub.Key)].Add(newSub);
                    }
                    newLine = streamReader.ReadLine();
                }
            }
        }

        public Subscriber Find(int key)
        {
            //throw new NotImplementedException();

            Subscriber sub = null;

            for (int i = 0; i < Table[Hash(key)].Count; i++)
            {
                if (Table[Hash(key)][i].Key == key)
                {
                    sub = Table[Hash(key)][i];
                    break;
                }
            }

            return sub;
        }

        public Subscriber Find(int key, out int steps)
        {
            //throw new NotImplementedException();

            Subscriber sub = null;

            steps = 0;

            for (int i = 0; i < Table[Hash(key)].Count; i++)
            {
                steps++;

                if (Table[Hash(key)][i].Key == key)
                {
                    sub = Table[Hash(key)][i];
                    break;
                }
            }

            return sub;
        }
    }
}
