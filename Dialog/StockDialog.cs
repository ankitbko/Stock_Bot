using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockLuisDlg
{
    [LuisModel("9fa4985b-351f-4e5e-8c8f-b726795a98b4", "a5d38008ca0f4e2187314509e3671953")]
    [Serializable]
    public class StockDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task NoneHandler(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry, I don't understand");
            context.Wait(MessageReceived);
        }
    }
}