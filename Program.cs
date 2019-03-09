using System;

namespace CodingChallenge1
{
    public class Program
    {
        public static string FindFirstNonRepeated(string charstring)
        {
            charstring = "abcabd";
            string[] chararray = charstring.Split();

            ////dictionaries
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            var e = 0;
            var f = 0;
            var g = 0;
            for (int i = 0; i <= charstring.Length; i++)
            {
                if (chararray[i] == "a") {
                    a++;
                    if (a == 1)
                    {
                        return "a";
                    }
                }
                if (chararray[i] == "b")
                {
                    b++;
                    if (b == 1)
                    {
                        return "b";
                    }
                }
                if (chararray[i] == "c")
                {
                    c++;
                    if (c == 1)
                    {
                        return "c";
                    }
                }
                if (chararray[i] == "d")
                {
                    d++;
                    if (d == 1)
                    {
                        return "d";
                    }
                }
                if (chararray[i] == "e")
                {
                    e++;
                    if (e == 1)
                    {
                        return "e";
                    }
                }
                if (chararray[i] == "f")
                {
                    f++;
                    if (f == 1)
                    {
                        return "f";
                    }
                }
                if (chararray[i] == "g")
                {
                    g++;
                    if (g == 1)
                    {
                        return "g";
                    }
                }
                if (a != 1 && b != 1 && c != 1 && d != 1 && e != 1 && f != 1 && g != 1)
                {
                    return "_";
                }
                else return "_";
            } 
            return "poop";
        }
    }
}
