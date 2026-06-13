csharp
public static class AgeClassifier
{
    public static string Classify(int age)
    {
        if (age < 0) return "Ошибка: отрицательный возраст";
        else if (age < 3) return "Младенец";
        else if (age < 12) return "Ребёнок";
        else if (age < 18) return "Подросток";
        else if (age < 60) return "Взрослый";
        else if (age < 120) return "Пожилой";
        else return "Некорректный возраст";
    }
}
