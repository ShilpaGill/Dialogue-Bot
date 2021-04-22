using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using System.Threading;
using Microsoft.Extensions.Logging;
using EchoBot1.Services;

namespace EchoBot1.Bots
{
    public class Dialog<T> : ActivityHandler where T : Dialog
    {
        #region Variables
        protected readonly Dialog _dialog;
        protected readonly StateService _stateService;
        protected readonly ILogger _logger;
        #endregion
        public Dialog(StateService botStateService, T dialog, ILogger<Dialog<T>> logger)
        {
            _stateService = botStateService ?? throw new System.ArgumentNullException(nameof(botStateService));
            _dialog = dialog ?? throw new System.ArgumentNullException(nameof(dialog));
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
       // public override  Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default(CancellationToken));
        
       
    }
}
