namespace Task_1
{
    public enum Gender
    {
        мужской,
        женский
    }

    public enum FamilyStatus
    {
        холост,
        женат,
        замужем,
        не_замужем,
    }

    internal class FamilyMambers
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public FamilyStatus FamilyStatus { get; set; }
        public FamilyMambers Mother { get; set; }
        public FamilyMambers Father { get; set; }
        public FamilyMambers Son { get; set; }
        public FamilyMambers Daughter { get; set; }
        public FamilyMambers Wife { get; set; }
        public FamilyMambers Husband { get; set; }
        public FamilyMambers Brother { get; set; }
        public FamilyMambers Sister { get; set; }


        public FamilyMambers[] GetGrandMother()
        {

            return new FamilyMambers[] { Mother?.Mother, Father?.Mother };
        }

        public FamilyMambers[] GetGrandFather()
        {
            return new FamilyMambers[] { Mother?.Father, Father?.Father };
        }

        public FamilyMambers[] GetFather()
        {
            return new FamilyMambers[] { Father };
        }

        public FamilyMambers[] GetMother()
        {
            return new FamilyMambers[] { Mother };
        }

        public FamilyMambers[] GetWife()
        {
            return new FamilyMambers[] { Wife };
        }

        public FamilyMambers[] GetHusband()
        {
            return new FamilyMambers[] { Husband };
        }

        public FamilyMambers[] GetSister()
        {
            return new FamilyMambers[] { Mother?.Daughter };
        }

        public FamilyMambers[] GetBrother()
        {
            return new FamilyMambers[] { Mother?.Son };
        }


        public static void PrintFamilyMemberInfo(FamilyMambers FamilyMamber)
        {
            Console.WriteLine($"Генеалогическое дерево семьи {FamilyMamber.FullName.Substring(0, 6)}ых");
            Console.WriteLine("_____________________________________\n\n");

            Console.WriteLine($" | _______ Бабушка по материнской линии: {FamilyMamber.GetGrandMother()[0]?.FullName}");
            Console.WriteLine($"||/");
            Console.WriteLine($"||   | ___ Дедушка по материнской линии: {FamilyMamber.GetGrandFather()[0]?.FullName}");
            Console.WriteLine($"||  ||/");
            Console.WriteLine($"||  ||");
            Console.WriteLine($"||  ||      | /_____ Бабушка по отцовской линии: {FamilyMamber.GetGrandMother()[1]?.FullName}");
            Console.WriteLine($"||  ||/    ||/");
            Console.WriteLine($"||  ||     ||   | /__ Дедушка по отцовской линии: {FamilyMamber.GetGrandFather()[1]?.FullName}");
            Console.WriteLine($"||  ||    \\||  ||/");
            Console.WriteLine($"||/ ||     \\|  |/");
            Console.WriteLine($"||  ||      \\ /");
            Console.WriteLine($"\\|  |/       Отец: {FamilyMamber.GetFather()[0]?.FullName}");
            Console.WriteLine($" \\ /         ||   ");
            Console.WriteLine($" Мать: {FamilyMamber.GetMother()[0]?.FullName}");
            Console.WriteLine($"\\||          ||");
            Console.WriteLine($" ||          ||");


            if (FamilyMamber.FullName != FamilyMamber.GetSister()[0]?.FullName)
                Console.WriteLine($" ||/         ||                 /__ Сестра: {FamilyMamber.GetSister()[0]?.FullName}");
            else
                Console.WriteLine($" ||/         ||                 /___ Брат: {FamilyMamber.GetBrother()[0]?.FullName}");

            Console.WriteLine($" ||__________||________________/\n");
            Console.WriteLine($" {FamilyMamber.FullName}\n\n Возраст: {FamilyMamber.Age} лет\n Пол:\t{FamilyMamber.Gender}");

            Console.WriteLine($" Семейное положение: {FamilyMamber.FamilyStatus}");
            if (FamilyMamber.FamilyStatus != FamilyStatus.не_замужем && FamilyMamber.FamilyStatus != FamilyStatus.холост)
            {
                if (FamilyMamber.Gender == Gender.женский)
                    Console.WriteLine($" Супруг: {FamilyMamber.GetHusband()[0]?.FullName}");
                else
                    Console.WriteLine($" Супруга: {FamilyMamber.GetWife()[0]?.FullName}");
            }
            else Console.WriteLine();




        }


    }


}
