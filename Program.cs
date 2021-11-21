using System;
using textGameStory.chapters;
using textGameStory;

namespace LifeAndOtherInconveniences
{
    class Program
    {
        static void Main(string[] args)
        {
            COne.C1(ref MainCharacter.name, ref MainCharacter.sex);

            CTwo.C2(ref MainCharacter.name, ref MainCharacter.sex, ref MainCharacter._hp, ref MainCharacter.characteristics);

            CThree.C3(ref MainCharacter.name, ref MainCharacter.sex, ref MainCharacter._hp, ref MainCharacter.characteristics);
        }
    }
}
