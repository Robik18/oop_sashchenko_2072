using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rational
    {
        int numer, denom;
        public Rational(int num, int den)
        {
            this.numer = num;
            this.denom = den;
        }
        public static Rational operator +(Rational rational1, Rational rational2)
        {
            if (rational1.denom == 0 || rational2.denom == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.numer * rational2.denom + rational2.numer * rational1.denom;
            denResult = rational1.denom * rational2.denom;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator -(Rational rational1, Rational rational2)
        {
            if (rational1.denom == 0 || rational2.denom == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.numer * rational2.denom - rational2.numer * rational1.denom;
            denResult = rational1.denom * rational2.denom;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator *(Rational rational1, Rational rational2)
        {
            if (rational1.denom == 0 || rational2.denom == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.numer * rational2.numer;
            denResult = rational1.denom * rational2.denom;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator /(Rational rational1, Rational rational2)
        {
            if (rational1.denom == 0 || rational2.denom == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult = rational1.numer * rational2.denom;
            int denResult = rational1.denom * rational2.numer;
            if (numResult == Math.Abs(0) || denResult == Math.Abs(0))
            {
                throw new DivideByZeroException();
            }
            Rational rational = new Rational(numResult, denResult);
            return rational;
        }
        public override string ToString()
        {
            string result = "";
            if (this.numer != this.denom)
            {
                result = $"{this.numer} / {this.denom}";
            }
            if (this.numer == Math.Abs(0))
            {
                result = $"{0}";
            }
            if (this.denom == 1)
            {
                result = $"{this.numer}";
            }
            return result;
        }
        public Rational Reduction()
        {
            int numResult = Math.Abs(this.numer);
            int denResult = Math.Abs(this.denom);
            if (numResult != denResult && numResult != 0)
            {
                while (numResult != denResult)
                {
                    if (numResult > denResult)
                    {
                        numResult = numResult - denResult;
                    }
                    else
                    {
                        denResult = denResult - numResult;
                    }
                }
                int nod = numResult;
                numResult = this.numer / nod;
                denResult = this.denom / nod;
            }
            else if (numResult == denResult)
            {
                numResult = numResult / numResult;
                denResult = denResult / denResult;
            }
            Rational result = new Rational(numResult, denResult);
            return result;
        }
    }
}
