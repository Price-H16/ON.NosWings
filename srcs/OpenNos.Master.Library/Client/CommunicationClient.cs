﻿using System.Threading.Tasks;
using NosSharp.Enums;
using OpenNos.Data;
using OpenNos.Master.Library.Data;
using OpenNos.Master.Library.Interface;

namespace OpenNos.Master.Library.Client
{
    internal class CommunicationClient : ICommunicationClient
    {
        #region Methods

        public void CharacterConnected(long characterId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnCharacterConnected(characterId));
        }

        public void CharacterDisconnected(long characterId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnCharacterDisconnected(characterId));
        }

        public void KickSession(long? accountId, long? sessionId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnKickSession(accountId, sessionId));
        }

        public void SendMail(MailDTO mail)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnSendMail(mail));
        }

        public void ChangeAuthority(long accountId, AuthorityType authority)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnAuthorityChange(accountId, authority));
        }

        public void SendMessageToCharacter(SCSCharacterMessage message)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnSendMessageToCharacter(message));
        }

        public void Shutdown()
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnShutdown());
        }

        public void UpdateBazaar(long bazaarItemId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnUpdateBazaar(bazaarItemId));
        }

        public void UpdateFamily(long familyId, bool changeFaction)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnUpdateFamily(familyId, changeFaction));
        }

        public void UpdatePenaltyLog(int penaltyLogId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnUpdatePenaltyLog(penaltyLogId));
        }

        public void UpdateRelation(long relationId)
        {
            Task.Run(() => CommunicationServiceClient.Instance.OnUpdateRelation(relationId));
        }

        #endregion
    }
}