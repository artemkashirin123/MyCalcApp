
namespace MyCalcApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ButtonClear_Clicked(object sender, EventArgs e)
    {
        resultText.Text = "0";
    }
    private void ButtonClearOne_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str.Length <= 1) resultText.Text = "0";
        else resultText.Text = str.Remove(str.Length - 1);
    }
    private void ButtonZero_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else resultText.Text = string.Concat(str, 0);
    }
    private void ButtonOne_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "1";
        else resultText.Text = string.Concat(str, 1);
    }
    private void ButtonTwo_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "2";
        else resultText.Text = string.Concat(str, 2);
    }
    private void ButtonThree_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "3";
        else resultText.Text = string.Concat(str, 3);
    }
    private void ButtonFour_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "4";
        else resultText.Text = string.Concat(str, 4);
    }
    private void ButtonFive_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "5";
        else resultText.Text = string.Concat(str, 5);
    }
    private void ButtonSix_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "6";
        else resultText.Text = string.Concat(str, 6);
    }
    private void ButtonSeven_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "7";
        else resultText.Text = string.Concat(str, 7);
    }
    private void ButtonEight_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "8";
        else resultText.Text = string.Concat(str, 8);
    }
    private void ButtonNine_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "9";
        else resultText.Text = string.Concat(str, 9);
    }
    private void ButtonPlus_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false && str.Contains("^") == false) resultText.Text = string.Concat(str, "+");
    }
    private void ButtonMinus_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false && str.Contains("^") == false) resultText.Text = string.Concat(str, "-");
    }
    private void ButtonUmn_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false && str.Contains("^") == false) resultText.Text = string.Concat(str, "*");
    }
    private void ButtonDelen_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false && str.Contains("^") == false) resultText.Text = string.Concat(str, "/");
    }
    private void ButtonStepen_Clicked(object sender, EventArgs e)
    {
        string str = resultText.Text;
        if (str == "0") resultText.Text = "0";
        else if (str.Contains("+") == false && str.Contains("-") == false && str.Contains("*") == false && str.Contains("/") == false && str.Contains("^") == false) resultText.Text = string.Concat(str, "^");
    }
    private void ButtonRavno_Clicked(object sender, EventArgs e)
    {
        try
        {
            string s = resultText.Text;

            char[] operat = { '+', '-', '*', '/', '^' };

            var data = s.Split(operat, StringSplitOptions.None);
            int arg1 = int.Parse(data[0]);
            int arg2 = int.Parse(data[1]);

            if (s.Contains("-")) resultText.Text = (arg1 - arg2).ToString();
            else if (s.Contains("+")) resultText.Text = (arg1 + arg2).ToString();
            else if (s.Contains("*")) resultText.Text = (arg1 * arg2).ToString();
            else if (s.Contains("/")) resultText.Text = (arg1 / arg2).ToString();
            else
            {
                double result = Math.Pow(arg1, arg2);
                resultText.Text = result.ToString();
            }
        }
        catch (Exception ex)
        {
            //txtCalc.Text = "$#*@%!!!";
            DisplayAlert("Ошибка!", ex.ToString(), "OK");
            resultText.Text = "0";
        }
    }
}

