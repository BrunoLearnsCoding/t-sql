namespace dotnet_sql_interaction;

public class Answer {
    public int AnswerId { get; set; }
    public string? Body { get; set; }
    public int PostedBy { get; set; }
    public int QuestionId { get; set; }
    public DateTime DatePosted { get; set; }
    public bool IsAccepted { get; set; }

    public override string ToString()
    {
        return $"{AnswerId}:{Body}:{IsAccepted}:{QuestionId}";
    }

}