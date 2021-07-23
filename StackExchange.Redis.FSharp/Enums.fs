namespace StackExchange.Redis.FSharp

module Enums =
    type Aggregate =
    | Min
    | Max
    | Sum

    type Bitwise =
    | And
    | Or
    | Xor
    | Not

    type ClientFlags =
    | None
    | ReplicaMonitor
    | Replica
    | Master
    | Transaction
    | Blocked
    | TransactionDoomed
    | Closing
    | Unblocked
    | CloseASAP
    | PubSubSubscriber
    | ReadOnlyCluster
    | UnixDomainSocket

    type ClientType =
    | Normal
    | Replica
    | PubSub

    type CommandFlags =
    | None
    | FireAndForget
    | PreferMaster
    | DemandMaster
    | PreferReplica
    | DemandReplica
    | NoRedirect
    | NoScriptCache

    type CommandStatus =
    | Unknown
    | WaitingToBeSent
    | Sent

    type ConnectionFailureType =
    | None
    | UnableToResolvePhysicalConnection
    | SocketFailure
    | AuthenticationFailure
    | ProtocolFailure
    | InternalFailure
    | SocketClosed
    | ConnectionDisposed
    | Loading
    | UnableToConnect

    type ConnectionType =
    | None
    | Interactive
    | Subscription

    type Exclude =
    | None
    | Start
    | Stop