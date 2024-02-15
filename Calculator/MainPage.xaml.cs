namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        string mainDisplayText;
        int firstNumber;
        int secondNumber;
        string calculatingMethod;

        public MainPage()
        {
            InitializeComponent();
        }

        public void updateDisplay()
        {
            mainDisplay.Text = mainDisplayText;
        }

        private void NumberButton1_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "1";
            updateDisplay();

        }

        private void NumberButton2_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "2";
            updateDisplay();

        }

        private void NumberButton3_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "3";
            updateDisplay();

        }

        private void NumberButton4_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "4";
            updateDisplay();

        }

        private void NumberButton5_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "5";
            updateDisplay();

        }

        private void NumberButton6_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "6";
            updateDisplay();

        }

        private void NumberButton7_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "7";
            updateDisplay();

        }

        private void NumberButton8_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "8";
            updateDisplay();

        }

        private void NumberButton9_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "9";
            updateDisplay();

        }

        private void NumberButton0_Clicked(object sender, EventArgs e)
        {
            mainDisplayText += "0";
            updateDisplay();

        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            mainDisplayText = "";
            firstNumber = 0;
            secondNumber = 0;
            calculatingMethod = "";
            updateDisplay();
        }

        private void FuntionButtonPlus_Clicked(object sender, EventArgs e)
        {
            if(firstNumber == 0)
            {
                firstNumber = int.Parse(mainDisplayText);
            }

            calculatingMethod = "plus";

            mainDisplayText = "";

            //System.Diagnostics.Debug.WriteLine(firstNumber);
        }

        private void FunctionButtonMinus_Clicked(object sender, EventArgs e)
        {
            if (firstNumber == 0)
            {
                firstNumber = int.Parse(mainDisplayText);
            }

            calculatingMethod = "plus";

            mainDisplayText = "";
        }

        private void FunctionButtonEqual_Clicked(object sender, EventArgs e)
        {
            if (firstNumber == 0) 
            {
                System.Diagnostics.Debug.WriteLine("There was no calculation function selected.");
                return;
            }

            if(mainDisplayText == "")
            {
                System.Diagnostics.Debug.WriteLine("Second number needed.");
                return;
            }

            secondNumber = int.Parse(mainDisplayText);

            switch(calculatingMethod)
            {
                case "plus":
                    int resultNumber = firstNumber + secondNumber;
                    mainDisplayText = $"{resultNumber}";
                    updateDisplay();
                    break;
            }
        }

        
    }

}
