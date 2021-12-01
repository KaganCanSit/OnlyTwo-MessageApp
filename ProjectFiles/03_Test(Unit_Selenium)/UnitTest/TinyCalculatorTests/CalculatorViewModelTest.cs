using System;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyCalculator;

namespace TinyCalculatorTests
{
    [TestClass]
    public class CalculatorViewModelTest
    {
        [TestMethod]
        public void CanCreateViewModel()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
        }

        [TestMethod]
        public void CanInputSum()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.Input = "1+1";
            Assert.AreEqual("1+1", viewModel.Input);
        }

        [TestMethod]
        public void CanExecuteCalculateCommand()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.Input = "1+1";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
        }

        [TestMethod]
        public void CanCalculateTwoPlusTwo()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.Input = "2+2";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
            Assert.AreEqual(4, viewModel.Result);
        }

        [TestMethod]
        public void CanCalculateFiveTimesSeven()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            viewModel.Input = "5*7";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
            Assert.AreEqual(35, viewModel.Result);
        }

        [TestMethod]
        public void ResultChangeNotificationIsFired()
        {
            CalculatorViewModel viewModel = new CalculatorViewModel();
            bool hasFired = false;
            viewModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Result")
                    hasFired = true;
            };

            viewModel.Input = "5*7";
            ICommand command = viewModel.CalculateCommand;
            command.Execute(null);
            Assert.IsTrue(hasFired);
        }
    }
}
