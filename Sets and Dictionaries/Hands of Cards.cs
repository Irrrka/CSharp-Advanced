using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsofCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Trim()
                .Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //string Pesho: dictionary <int, hashset(string)> 2C, 4H, 9H, AS, QS

            Dictionary<string, Dictionary<int, HashSet<int>>> cardsOfUsers = 
                new Dictionary<string, Dictionary<int, HashSet<int>>>();
            //Dictionary<int, HashSet<string>> cards = new Dictionary<int, HashSet<string>>();

            //PESHO: powerP{2,3,4,5,6,7,8,9,J 11,Q 12,K 13,A 14} typeT{S 4,H 3,D 2,C 1}


            while (inputData[0]!="JOKER")
            {
                string name = inputData[0];

                if (!cardsOfUsers.ContainsKey(name))
                {
                    cardsOfUsers.Add(name, new Dictionary<int, HashSet<int>>());//pesho
                    for (int i = 1; i <= 4; i++)
                        cardsOfUsers[name].Add(i, new HashSet<int>());//add type >> 1,2,3,4 
                }
                for (int i = 1; i < inputData.Length; i++)
                {
                    string currentCard = inputData[i].Trim();// 2C/4H/9H/AS/QS
                    string cardPower = "";
                    int cardPowerValue = 0;
                    string cardType = "";
                    int cardTypeValue = 0;

                    if (currentCard.Length > 2)
                    {
                        cardPower = currentCard.Substring(0, 2);//10
                        cardPowerValue = GetPowerValue(cardPower);
                        
                        cardType = currentCard.Substring(2);//H
                        cardTypeValue = GetTypeValue(cardType, cardTypeValue);
                    }
                    else
                    {
                        cardPower = currentCard[0].ToString();//10
                        cardPowerValue = GetPowerValue(cardPower);

                        cardType = currentCard[1].ToString();//H
                        cardTypeValue = GetTypeValue(cardType, cardTypeValue);
                    }
                    if (!cardsOfUsers[name][cardTypeValue].Contains(cardPowerValue))
                    {
                        cardsOfUsers[name][cardTypeValue].Add(cardPowerValue);
                    }
                }
                    inputData = Console.ReadLine().Trim()
                    .Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

                foreach (var outerPair in cardsOfUsers)
                    {
                        int sum = 0;
                        foreach (var innerPair in outerPair.Value)
                        {
                            sum += innerPair.Key * innerPair.Value.Sum();
                        }
                        Console.WriteLine("{0}: {1}", outerPair.Key, sum);
                    }
                }

        private static int GetTypeValue(string cardType, int cardTypeValue)
        {
            switch (cardType)
            {
                case "S":
                    cardTypeValue = 4;
                    break;
                case "H":
                    cardTypeValue = 3;
                    break;
                case "D":
                    cardTypeValue = 2;
                    break;
                case "C":
                    cardTypeValue = 1;
                    break;
            }

            return cardTypeValue;
        }

        private static int GetPowerValue(string cardPower)
        {
            int cardPowerValue;
            switch (cardPower)
            {
                case "J":
                    cardPowerValue = 11;
                    break;
                case "Q":
                    cardPowerValue = 12;
                    break;
                case "K":
                    cardPowerValue = 13;
                    break;
                case "A":
                    cardPowerValue = 14;
                    break;
                default:
                    cardPowerValue = int.Parse(cardPower);
                    break;
            }

            return cardPowerValue;
        }
    }
    }
