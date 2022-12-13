namespace TemperatureConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature("cels", 202.50f);
        }
        static void Temperature(string unit, float temp)
        {
            float cel = 0;
            float fah = 0;
            float kel = 0;
            float ran = 0;
            float del = 0;
            float newt = 0;
            float rea = 0;
            float rom = 0;

            switch (unit)
            {
                case "cel":
                    cel = temp;
                    fah = temp * 1.8f + 32;
                    kel = temp + 273.15f;
                    ran = (temp + 273.15f) * 1.8f;
                    del = (100 - temp) * 1.5f;
                    newt = temp * 0.33f;
                    rea = temp * 0.8f;
                    rom = temp * 0.525f + 7.5f;
                    break;
                case "fah":
                    cel = (temp - 32) * 1.8f;
                    fah = temp;
                    kel = (temp + 459.67f) * 1.8f;
                    ran = temp + 459.67f;
                    del = (212 - temp) * 0.83f;
                    newt = (temp - 32) * 0.183f;
                    rea = (temp - 32) * 0.44f;
                    rom = (temp - 32) * 0.291f;
                    break;
                case "kel":
                    cel = temp - 273.15f;
                    fah = temp * 1.8f - 459.67f;
                    kel = temp;
                    ran = temp * 1.8f;
                    del = (375.15f - temp) * 1.5f;
                    newt = (temp - 273.15f) * 0.33f;
                    rea = (temp - 273.15f) * 0.8f;
                    rom = (temp - 273.15f) * 0.525f + 7.5f;
                    break;
                case "ran":
                    cel = (temp - 491.67f) * 1.8f;
                    fah = temp - 459.67f;
                    kel = temp - 459.67f;
                    ran = temp;
                    del = (671.67f - temp) * 0.83f;
                    newt = (temp - 491.67f) * 0.183f;
                    rea = (temp - 491.67f) * 0.44f;
                    rom = (temp - 491.67f) * 0.291f + 7.5f;
                    break;
            }
        }
    }
}