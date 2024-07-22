public class User
{
    public int UserID { get; set; }
    // Other properties
}

public class ContentItemManager
{
    private int _userId;
    
    public ContentItemManager(int userId)
    {
        _userId = userId;
    }
    
    // Methods to manage content items
}

public class ContentItemManagerFactory
{
    public ContentItemManager Create(int userId)
    {
        return new ContentItemManager(userId);
    }
}
