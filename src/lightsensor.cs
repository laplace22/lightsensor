using System;
using Windows.Devices.Sensors;

namespace LightSensorPlugin
{
    class LightSensorPlugin
    {
        static void Main(string[] args) 
        {
            if(args != null) {
                if(args.Length==0){
                    LightSensor sensor = LightSensor.GetDefault();
                    if(sensor!=null){
                        LightSensorReading reading = sensor.GetCurrentReading();
                        if(reading!=null){
                            Console.Write("Lux.value ");
                            Console.Write(reading.IlluminanceInLux);
                            Console.Write("\n");
                            Console.Write(".\n");
                        }
                    }
                } else if(args[0]=="config") {
                    Console.Write("graph_title brightness_of_room\n");
                    Console.Write("graph_category Room\n");
                    Console.Write("graph_vlabel Lux\n");
                    Console.Write("Lux.label Lux\n");
                    Console.Write(".\n");
                } else if(args[0]=="name") {
                    Console.Write("Lux\n");
                }
            }
        }
    }
}
/* vim: set expandtab sw=4 : */
