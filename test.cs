using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

class HelloWorld {
  static void Main() {
    string test = "이여름바닷가";
   string result = ToStringToHex(test);
   //암호화
   string test2 = "" //http://t.dgl.kr/seed/%5B02%5D%20CBC/ 여기서  result값을 2번에 입력
   string test2_2 =  test2.Replace(",", "");

   //string
   string result2 =  ToHexString(test2_2);

    string result3 =  ConvertToBase64String(result2);

    Console.WriteLine(result);
    Console.WriteLine(result2);
    Console.WriteLine(result3);
  }
  
  
public static string ToHexString(string hexString)
{

    byte[] myBytes = new byte[hexString.Length / 2];
    for (var i = 0; i < myBytes.Length; i++)
    {
        // Convert the number expressed in base-16 to an integer. 
        int value = Convert.ToInt32(hexString.Substring(i * 2, 2), 16);

        myBytes[i] = (byte)value;

    }
   return Encoding.Default.GetString(myBytes);
}

  public static string ToStringToHex(string plainText)
        {
            string result = string.Empty;
            int index = 0;
            foreach (byte byteStr in Encoding.Default.GetBytes(plainText))
            {
                if(index == 0) {
                     result += string.Format("{0:X2}", byteStr);
                } else {
                    result +=  ','+string.Format("{0:X2}", byteStr);
                }
               
                index++;
            }
            return result;
        }



public static string ConvertToBase64String(string plainText)
        {
           var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
           
        }

            
}
