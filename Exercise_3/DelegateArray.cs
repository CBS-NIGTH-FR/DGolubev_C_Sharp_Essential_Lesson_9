using System;


namespace Exercise_3
{
    class DelegateArray
    {
        delegate int MyDelegate();
        MyDelegate[] delegates;
        delegate double ArrayDel(MyDelegate[] delegates);
        

        int RND()
        {
            return new Random().Next(100);
        }

        private MyDelegate[] AvNum(int array_length)
        {
            delegates = new MyDelegate[array_length];
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => new MyDelegate(RND).Invoke();
            }
            return delegates;
        }

        private ArrayDel Averege = (MyDelegate[] delegates) => 
        { 
            double av_num = 0;
            for (int i = 0; i < delegates.Length; i++)
            {
                av_num += delegates[i].Invoke();
            }
            return av_num / delegates.Length;
          
        };
        public void Print()
        {
            Console.WriteLine("Введите размер массива");
            int array_length = Convert.ToInt32(Console.ReadLine());
            AvNum(array_length);
            Console.WriteLine(Averege(delegates));
        }
    }
}
