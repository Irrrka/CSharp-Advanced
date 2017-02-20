using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck
{
    class Truck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();//създаваме опашка от колони, с които ще работим

            for (int i = 0; i < n; i++)
            {
                int[] pumpInfo = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();//въвеждаме х-ки на колоните, еднакви имена с конструктора
                int amountOfPetrol = pumpInfo[0];
                int distanceToNextPump = pumpInfo[1];
                int indexOfPump = i;

                PetrolPump pump = new PetrolPump(amountOfPetrol,distanceToNextPump,indexOfPump);//създаваме обекта Помпа с данни от входа
                pumps.Enqueue(pump);//добавяме първата помпа в опашката с помпи
            }

            while (pumps.Count>0)
            {
                PetrolPump currentPump = pumps.Dequeue();
                PetrolPump startPump = currentPump;
                pumps.Enqueue(currentPump);

                int petrolInTank = currentPump.amountOfPetrol;
                bool fullCircle = false;

                while (petrolInTank > currentPump.distanceToNextPump)
                {
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == startPump)
                    {
                        fullCircle = true;
                        break;
                    }
                    petrolInTank += currentPump.amountOfPetrol;
                }
                    if (fullCircle)
                    {
                        Console.WriteLine(currentPump.indexOfPump);
                        break;
                    }
            }
        }
    }

    public class PetrolPump//клас помпи с характеристики
    {
        public int amountOfPetrol;
        public int distanceToNextPump;
        public int indexOfPump;

        public PetrolPump(int amountOfPetrol, int distanceToNextPump, int indexOfPump) //конструктор, в случая може и без него
        {
            this.amountOfPetrol = amountOfPetrol;
            this.distanceToNextPump = distanceToNextPump;
            this.indexOfPump = indexOfPump;
        }
    }

}
