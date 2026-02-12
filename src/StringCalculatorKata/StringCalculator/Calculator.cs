
using System.ComponentModel;

public class Calculator
{
    private const string newLine = "\n";
    private const string comma = ",";
    private int _currCount = 0;

    public int Add(string numbers)
    {

        if (numbers.Length <= 0)
        {
            //empty string = 0
            return 0;
        } else if (numbers.Split(',').Length > 1 || numbers.Split(newLine).Length > 1)
        {
            //splits string by comma (#3) and adds them
            //After reading #4, I think this can pass for 4 too..trying
            int count = 0;
            //added extra pieces to account for new lines in #5
            string[] newLinesArray = numbers.Split(newLine);
            string[] numArray = [];
            foreach (string n in newLinesArray)
            {
                //checks if newLine string contains comma, if not, for now assuming it is a num
                if (n.Contains(comma))
                {
                    //if comma found, splitting and adding
                    string[] x = n.Split(comma);
                    numArray = [.. numArray, .. x];
                    
                } else
                {
                    numArray = [.. numArray, n];
                }
            }
            foreach (string i in numArray)
            {
                //added the trim in case there were spaces between some and not others
                count = count + Int32.Parse(i.Trim(" "));
            }
            return count;
        } else 
        {
            //converts single to int
            int numberInNumberForm = 0;
            int.TryParse(numbers, out numberInNumberForm);
            return numberInNumberForm;
        }
    }
}
