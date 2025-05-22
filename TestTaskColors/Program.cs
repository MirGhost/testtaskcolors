int[] hedgehogs = new int[] { 0, 15, 21 }; 

Console.WriteLine(countOfSteps(hedgehogs, 0));

int countOfSteps(int[] colors, int target)
{
    if (colors.Length != 3 || target < 0 || target > 2) 
        throw new Exception(message: "You entered the wrong data");

    // Оберемо не цільові кольори
    List<int> allColors = new List<int> {0,1,2};
    allColors.Remove(target);

    int firstColor = colors[allColors[0]];
    int secondColor = colors[allColors[1]];

    // перевірка чи можливо привести до цільового кольору.
    // Сутність перевірки в тому щоб мати спроможність розкласти залишок рівно по 3х ячейках,
    // якщо ми маємо таку можливість, то можна довести до одного кольору.
    if ((firstColor - secondColor)%3 == 0 )
        if (firstColor > secondColor) //ми відокремлюємо найбільшу кількість їжаків одного кольору,
                                      //бо саме стільки шагів нам буде потрібно щоб привести їх кількість до 0,
                                      //а значить це найменша можлива кількість шагів
            return firstColor;
        else
            return secondColor;
    else
        return -1 ;
}