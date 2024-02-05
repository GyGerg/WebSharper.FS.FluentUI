module internal WebSharper.FS.FluentUI.Proxies

    open WebSharper
    open WebSharper.JavaScript

    // [<Proxy(typeof<Fable.React.ReactElement>)>]
    // type ReactElementProxy = React.React.Element


    [<Proxy(typeof<Fable.Core.U2<_,_>>)>]
    type U2Proxy<'A,'B> = Union<'A,'B>

    // [<Proxy(typeof<System.Threading.CancellationTokenSource>)>]
    // type CtsProxy() =
    //     member this.Dispose() =
    //         (As<System.IDisposable> this).Dispose()

