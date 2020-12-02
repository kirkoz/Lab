using NUnit.Framework;
using Program = Calc.Calc;

[assembly: Parallelizable(ParallelScope.All)]
namespace CalcTestProject
{
    public class Tests
    {
        [Test(Description = "�������� ������������ �������� ���� ����� �����"), TestCaseSource("TestValuesPlus")]
         public void PlusTest(int a, int b, int c)
        {
            Assert.AreEqual(c, Program.Plus(a, b), "a = {0}, b = {1}, a + b = {2}", a, b, Program.Plus(a, b));
        }
        static object[] TestValuesPlus =
        {
            new object [] { 6, 5, 11 },
            new object [] { 5, 0, 5 },
            new object [] { -13, -12, -25 },
            new object [] { -22, 10, -12 },
            new object [] { 33, -15, 18 },
            new object [] { 14, 18, 32 },
        };
        
        [Test(Description = "�������� ������������ ���������� �������� ���� ����� �����"), TestCaseSource("TestValuesDiff")]
        public void DiffrenceTest(int a, int b, int c)
        {
            Assert.AreEqual(c, Program.Diffrence(a, b), "a = {0}, b = {1}, a - b = {2}", a, b, Program.Diffrence(a, b));
        }
        static object[] TestValuesDiff =
        {
            new object [] { 7, 5, 2 },
            new object [] { -30, -22, -8 },
            new object [] { -20, 10, -30 },
            new object [] { 0, 14, -14 },
            new object [] { 15, 0, 15 },
            new object [] { 15, 11, 4 },
        };
        
        [Test(Description = "�������� ������������ ���������� ������������ ���� ����� �����"), TestCaseSource("TestValuesMult")]
        public void �ultiplicationTest(int a, int b, int c)
        {
            Assert.AreEqual(c, Program.�ultiplication(a, b), "a = {0}, b = {1}, a * b = {2}", a, b, Program.�ultiplication(a, b));
        }
        static object[] TestValuesMult =
        {
            new object [] { 2, 6, 12 },
            new object [] { 11, 3, 33 },
            new object [] { -4, -11, 44 },
            new object [] { -10, 12, -120 },
            new object [] { 15, 0, 0 },
        };
        [Test(Description = "�������� ������������ ���������� �������� ���� ����� �����"), TestCaseSource("TestValuesDivision")]       
        public void DivisionTest(int a, int b, int c)
        {
            Assert.AreEqual(c, Program.Division(a, b), "a = {0}, b = {1}, a / b = {2}", a, b, Program.Division(a, b));
        }
        static object[] TestValuesDivision =
        {
            new object [] { 6, 2, 3 },
            new object [] { 12, 2, 6 },
            new object [] { -14, -7, 2 },
            new object [] { 20, -2, -10 },
            new object [] { 0, 5, 0 },
        };

        [TestCase(3, 0, TestName = "������� �� 0", Description = "��� ������� ������� �� ���� ����� Division ������ ���������� ���������� �������������� �������� DivideByZeroException")]
        public void DivisionTest(int a, int b)
        {
            Assert.Throws<System.DivideByZeroException>(() => Program.Division(a, b));
        }
    }
}