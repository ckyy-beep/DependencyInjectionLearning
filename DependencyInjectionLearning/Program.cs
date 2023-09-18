// See https://aka.ms/new-console-template for more information
namespace propertyInjection
{
    public interface Text
    {
        void print();
    }
    class format : Text
    {
        public void print()
        {
            Console.WriteLine("Hello world! play valorant!");
        }
    }
    public class constructorinjection
    {
        private Text _text;
        public constructorinjection(Text t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }

    class constructor
    {
        static void main(String[] args)
        {
            constructorinjection cs = new constructorinjection(BinaryWriter format());
            cs.print();
            Console.ReadKey();
        }
    }
}
