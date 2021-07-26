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

    type ExportOptions =
    | None
    | Info
    | Config
    | Client
    | Cluster
    | All

    module GeoUnits =
        [<Measure>]
        type m

        [<Measure>]
        type km

        [<Measure>]
        type ft

        [<Measure>]
        type mi

        let metersToKilometers (m:int<m>) =
            m / 1000<km/m>

        let feetToMiles (ft:int<ft>) =
            ft / 5280<ft/mi>

    type MigrateOptions =
    | None
    | Copy
    | Replace

    type Order =
    | Ascending
    | Descending

    type PositionKind =
    | Beginning
    | Explicit
    | New

    type Proxy = 
    | None
    | TwemProxy

    type RedisCommand =
    | NONE
    | APPEND
    | ASKING
    | AUTH
    
    | BGREWRITEAOF
    | BGSAVE
    | BITCOUNT
    | BITOP
    | BITPOS
    | BLPOP
    | BRPOP
    | BRPOPLPUSH
    
    | CLIENT
    | CLUSTER
    | CONFIG
    
    | DBSIZE
    | DEBUG
    | DECR
    | DECRBY
    | DEL
    | DISCARD
    | DUMP
    
    | ECHO
    | EVAL
    | EVALSHA
    | EXEC
    | EXISTS
    | EXPIRE
    | EXPIREAT
    
    | FLUSHALL
    | FLUSHDB
    
    | GEOADD
    | GEODIST
    | GEOHASH
    | GEOPOS
    | GEORADIUS
    | GEORADIUSBYMEMBER
    
    | GET
    | GETBIT
    | GETRANGE
    | GETSET
    
    | HDEL
    | HEXISTS
    | HGET
    | HGETALL
    | HINCRBY
    | HINCRBYFLOAT
    | HKEYS
    | HLEN
    | HMGET
    | HMSET
    | HSCAN
    | HSET
    | HSETNX
    | HSTRLEN
    | HVALS
    
    | INCR
    | INCRBY
    | INCRBYFLOAT
    | INFO
    
    | KEYS
    
    | LASTSAVE
    | LATENCY
    | LINDEX
    | LINSERT
    | LLEN
    | LPOP
    | LPUSH
    | LPUSHX
    | LRANGE
    | LREM
    | LSET
    | LTRIM
    
    | MEMORY
    | MGET
    | MIGRATE
    | MONITOR
    | MOVE
    | MSET
    | MSETNX
    | MULTI
    
    | OBJECT
    
    | PERSIST
    | PEXPIRE
    | PEXPIREAT
    | PFADD
    | PFCOUNT
    | PFMERGE
    | PING
    | PSETEX
    | PSUBSCRIBE
    | PTTL
    | PUBLISH
    | PUBSUB
    | PUNSUBSCRIBE
    
    | QUIT
    
    | RANDOMKEY
    | READONLY
    | READWRITE
    | RENAME
    | RENAMENX
    | REPLICAOF
    | RESTORE
    | ROLE
    | RPOP
    | RPOPLPUSH
    | RPUSH
    | RPUSHX
    
    | SADD
    | SAVE
    | SCAN
    | SCARD
    | SCRIPT
    | SDIFF
    | SDIFFSTORE
    | SELECT
    | SENTINEL
    | SET
    | SETBIT
    | SETEX
    | SETNX
    | SETRANGE
    | SHUTDOWN
    | SINTER
    | SINTERSTORE
    | SISMEMBER
    | SLAVEOF
    | SLOWLOG
    | SMEMBERS
    | SMOVE
    | SORT
    | SPOP
    | SRANDMEMBER
    | SREM
    | STRLEN
    | SUBSCRIBE
    | SUNION
    | SUNIONSTORE
    | SSCAN
    | SWAPDB
    | SYNC
    
    | TIME
    | TOUCH
    | TTL
    | TYPE
    
    | UNLINK
    | UNSUBSCRIBE
    | UNWATCH
    
    | WATCH
    
    | XACK
    | XADD
    | XCLAIM
    | XDEL
    | XGROUP
    | XINFO
    | XLEN
    | XPENDING
    | XRANGE
    | XREAD
    | XREADGROUP
    | XREVRANGE
    | XTRIM
    
    | ZADD
    | ZCARD
    | ZCOUNT
    | ZINCRBY
    | ZINTERSTORE
    | ZLEXCOUNT
    | ZPOPMAX
    | ZPOPMIN
    | ZRANGE
    | ZRANGEBYLEX
    | ZRANGEBYSCORE
    | ZRANK
    | ZREM
    | ZREMRANGEBYLEX
    | ZREMRANGEBYRANK
    | ZREMRANGEBYSCORE
    | ZREVRANGE
    | ZREVRANGEBYLEX
    | ZREVRANGEBYSCORE
    | ZREVRANK
    | ZSCAN
    | ZSCORE
    | ZUNIONSTORE
    
    | UNKNOWN

    type RedisType =
    | None
    | String
    | List
    | Set
    | SortedSet
    | Hash
    | Stream
    | Unknown

    type ReplicationChangeOptions =
    | None
    | SetTiebreaker
    | Broadcast
    | ReplicateToOtherEndpoints

    type ResultType =
    | None
    | Error
    | SimpleString
    | Integer
    | BulkString
    | MultiBulk
    
    type RetransmissionReasonType =
    | None
    | Ask
    | Moved

    type SaveType =
    | BackgroundRewriteAppendOnlyFile
    | BackgroundSave

    type ServerType =
    | Standalone
    | Sentinel
    | Cluster
    | TwemProxy

    type SetOperation =
    | Union
    | Intersect
    | Difference

    type ShutdownMode =
    | Default
    | Never
    | Always
    
    type SortType =
    | Numeric
    | Alphabetical

    type When =
    | Always
    | Exists
    | NotExists