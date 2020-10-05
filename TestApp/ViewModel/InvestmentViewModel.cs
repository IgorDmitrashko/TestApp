using DevExpress.Mvvm;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace TestApp.ViewModel
{
    class InvestmentViewModel : DependencyObject
    {
        public double StartCount
        {
            get { return (double)GetValue(_StartCount); }
            set { SetValue(_StartCount, value); }
        }
        public static readonly DependencyProperty _StartCount =
            DependencyProperty.Register("SumValue", typeof(double), typeof(InvestmentViewModel));

        public double Percent
        {
            get { return (double)GetValue(_Percent); }
            set { SetValue(_Percent, value); }
        }



        public static readonly DependencyProperty _Percent =
            DependencyProperty.Register("PercentValue", typeof(double), typeof(InvestmentViewModel));

        public int Years
        {
            get { return (int)GetValue(_Years); }
            set { SetValue(_Years, value); }
        }
        public static readonly DependencyProperty _Years =
            DependencyProperty.Register("YearsValue", typeof(int), typeof(InvestmentViewModel));

        public double Total
        {
            get { return (double)GetValue(_Total); }
            set { SetValue(_Total, value); }
        }
        public static readonly DependencyProperty _Total =
            DependencyProperty.Register("Total", typeof(double), typeof(InvestmentViewModel));

        public ICommand Calculate
        {
            get
            {
                return new DelegateCommand(() => {
                    double stastcount = StartCount;
                    StartCount = StartCount * Math.Pow((1 + (Percent / 100)), Years);
                    Total = Math.Round(StartCount, 2) - stastcount;
                });
            }
        }
    }
}
