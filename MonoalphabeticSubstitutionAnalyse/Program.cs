using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ConsoleApp1
{
    class Program
    {
        private const float e = 17.40f;

        static void Main(string[] args)
        {
            string text = "Es ausfallen wie Staaten aber geben, eines Öffnung Internet diesem Zeichen, sagte Kind erkannte verwobene jedoch. Die Information des über Stirn, Rentner das Benutzung setzte einer besseren. Seine wie weiterhin den noch sagen. Er Genugtuung zugeben alle wieder in Internets unvorsichtig für, daß Kirchen doch noch worden starb. Indem Wesen wäre bewußt befremdet ungemein, wenn verbesserten und breiten sind. Das Neugierde Information an seine, nachdem mit den hier zu Bewegung. Die des zurückgeben wandte nach dem Kopfkissen, die mußte worden stillschweigend nur, auf sich abgegangen ausfallen Zeit Depot, so Information dazu dadurch Zigarette und in, als und es hinnehmen und aber sozialen fragte, als Frau Firmen sollte Helga zu, unkonventionell Sitzgelegenheit und dann dem und, als gegeben nach Unternehmen bewußt, dann verstanden ihrem schicken Sachen sahen.";
            CharList charList = new CharList(text);
            charList.WriteToConsole();

            Console.ReadKey();
        }
    }
}
