class Question
{
  public string FullQuestion { get; set; }
  public string[] Options { get; set; }

  public int CorrectAnswerIndex { get; set; }

  public Question(string fullQuestion, string[] options, int correctAnswerIndex)
  {
    FullQuestion = fullQuestion;
    Options = options;
    CorrectAnswerIndex = correctAnswerIndex;
  }
}