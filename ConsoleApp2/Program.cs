using System;

/*这是接口隔离原则的第三个例子，显示接口事件
 * 意思就是在某一些情况下，当你不用这个接口的时候就会隐藏起来，等你使用的时候就会自动调出
 * 例子就是这个杀手不太冷的杀手，同时有kill和lova两种属性
 * */
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new WarmKiller();
            //v.Kill();
            v.Love();
            /*这里的v.能同时显示kill和love两个属性，逻辑上没有问题，但是现实是这个杀手在街上的时候要隐藏自己的杀手属性
            *所以要refactor
            * 方法就是class 里面生成方法的时候要用 implement interface explicitly（可以看到viod前面没有了public）
            * 然后在main里面实例化一个killer，在调用属性,如下code
            * */
            IKIller k = new WarmKiller();
            k.Kill();
        }
    }

    interface IGentleman
    {
        void Love();

    }

    interface IKIller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKIller
    {


        public void Love()
        {
            Console.WriteLine("Love");
        }

        void IKIller.Kill()
        {
            Console.WriteLine("kill");
        }
    }
}
