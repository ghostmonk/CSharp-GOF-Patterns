using Mediator.Shops;

namespace Mediator.Core
{
    interface Mediator
    {
        void Handle( ProcessType type );
    }
}
