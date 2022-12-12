namespace AppFx.DocView;

public abstract class Document
{
    /// <summary>
    /// A nézetek listája, melyek a dokumentumot megjelenítik. 
    /// </summary>
    private readonly List<IView> views = new List<IView>();

    /// <summary>
    /// Egy nézetet beregisztrál a dokumentumhoz.
    /// </summary>
    /// <param name="v"></param>
    public void AttachView(IView v)
    {
        views.Add(v);
    }

    /// <summary>
    /// Betölti a dokumentum tartalmát. A leszármazott osztályban felüldefiniálandó (override).
    /// </summary>
    public virtual void LoadDocument(string filePath)
    {
    }

    /// <summary>
    /// Elmenti a dokumentum tartalmát. A leszármazott osztályban felüldefiniálandó (override).
    /// </summary>
    public virtual void SaveDocument(string filePath)
    {
    }
}
