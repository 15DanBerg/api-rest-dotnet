namespace model;
class UserModel
{
    public UserModel(int id, String name, String note)
    {
        this.id = id;
        this.name = name;
        this.note = note;
    }
    private int id;
    private String name;
    private String note;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public String Name
    {
        get { return name; }
        set { name = value; }
    }
    public String Note
    {
        get { return note; }
        set { note = value; }
    }
}