using Assets.Scripts;

public class Level : Singleton<Level>
{
    public int btnValue1;
    public int btnValue2;
    public int btnValue3;
    public int max;
    public string equasion;
    public void All(int level)
    {
        CountEquasion(level);
        AnswerVars(level);
    }
    public void CountEquasion(int level)
    {
        GetMax(level);
        Equasion equa = new Equasion();
        equasion = equa.CountEquasion(max);
        max = 0;
    }
    private void GetMax(int level)
    {
        switch (level)
        {
            case 1:
                max = 20;
                break;
        }
    }
    public void AnswerVars(int level)
    {
        GetMax(level);
        AnswerVars answerVars = new AnswerVars(max, equasion);
        answerVars.CorrectAnswer();
        btnValue1 = answerVars.btnValue1;
        btnValue2 = answerVars.btnValue2;
        btnValue3 = answerVars.btnValue3;
    }
}
