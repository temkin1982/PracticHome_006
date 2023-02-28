namespace PracticHome007
{
    
    public class Phone
    {
        public string model;
        public int number;
        public double weight;
        
        

        public void PhoneStats()
        {
            Console.WriteLine($"The model name Phone: {model}\nNumber Phone: {number}  \nand weight Phone is: {weight} gram");
        }
        public void receiveCall(string nameCall)
        {
            Console.WriteLine($"You have call from {nameCall}");
        }

        public Phone (double weightPhone) : this("MaxPro" ,0509015021)
        {

            
            weight = weightPhone;

        }
        public Phone (string modelPhone, int numberPhone)
        {

            this.model = modelPhone;
            this.number = numberPhone;

        }
        public void ShowStats()
        {
            Console.WriteLine($"The model name Phone: {model}\nNumber Phone: {number}");
        }
        public void receiveCall(string nameCall, int number)
        {
            var result = nameCall.ToString() + number;
           
            Console.WriteLine($"You have call from {nameCall} number call {number}");
            return;
        }




        //конструктор без параметров.
        //public Phone()
        //{

        //}
        public void Care(int number)
        {
            Console.WriteLine(number);

        }

        
        public void Care(ref int speed)
        {
            speed = speed + 12;
            Console.WriteLine(speed);
        }
       
        public void Care(long mull  )
        {
            mull = mull * 2;
            Console.WriteLine(mull);
        }
    
    
    
    
    
    
    
    
    
        

    }   
}
