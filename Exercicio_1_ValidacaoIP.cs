class Program
{
    static void Main(string[] args)
    {
        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
        string[] address;
        bool validLength = false;
        bool validStart = false;
        bool validRange = false;

        foreach (string ip in ipv4Input)
        {
            address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
            ValidateLength();
            ValidateStart();
            ValidateRange();
            if (validLength == true && validStart == true && validRange == true)

                Console.WriteLine($"{ip} É um ip válido.");

            else
                Console.WriteLine($"{ip} nao é um ip válido.");
        }



        void ValidateLength()
        {
            validLength = address.Length == 4;

        }
        void ValidateStart()
        {
            foreach (string value in address)
            {
                if (value.StartsWith("0"))
                {
                    validStart = false;
                    return;
                }
                else
                {
                    validStart = true;
                }
            }
        }
        void ValidateRange()
        {

            foreach (string value in address)
            {
                int number = Int32.Parse(value);
                if (number >= 0 && number < 256)
                    validRange = true;
                else
                    validRange = false;
            }
        }

    }
}