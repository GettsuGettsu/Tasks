using System.Runtime.CompilerServices;

namespace NutcrackerStory
{
    internal class Program
    {
        public static string Language { get; set; } = "en"; // ru/en

        static void Main()
        {
            ChangeConsoleEncoding("UTF-8");
            Story.Run();
            WaitToClose();
        }        

        private static void ChangeConsoleEncoding(string name)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(name);
        }

        private static void WaitToClose()
        {
            Console.ReadKey(true);
        }
    }

    public class Story
    {
        public static void Run()
        {
            int dolphinsCount = 2;
            string dolphinScale = "Golden-scale";
            int moorsCount = 12;

            for (int i = 0; i < dolphinsCount; i++)
            {
                Sea.AddDophin(dolphinScale);
            }

            foreach (Dophin dophin in Sea.Dophins)
            {
                dophin.RaiseHead();
                dophin.MakeFontain();
            }

            Splashes.Create();
            Splashes.IsFlashing = true;
            Splashes.Sing();            

            List<Moor> moors = new();
            for (int i = 0; i < moorsCount; i++)
            {
                Moor moor = new();
                moor.Parasol = new Parasol
                {
                    material = "Palm leaves"
                };
                moors.Add(moor);
            }

            Maria.Escort = moors;

            foreach (Moor moor in Maria.Escort)
            {
                moor.IsPleased = false;
                moor.ShakeParasol();
                moor.Stomp();
                moor.Sing();
            }

            Nutcracker.Comment();
            Nutcracker.IsDisturbed = true;

            Splashes.Destroy();

        }

        public class Dophin
        {
            private string skin;

            public string Skin
            {
                get { return skin; }
            }

            public void MakeFontain()
            {
                SpoutWater();
            }

            public void RaiseHead() { }

            private void SpoutWater() { }

            public Dophin(string skin)
            {
                this.skin = String.IsNullOrEmpty(skin) ? "Scale" : skin;
            }
        }

        public static class Sea
        {
            private static List<Dophin> dophins = new();

            public static List<Dophin> Dophins
            {
                get { return dophins; }
            }

            public static void AddDophin(string dolphinScale)
            {
                dophins.Add(new Dophin(dolphinScale));
            }
        }

        public static class Splashes
        {
            public static bool IsCreated { get; set; } = false;
            public static bool IsCrystal { get; set; }
            public static bool IsFlashing { get; set; }

            public static void Sing()
            {
                if (!IsCreated)
                {
                    throw new NullReferenceException();
                }

                string language = Program.Language.ToLower();

                switch (language)
                {
                    case "ru":
                        SingRu();
                        break;

                    default:
                        SingEn();
                        break;
                }
            }

            public static void Destroy()
            {
                IsCreated = false;
                IsCrystal = false;
                IsFlashing = false;
            }

            private static void SingEn()
            {
                Console.WriteLine("Who sails upon the rosy lake? The little fairy—awake, awake! Music and song—bim-bim, fishes—sim-sim, swans—tweet-tweet, birds—whiz- whiz, breezes!—rustling, ringing, singing, blowing!—a fairy o'er the waves is going! Rosy billows, murmuring, playing, dashing, cooling the air!—roll along, along.");
            }

            private static void SingRu()
            {
                Console.WriteLine("Послушайте, скорее, скорее! — навстречу хорошенькой фее! Мушки жужжите! Рыбки плывите! Лебеди песенки пойте! Волны кружитесь, играйте! — Птички над нами летайте! Динь - дин - дон! Динь - динь - дон!");
            }

            public static void Create()
            {
                IsCreated = true;
            }
        }

        public class Moor
        {
            public Parasol Parasol { get; set; }
        }

        public class Parasol
        {
            public string material { get; set; }
        }

        public static class Maria
        {
            public static List<Moor> Escort { get; set; }
        }

        public static class Nutcracker
        {

        }
    }
}