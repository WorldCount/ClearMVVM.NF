using System.Threading.Tasks;

namespace ClearMVVM.NF.Infrastructure
{
    internal delegate Task ActionAsync();

    internal delegate Task ActionAsync<in T>(T parameter);
}
