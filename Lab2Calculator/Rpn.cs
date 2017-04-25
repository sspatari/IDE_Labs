using System;
using System.Collections.Generic;


namespace Lab2Calculator
{
    class Rpn 
    {
        static public double Calculate(string input)
        {
            try { return double.Parse(GetExpression(input));}
            catch (Exception) { return Counting(GetExpression(input));}
        }

        static private string GetExpression(string input)
        {
            string output = string.Empty; 
            string fun = string.Empty; 
            Stack<char> operStack = new Stack<char>();
            char k = ' '; string p = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (IsOperator(input[i]) || Char.IsDigit(input[i]))
                {
                    if (k == ' ')
                        k = input[i];
                    else if (input[i] == '-' && !Char.IsDigit(k))
                        p += " 0 ";
                    k = input[i];
                }         
                p += input[i];
            }
            input = p;
            for (int i = 0; i < input.Length; i++) 
            {
                if (IsDelimeter(input[i]))
                    continue;
                if (Char.IsDigit(input[i])) 
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i]; 
                        i++;
                        if (i == input.Length) break; 
                    }
                    output += " "; 
                    i--; 
                }
                else if (IsOperator(input[i])) 
                {
                    if (input[i] == '(') 
                        operStack.Push(input[i]); 
                    else if (input[i] == ')')
                    {
                        char s = operStack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0) 
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop().ToString() + " "; 

                        operStack.Push(char.Parse(input[i].ToString()));

                    }
                }
                else if (input[i] == '\u03C0')
                    output += " \u03C0 ";
                else
                {
                    fun = String.Empty;
                    while (input[i] != '(')
                    {
                        fun += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    i++;
                    if (IsFunction(fun))
                    {
                        String param = String.Empty;
                        while (input[i] != ')')
                        {
                            param += input[i];
                            i++;
                            if (i == input.Length) break; 
                        }
                        double d;
                        try { d = double.Parse(param); }
                        catch (Exception) { d = Counting(GetExpression(param)); }
                        output += doFunc(fun, d);
                    }
                }
            }
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";
                System.Console.WriteLine("output " + output);
                return output;
        }

        static private double Counting(string input)
        {
            System.Console.WriteLine("input " + input);
            double result = 0;
            double b = 0;
            Stack<double> temp = new Stack<double>(); 
            try {
                System.Console.WriteLine("parse " + double.Parse(input));
                return double.Parse(input); }
            catch (Exception)
            {
                for (int i = 0; i < input.Length; i++) 
                {
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i])) 
                        {
                            a += input[i];
                            i++;
                            if (i == input.Length) break;
                        }
                        temp.Push(double.Parse(a)); 
                        i--;
                    }
                    else if (input[i] == '\u03C0')
                        temp.Push(Math.PI);
                    else if (IsOperator(input[i])) 
                    {
                        double a = temp.Pop();
                        try
                        { b = temp.Pop(); }
                        catch (Exception) { b = 0; }

                        switch (input[i])
                        {
                            case '^': result = Math.Pow(b,a); break;
                            case '+': result = b + a; break;
                            case '-': result = b - a; break;
                            case '*': result = b * a; break;
                            case '/': if (a == 0) throw new DividedByZeroException(); else result = b / a; break;
                        }
                        temp.Push(result);
                    }
                }
                try {
                    System.Console.WriteLine("result " + temp.Peek());
                    return temp.Peek(); }
                catch (Exception) { throw new SyntaxException(); }
                
            }
            
        }
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        static private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }
        static private bool IsFunction(String s)
        {
            String[] func = { "sqrt"};
            if (Array.Exists(func, e => e == s))
                return true;
            return false;
        }
        static private String doFunc(String fun,double param)
        {
            switch (fun)
            {
                case "sqrt": if (param < 0) throw new SqrtException(param); else return Math.Sqrt(param).ToString();
                default: return "";
            }
        }
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 4;
            }
        }
    }
    public class MyException : Exception
    {
        public string type;
    }

    public class SqrtException : MyException
    {
        public SqrtException(double x)
        {
            this.type = "Math error";
        }
    }
    public class DividedByZeroException : MyException
    {
        public DividedByZeroException()
        {
            this.type = "Math erro Division by zero";
        }
    }
   
    public class SyntaxException : MyException
    {
        public SyntaxException()
        {
            this.type = "Syntax error";
        }
    }
}
