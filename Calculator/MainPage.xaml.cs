namespace Calculator;

public partial class MainPage : ContentPage
{
	double num1;
	double num2;
    string op = "";
    bool ansShown = false;

	public MainPage()
	{
		InitializeComponent();
	}

    public void ZeroClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "0";
            ansShown = false;
        }
        else if (output.Text != "0")
        {
            output.Text = output.Text + "0";
        }
        else
        {
            output.Text = "0";
        }
    }
	public void OneClicked(object sender, EventArgs e)
	{   
        if (ansShown)
        {
            output.Text = "1";
            ansShown = false;
        }
		else if (output.Text != "0")
			output.Text = output.Text + "1";
		else
			output.Text = "1";
	}

    public void TwoClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "2";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "2";
        else
            output.Text = "2";
    }
    public void ThreeClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "3";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "3";
        else
            output.Text = "3";
    }
    public void FourClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "4";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "4";
        else
            output.Text = "4";
    }
    public void FiveClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "5";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "5";
        else
            output.Text = "5";
    }
    public void SixClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "6";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "6";
        else
            output.Text = "6";
    }
    public void SevenClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "7";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "7";
        else
            output.Text = "7";
    }
    public void EightClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "8";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "8";
        else
            output.Text = "8";
    }
    public void NineClicked(object sender, EventArgs e)
    {
        if (ansShown)
        {
            output.Text = "9";
            ansShown = false;
        }
        else if (output.Text != "0")
            output.Text = output.Text + "9";
        else
            output.Text = "9";
    }

    public void ClearClicked(object sender, EventArgs e)
    {
        output.Text = "0";
        num1 = 0; 
        num2 = 0;
    }

    public void PlusClicked(object sender, EventArgs e)
    {
        num1 = double.Parse(output.Text);
        op = "plus";
        output.Text = "0";
    }

    public void MinusClicked(object sender, EventArgs e)
    {
        num1 = double.Parse(output.Text);
        op = "minus";
        output.Text = "0";
    }

    public void MultClicked(object sender, EventArgs e)
    {
        num1 = double.Parse(output.Text);
        op = "mult";
        output.Text = "0";
    }

    public void DivideClicked(object sender, EventArgs e)
    {
        num1 = double.Parse(output.Text);
        op = "div";
        output.Text = "0";
    }

    public void EqualClicked(object sender, EventArgs e)
    {
        num2 = double.Parse(output.Text);
        if (op == "plus")
        {
            output.Text = (num1 + num2).ToString();
        }
        else if (op == "minus")
        {
            output.Text = (num1 - num2).ToString();
        }
        else if (op == "mult")
        {
            output.Text = (num1 * num2).ToString();
        }
        else if (op == "div")
        {
            output.Text = (num1 / num2).ToString();
        }

        op = "";
        ansShown = true;
    }

    public void NegClicked(object sender, EventArgs e)
    {
        output.Text = (double.Parse(output.Text) * -1).ToString();
    }

    public void PerClicked(object sender, EventArgs e)
    {
        output.Text = (double.Parse(output.Text) / 100).ToString();
    }
}

