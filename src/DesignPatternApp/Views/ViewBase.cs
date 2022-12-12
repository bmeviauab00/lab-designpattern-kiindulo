using AppFx.DocView;

using DesignPatternApp.Documents;

namespace DesignPatternApp;

/// <summary>
/// - A nézeteink közös ősosztálya, kóduplikáció elkerülésére vezettük be. Implementálja az IView interfészt.
/// - UserControl-ból származik(hasonló koncepciót már láttunk a megelőző gyakorlat FontEditor példájában)
/// - A document tagváltozóban tárolja a nézetet.
/// -   A dokumentum megfelelő eseményeire való fel/leiratkozáshoz bevezeti a RegisterToDocEvents 
///     és UnRegisterToDocEvents virtuális műveleteket, a leszármazottakban igény szerint lehet implementálni
/// </summary>
public partial class ViewBase : UserControl, IView<DrawingDocument>
{
    protected DrawingDocument Document { get; private set; }

    public ViewBase()
    {
        InitializeComponent();
    }

    public void SetDocumentAndRegisterToDocEvents(DrawingDocument document)
    {
        Document = document;
        RegisterToDocEvents();
    }

    public void RemoveDocumentAndUnregisterDocEvents()
    {
        // Fontos a sorrend
        UnRegisterToDocEvents();
        Document = null;
    }

    protected virtual void RegisterToDocEvents()
    {
    }

    protected virtual void UnRegisterToDocEvents()
    {
    }
}
