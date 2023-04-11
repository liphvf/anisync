namespace AnySync.Brazor.Data.DatabaseModels;

public class User
{
    public int Id { get; set; }

    public required string KitsuUserName { get; set; }

    public Library Library { get; set; }
}
