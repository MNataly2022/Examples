// В тексте поменять маленькие "к" на большие "К", пробелы на вертикальную черту

string text = "Наверняка и вам есть что сказать о недавней покупке."
            + "Расскажите о своих впечатлениях и помогите другим сделать правильный выбор."; 

string Replace(string text, char oldValue, char newValue)         
{
    string result = String.Empty;
    int lenth = text.Length;

    for (int i = 0; i <  lenth; i++)
    {
        if(text[i] == oldValue)
              result = result + $"{newValue}"; 
        else 
              result = result + $"{text[i]}";
    }
    return result; 
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
