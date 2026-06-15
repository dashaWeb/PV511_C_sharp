using System;


namespace _06_Intro_class
{
    // public - відкритий для інших збірок
    // internal - закритий для інших збірок
    public class Character // неявно успадковується від супертипу Object
    {
        // private - закритий доступ
        // public - вікритий доступ
        // protected - захищений доступ
        // internal - дані доступні в методах поточної збірки
        // protected internal
        private string name = "Unknown";
        private uint hp = 100;

        public Character(string name, uint hp, uint damage)
        {
            Name = name;
            this.hp = hp;
            Damage = damage;
        }
        public Character(string name) : this(name, 100, 1) //  каскадно викликається к-р цього ж класу
        {

        }
        public Character() { }

        public override string ToString()
        {
            return $"Name : {name,-10} HP : {hp,-10} Damage : {Damage,-10}";
        }
        public void Print()
        {
            Console.WriteLine($"Character name   :: {name}");
            Console.WriteLine($"Character hp     :: {hp}");
            Console.WriteLine($"Character damage :: {Damage}");
        }
        public uint Damage { get; set; } // авто-властивість, компілятор створить поле типу uint та для нього get, set
        public string Name // props
        {
            get
            {
                return name;
            }
            set // value - ключове слово для set = значення яке хочемо встановити
            {
                //if (value.Length != 0) // " \t \n"
                //    name = value;
                if (!String.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        //public uint KPD { get { return Damage * hp; } }
        public uint KPD { get => Damage * hp; } // property тільки на читання
    }
}
