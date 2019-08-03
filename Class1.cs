using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс для поставки внешним клиентам
    /// </summary>
    public class Class1
    {
        #region Площадь круга и площадь треугольника по 3 сторонам
        ///<summary>Площадь круга</summary>
        ///<param name="_radius">Радиус круга</param>
        public static string AreaCircle(double _radius)
        {
            if (_radius < 0) Bin.ModulNumber(ref _radius);
            return $"Круг площадью {(Math.PI * Math.Pow(_radius, 2))}";
        }
        ///<summary>Площадь круга</summary>
        ///<param name="_radius">Радиус круга</param>
        public static string AreaCircle(int _radius)
        {
            if (_radius < 0) Bin.ModulNumber(ref _radius);
            return $"Круг площадью {(Math.PI * Math.Pow(_radius, 2))}";
        }
        //Площадь треугольника по 3 сторонам
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="a">Сторона А</param>
        ///<param name="b">Сторона B</param>
        ///<param name="c">Сторона С</param>
        public static string AreaTriangle(double a, double b, double c)
        {
            
            Bin.ModulNumber(ref a,ref b,ref c);
            var _p = a + b + c;
            return $"{Bin.RightTriangle(a,b,c)} площадью {(Math.Sqrt(_p * (_p - a) * (_p - b) * (_p * c)))}";
        }
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="a">Сторона А</param>
        ///<param name="b">Сторона B</param>
        ///<param name="c">Сторона С</param>
        public static string AreaTriangle(int a, int b, int c)
        {
            Bin.ModulNumber(ref a, ref b, ref c);
            var _p = a + b + c;
            return $"{Bin.RightTriangle(a, b, c)} площадью {(Math.Sqrt(_p * (_p - a) * (_p - b) * (_p * c)))}";
        }
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_params">Массив должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AreaTriangle(double[] _params)
        {
            if (_params.Length > 3) return "Неизвестно";
            else if(_params.Length<3) return "Неизвестно";
            Bin.ModulNumber(ref _params);
            double a = _params[0];double b = _params[1];double c = _params[2];
            double _p = a + b + c;
            return $"{Bin.RightTriangle(_params)} площадью {(Math.Sqrt(_p * (_p - a) * (_p - b) * (_p * c)))}";
        }
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_params">Массив должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AreaTriangle(int[] _params)
        {
            if (_params.Length > 3) return "Неизвестно";
            else if (_params.Length < 3) return "Неизвестно";
            Bin.ModulNumber(ref _params);
            double a = _params[0]; double b = _params[1]; double c = _params[2];
            double _p = a + b + c;
            return $"{Bin.RightTriangle(_params)} площадью {(Math.Sqrt(_p * (_p - a) * (_p - b) * (_p * c)))}";
        }
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_list">Список должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AreaTriangle(List<double> _list)
        {
            if (_list.Count > 3) return "Неизвестно";
            double[] _params = { _list[0], _list[1], _list[2] };
            return AreaTriangle(_params); ;
        }
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_list">Список должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AreaTriangle(List<int> _list)
        {
            if (_list.Count > 3) return "Неизвестно";
            int[] _params = { _list[0], _list[1], _list[2] };
            return AreaTriangle(_params); ;
        }
        #endregion
    }
    class Bin
    {
        public static string RightTriangle(double a,double b,double c)
        {
            if (Math.Pow(a, 2) ==(Math.Pow(b,2) + Math.Pow(c,2)))
            {
                return "Прямоугольный треугольник";
            }
            if (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)))
            {
                return "Прямоугольный треугольник";
            }
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                return "Прямоугольный треугольник";
            }
            return "Треугольник";
        }
        public static string RightTriangle(int a, int b, int c) => RightTriangle(Convert.ToDouble(a)
            , Convert.ToDouble(b), Convert.ToDouble(c));
        public static string RightTriangle(double[] _vector) => RightTriangle(_vector[0], _vector[1], _vector[2]);
        public static string RightTriangle(int[] _vector) => RightTriangle(_vector[0], _vector[1], _vector[2]);
        public static void ModulNumber(ref double a,ref double b,ref double c)
        {
            if (a < 0) a = Math.Abs(a);
            if (b < 0) b = Math.Abs(b);
            if (c < 0) c = Math.Abs(c);
        }
        public static void ModulNumber(ref int a, ref int b, ref int c)
        {
            if (a < 0) a = Math.Abs(a);
            if (b < 0) b = Math.Abs(b);
            if (c < 0) c = Math.Abs(c);
        }
        public static void ModulNumber(ref double[] _vector)
        {
            for (int i = 0; i < _vector.Length; i++)
            {
                if (_vector[i] < 0)
                {
                    _vector[i] = Math.Abs(_vector[i]);
                }
            }
        }
        public static void ModulNumber(ref int[] _vector)
        {
            for (int i = 0; i < _vector.Length; i++)
            {
                if (_vector[i] < 0)
                {
                    _vector[i] = Math.Abs(_vector[i]);
                }
            }
        }
        public static void ModulNumber(ref int a)
        {
            a = Math.Abs(a);
        }
        public static void ModulNumber(ref double a)
        {
            a = Math.Abs(a);
        }

    }
    public class AcyncClass1
    {
        #region Методы, возвращающие строку
        ///<summary>Площадь круга</summary>
        ///<param name="_radius">Радиус круга</param>
        public static string AsyncAreaCircle(double _radius)=> AreaCircle(_radius).Result;
        ///<summary>Площадь круга</summary>
        ///<param name="_radius">Радиус круга</param>
        public static string AsyncAreaCircle(int _radius) => AreaCircle(_radius).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="a">Сторона А</param>
        ///<param name="b">Сторона B</param>
        ///<param name="c">Сторона С</param>
        public static string AsyncAreaTriangle(double a, double b, double c) => AreaTriangle(a, b, c).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="a">Сторона А</param>
        ///<param name="b">Сторона B</param>
        ///<param name="c">Сторона С</param>
        public static string AsyncAreaTriangle(int a, int b, int c) => AreaTriangle(a, b, c).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_params">Массив должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AsyncAreaTriangle(double[] _params) => AreaTriangle(_params).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_params">Массив должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AsyncAreaTriangle(int[] _params) => AreaTriangle(_params).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_list">Список должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AsyncAreaTriangle(List<double>_list) => AreaTriangle(_list).Result;
        ///<summary>Метод расчитывает плозадь треугольника по 3 сторонам (если есть отрицательное значение
        ///то значение будет взято по модулю)</summary>
        ///<param name="_list">Список должен быть размерностью 3, иначе возвращает "Неизвестно"</param>
        public static string AsyncAreaTriangle(List<int> _list) => AreaTriangle(_list).Result;
        #endregion

        #region Методы расчета
        private static async Task<string> AreaCircle(double _radius)=> await Task<string>.Run(() => Class1.AreaCircle(_radius));
        private static async Task<string> AreaCircle(int _radius) => await Task<string>.Run(() => Class1.AreaCircle(_radius));
        private static async Task<string> AreaTriangle(double a, double b, double c)=> await Task.Run(() => Class1.AreaTriangle(a, b, c));
        private static async Task<string> AreaTriangle(int a, int b, int c)=> await Task.Run(() => Class1.AreaTriangle(a, b, c));
        private static async Task<string> AreaTriangle(double[] _params)=> await Task.Run(() => Class1.AreaTriangle(_params));
        private static async Task<string> AreaTriangle(int[] _params)=> await Task.Run(() => Class1.AreaTriangle(_params));
        private static async Task<string> AreaTriangle(List<double> _list)=> await Task.Run(() => Class1.AreaTriangle(_list));
        private static async Task<string> AreaTriangle(List<int> _list)=> await Task.Run(() => Class1.AreaTriangle(_list));
        #endregion
    }
}
