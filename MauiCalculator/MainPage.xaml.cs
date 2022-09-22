using MauiCalculator;

namespace MauiCalculator;

class InputValidate
{
	public static double GetInput(string numText)
	{
		double TempNum = 0;

		if (numText != null)
		{
			if (double.TryParse(numText, out TempNum))
			{
				return TempNum; //correct number!!
			}
			else
			{
				return 0;
			}
		}
		else
		{
			return 0;
		}
		}
	}
public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	public string correctNum1="";
	public string correctNum2="";

	private void entryNum1_TextChanged(object sender, TextChangedEventArgs e)
	{
		double NumTemp = 0;
		if(double.TryParse(entryNum1.Text, out NumTemp))
		{
			correctNum1 = entryNum1.Text;  // correct number!!!
		}
		else
		{
			entryNum1.CursorPosition=correctNum1.Length;
			int selectionLength = e.NewTextValue.Length - correctNum1.Length;
			if (selectionLength > 0)
			{
				entryNum1.SelectionLength = selectionLength;
			}
		}
	}

	private void entryNum2_TextChanged(object sender, TextChangedEventArgs e)
	{
        double NumTemp = 0;
        if (double.TryParse(entryNum2.Text, out NumTemp))
        {
            correctNum2 = entryNum2.Text;  // correct number!!!
        }
        else
        {
            entryNum2.CursorPosition = correctNum2.Length;
            int selectionLength = e.NewTextValue.Length - correctNum2.Length;
            if (selectionLength > 0)
            {
                entryNum2.SelectionLength = selectionLength;
            }
        }
    }

	private void btnAdd_Clicked(object sender, EventArgs e)
	{
		double Num1 = InputValidate.GetInput(entryNum1.Text);
		double Num2 = InputValidate.GetInput(entryNum2.Text);
		double Result = Num1 + Num2;
		txtResult.Text = Convert.ToString(Result);
	}

	private void btnSubstract_Clicked(object sender, EventArgs e)
	{
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 - Num2;
        txtResult.Text = Convert.ToString(Result);
    }

	private void btnMultiply_Clicked(object sender, EventArgs e)
	{
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 * Num2;
        txtResult.Text = Convert.ToString(Result);
    }

	private void btnDivide_Clicked(object sender, EventArgs e)
	{
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 / Num2;
        txtResult.Text = Convert.ToString(Result);
    }
}

