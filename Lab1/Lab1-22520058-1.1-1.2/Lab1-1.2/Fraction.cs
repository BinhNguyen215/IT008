using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1._2
{ 
    public class Fraction : IComparable<Fraction>
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Mẫu số (denominator) không thể bằng 0.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            simplify();
        }

        // ngầm định từ số nguyên ra phân số
        public static implicit operator Fraction(int num)
        {
            return new Fraction(num, 1);
        }

        // tường minh từ phân số ra số thực
        public static explicit operator double(Fraction fraction)
        {
            return (double)fraction.numerator / fraction.denominator;
        }

        public int Numerator
        {
            get { return numerator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public int CompareTo(Fraction other)
        {
            // đổi cả hai phân số về cùng mẫu số trước khi so sánh
            int commonDenominator = this.denominator * other.denominator;
            int thisNumerator = this.numerator * other.denominator;
            int otherNumerator = other.numerator * this.denominator;

            return thisNumerator.CompareTo(otherNumerator);
        }

        // Các toán tử +, -, *, /
        public static Fraction operator +(Fraction left, Fraction right)
        {
            int commonDenominator = left.denominator * right.denominator;
            int newNumerator = (left.numerator * right.denominator) + (right.numerator * left.denominator);
            return new Fraction(newNumerator, commonDenominator);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            int commonDenominator = left.denominator * right.denominator;
            int newNumerator = (left.numerator * right.denominator) - (right.numerator * left.denominator);
            return new Fraction(newNumerator, commonDenominator);
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            int newNumerator = left.numerator * right.numerator;
            int newDenominator = left.denominator * right.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            if (right.numerator == 0)
            {
                throw new DivideByZeroException("Không thể chia cho 0.");
            }
            int newNumerator = left.numerator * right.denominator;
            int newDenominator = left.denominator * right.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        // Các phép so sánh ==,!=,>,<
        public static bool operator ==(Fraction left, Fraction right)
        {
            return left.CompareTo(right) == 0;
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return left.CompareTo(right) != 0;
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Fraction left, Fraction right)
        {
            return left.CompareTo(right) > 0;
        }

        private int gCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void simplify()
        {
            int gcd = gCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            // Đảm bảo mẫu số > 0
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction otherFraction)
            {
                return this.CompareTo(otherFraction) == 0;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
    }

}
