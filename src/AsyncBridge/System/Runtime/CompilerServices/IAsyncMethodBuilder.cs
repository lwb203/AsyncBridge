#if NET40 || PORTABLE
namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Represents an asynchronous method builder.
    /// </summary>
    internal interface IAsyncMethodBuilder
    {
        void PreBoxInitialization();
    }
}
#endif
