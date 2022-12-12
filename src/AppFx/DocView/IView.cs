namespace AppFx.DocView;

public interface IView
{
}

public interface IView<TDocument> : IView
    where TDocument : Document
{
    // Esetünkben a dokumentumoknak különböző eseményei is lehetnek. Minden nézet 
    // a dokumentum azon eseményeire iratkozik fel, melyek számára érdekesek. Így
    // nem elég egy Update művelet bevezetése, mert annak hívásával a dokumentum csak egyfajta
    // eseményt/változást tudna jelezni. Helyette a nézeteknek implementálniuk kell az alábbi
    // SetDocumentAndRegisterToDocEvents műveletet, melyben egyrészt eltárolnak egy hivatkozást a 
    // dokumentumukra, másrészt felirítkoznak a számukra érdekes documentum eseményekre.  
    // void UpdateView();
    // TODO generikusság magyarázata
    void SetDocumentAndRegisterToDocEvents(TDocument doc);

    void RemoveDocumentAndUnregisterDocEvents();
}
