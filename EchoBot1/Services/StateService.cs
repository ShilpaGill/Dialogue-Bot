using EchoBot1.Models;
using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchoBot1.Services
{
    public class StateService
    {//State Vriables
        #region Variables
        public ConversationState ConversationState { get; }
        public UserState UserState { get; }
       //IDs
        public static string UserProfileId { get; } = $"{nameof(StateService)}.UserProfile";
        public static string ConversationDataId { get; } = $"{nameof(StateService)}.ConversationData";
        //Accessors
        public IStatePropertyAccessor<UserProfile> UserProfileAccessor { get; set; }
        public IStatePropertyAccessor<ConversationData> ConversationDataAccessor { get; set; }
        #endregion
        //Constructor
        public StateService(UserState userState, ConversationState conversationState)
        {
            ConversationState = conversationState ?? throw new ArgumentNullException(nameof(conversationState));
            UserState = userState ?? throw new ArgumentNullException(nameof(userState));
            InitializeAccessor();
        }
        public void InitializeAccessor()
        {//Initialize Conversation state Accessor
            ConversationDataAccessor = ConversationState.CreateProperty<ConversationData>(ConversationDataId);
            //Initialize User state
            UserProfileAccessor = UserState.CreateProperty<UserProfile>(UserProfileId);
        }

    }
}
