using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    struct Rational
    {
        public bool Equals(Rational other)
        {
            return _denominator == other._denominator && _numerator == other._numerator;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return _denominator*_numerator;
            }
        }

        private int _denominator;
        private int _numerator;
        public Rational(int numerator, int denominator)
        {
            _denominator = denominator;
            if (numerator == 0)
            {
                _numerator = 1;
            }
            else
            {
                _numerator = numerator;
            }
        }

        public Rational(int numerator) : this(numerator, 1)
        {
        }

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public double Decimalvalue
        {
            get { return  (Convert.ToDouble(_numerator)/Convert.ToDouble(_denominator)); }
            set { }
            
        }

        public Rational AddRational(Rational first)
        {
            Rational newRational;
            newRational._numerator = (first._numerator*this._denominator) + (this._numerator*first._denominator);
            newRational._denominator = first._denominator*this._denominator;
            return newRational;
        }
        public Rational SubtractRational(Rational first)
        {
            Rational newRational;
            newRational._numerator = (first._numerator * this._denominator) - (this._numerator * first._denominator);
            newRational._denominator = first._denominator * this._denominator;
            return newRational;
        }
        public Rational MulRational(Rational first)
        {
            Rational newRational;
            newRational._numerator = (first.ReduceRational()._numerator * this.ReduceRational()._numerator);
            newRational._denominator = first.ReduceRational()._denominator * this.ReduceRational()._denominator;
            return newRational;
        }

        public Rational DevideRational(Rational first)
        {
            Rational newRational;
            newRational._numerator = (first.ReduceRational()._numerator * this.ReduceRational()._denominator);
            newRational._denominator = first.ReduceRational()._denominator * this.ReduceRational()._numerator;
            return newRational;
        }

        public Rational ReduceRational()
        {
            for (int i = 2; i < 50; i++)
            {
                if (this._numerator % i == 0 && this._denominator % i == 0)
                {
                    this._numerator = this._numerator / i;
                    this.Denominator = this.Denominator / i;
                    ReduceRational();
                }
            }
            return this;
        }

        public override string ToString()
        {

            StringBuilder rationalToString = new StringBuilder();
            rationalToString.Append(Numerator);
            rationalToString.Append("/");
            rationalToString.Append(_denominator);
            return rationalToString.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }


            Rational secondRational = obj is Rational ? (Rational) obj : new Rational();

            this.ReduceRational();
            secondRational.ReduceRational();
            return (Numerator == secondRational.Numerator) && (Denominator == secondRational.Denominator);
        }

        public static Rational operator +(Rational lhs, Rational r)
        {
            return lhs.AddRational(r);
        }
        public static Rational operator -(Rational lhs, Rational r)
        {
            return lhs.SubtractRational(r);
        }
        public static Rational operator /(Rational lhs, Rational r)
        {
            return lhs.DevideRational(r);
        }
        public static Rational operator *(Rational lhs, Rational r)
        {
            return lhs.MulRational(r);
        }
    }
}
