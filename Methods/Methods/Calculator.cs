using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator
    {
        /***************Method that converts a decimal number to a binary number******************/
        public long Binary(int numberSelected) 
        {
            string bufferBinary="";//This buffer saves the partial result 
            int remainderBinary;//Save the reamainder 
            long binaryReturn;
            //Compare the selected number in order to know if is less than 2
            if (numberSelected < 2)
            {
                binaryReturn = numberSelected;
            }
            else 
            {
                while (numberSelected >0)
                {
                    remainderBinary = numberSelected % 2;//Get the ramainder
                    numberSelected /= 2;
                    bufferBinary = remainderBinary.ToString() + bufferBinary;//Save the partial remainder
                }
                binaryReturn = Convert.ToInt64(bufferBinary);
            }            
            return binaryReturn;
        }

        /***********Method that converts a decimal number to a octal number**************/
        public int Octal(int numberSelected)
        {
            string bufferOctal = "";//This buffer saves the partial result 
            int remainderOctal;//Save the reamainder 
            int octalReturn;
            if (numberSelected < 7 )
            {
                octalReturn = numberSelected;
            }
            else
            {
                while (numberSelected > 0)
                {
                    remainderOctal = numberSelected % 8;//Get the ramainder
                    numberSelected /=  8;
                    bufferOctal = remainderOctal.ToString() + bufferOctal;//Save the partial remainder
                }
                octalReturn = Convert.ToInt32(bufferOctal);
            }
            return octalReturn;
        }

        /*****************Method that converts a decimal number to a hexadecimal number*************/
        public string Hexadecimal(int numberSelected)
        {
            string bufferHex = "";//This buffer saves the partial result 
            int remainderHex;//Save the reamainder 
            string hexReturn;
            if (numberSelected < 9)
            {
                hexReturn = numberSelected.ToString();
            }
            else
            {
                while (numberSelected > 0)
                {
                    remainderHex = numberSelected % 16;   //Get the ramainder                 
                    numberSelected /= 16;
                    string bufferRemainderHex; //This buffer saves the partial hexadecimal alphabetics numbers 
                    switch (remainderHex.ToString())//This switch statement checks if the number is from 10 to 15 to change it in the correspondent letter
                    {
                        case "10":
                            bufferRemainderHex = "A";
                            break;
                        case "11":
                            bufferRemainderHex = "B";
                            break;
                        case "12":
                            bufferRemainderHex = "C";
                            break;
                        case "13":
                            bufferRemainderHex = "D";
                            break;
                        case "14":
                            bufferRemainderHex = "E";
                            break;
                        case "15":
                            bufferRemainderHex = "F";
                            break;
                        default:
                            bufferRemainderHex = remainderHex.ToString();//If the number is less than 10 then takes the remainder number
                            break;
                    }
                    bufferHex = bufferRemainderHex + bufferHex;//Save the partial remainder
                }
                hexReturn = bufferHex;
            }
            return hexReturn;
        }

        /*Method that adds 5 to the number selected*/
        public int AddFive(int numberSelected) 
        {
            numberSelected += 5;
            return numberSelected;
        }

        /*Method that subtract 5 to the number selected*/
        public int SubtractFive(int numberSelected)
        {
            numberSelected -= 5;
            return numberSelected;
        }

        /*Method that multiply 5 to the number selected*/
        public int MultiplyFive(int numberSelected)
        {
            numberSelected *= 5;
            return numberSelected;
        }
    }
}
