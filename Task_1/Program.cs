namespace Task_1
{
    // Задача. Спроектируйте программу для построения генеалогического дерева.
    // Учтите что у нас есть члены семьи у кого нет детей.
    // Есть члены семьи у кого дети есть (взрослые). Есть мужчины и женщины.

    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMambers GrandMother_1 = new FamilyMambers()
            {
                FullName = "Иванова Ирина Сергеевна",
                Age = 59,
                Gender = Gender.женский,
                FamilyStatus = FamilyStatus.замужем,

            };

            FamilyMambers GrandMother_2 = new FamilyMambers()
            {
                FullName = "Петрова Варвара Андреевна",
                Age = 60,
                Gender = Gender.женский,
                FamilyStatus = FamilyStatus.замужем,
            };

            FamilyMambers GrandFather_1 = new FamilyMambers()
            {
                FullName = "Иванов Роман Петрович",
                Age = 61,
                Gender = Gender.мужской,
                FamilyStatus = FamilyStatus.женат,

            };

            FamilyMambers GrandFather_2 = new FamilyMambers()
            {
                FullName = "Петров Иван Геннадьевич",
                Age = 62,
                Gender = Gender.мужской,
                FamilyStatus = FamilyStatus.женат,
            };

            FamilyMambers Woman_1 = new FamilyMambers()
            {
                FullName = "Петрова Ольга Романовна",
                Age = 42,
                Gender = Gender.женский,
                Mother = GrandMother_1,
                Father = GrandFather_1,
                FamilyStatus = FamilyStatus.замужем,
            };

            FamilyMambers Woman_2 = new FamilyMambers()
            {
                FullName = "Иванова Светлана Романовна",
                Age = 34,
                Gender = Gender.женский,
                Mother = GrandMother_1,
                Father = GrandFather_1,
                FamilyStatus = FamilyStatus.не_замужем,
            };

            FamilyMambers Woman_3 = new FamilyMambers()
            {
                FullName = "Громова Алла Ивановна",
                Age = 37,
                Gender = Gender.женский,
                Mother = GrandMother_2,
                Father = GrandFather_2,
                FamilyStatus = FamilyStatus.замужем,
            };

            FamilyMambers Woman_4 = new FamilyMambers()
            {
                FullName = "Иванова Мария Ивановна",
                Age = 35,
                Gender = Gender.женский,
                Mother = GrandMother_2,
                Father = GrandFather_2,
                FamilyStatus = FamilyStatus.замужем,
            };


            FamilyMambers Man_1 = new FamilyMambers()
            {
                FullName = "Иванов Сергей Романович",
                Age = 44,
                Gender = Gender.мужской,
                Mother = GrandMother_1,
                Father = GrandFather_1,
                FamilyStatus = FamilyStatus.женат,
            };

            FamilyMambers Man_2 = new FamilyMambers()
            {
                FullName = "Петров Игорь Иванович",
                Age = 42,
                Gender = Gender.мужской,
                Mother = GrandMother_2,
                Father = GrandFather_2,
                FamilyStatus = FamilyStatus.женат,
            };

            FamilyMambers Man_3 = new FamilyMambers()
            {
                FullName = "Громов Алексей Валерьевич",
                Age = 41,
                Gender = Gender.мужской,
                Mother = new FamilyMambers() { FullName = "Громова Раиса Витальевна", Age = 64, Gender = Gender.женский},
                Father = new FamilyMambers() { FullName = "Громов Валерий Сергеевич", Age = 62, Gender = Gender.мужской},
                FamilyStatus = FamilyStatus.женат,
            };

            FamilyMambers Man_4 = new FamilyMambers()
            {
                FullName = "Иванов Аркадий Романович",
                Age = 36,
                Gender = Gender.мужской,
                Mother = GrandMother_1,
                Father = GrandFather_1,
                FamilyStatus = FamilyStatus.холост,
            };

            FamilyMambers Son_1 = new FamilyMambers()
            {
                FullName = "Громов Юрий Алексеевич",
                Age = 14,
                Gender = Gender.мужской,
                Mother = Woman_3,
                Father = Man_3,
                FamilyStatus = FamilyStatus.холост,
            };

            FamilyMambers Son_2 = new FamilyMambers()
            {
                FullName = "Петров Константин Игоревич",
                Age = 15,
                Gender = Gender.мужской,
                Mother = Woman_1,
                Father = Man_2,
                FamilyStatus = FamilyStatus.холост,
            };

            FamilyMambers Son_3 = new FamilyMambers()
            {
                FullName = "Иванов Александр Сергеевич",
                Age = 12,
                Gender = Gender.мужской,
                Father = Man_1,
                Mother = new FamilyMambers() { FullName = "Иванова Раиса Максимовна", Age = 38, Gender = Gender.женский},
                FamilyStatus = FamilyStatus.холост,
            };

            FamilyMambers Daughter_1 = new FamilyMambers()
            {
                FullName = "Петрова Яна Игоревна",
                Age = 12,
                Gender = Gender.женский,
                Mother = Woman_1,
                Father = Man_2,
                FamilyStatus = FamilyStatus.не_замужем,
            };

            FamilyMambers Daughter_2 = new FamilyMambers()
            {
                FullName = "Громова Светлана Алексеевна",
                Age = 16,
                Gender = Gender.женский,
                Mother = Woman_3,
                Father = Man_3,
                FamilyStatus = FamilyStatus.не_замужем,
            };

            FamilyMambers Daughter_3 = new FamilyMambers()
            {
                FullName = "Иванова Надежда Сергеевна",
                Age = 14,
                Gender = Gender.женский,
                Father = Man_1,
                Mother = Woman_4,
                FamilyStatus = FamilyStatus.не_замужем,
            };

            // Отношение муж / жена

            GrandMother_1.Husband = GrandFather_1;
            GrandMother_2.Husband = GrandFather_2;
            GrandFather_1.Wife = GrandMother_1;
            GrandFather_2.Wife = GrandMother_2;
            Woman_1.Husband = Man_2;
            Woman_3.Husband = Man_3;
            Woman_4.Husband = Man_1;
            Man_2.Wife = Woman_1;
            Man_3.Wife = Woman_3;
            Man_1.Wife = Woman_4;


            // Отношение мать / дочь

            GrandMother_1.Daughter = Woman_1;
            GrandMother_1.Daughter = Woman_2;
            GrandMother_2.Daughter = Woman_3;
            GrandMother_2.Daughter = Woman_4;
            Woman_1.Daughter = Daughter_1;
            Woman_3.Daughter = Daughter_2;
            Woman_4.Daughter = Daughter_3;


            // Отношение Мать / сын

            GrandMother_1.Son = Man_1;
            GrandMother_1.Son = Man_4;
            GrandMother_2.Son = Man_2;
            Woman_1.Son = Son_2;
            Woman_3.Son = Son_1;
           

            // Вывод генеалогического дерева в консоль

            FamilyMambers.PrintFamilyMemberInfo(Man_2);

            Console.WriteLine("\n");

            FamilyMambers.PrintFamilyMemberInfo(Woman_1);

            Console.WriteLine("\n");

            FamilyMambers.PrintFamilyMemberInfo(Son_2);

            Console.WriteLine("\n");

            FamilyMambers.PrintFamilyMemberInfo(Daughter_1);


            Console.ReadLine();


        }
    }
}
