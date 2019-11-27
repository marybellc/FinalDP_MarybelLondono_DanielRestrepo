
using Ecuation.Core.Models;
using Ecuation.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ecuation.Core.ViewModels
{
    public class EcuationViewModel : MvxViewModel
    {
        private readonly IEcuationService _ecuationService;
        private double _a;
        private double _b;
        private double _c;
        private RaizType _raizType;
        private double _result;
        private double _result2;
        private MvxCommand _calculateCommand;

        public EcuationViewModel(IEcuationService ecuationService)
        {
            _ecuationService = ecuationService;
        }

        public double A
        {
            get => _a;
            set
            {
                _a = value;
                RaisePropertyChanged(() => A);
                Calculate();
            }
        }
        public double B
        {
            get => _b;
            set
            {
                _b = value;
                RaisePropertyChanged(() => B);
                Calculate();
            }
        }
        public double C
        {
            get => _c;
            set
            {
                _c = value;
                RaisePropertyChanged(() => C);
                Calculate();
            }
        }

        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                RaisePropertyChanged(() => Result);
            }
        }


        public double Result2
        {
            get => _result2;
            set
            {
                _result2 = value;
                RaisePropertyChanged(() => Result2);
            }
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public RaizType raizType
        {
            get => _raizType;
            set
            {
                _raizType = value;
                RaisePropertyChanged(() => raizType);
                Calculate();
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            A = 1;
            B = 3;
            C = 2;

            Calculate();
        }

        private void Calculate()
        {
            Result = _ecuationService.GetEcuation(A, B, C, raizType);
            Result2 = _ecuationService.GetEcuation2(A, B, C, raizType);
        }
    }
}
