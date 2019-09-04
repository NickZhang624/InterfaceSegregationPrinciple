using System;

/*接口隔离原则（Interface segregation Principle
 * 客户端不应该依赖它不需要的接口；一个类对另一个类的依赖应该建立在最小的接口上。
 * the interface-segregation principle (ISP) states that no client should be forced to depend on methods it does not use.
 * 
 * 例子：
 * 一个女生开轿车出去发生车祸，男朋友说以后换一个安全一点的车，换成卡车。开始世界大战，又要给女朋友换一个tank，tank可以run和fire。
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver d = new Driver(new Tank());
            d.Drive();

            ITank tank = new Tank();
            tank.Fire();
        }
    }


    class Driver
    {
        private IVehicle _vehicle;
 
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Run();

        }
    }
    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }
    //类和类只能有一个接口就是子类和父类。接口可以有多个接口。一个类也可以有多个接口
    interface ITank: IVehicle,IWeapon
    {

    }

    interface IWeapon
    {
        void Fire();
    }

    class Tank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Fire!!!!!!");
        }

        public void Run()
        {
            Console.WriteLine("Tank is running");
        }
    }
}



