namespace HomeWork10.Problem2;

public class CascadingActor : IActor
{
    private MainActor _mainActor;

    public CascadingActor(MainActor mainActor)
    {
        _mainActor = mainActor;
    }

    public void PlayRole()
    {
        _mainActor.PlayRole();
        Console.WriteLine("The cascading actor takes a role in a movie and also takes part in hardcore roles.");
    }
}