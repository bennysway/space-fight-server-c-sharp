using System.Linq;
using System;

namespace SpaceFightServer
{
    public enum ServerPackets
    {
        SWelcome = 1,
        SSuccessfulLogIn,
        SSuccessfulLogOut,
        SSuccessfulRegister,
        SRegisterFail,
        SReceivedManage,
        SSuccessfulManage,
        SSpawnPlayer,
        SSpawnOpponent,
        SSpawnSupernova,
        SBullet,
        SRemovePlayer,
        SRemoveOpponent,
        SOpponentPosition,
        SPlayerInfo,
        SPlayerInfoExtended,
        SWrongPassword,
        SWrongCredentials,
        SBanLogin,
        SBanInPlay,
        SUsernameTaken,
        SUsernameAccessed,
        SUnknownError,
        SManagingFailed,
        SSendInGame,
        SMessage,
        SPlayerRealtimeUpdate,
        SInput,
        SBlock,
        SUnblock,
    }
    public enum ClientPackets
    {
        CNewConnection = 1,
        CLogin,
        CLogout,
        CRegister,
        CManage,
        CSpawn,
        CPosition,
        CRealtimePosition,
        CBullet,
        CSupernova,
        CInfo,
        CDied,
        CLeftGame,
        CQuit,
        CBan,
        CInput,
        CUnblock,
    }
    public enum Sql_playerData
    {
        idplayerdata = 0,
        username,
        password,
        playername,
        health,
        ammo,
        map,
        rank,
        score,
        isbanned
    }
    public enum Player_role
    {
        player = 1,
        playing,
        applicant,
        manager,
        managing,
    }
    public enum ClientInput
    {
        W = 1,
        A,
        S,
        D,
        Mouse1,
        Mouse2,
        StopMotion,
    }
    public static class PlayerRole
    {
        public static Player_role GetNextEnumValueOf(Player_role value)
        {
            return (from Player_role val in Enum.GetValues(typeof(Player_role))
                    where val > value
                    orderby val
                    select val).DefaultIfEmpty().First();
        }
        public static Player_role GetPreviousEnumValueOf(Player_role value)
        {
            return (from Player_role val in Enum.GetValues(typeof(Player_role))
                    where val < value
                    orderby val
                    select val).DefaultIfEmpty().Last();
        }
    }
}

///<lis>
///[0].Add(dataReader["idplayerdata"].ToString());
///[1].Add(dataReader["username"].ToString());
///[2].Add(dataReader["password"].ToString());
///[3].Add(dataReader["playername"].ToString());
///[4].Add(dataReader["health"].ToString());
///[5].Add(dataReader["ammo"].ToString());
///[6].Add(dataReader["map"].ToString());
///[7].Add(dataReader["rank"].ToString());
///[8].Add(dataReader["score"].ToString());
///[9].Add(dataReader["isbanned"].ToString());
/// </lis>