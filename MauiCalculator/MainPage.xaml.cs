using MauiCalculator;

namespace MauiCalculator;

class InputValidate
{
	public static double GetInput(string numText) //Validate that inputs are not empty to avoid zero div
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
	int count = 0; //Clicker counter use for easter egg

	public MainPage()
	{
		InitializeComponent();
	}	
	public string correctNum1="";
	public string correctNum2="";


	private void entryNum1_TextChanged(object sender, TextChangedEventArgs e)
	{
        // Validate entry number 1 is a valid double number
        double NumTemp = 0;
		if(double.TryParse(entryNum1.Text, out NumTemp))
		{
			correctNum1 = entryNum1.Text;  // correct number!!!
		}
		else
		{
			//Highlight the position where a non valid character is input
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
        // Validate entry number 2 is a valid double number
        double NumTemp = 0;
		if (double.TryParse(entryNum2.Text, out NumTemp))
		{
			correctNum2 = entryNum2.Text;  // correct number!!!
		}
		else
        {
            //Highlight the position where a non valid character is input
            entryNum2.CursorPosition = correctNum2.Length;
            int selectionLength = e.NewTextValue.Length - correctNum2.Length;
            if (selectionLength >= 0)
            {
                entryNum2.SelectionLength = selectionLength;
            }
        }
    }
	private void btnAdd_Clicked(object sender, EventArgs e)			//Addition button calculations with input validation
	{
		double Num1 = InputValidate.GetInput(entryNum1.Text);
		double Num2 = InputValidate.GetInput(entryNum2.Text);
		double Result = Num1 + Num2;
		txtResult.Text = Convert.ToString(Result);
	}

	private void btnSubstract_Clicked(object sender, EventArgs e)	//Substraction button calculations with input validation
	{
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 - Num2;
        txtResult.Text = Convert.ToString(Result);
    }

	private void btnMultiply_Clicked(object sender, EventArgs e)    //Multiply button calculations with input validation
    {
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 * Num2;
        txtResult.Text = Convert.ToString(Result);
    }

	private void btnDivide_Clicked(object sender, EventArgs e)      //Divide button calculations with input validation
    {
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Num2 = InputValidate.GetInput(entryNum2.Text);
        double Result = Num1 / Num2;
        txtResult.Text = Convert.ToString(Result);
    }
    private void btnSqr_Clicked(object sender, EventArgs e)			//Square button calculations with input validation
    {
		// Clicked count to display name after 5 times
		count++;
		if (count == 5)
		{
			myName.Text = "Cuauhtemoc";
			count = 0;
		}
		else
			myName.Text = "";
			
	//	SemanticScreenReader.Announce(myName.Text);					//ToDo -- check SematicScreenReader use
			
        double Num1 = InputValidate.GetInput(entryNum1.Text);
        double Result = Num1 * Num1;
        txtResult.Text = Convert.ToString(Result);
    }
}

